Imports MySql.Data.MySqlClient

Public Class frmService
    Private Sub frmService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadService()
    End Sub
    Private Sub cleartxt()
        txtSName.Clear()
        txtDesc.Clear()
        chkS.Checked = False
        service_id = -1
        btnSave.Text = "Save"
    End Sub
    Private Sub loadService()
        Dim sqlshow As String = "SELECT * FROM services ORDER BY name"
        Dim dt As New DataTable()
        dgvServ.Rows.Clear() ' clear previous data
        FillDynamicTable(sqlshow, dt)


        If dt.Rows.Count > 0 Then

            For i = 0 To dt.Rows.Count - 1
                dgvServ.Rows.Add(dt(i)(0), i + 1, dt(i)(1), dt(i)(2), Format(dt(i)(3), "dd-MM-yyyy"), dt(i)(4))
            Next
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtSName.Text.Trim() = "" Then
            MessageBox.Show("Please enter service name.")
            Exit Sub
        End If
        Dim values As New Dictionary(Of String, Object)
        values.Add("name", txtSName.Text.Trim())
        values.Add("description", txtDesc.Text.Trim())
        values.Add("status", chkS.Checked)
        If btnSave.Text = "Save" Then
            Dim newServiceID As Integer = ModuleDatabase.SaveWithImage("services", values)
            If newServiceID > 0 Then
                MessageBox.Show("Service saved successfully! ")
                loadService() ' refresh DataGridView
            Else
                MessageBox.Show("Failed to save service!")
            End If
        ElseIf btnSave.Text = "Update" Then

            Dim condition As String = "service_id = " & service_id & " "
            ModuleDatabase.UpdateWithImage("services", values, condition)
            MessageBox.Show("Service updated successfully! ")
            loadService() ' refresh DataGridView
            cleartxt()
        End If

    End Sub

    Private Sub loadServiceToForm(rowService As DataGridViewRow)
        txtSName.Text = rowService.Cells("colNservice").Value.ToString()
        txtDesc.Text = rowService.Cells("coldesc").Value.ToString()
        chkS.Checked = CBool(rowService.Cells("colStatus").Value)
        service_id = rowService.Cells("colsid").Value

    End Sub
    ' Make sure this is your event
    Private Sub dgvServ_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
    Handles dgvServ.CellDoubleClick

        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvServ.Rows(e.RowIndex)
        loadServiceToForm(row)
        btnSave.Text = "Update"
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cleartxt()
    End Sub

    Private Sub dgvServ_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) _
      Handles dgvServ.CellMouseDown

        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            dgvServ.ClearSelection()
            dgvServ.Rows(e.RowIndex).Selected = True
            service_id = dgvServ.Rows(e.RowIndex).Cells(0).Value

            cmsService.Show(Cursor.Position)
        End If
    End Sub

    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) _
    Handles mnuDelete.Click

        If dgvServ.SelectedRows.Count = 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvServ.SelectedRows(0)
        Dim condition As String = "service_id = " & service_id & " "

        If MessageBox.Show("Delete this service?", "Confirm",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then

            ModuleDatabase.DeleteRow("services", condition)
            loadService()
        End If
    End Sub
End Class