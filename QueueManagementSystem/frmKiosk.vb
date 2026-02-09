Imports MySql.Data.MySqlClient

Public Class frmKiosk

    Private Sub frmKiosk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure database connection is ready
        Try
            If ModuleDatabase.cn.State <> ConnectionState.Open Then
                ModuleDatabase.setConnectionDatabase()
                If ModuleDatabase.cn.State <> ConnectionState.Open Then
                    MessageBox.Show("Cannot connect to database. Please check settings.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Application.Exit()
                    Exit Sub
                End If
            End If

            ' Load all available services
            ModuleDatabase.FillComboBox(cmbService, "services", "service_id", "name", "", "name ASC")

            ' Reset UI to initial state
            pnlTicket.Visible = False
            lblWelcome.Visible = True
            lblInstruction.Visible = True
            cmbService.Visible = True
            btnGetTicket.Visible = True
            cmbService.SelectedIndex = -1
            lblTicketNumber.Text = "-----"

        Catch ex As Exception
            MessageBox.Show("Form load error: " & ex.Message, "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGetTicket_Click(sender As Object, e As EventArgs) Handles btnGetTicket.Click
        If cmbService.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a service first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbService.Focus()
            Exit Sub
        End If

        Try
            ' Ensure connection is open
            If ModuleDatabase.cn.State <> ConnectionState.Open Then
                ModuleDatabase.cn.Open()
                ' MessageBox.Show("Connection opened for ticket creation", "Debug Info")  ' Uncomment for debug
            End If

            Dim serviceId As Integer = Convert.ToInt32(cmbService.SelectedValue)

            ' Prepare insert values
            Dim values As New Dictionary(Of String, Object) From {
                {"service_id", serviceId},
                {"status", "waiting"},
                {"joined_at", DateTime.Now}   ' Explicitly set - remove if table has DEFAULT CURRENT_TIMESTAMP
            }
            ' Insert new queue entry
            Dim newQueueId As Integer = ModuleDatabase.SaveWithImage("queue", values)
            If newQueueId > 0 Then
                ' Fetch the generated queue_number
                Dim dt As New DataTable
                Dim sql As String = "SELECT queue_number FROM queue WHERE queue_id = @id"
                Using cmd As New MySqlCommand(sql, ModuleDatabase.cn)
                    cmd.Parameters.AddWithValue("@id", newQueueId)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using

                If dt.Rows.Count > 0 Then
                    Dim ticket As String = dt.Rows(0)("queue_number").ToString()
                    lblTicketNumber.Text = ticket
                    pnlTicket.Visible = True
                    lblWelcome.Visible = False
                    lblInstruction.Visible = False
                    cmbService.Visible = False
                    btnGetTicket.Visible = False
                    TimerReset.Start()
                Else
                    MessageBox.Show("Ticket created (ID: " & newQueueId & ") but queue_number not found in DB", "Warning")
                End If
            Else
                MessageBox.Show("Failed to create ticket." & vbCrLf &
                                "Returned ID: " & newQueueId & vbCrLf &
                                "Possible causes: connection issue, missing fields, trigger error, or table constraints.", "Error")
            End If

        Catch ex As Exception
            MessageBox.Show("Critical error during ticket creation:" & vbCrLf &
                            ex.Message & vbCrLf & vbCrLf &
                            "Stack Trace:" & vbCrLf & ex.StackTrace,
                            "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Optional: close connection only if you don't want to keep it open
            ' If ModuleDatabase.cn.State = ConnectionState.Open Then ModuleDatabase.cn.Close()
        End Try
    End Sub

    Private Sub TimerReset_Tick(sender As Object, e As EventArgs) Handles TimerReset.Tick
        TimerReset.Stop()

        ' Reset form for the next customer
        pnlTicket.Visible = False
        lblWelcome.Visible = True
        lblInstruction.Visible = True
        cmbService.Visible = True
        btnGetTicket.Visible = True
        cmbService.SelectedIndex = -1
        lblTicketNumber.Text = "-----"
    End Sub
End Class