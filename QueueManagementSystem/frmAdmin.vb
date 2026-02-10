Imports MySql.Data.MySqlClient

Public Class frmAdmin

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setConnectionDatabase()
        ' Fill counters
        ModuleDatabase.FillComboBox(cmbCounter, "counters", "counter_id", "name", "", "name ASC")
        ' Fill services
        ModuleDatabase.FillComboBox(cmbService, "services", "service_id", "name", "", "name ASC")
        ' Load current assignments
        LoadAssignments()
        TimerRefresh.Start()
    End Sub

    Private Sub LoadAssignments()
        Dim sql As String = "
        SELECT 
            c.name AS 'Counter Name',
            s.name AS 'Service Name',
            cs.counter_id AS 'Counter ID',
            cs.service_id AS 'Service ID'
        FROM counter_services cs
        JOIN counters c ON cs.counter_id = c.counter_id
        JOIN services s ON cs.service_id = s.service_id
        ORDER BY c.name, s.name"

        Dim dt As New DataTable
        ModuleDatabase.FillDynamicTable(sql, dt)
        dgvAssignments.DataSource = dt

        ' No need to hide 'id' anymore
        ' Remove or comment out these lines:
        ' If dgvAssignments.Columns.Contains("id") Then
        '     dgvAssignments.Columns("id").Visible = False
        ' End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbCounter.SelectedValue Is Nothing Or cmbService.SelectedValue Is Nothing Then
            MessageBox.Show("Please select both a counter and a service", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim counterId As Integer = Convert.ToInt32(cmbCounter.SelectedValue)
            Dim serviceId As Integer = Convert.ToInt32(cmbService.SelectedValue)

            Dim sql As String = "INSERT IGNORE INTO counter_services (counter_id, service_id) VALUES (@cid, @sid)"
            Using cmd As New MySqlCommand(sql, ModuleDatabase.cn)
                cmd.Parameters.AddWithValue("@cid", counterId)
                cmd.Parameters.AddWithValue("@sid", serviceId)
                If ModuleDatabase.cn.State <> ConnectionState.Open Then ModuleDatabase.cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Assignment added successfully!", "Success")
            LoadAssignments()

        Catch ex As Exception
            MessageBox.Show("Error adding assignment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvAssignments.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an assignment to remove", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Dim counterId As Integer = Convert.ToInt32(dgvAssignments.SelectedRows(0).Cells(2).Value)
            Dim serviceId As Integer = Convert.ToInt32(dgvAssignments.SelectedRows(0).Cells(3).Value)
            Dim sql As String = "DELETE FROM counter_services WHERE counter_id = @cid AND service_id = @sid"
            Using cmd As New MySqlCommand(sql, ModuleDatabase.cn)
                cmd.Parameters.AddWithValue("@cid", counterId)
                cmd.Parameters.AddWithValue("@sid", serviceId)
                If ModuleDatabase.cn.State <> ConnectionState.Open Then ModuleDatabase.cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Assignment removed successfully!", "Success")
            LoadAssignments()

        Catch ex As Exception
            MessageBox.Show("Error removing assignment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAssignments()
    End Sub

    Private Sub TimerRefresh_Tick(sender As Object, e As EventArgs) Handles TimerRefresh.Tick
        ' Optional: auto-refresh every 10 seconds
        LoadAssignments()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        frmAddUser.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmService.ShowDialog()

    End Sub
End Class