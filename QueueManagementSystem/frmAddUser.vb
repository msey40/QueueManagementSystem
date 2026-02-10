Imports MySql.Data.MySqlClient
Public Class frmAddUser
    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUser()
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList

        ' Clear previous items and add roles
        cboRole.Items.Clear()
        cboRole.Items.Add("Admin")
        cboRole.Items.Add("Staff")

        ' Optional: select first item
        cboRole.SelectedIndex = 0
    End Sub
    Private Sub LoadUser()
        dgvUser.Rows.Clear() ' clear previous data

        Dim sqlquery As String = "
        SELECT user_id, username, password_hash, role, status
        FROM users
        ORDER BY username ASC"

        Using cmd As New MySqlCommand(sqlquery, ModuleDatabase.cn)
            If ModuleDatabase.cn.State <> ConnectionState.Open Then ModuleDatabase.cn.Open()

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                Dim i As Integer = 1
                While reader.Read()
                    dgvUser.Rows.Add(
                        reader("user_id"),
                    i,                                  ' No.
                    reader("username").ToString(),     ' Username
                    reader("password_hash").ToString(),     ' Password
                    reader("role").ToString(),         ' Role
                    Convert.ToBoolean(reader("status")) ' Status (checkbox)
                )
                    i += 1
                End While
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtUsername.Text.Trim() = "" Or txtpw.Text.Trim() = "" Then
            MessageBox.Show("Please enter username and password.")
            Exit Sub
        End If
        Dim values As New Dictionary(Of String, Object)
        values("username") = txtUsername.Text.Trim()
        values("password_hash") = txtpw.Text.Trim()
        values("role") = cboRole.SelectedItem.ToString()
        values("status") = ckSt.Checked
        Dim newUserID As Integer = ModuleDatabase.SaveWithImage("users", values)
        If newUserID > 0 Then
            MessageBox.Show("User saved successfully! ")
            LoadUser() ' refresh DataGridView
        Else
            MessageBox.Show("Failed to save user!")
        End If
    End Sub
    Sub ClearFields()
        txtUsername.Clear()
        txtpw.Clear()
        cboRole.SelectedIndex = 0
        ckSt.Checked = False
        user_id = -1
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If user_id = -1 Then
            MessageBox.Show("Please select a user first!")
            Exit Sub
        End If
        Dim values As New Dictionary(Of String, Object)
        values("username") = txtUsername.Text.Trim()
        values("password_hash") = txtpw.Text.Trim()
        values("role") = cboRole.Text
        values("status") = ckSt.Checked

        Dim conditions As String = "user_id=" & user_id & ""


        ModuleDatabase.UpdateWithImage(
        "users",
        values,
        conditions
    )

        MessageBox.Show("User updated successfully")


        LoadUser()
        ClearFields()
    End Sub

    Private Sub LoadUserToForm(row As DataGridViewRow)
        txtUsername.Text = row.Cells("user_name").Value.ToString()
        txtpw.Text = row.Cells("user_pw").Value.ToString()
        cboRole.SelectedItem = row.Cells("user_role").Value.ToString()
        ckSt.Checked = CBool(row.Cells("status").Value)

        ' Save user_id in hidden variable
        user_id = row.Cells("colid").Value
    End Sub

    Private Sub dgvUser_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        LoadUserToForm(dgvUser.Rows(e.RowIndex))

    End Sub

End Class