Imports MySql.Data.MySqlClient

Public Class frmMonitor

    ' Move this here so it "remembers" the count between timer ticks
    Private lastRowCount As Integer = 0

    Private Sub frmMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModuleDatabase.cn.State <> ConnectionState.Open Then
            ModuleDatabase.setConnectionDatabase()
        End If

        Me.FormBorderStyle = FormBorderStyle.None
        TimerRefresh.Interval = 2000
        TimerRefresh.Start()
        UpdateDisplay()
    End Sub

    Private Sub TimerRefresh_Tick(sender As Object, e As EventArgs) Handles TimerRefresh.Tick
        UpdateDisplay()
    End Sub

    Private Sub UpdateDisplay()
        Try
            Dim sql As String = "
                SELECT q.queue_number, c.name AS counter_name, s.name AS service_name, q.called_at
                FROM queue q
                INNER JOIN counters c ON q.called_counter_id = c.counter_id
                INNER JOIN services s ON q.service_id = s.service_id
                WHERE q.status = 'called'
                AND q.join_date = CURDATE() 
                ORDER BY q.called_at DESC"

            Dim dt As New DataTable
            ModuleDatabase.FillDynamicTable(sql, dt)

            Dim currentRowCount As Integer = dt.Rows.Count

            If currentRowCount > 0 Then
                ' 1. Check if the count has INCREASED since the last check
                If currentRowCount > lastRowCount Then
                    PlayRingSound()
                End If

                ' 2. Update the persistence variable
                lastRowCount = currentRowCount

                ' 3. Update the UI Text
                Dim displayText As String = ""
                For Each row As DataRow In dt.Rows
                    displayText &= $"{row("queue_number")} - {row("counter_name")} - {row("service_name")}" & vbCrLf
                Next

                lblDisplay.Text = displayText
                lblDisplay.ForeColor = Color.Lime
                lblTitle.Text = "NOW SERVING"
                lblWaiting.Visible = False
            Else
                lastRowCount = 0 ' Reset if list is empty
                lblDisplay.Text = "-----"
                lblWaiting.Text = "Waiting for next call..."
                lblWaiting.Visible = True
            End If

        Catch ex As Exception
            Debug.WriteLine("Update error: " & ex.Message)
        End Try
    End Sub

    ' Cleaned up sound logic into its own sub
    Private Sub PlayRingSound()
        Try
            Dim soundPath As String = IO.Path.Combine(Application.StartupPath, "ring.wav")
            If IO.File.Exists(soundPath) Then
                My.Computer.Audio.Play(soundPath, AudioPlayMode.Background)
            End If
        Catch ex As Exception
            Debug.WriteLine("Sound error: " & ex.Message)
        End Try
    End Sub

End Class