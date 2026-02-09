Imports MySql.Data.MySqlClient

Public Class frmMonitor

    Private Sub frmMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModuleDatabase.cn.State <> ConnectionState.Open Then
            ModuleDatabase.setConnectionDatabase()
        End If

        Me.FormBorderStyle = FormBorderStyle.None
        'Me.WindowState = FormWindowState.Maximized

        TimerRefresh.Interval = 2000   ' Faster refresh - 2 seconds
        TimerRefresh.Start()
        UpdateDisplay()
    End Sub

    Private Sub TimerRefresh_Tick(sender As Object, e As EventArgs) Handles TimerRefresh.Tick
        UpdateDisplay()
    End Sub

    Private Sub UpdateDisplay()
        Try
            ' Show ALL currently called customers from ALL counters
            Dim sql As String = "
                SELECT 
                    q.queue_number,
                    c.name AS counter_name,
                    s.name AS service_name,
                    q.called_at
                FROM queue q
                INNER JOIN counters c ON q.called_counter_id = c.counter_id
                INNER JOIN services s ON q.service_id = s.service_id
                WHERE q.status = 'called'
                ORDER BY q.called_at DESC"

            Dim dt As New DataTable
            ModuleDatabase.FillDynamicTable(sql, dt)

            If dt.Rows.Count > 0 Then
                ' We clear the initial text to match your desired header
                Dim displayText As String = ""

                For Each row As DataRow In dt.Rows
                    ' Constructing the line: Ticket - Counter - Service
                    Dim ticket As String = row("queue_number").ToString()
                    Dim counter As String = row("counter_name").ToString()
                    Dim service As String = row("service_name").ToString()

                    ' Build the single line format
                    displayText &= $"{ticket} - {counter} - {service}" & vbCrLf
                Next

                lblDisplay.Text = displayText
                lblDisplay.ForeColor = Color.Lime
                lblTitle.Text = "NOW SERVING" ' Kept simple as per your request
                lblWaiting.Visible = False
            Else
                lblDisplay.Text = "-----"
                lblTitle.Text = "NOW SERVING"
                lblWaiting.Text = "Waiting for next call from any counter..."
                lblWaiting.Visible = True
            End If

        Catch ex As Exception
            lblWaiting.Text = "Display error: " & ex.Message
            lblWaiting.Visible = True
        End Try
    End Sub

    Private Sub lblDisplay_Click(sender As Object, e As EventArgs) Handles lblDisplay.Click

    End Sub
End Class