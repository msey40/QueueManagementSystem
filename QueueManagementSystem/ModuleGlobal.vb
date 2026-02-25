Imports System.IO

Module ModuleGlobal
    Public CurrentUserID As Integer = -1
    Public CurrentUsername As String = ""
    Public CurrentCounterID As Integer = -1
    Public user_id As Integer
    Public service_id As Integer
    Public counter_id As Integer
    Public dbName As String
    Public Function GetConfigValue(key As String) As String
        ' The file is in the root of the startup directory
        Dim filePath As String = Path.Combine(Application.StartupPath, "conf.txt")

        Try
            If File.Exists(filePath) Then
                ' Read all lines from the file
                Dim lines = File.ReadAllLines(filePath)

                For Each line In lines
                    ' Look for the line that starts with our key (e.g., "serverAddress=")
                    If line.StartsWith(key & "=", StringComparison.OrdinalIgnoreCase) Then
                        ' Return everything after the "="
                        Return line.Substring(key.Length + 1).Trim()
                    End If
                Next
            Else
                Return "File Not Found"
            End If
        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try

        Return String.Empty ' Return empty if key wasn't found
    End Function

End Module
