Imports System.IO
Imports System.Text
Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient
'Copyright Sok Dolla
'Connection setting
'

Module ModuleDatabase
    Public isbooking As Boolean = False
    Public checkDateAndDay As (DateToday As String, Days As Integer)
    Public roomInfo As (roomID As Integer, FloorID As Integer, RoomTypeID As Integer, CusID As Integer)
    Public customerID As String
    Public customerDocView As Image
    Public checkOutToday As Boolean = False
    Dim OutputStream As System.IO.StreamWriter
    Public invoiceInfo As (invoiceNo As String, tableID As String, grandTotal As String)
    Public checkAdjust As Boolean = False
    Public cn As New MySqlConnection
    Dim connection As String
    Dim sqlCmd As MySqlCommand
    Dim objDataAdapter As MySqlDataAdapter
    Public Sub setConnectionDatabase()
        Try
            ' Updated connection string for MySQL 8
            connection = $"SERVER={"localhost"};DATABASE={"qeue_sys"};UID={"root"};PWD=;PORT={"3306"};Charset=utf8mb4;"
            cn = New MySqlConnection
            With cn
                Try
                    .ConnectionString = connection
                    .Open()
                Catch ex As Exception
                    MessageBox.Show("Cannot connect to your Database." & vbCrLf & "Report: " & ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End With
            If cn.State <> ConnectionState.Open Then
                MsgBox("Techincal Error: We cannot connect to database.", vbInformation)
            End If
        Catch ex As Exception
            MessageBox.Show("System cannot connect to data store. Please configure your setting first.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End Try
    End Sub

    Public Sub ExecuteNonQuery(ByVal sql As String, Optional ByVal params As Dictionary(Of String, Object) = Nothing)
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Using cmd As New MySqlCommand(sql, cn)
                If params IsNot Nothing Then
                    For Each p In params
                        cmd.Parameters.AddWithValue(p.Key, p.Value)
                    Next
                End If
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("ExecuteNonQuery failed: " & ex.Message & vbCrLf & vbCrLf & sql, "Database Error")
        End Try
    End Sub

    Public Sub FillDataGridView(ByVal dgv As DataGridView, ByVal sql As String)
        Try
            Dim dt As New DataTable
            FillDynamicTable(sql, dt)
            dgv.DataSource = dt

            ' Optional: auto-format common columns
            If dgv.Columns.Contains("queue_id") Then
                dgv.Columns("queue_id").Visible = False
            End If
            If dgv.Columns.Contains("joined_at") Then
                dgv.Columns("joined_at").DefaultCellStyle.Format = "HH:mm:ss"
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading grid: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub AlertMessage(ByVal message As String)
        Dim newform As New frmmessage
        newform.panelmessage.Text = message
        newform.ShowDialog()
    End Sub
    Public Sub FillComboBox(ByVal cbo As ComboBox, ByVal tableName As String, ByVal idColumn As String, ByVal displayNameColumn As String, Optional ByVal groupBy As String = "", Optional ByVal orderBy As String = "")
        Try
            ' Build SQL
            Dim sql As String = $"SELECT {idColumn}, {displayNameColumn} FROM {tableName}"
            If Not String.IsNullOrEmpty(groupBy) Then sql &= " GROUP BY " & groupBy
            If Not String.IsNullOrEmpty(orderBy) Then sql &= " ORDER BY " & orderBy

            ' Create and execute command
            Using cmd As New MySqlCommand(sql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()

                Dim dt As New DataTable()
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                ' Reset and bind
                cbo.DataSource = Nothing
                cbo.Items.Clear()
                cbo.BindingContext = New BindingContext() ' Reset binding context
                cbo.DataSource = dt
                cbo.DisplayMember = displayNameColumn
                cbo.ValueMember = idColumn

                ' Clear selection AFTER binding completes
                If dt.Rows.Count > 0 Then
                    cbo.BindingContext(cbo.DataSource).Position = -1
                    cbo.SelectedIndex = -1
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error while filling combo box: " & ex.Message)
        End Try
    End Sub

    Public Function checkExist(ByVal tableName As String, ByVal condition As String) As Boolean
        Dim dt As New DataTable
        Dim sql As String = $"SELECT 1 FROM {tableName} WHERE {condition} LIMIT 1"
        FillDynamicTable(sql, dt)
        ' If the DataTable has rows, it means data exists
        Return dt.Rows.Count > 0
    End Function

    Public Sub LoadImagesToFlowLayoutPanel(flowPanel As FlowLayoutPanel)
        For Each panel As Control In flowPanel.Controls
            If TypeOf panel Is PanelEx Then
                For Each ctrl As Control In panel.Controls
                    If TypeOf ctrl Is PictureBox Then
                        Dim picBox As PictureBox = CType(ctrl, PictureBox)
                        If picBox.Tag IsNot Nothing Then
                            Dim itemId As Integer
                            If Integer.TryParse(picBox.Tag.ToString(), itemId) Then
                                picBox.Image = LoadItemImage(itemId)
                            End If
                        End If
                    End If
                Next
            End If
        Next
    End Sub
    Public Function LoadItemImage(itemId As Integer) As Image
        Try
            Dim sql As String = "SELECT itempic FROM tblitem WHERE id = @id LIMIT 1"
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", itemId)
                If cn.State = ConnectionState.Closed Then cn.Open()
                Dim imgData = CType(cmd.ExecuteScalar(), Byte())
                If imgData IsNot Nothing Then
                    Using ms As New MemoryStream(imgData)
                        Return Image.FromStream(ms)
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Image load error: " & ex.Message)
        Finally
            cn.Close()
        End Try
        Return Nothing
    End Function

    Public Function selectImage(tableName As String, fieldName As String, idValue As String) As Byte()
        Dim imageData As Byte() = Nothing
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim sql As String = $"SELECT {fieldName} FROM {tableName} WHERE id = @id LIMIT 1"
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", idValue)
                Dim result = cmd.ExecuteScalar()
                If Not IsDBNull(result) Then
                    imageData = CType(result, Byte())
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while retrieving image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
        Return imageData
    End Function
    Public Sub FillDynamicTable(ByVal sql As String, ByRef dt As DataTable)
        Try
            sqlCmd = New MySqlCommand(sql, cn)
            objDataAdapter = New MySqlDataAdapter
            objDataAdapter.SelectCommand = sqlCmd

            ' Clear existing data in the provided DataTable
            dt.Clear()

            ' Populate the provided DataTable
            objDataAdapter.Fill(dt)

            ' Cleanup
            objDataAdapter.Dispose()
            objDataAdapter = Nothing
            sqlCmd.Dispose()
            sqlCmd = Nothing
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("Cannot get your datatable." & vbCrLf & "Report: " & ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Function ComputeDays(startDate As String, endDate As String) As Integer
        ' Convert the string inputs to DateTime format
        Dim format As String = "MM-dd-yyyy HH:mm:ss"
        Dim startDateTime As DateTime = DateTime.ParseExact(startDate, format, Globalization.CultureInfo.InvariantCulture)
        Dim endDateTime As DateTime = DateTime.ParseExact(endDate, format, Globalization.CultureInfo.InvariantCulture)

        ' Calculate the total days difference
        Dim totalDays As Integer = (endDateTime - startDateTime).Days

        ' Ensure that any partial days are rounded up if the time extends past 12:00 PM
        If endDateTime.TimeOfDay > New TimeSpan(12, 0, 0) Then
            totalDays += 1
        End If
        Return totalDays
    End Function
    Function CompareDateToToday(inputDate As Date) As Boolean
        ' Get today's date
        Dim today As Date = Date.Today
        ' Compare input date with today's date
        If Format(today, "MM-dd-yyyy") > inputDate Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub DeleteRow(ByVal table As String, ByVal condition As String)
        Try
            ' Ensure the connection is open
            If cn.State <> ConnectionState.Open Then
                cn.Open()  ' Open the connection if it's not already open
            End If
            ' Build the SQL DELETE query with the condition (WHERE clause)
            Dim sqlDelete As String = $"DELETE FROM {table} WHERE {condition}"
            ' Create a MySQL command object
            Using cmd As New MySqlCommand(sqlDelete, cn) ' Assuming 'cn' is your MySQL connection object
                ' Execute the command
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            ' Log the MySQL exception details
            MessageBox.Show("MySQL error: " & ex.Message)
        Catch ex As Exception
            ' Log any other general exception details
            MessageBox.Show("General error: " & ex.Message)
        End Try
    End Sub
    Public Sub UpdateWithImage(ByVal table As String, ByVal values As Dictionary(Of String, Object), ByVal condition As String)
        Try
            ' Ensure the connection is open
            If cn.State <> ConnectionState.Open Then
                cn.Open()  ' Open the connection if it's not already open
            End If

            ' Create a list to hold the field names and their parameters
            Dim setStatements As New List(Of String)()

            ' Create SQL SET clause
            For Each kvp As KeyValuePair(Of String, Object) In values
                setStatements.Add($"{kvp.Key} = @{kvp.Key}")
            Next

            ' Join the SET clauses together
            Dim setClause As String = String.Join(", ", setStatements)

            ' Build the SQL query with the condition (WHERE clause)
            Dim sqlUpdate As String = $"UPDATE {table} SET {setClause} WHERE {condition}"

            ' Create a MySQL command object with parameters
            Using cmd As New MySqlCommand(sqlUpdate, cn) ' Assuming 'cn' is your MySQL connection object
                ' Add each parameter dynamically from the dictionary
                For Each kvp As KeyValuePair(Of String, Object) In values
                    cmd.Parameters.AddWithValue("@" & kvp.Key, If(kvp.Value IsNot Nothing, kvp.Value, DBNull.Value))
                Next
                ' Execute the command
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            ' Log the MySQL exception details
            MessageBox.Show("MySQL error: " & ex.Message)
        Catch ex As Exception
            ' Log any other general exception details
            MessageBox.Show("General error: " & ex.Message)
        End Try
    End Sub
    Public Function SaveWithImage(ByVal table As String, ByVal values As Dictionary(Of String, Object)) As Integer
        Dim lastInsertedID As Integer = -1
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim fieldNames As String = String.Join(",", values.Keys)
            Dim parameterNames As String = String.Join(",", values.Keys.Select(Function(k) "@" & k))

            Dim sqlSave As String = $"INSERT INTO {table} ({fieldNames}) VALUES ({parameterNames}); SELECT LAST_INSERT_ID();"

            Using cmd As New MySqlCommand(sqlSave, cn)
                For Each kvp In values
                    cmd.Parameters.AddWithValue("@" & kvp.Key, If(kvp.Value IsNot Nothing, kvp.Value, DBNull.Value))
                Next

                lastInsertedID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

        Catch ex As Exception
            MessageBox.Show("SaveWithImage failed!" & vbCrLf & ex.Message)
        End Try

        Return lastInsertedID
    End Function

    '  Dim values As New Dictionary(Of String, Object)()
    '  ' Add regular value
    '  ' values.Add("field1", "USA")
    '  ' Add binary data for image (example: reading an image as byte array)
    '  Dim imageBytes As Byte() = System.IO.File.ReadAllBytes("C:\path\to\your\image.jpg")
    ' values.Add("image", imageBytes)
    ''Call the Save method
    ''Save("your_table_name", values)
    '-----------------------------------------------
    Public Function Login(ByVal username As String, ByVal password As String, ByVal selectFields As String, ByVal tableName As String) As Dictionary(Of String, Object)
        Dim result As New Dictionary(Of String, Object)

        Try
            ' Ensure the connection is open
            If cn.State <> ConnectionState.Open Then
                cn.Open()  ' Open the connection if it's not already open
            End If

            ' Build the SQL SELECT query dynamically using provided fields and table
            Dim sqlLogin As String = $"SELECT {selectFields} FROM {tableName} WHERE username = @username AND password = @password"

            ' Create the MySQL command object with the SQL query
            Using cmd As New MySqlCommand(sqlLogin, cn)
                ' Add parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                ' Execute the query and read the result
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        ' Read the data
                        reader.Read()

                        ' Dynamically add each selected field to the result dictionary
                        For Each field As String In selectFields.Split(","c)
                            field = field.Trim() ' Remove any leading or trailing spaces
                            result(field) = reader(field)
                        Next
                    Else
                        ' If no matching row found, return an empty dictionary (indicating login failed)
                        result = New Dictionary(Of String, Object)()
                    End If
                End Using
            End Using

        Catch ex As MySqlException
            ' Log MySQL exception details
            MessageBox.Show("MySQL error: " & ex.Message)
        Catch ex As Exception
            ' Log any other general exception details
            MessageBox.Show("General error: " & ex.Message)
        End Try

        ' Return the result, which will be empty if login failed, or contain user data if successful
        Return result
    End Function
    ' how to use
    '    Dim selectFields As String = "UserID, username, departID"
    '    Dim tableName As String = "tblappuser"

    '    Dim userInfo As Dictionary(Of String, Object) = Login("testUser", "testPassword", selectFields, tableName)

    '    If userInfo.Count > 0 Then
    '    ' Login successful
    '    Dim userID As Integer = userInfo("UserID")
    '    Dim username As String = userInfo("username")
    '    Dim departID As Integer = userInfo("departID")

    '    ' You can use the returned fields as needed
    '    MessageBox.Show("Login successful. Welcome " & username)
    'Else
    '    ' Login failed
    '    MessageBox.Show("Invalid username or password.")
    'End If
    '-----------------------------------------------------------------------------------------
    Function RemoveNonNumeric(input As String) As String
        ' Use regular expression to match only numeric and decimal point
        Dim result As String = System.Text.RegularExpressions.Regex.Replace(input, "[^\d.]", "")
        ' Return the result
        Return result
    End Function

    Public Function checkDateFromToday(inputDate As String, expectedFormat As String) As Boolean
        ' Declare parsedDate to store the result of parsing
        Dim parsedDate As DateTime
        ' Try to parse the input string into a DateTime object using the exact format
        If DateTime.TryParseExact(inputDate, expectedFormat, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, parsedDate) Then
            ' Compare the dates
            If parsedDate.Date > Now.Date Then
                Return False ' If the date is in the future, return False
            ElseIf parsedDate.Date = Now.Date Then
                Return True ' If the date is today, return True
            Else
                Return False ' If the date is in the past, return False
            End If
        Else
            ' Return false if the date parsing fails
            Return False
        End If
    End Function
    Public Function ParseDate(inputDate As String, Optional format As String = "dd-MM-yyyy HH:mm:ss") As DateTime?
        Dim parsedDate As DateTime
        If DateTime.TryParseExact(inputDate, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, parsedDate) Then
            Return parsedDate ' Return the parsed DateTime
        Else
            Return Nothing ' Return Nothing if parsing fails
        End If
    End Function
    Function CleanNonNumeric(ByVal input As String) As Double
        ' Keep digits and one decimal point
        Dim cleanedInput As String = ""
        Dim decimalFound As Boolean = False

        For Each ch As Char In input
            If Char.IsDigit(ch) Then
                cleanedInput &= ch
            ElseIf ch = "."c AndAlso Not decimalFound Then
                cleanedInput &= ch
                decimalFound = True
            End If
        Next
        ' Return the cleaned number or 0 if invalid
        If Not String.IsNullOrEmpty(cleanedInput) AndAlso IsNumeric(cleanedInput) Then
            Return Double.Parse(cleanedInput)
        Else
            Return 0
        End If
    End Function

    Sub OnDataReceived1(sender As Object, e As DataReceivedEventArgs)
        If e.Data IsNot Nothing Then
            ' Write each line received from mysqldump to file
            OutputStream.WriteLine(e.Data)
        End If
    End Sub
    Public Sub CallStoredProcedure(ByVal invoiceId As Integer)
        Try
            ' Prepare the command for calling the stored procedure with CALL
            Dim sql As String = "CALL sp_UpdateInvoiceTotal(@p_id);"
            sqlCmd = New MySqlCommand(sql, cn)
            sqlCmd.CommandType = CommandType.Text
            ' Add the @p_id parameter for the stored procedure
            sqlCmd.Parameters.Clear()
            sqlCmd.Parameters.Add(New MySqlParameter("@p_id", MySqlDbType.Int32)).Value = invoiceId
            ' Open the connection if it's not already open
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            ' Execute the stored procedure (this won't return a DataTable, just updates)
            sqlCmd.ExecuteNonQuery()
            ' Cleanup
            sqlCmd.Dispose()
            sqlCmd = Nothing
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("Cannot execute the stored procedure." & vbCrLf & "Report: " & ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
