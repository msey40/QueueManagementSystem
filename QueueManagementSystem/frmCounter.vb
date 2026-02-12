Public Class frmCounter
    Private Sub frmCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCounter()

    End Sub
    Private Sub clearCounter()
        txtCName.Clear()
        counter_id = -1
        txtCCid.Clear()
        btnCSave.Text = "Save"

    End Sub
    Private Sub loadCounter()

        Dim sql As String = "SELECT * FROM counters ORDER BY name"
        Dim dt As New DataTable()
        dgvCount.Rows.Clear() ' clear previous data
        ModuleDatabase.FillDynamicTable(sql, dt)
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                dgvCount.Rows.Add(dt(i)(0), i + 1, dt(i)("current_coun_id"), dt(i)(1))
            Next
        End If
    End Sub

    Private Sub btnCClear_Click(sender As Object, e As EventArgs) Handles btnCClear.Click
        clearCounter()
    End Sub

    Private Sub btnCSave_Click(sender As Object, e As EventArgs) Handles btnCSave.Click
        Dim values As New Dictionary(Of String, Object)
        If txtCName.Text.Trim() = "" Then
            MessageBox.Show("Please enter counter name.")
            Exit Sub
        End If

        values.Add("name", txtCName.Text.Trim())
        values.Add("current_coun_id", txtCCid.Text.Trim().ToString())
        If btnCSave.Text = "Save" Then
            Dim newCounterID As Integer = ModuleDatabase.SaveWithImage("counters", values)
            If newCounterID > 0 Then
                MessageBox.Show("Counter saved successfully! ")
                loadCounter() ' refresh DataGridView
            Else
                MessageBox.Show("Failed to save counter!")
            End If
        ElseIf btnCSave.Text = "Update" Then
            Dim condition As String = "counter_id = " & counter_id & " "
            ModuleDatabase.UpdateWithImage("counters", values, condition)
            MessageBox.Show("Counter updated successfully! ")
            loadCounter() ' refresh DataGridView
            clearCounter()
            btnCSave.Text = "Save"
        End If
    End Sub

    Private Sub dgvCount_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCount.CellMouseDown
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            dgvCount.ClearSelection()
            dgvCount.Rows(e.RowIndex).Selected = True
            counter_id = dgvCount.Rows(e.RowIndex).Cells(0).Value
            cmsCounter.Show(Cursor.Position)
        End If
    End Sub

    Private Sub itemUpdate_Click(sender As Object, e As EventArgs) Handles itemUpdate.Click
        If dgvCount.CurrentRow Is Nothing Then Exit Sub

        Dim row As DataGridViewRow = dgvCount.CurrentRow
        counter_id = row.Cells("colcid").Value
        txtCCid.Text = row.Cells("col_ccid").Value.ToString()
        txtCName.Text = row.Cells("colcname").Value.ToString()
        btnCSave.Text = "Update"
    End Sub

    Private Sub itemDelete_Click(sender As Object, e As EventArgs) Handles itemDelete.Click
        If dgvCount.SelectedRows.Count = 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvCount.SelectedRows(0)
        Dim condition As String = "counter_id = " & counter_id & " "
        If MessageBox.Show("Delete this counter?",
                       "Confirm",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning) = DialogResult.Yes Then
            ModuleDatabase.DeleteRow("counters", condition)
            loadCounter()
        End If
    End Sub
End Class