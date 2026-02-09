Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setConnectionDatabase()
        txtUsername.Focus()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtPassword.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblError.Text = ""

        If txtUsername.Text.Trim() = "" Then
            lblError.Text = "Please enter username"
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Trim() = "" Then
            lblError.Text = "Please enter password"
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            ' Updated query: also fetch role
            Dim sql As String = "SELECT user_id, username, role FROM users WHERE username = @user AND password_hash = @pass"

            Dim cmd As New MySqlCommand(sql, ModuleDatabase.cn)
            cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())  ' Use hashed password in production!

            If ModuleDatabase.cn.State <> ConnectionState.Open Then
                ModuleDatabase.cn.Open()
            End If

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                CurrentUserID = Convert.ToInt32(dt.Rows(0)("user_id"))
                CurrentUsername = dt.Rows(0)("username").ToString()
                ' NEW: Get role
                Dim userRole As String = dt.Rows(0)("role").ToString().ToLower()
                ' Route based on role
                Select Case userRole
                    Case "admin"
                        frmAdmin.Show()
                    Case "staff"
                        frmStaffMain.Show()
                    Case Else
                        MessageBox.Show("Unknown role: " & userRole & vbCrLf & "Contact administrator.", "Access Denied")
                        Exit Sub
                End Select

                Me.Hide()  ' or Me.Close() if you don't need to keep login open
            Else
                lblError.Text = "Invalid username or password"
                txtPassword.Clear()
                txtPassword.Focus()
            End If

        Catch ex As Exception
            lblError.Text = "Connection error: " & ex.Message
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class