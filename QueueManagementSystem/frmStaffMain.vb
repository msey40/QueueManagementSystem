Imports MySql.Data.MySqlClient

Public Class frmStaffMain

    Private isFormLoaded As Boolean = False
    Private CurrentCounterID As Integer = -1

    Private Sub frmStaffMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModuleDatabase.cn.State <> ConnectionState.Open Then
            ModuleDatabase.setConnectionDatabase()
        End If

        lblUser.Text = "Logged in: " & CurrentUsername

        ' Fill counter dropdown
        ModuleDatabase.FillComboBox(cmbCounter, "counters", "counter_id", "name", "", "name ASC")

        ' Fill services for self-assignment
        Dim dtServices As New DataTable
        ModuleDatabase.FillDynamicTable("SELECT service_id, name FROM services ORDER BY name", dtServices)
        checkedListServices.DataSource = dtServices
        checkedListServices.DisplayMember = "name"
        checkedListServices.ValueMember = "service_id"


        If cmbCounter.Items.Count > 0 Then
            cmbCounter.SelectedIndex = 0
        End If

        isFormLoaded = True
        TimerRefresh.Start()
        LoadWaitingQueue()
    End Sub
    Private Sub cmbCounter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCounter.SelectedIndexChanged
        If Not isFormLoaded Then Exit Sub
        If cmbCounter.SelectedIndex = -1 Then Exit Sub

        CurrentCounterID = Convert.ToInt32(cmbCounter.SelectedValue)

        Try
            ' --- Load only the services assigned to this counter ---
            Dim dtAssigned As New DataTable
            Dim sql As String =
            "SELECT s.service_id " &
            "FROM services s " &
            "INNER JOIN counter_services cs ON s.service_id = cs.service_id " &
            "WHERE cs.counter_id = @counter_id"

            Using cmd As New MySqlCommand(sql, ModuleDatabase.cn)
                cmd.Parameters.AddWithValue("@counter_id", CurrentCounterID)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dtAssigned)
                End Using
            End Using

            ' --- Check only the assigned services ---
            Dim assignedIds As New HashSet(Of Integer)
            For Each row As DataRow In dtAssigned.Rows
                assignedIds.Add(Convert.ToInt32(row("service_id")))
            Next

            ' Save admin-assigned IDs for locking
            adminAssignedIds.Clear()
            For Each id As Integer In assignedIds
                adminAssignedIds.Add(id)
            Next

            ' --- Clear all previous checks first ---
            For i As Integer = 0 To checkedListServices.Items.Count - 1
                checkedListServices.SetItemChecked(i, False)
            Next

            ' --- Now check admin-assigned services ---
            For i As Integer = 0 To checkedListServices.Items.Count - 1
                Dim drv As DataRowView = DirectCast(checkedListServices.Items(i), DataRowView)
                Dim serviceId As Integer = Convert.ToInt32(drv("service_id"))

                If assignedIds.Contains(serviceId) Then
                    checkedListServices.SetItemChecked(i, True)
                End If
            Next



        Catch ex As Exception
            MessageBox.Show("Error loading counter services: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub LoadWaitingQueue()
        If CurrentCounterID <= 0 Then Exit Sub

        If ModuleDatabase.cn.State <> ConnectionState.Open Then
            Try
                ModuleDatabase.cn.Open()
            Catch ex As Exception
                ModuleDatabase.AlertMessage("Connection error in queue load: " & ex.Message)
                Exit Sub
            End Try
        End If

        Dim sql As String = "
            SELECT 
                q.queue_id, 
                q.queue_number AS 'Queue Number', 
                s.name AS Service, 
                q.joined_at AS 'Joined at',
                q.Status,
                CASE WHEN q.status = 'called' THEN 'Called' ELSE 'Waiting' END AS 'Display Status'
            FROM queue q
            INNER JOIN services s ON q.service_id = s.service_id
            INNER JOIN counter_active_services cas ON cas.service_id = q.service_id
            WHERE q.status IN ('waiting', 'called')
              AND cas.counter_id = @counterId
              AND cas.is_active = 1
            ORDER BY 
                CASE WHEN q.status = 'called' THEN 0 ELSE 1 END,   -- Called first
                q.joined_at ASC"

        Dim dt As New DataTable
        Dim cmd As New MySqlCommand(sql, ModuleDatabase.cn)
        cmd.Parameters.AddWithValue("@counterId", CurrentCounterID)

        Try
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
            dgvQueue.DataSource = dt

            ' Hide technical columns
            If dgvQueue.Columns.Contains("queue_id") Then dgvQueue.Columns("queue_id").Visible = False
            If dgvQueue.Columns.Contains("joined_at") Then dgvQueue.Columns("joined_at").DefaultCellStyle.Format = "HH:mm:ss"

            If dt.Rows.Count = 0 Then
                lblStatus.Text = "No waiting or called customers"
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading queue: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCallNext_Click(sender As Object, e As EventArgs) Handles btnCallNext.Click
        If CurrentCounterID <= 0 Then
            ModuleDatabase.AlertMessage("Please select a counter first")
            Exit Sub
        End If

        If ModuleDatabase.cn.State <> ConnectionState.Open Then
            Try
                ModuleDatabase.cn.Open()
            Catch ex As Exception
                ModuleDatabase.AlertMessage("Cannot open database connection: " & ex.Message)
                Exit Sub
            End Try
        End If

        Dim sql As String = "
        SELECT q.queue_id, q.queue_number, s.name AS service
        FROM queue q
        INNER JOIN services s ON q.service_id = s.service_id
        INNER JOIN counter_active_services cas ON cas.service_id = q.service_id
        WHERE q.status = 'waiting'
          AND cas.counter_id = @counter
          AND cas.is_active = 1
        ORDER BY q.joined_at ASC
        LIMIT 1"

        Dim dt As New DataTable

        Try
            Using cmd As New MySqlCommand(sql, ModuleDatabase.cn)
                cmd.Parameters.AddWithValue("@counter", CurrentCounterID)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using

            If dt.Rows.Count = 0 Then
                ModuleDatabase.AlertMessage("No waiting customers for your selected services")
                Exit Sub
            End If

            Dim row = dt.Rows(0)
            Dim queueId = Convert.ToInt32(row("queue_id"))
            Dim ticket = row("queue_number").ToString()
            Dim service = row("service").ToString()

            ' ────────────────────────────────────────────────
            '           PLAY RING SOUND (use ring.wav)
            ' ────────────────────────────────────────────────
            Try
                ' Use .wav file – My.Computer.Audio.Play does NOT support mp3 reliably
                Dim soundPath As String = IO.Path.Combine(Application.StartupPath, "ring.wav")

                Debug.WriteLine("Sound path: " & soundPath)
                Debug.WriteLine("File exists? " & IO.File.Exists(soundPath).ToString)

                If IO.File.Exists(soundPath) Then
                    My.Computer.Audio.Play(soundPath, AudioPlayMode.Background)
                    Debug.WriteLine("Sound playback started")
                Else
                    Debug.WriteLine("Sound file NOT found: " & soundPath)
                    ' Optional: uncomment during testing
                    ' ModuleDatabase.AlertMessage("Ring sound file not found!")
                End If
            Catch ex As Exception
                Debug.WriteLine("Sound playback error: " & ex.Message)
                ' Optional: uncomment to see error during testing
                ' MessageBox.Show("Cannot play ring sound: " & ex.Message)
            End Try
            ' ────────────────────────────────────────────────

            ' Update queue status to called
            Dim updateSql = "UPDATE queue SET status = 'called', called_counter_id = @cid, called_at = NOW() WHERE queue_id = @qid"
            Using cmdUpdate As New MySqlCommand(updateSql, ModuleDatabase.cn)
                cmdUpdate.Parameters.AddWithValue("@cid", CurrentCounterID)
                cmdUpdate.Parameters.AddWithValue("@qid", queueId)
                cmdUpdate.ExecuteNonQuery()
            End Using

            ' Log the call
            Dim logSql = "INSERT INTO call_logs (queue_id, counter_id, user_id, action) VALUES (@qid, @cid, @uid, 'call')"
            Using cmdLog As New MySqlCommand(logSql, ModuleDatabase.cn)
                cmdLog.Parameters.AddWithValue("@qid", queueId)
                cmdLog.Parameters.AddWithValue("@cid", CurrentCounterID)
                cmdLog.Parameters.AddWithValue("@uid", CurrentUserID)
                cmdLog.ExecuteNonQuery()
            End Using

            ModuleDatabase.AlertMessage("Calling: " & ticket & " - " & service & vbCrLf & "Go to Counter " & cmbCounter.Text)

            LoadWaitingQueue()


        Catch ex As Exception
            ModuleDatabase.AlertMessage("Error calling next customer: " & ex.Message)
        End Try
    End Sub

    Private Sub btnServed_Click(sender As Object, e As EventArgs) Handles btnServed.Click
        setConnectionDatabase()
        If dgvQueue.SelectedRows.Count = 0 Then
            ModuleDatabase.AlertMessage("Please select a customer from the queue")
            Exit Sub
        End If

        Try
            Dim queueId = Convert.ToInt32(dgvQueue.SelectedRows(0).Cells("queue_id").Value)
            Dim status = dgvQueue.SelectedRows(0).Cells("status").Value.ToString()

            If status = "called" Then
                Dim sql = "UPDATE queue SET status = 'served', served_at = NOW() WHERE queue_id = @qid"
                Using cmd As New MySqlCommand(sql, ModuleDatabase.cn)
                    cmd.Parameters.AddWithValue("@qid", queueId)
                    cmd.ExecuteNonQuery()
                End Using

                ModuleDatabase.AlertMessage("Customer marked as served")
                LoadWaitingQueue()
            Else
                ModuleDatabase.AlertMessage("This customer is not currently called")
            End If

        Catch ex As Exception
            ModuleDatabase.AlertMessage("Error marking as served: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadWaitingQueue()
    End Sub

    Private Sub TimerRefresh_Tick(sender As Object, e As EventArgs) Handles TimerRefresh.Tick
        If CurrentCounterID > 0 Then
            LoadWaitingQueue()
        End If
    End Sub

    Private Sub btnConfirmServices_Click(sender As Object, e As EventArgs) Handles btnConfirmServices.Click
        If CurrentCounterID <= 0 Then
            MessageBox.Show("Please select your counter first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Clear old assignments for this counter
            ModuleDatabase.DeleteRow("counter_active_services", "counter_id = " & CurrentCounterID)

            ' Save new selected services
            For Each item In checkedListServices.CheckedItems
                Dim drv As DataRowView = DirectCast(item, DataRowView)
                Dim serviceId = Convert.ToInt32(drv("service_id"))

                Dim values As New Dictionary(Of String, Object) From {
                    {"counter_id", CurrentCounterID},
                    {"service_id", serviceId},
                    {"assigned_by", CurrentUserID}
                }
                ModuleDatabase.SaveWithImage("counter_active_services", values)
            Next

            MessageBox.Show("Your selected services have been confirmed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadWaitingQueue()

        Catch ex As Exception
            MessageBox.Show("Error confirming services: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMonitor.Show()
        frmMonitor.Left = Screen.PrimaryScreen.Bounds.Width
        frmMonitor.Top = 0
        frmMonitor.WindowState = FormWindowState.Maximized
    End Sub
    ' Form-level variable to track admin-assigned services
    Private adminAssignedIds As New HashSet(Of Integer)
    ' Prevent unchecking admin-assigned services
    Private Sub checkedListServices_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles checkedListServices.ItemCheck
        Dim drv As DataRowView = DirectCast(checkedListServices.Items(e.Index), DataRowView)
        Dim serviceId As Integer = Convert.ToInt32(drv("service_id"))

        ' Block unchecking admin-assigned services
        If adminAssignedIds.Contains(serviceId) AndAlso e.NewValue = CheckState.Unchecked Then
            e.NewValue = CheckState.Checked
        End If
    End Sub
    ' Optional: gray out admin-assigned services
    Private Sub CheckedListServices_DrawItem(sender As Object, e As DrawItemEventArgs)
        e.DrawBackground()
        If e.Index < 0 Then Return

        Dim drv As DataRowView = DirectCast(checkedListServices.Items(e.Index), DataRowView)
        Dim serviceId As Integer = Convert.ToInt32(drv("service_id"))

        Dim foreColor As Color = If(adminAssignedIds.Contains(serviceId), Color.Gray, Color.Black)
        TextRenderer.DrawText(e.Graphics, drv("name").ToString(), e.Font, e.Bounds, foreColor)
        e.DrawFocusRectangle()
    End Sub

    Private Sub frmStaffMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
            Return
        End If
        Application.ExitThread()
    End Sub
End Class