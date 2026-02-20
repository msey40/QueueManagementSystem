
Imports MySql.Data.MySqlClient
Public Class frmConfirm
    Private Sub frmConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setConnectionDatabase()
    End Sub
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
        frmKiosk.Show()
    End Sub
    Private IsAdminVerified As Boolean = False
    Private Sub btncfSave_Click(sender As Object, e As EventArgs) Handles btncfSave.Click
        ' === Validation ===
        If String.IsNullOrWhiteSpace(txtcfName.Text) Then
            MessageBox.Show("Please enter name", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcfName.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtcfPw.Text) Then
            MessageBox.Show("Please enter password", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcfPw.Focus()
            Exit Sub
        End If

        Try
            If ModuleDatabase.cn.State <> ConnectionState.Open Then
                ModuleDatabase.cn.Open()
            End If

            Dim sql As String =
                "SELECT role
             FROM users
             WHERE username = @user
               AND password_hash = @pass
               AND role = 'admin'"

            Using cmd As New MySqlCommand(sql, ModuleDatabase.cn)
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtcfName.Text.Trim()
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtcfPw.Text.Trim()

                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    IsAdminVerified = True
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                    frmDevices.ShowDialog()
                Else
                    MessageBox.Show("Invalid admin credentials.",
                                    "Authentication Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error verifying credentials: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btncfExit_Click(sender As Object, e As EventArgs) Handles btncfExit.Click
        Me.Close()
        frmKiosk.Show()
    End Sub
End Class