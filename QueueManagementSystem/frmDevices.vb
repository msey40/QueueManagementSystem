Imports System.Drawing.Printing

Public Class frmDevices
    Private Sub frmDevices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadprintername()
        cmbPrinter.Text = My.Settings.printerName
    End Sub
    Private Sub loadprintername()
        cmbPrinter.Items.Clear()

        For Each printer As String In PrinterSettings.InstalledPrinters
            cmbPrinter.Items.Add(printer)
        Next

        ' Load saved printer
        If My.Settings.printerName <> "" Then
            cmbPrinter.Text = My.Settings.printerName
        Else
            ' Fallback to default printer
            Dim ps As New PrinterSettings()
            cmbPrinter.Text = ps.PrinterName
        End If
    End Sub

    Private Sub btnPSave_Click(sender As Object, e As EventArgs) Handles btnPSave.Click

        My.Settings.printerName = cmbPrinter.Text
        My.Settings.Save()

        MessageBox.Show(
        "Printer settings have been saved successfully.",
        "Settings Saved",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    )
    End Sub
End Class