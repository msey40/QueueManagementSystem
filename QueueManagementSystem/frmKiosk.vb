Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class frmKiosk
    'Private Const PRINTER_NAME As String = "\\192.168.99.197\80mm Series Printer"
    Private PRINTER_NAME As String = My.Settings.printerName
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
            If ModuleDatabase.cn.State <> ConnectionState.Open Then
                ModuleDatabase.cn.Open()
            End If

            Dim serviceId As Integer = Convert.ToInt32(cmbService.SelectedValue)
            Dim serviceName As String = cmbService.Text ' Get the name for the receipt

            ' Prepare insert values
            Dim values As New Dictionary(Of String, Object) From {
                {"service_id", serviceId},
                {"status", "waiting"},
                {"joined_at", DateTime.Now}
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
                    Dim ticketNumber As String = dt.Rows(0)("queue_number").ToString()

                    ' Update UI
                    lblTicketNumber.Text = ticketNumber
                    ShowTicketPanel(True)

                    ' --- START PRINTING LOGIC ---
                    PrintQueueTicket(ticketNumber, serviceName)
                    ' --- END PRINTING LOGIC ---

                    TimerReset.Start()
                Else
                    MessageBox.Show("Ticket created but queue_number not found.", "Warning")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' New helper method for printing
    Private Sub PrintQueueTicket(ticketNum As String, serviceName As String)
        Try
            Dim printer As New ReceiptPrinter80(PRINTER_NAME)
            ' Configure Header
            printer.AddReceiptHeader("OUR BANK / CLINIC", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "QUEUE TICKET")

            printer.AddEmptyLine()

            ' Print Ticket Number (Make it large by setting font if desired)
            printer.SetFont("Arial", 24, FontStyle.Bold)
            printer.AddLine(ticketNum, "center")

            ' Print Service Name
            printer.SetFont("Segoe UI", 12, FontStyle.Regular)
            printer.AddLine(serviceName, "center")

            printer.AddEmptyLine()
            printer.AddSeparator("-")

            ' Footer
            printer.SetFont("Segoe UI", 8, FontStyle.Italic)
            printer.AddLine("Please wait for your number to be called.", "center")
            printer.AddLine("Thank you!", "center")

            ' Execute print
            printer.Print()

        Catch ex As Exception
            ' We use Console.WriteLine so the kiosk UI doesn't crash if printer is off
            Console.WriteLine("Printing failed: " & ex.Message)
        End Try
    End Sub

    ' Helper to clean up UI toggle code
    Private Sub ShowTicketPanel(show As Boolean)
        pnlTicket.Visible = show
        lblWelcome.Visible = Not show
        lblInstruction.Visible = Not show
        cmbService.Visible = Not show
        btnGetTicket.Visible = Not show
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

    Private Sub btnKioskSettings_Click(sender As Object, e As EventArgs) Handles btnKioskSettings.Click
        frmConfirm.Show()
    End Sub
End Class