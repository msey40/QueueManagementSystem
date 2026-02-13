Imports System.Drawing.Printing
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Text

Public Class ReceiptPrinter80
    Private receiptLines As New List(Of Tuple(Of String(), Boolean, Font, String)) ' (columns or single line, isColumnRow, font, alignment)
    Private imagesToDraw As New List(Of Tuple(Of Image, Integer, Integer, Integer, Integer)) ' (image, x, y, width, height)
    Private columnHeaders As String()
    Private columnWidths As Integer()
    Private Const MaxWidth As Integer = 295 ' Reduced to 295 to account for margins
    Private Const MaxChars As Integer = 56 ' Max chars at 8pt font
    Private currentY As Single = 20 ' Start below top margin
    Private leftMargin As Single = 0
    Private printFont As Font = New Font("Khmer OS Battambang", 8, FontStyle.Regular) ' Default font
    Private printBrush As SolidBrush = New SolidBrush(Color.Black)
    Private printerName As String
    Private ReadOnly columnXPositions As Single() = {0, 120, 180, 200} ' Pixel positions for Item, Qty, Price, Total

    Public Sub New(printer As String)
        printerName = printer
        receiptLines = New List(Of Tuple(Of String(), Boolean, Font, String))
        imagesToDraw = New List(Of Tuple(Of Image, Integer, Integer, Integer, Integer))
        columnHeaders = {}
        columnWidths = {}
    End Sub

    Public Sub SetColumns(headers As String(), widths As Integer())
        If headers.Length <> widths.Length Then
            Throw New ArgumentException("Headers and widths must have the same length")
        End If
        If widths.Sum() > MaxChars Then
            Throw New ArgumentException($"Total column width ({widths.Sum()}) exceeds {MaxChars} characters")
        End If
        columnHeaders = headers
        columnWidths = widths
        Console.WriteLine($"Set columns: {String.Join(", ", headers)}, Widths: {String.Join(", ", widths)}")
    End Sub

    Public Sub AddReceiptHeader(storeName As String, dateHeader As String, title As String)
        receiptLines.Add(Tuple.Create({New String("="c, MaxChars)}, False, printFont, ""))
        receiptLines.Add(Tuple.Create({CenterText(title)}, False, printFont, ""))
        receiptLines.Add(Tuple.Create({CenterText(storeName)}, False, printFont, ""))
        receiptLines.Add(Tuple.Create({CenterText(dateHeader)}, False, printFont, ""))
        receiptLines.Add(Tuple.Create({New String("="c, MaxChars)}, False, printFont, ""))
        currentY += printFont.GetHeight() * 5 ' Approximate height for 5 lines
        Console.WriteLine($"Added header: {storeName}, {dateHeader}, Font: {printFont.Name}, {printFont.Size}, {printFont.Style}, y={currentY}")
    End Sub

    Public Sub AddLine(text As String, Optional alignment As String = "center")
        Dim validAlignments As String() = {"left", "right", "center"}
        Dim normalizedAlignment As String = If(alignment?.ToLower(), "center")
        If Not validAlignments.Contains(normalizedAlignment) Then
            Console.WriteLine($"Invalid alignment '{alignment}', defaulting to 'center'")
            normalizedAlignment = "center"
        End If
        Dim trimmedText As String = If(text?.Trim(), "")

        ' Wrap text into multiple lines if necessary
        Dim wrappedLines As String() = WrapText(trimmedText, MaxChars)
        For Each line As String In wrappedLines
            Dim formattedLine As String
            Select Case normalizedAlignment
                Case "left"
                    formattedLine = line.PadRight(MaxChars)
                Case "right"
                    formattedLine = line.PadLeft(MaxChars)
                Case Else ' center
                    formattedLine = CenterText(line)
            End Select
            If formattedLine.Length > MaxChars Then
                formattedLine = formattedLine.Substring(0, MaxChars)
            End If
            receiptLines.Add(Tuple.Create({formattedLine}, False, printFont, normalizedAlignment))
            currentY += printFont.GetHeight()
            Console.WriteLine($"Adding line: '{formattedLine}' (length: {formattedLine.Length}, alignment: {normalizedAlignment}, Font: {printFont.Name}, {printFont.Size}, {printFont.Style}, y={currentY}")
        Next
    End Sub

    Private Function CenterText(text As String) As String
        If String.IsNullOrEmpty(text) Then
            Return New String(" "c, MaxChars)
        End If
        Dim spaces As Integer = (MaxChars - text.Length) \ 2
        Dim line As String = New String(" "c, spaces) & text & New String(" "c, MaxChars - text.Length - spaces)
        If line.Length > MaxChars Then
            line = line.Substring(0, MaxChars)
        End If
        Return line
    End Function

    Public Sub AddRow(values As String())
        If values.Length <> columnHeaders.Length Then
            Throw New ArgumentException($"Row must have {columnHeaders.Length} values")
        End If

        ' Clean and validate input
        Dim cleanValues As String() = values.Select(Function(v) If(v, "").Replace(vbNullChar, "").Trim()).ToArray()

        ' Wrap Item column (first column) separately
        Dim itemLines As String() = WrapText(cleanValues(0), columnWidths(0))

        ' Generate lines
        For lineIndex As Integer = 0 To itemLines.Length - 1
            Dim rowValues As String() = New String(columnHeaders.Length - 1) {}
            rowValues(0) = itemLines(lineIndex)
            If lineIndex = 0 Then
                ' Include other columns only on the first line
                For i As Integer = 1 To columnHeaders.Length - 1
                    Dim valueText As String = cleanValues(i)
                    If valueText.Length > columnWidths(i) Then
                        valueText = valueText.Substring(0, columnWidths(i))
                    End If
                    rowValues(i) = valueText
                Next
            Else
                ' Empty columns for wrapped lines
                For i As Integer = 1 To columnHeaders.Length - 1
                    rowValues(i) = ""
                Next
            End If

            receiptLines.Add(Tuple.Create(rowValues, True, printFont, ""))
            currentY += printFont.GetHeight()
            Console.WriteLine($"Adding row line: Item='{rowValues(0)}', Qty='{rowValues(1)}', Price='{rowValues(2)}', Total='{rowValues(3)}', Font: {printFont.Name}, {printFont.Size}, {printFont.Style}, y={currentY}")
        Next
    End Sub

    Public Function WrapText(text As String, maxWidth As Integer) As String()
        If String.IsNullOrEmpty(text) Then
            Return {""}
        End If
        Dim words As String() = text.Split(" "c)
        Dim lines As New List(Of String)
        Dim currentLine As New StringBuilder
        For Each word In words
            If currentLine.Length + word.Length + (If(currentLine.Length > 0, 1, 0)) <= maxWidth Then
                If currentLine.Length > 0 Then
                    currentLine.Append(" ")
                End If
                currentLine.Append(word)
            Else
                If currentLine.Length > 0 Then
                    lines.Add(currentLine.ToString())
                    currentLine.Clear()
                End If
                If word.Length > maxWidth Then
                    Dim startIndex As Integer = 0
                    While startIndex < word.Length
                        Dim length As Integer = Math.Min(maxWidth, word.Length - startIndex)
                        lines.Add(word.Substring(startIndex, length))
                        startIndex += length
                    End While
                Else
                    currentLine.Append(word)
                End If
            End If
        Next
        If currentLine.Length > 0 Then
            lines.Add(currentLine.ToString())
        End If
        Return lines.ToArray()
    End Function

    Public Sub AddImage(image As Image, x As Integer, y As Integer, imageWidth As Integer, imageHeight As Integer)
        imagesToDraw.Add(Tuple.Create(image, x, y, imageWidth, imageHeight))
        Console.WriteLine($"Adding image at x={x}, y={y}, width={imageWidth}, height={imageHeight}")
    End Sub

    Public Sub AddImageAfterLine(image As Image, x As Integer, imageWidth As Integer, imageHeight As Integer)
        Dim imageY As Integer = CInt(currentY + 5) ' Place image 5 pixels below the last line
        imagesToDraw.Add(Tuple.Create(image, x, imageY, imageWidth, imageHeight))
        currentY = imageY + imageHeight + 5 ' Reserve space for image and gap
        Console.WriteLine($"Adding image after line at x={x}, y={imageY}, width={imageWidth}, height={imageHeight}")
    End Sub

    Public Sub AddSeparator(Optional character As String = "-")
        Dim line As String = New String(character(0), MaxChars)
        receiptLines.Add(Tuple.Create({line}, False, printFont, ""))
        currentY += printFont.GetHeight()
        Console.WriteLine($"Adding separator: {line}, Font: {printFont.Name}, {printFont.Size}, {printFont.Style}, y={currentY}")
    End Sub

    Public Sub AddEmptyLine()
        receiptLines.Add(Tuple.Create({""}, False, printFont, ""))
        currentY += printFont.GetHeight()
        Console.WriteLine($"Adding empty line, Font: {printFont.Name}, {printFont.Size}, {printFont.Style}, y={currentY}")
    End Sub

    Public Sub SetFont(fontName As String, fontSize As Single, fontStyle As FontStyle)
        Try
            printFont = New Font(fontName, fontSize, fontStyle)
            Console.WriteLine($"Set font: {fontName}, {fontSize}, {fontStyle}")
        Catch ex As Exception
            Console.WriteLine($"Error setting font {fontName}: {ex.Message}")
            printFont = New Font("Courier New", fontSize, fontStyle)
        End Try
    End Sub

    Public Sub SetMargin(margin As Single)
        leftMargin = margin
        Console.WriteLine($"Set margin: {margin}")
    End Sub

    Private Sub OnPrintPage(sender As Object, e As PrintPageEventArgs)
        Try
            currentY = 20

            ' Sort images by y position to ensure correct order
            Dim sortedImages = imagesToDraw.OrderBy(Function(img) img.Item3).ToList()
            Dim imageIndex As Integer = 0
            Dim rowLineCount As Integer = 0
            Dim isWrappedRow As Boolean = False

            For Each lineData In receiptLines
                Dim values As String() = lineData.Item1
                Dim isColumnRow As Boolean = lineData.Item2
                Dim font As Font = lineData.Item3
                Dim alignment As String = lineData.Item4

                ' Draw images scheduled before or at this line's y position
                While imageIndex < sortedImages.Count AndAlso sortedImages(imageIndex).Item3 <= currentY
                    Dim imgData = sortedImages(imageIndex)
                    Try
                        Dim img As Image = imgData.Item1
                        Dim x As Integer = imgData.Item2
                        Dim y As Integer = imgData.Item3
                        Dim width As Integer = imgData.Item4
                        Dim height As Integer = imgData.Item5

                        If width <= 0 Or height <= 0 Then
                            Dim scaleFactor As Single = Math.Min(CSng(MaxWidth) / img.Width, 1)
                            width = CInt(img.Width * scaleFactor)
                            height = CInt(img.Height * scaleFactor)
                        ElseIf width > MaxWidth Then
                            Dim scaleFactor As Single = CSng(MaxWidth) / width
                            width = MaxWidth
                            height = CInt(height * scaleFactor)
                        End If

                        e.Graphics.DrawImage(img, x, y, width, height)
                        currentY = Math.Max(currentY, CSng(y + height + 3))
                        Console.WriteLine($"Image drawn at x={x}, y={y}, width={width}, height={height}")
                    Catch ex As Exception
                        Console.WriteLine($"Error drawing image: {ex.Message}")
                    End Try
                    imageIndex += 1
                End While

                ' Draw the text line
                If isColumnRow AndAlso columnHeaders.Length = 4 Then
                    ' Track wrapped rows
                    rowLineCount += 1
                    If rowLineCount > 1 AndAlso values(1) = "" AndAlso values(2) = "" AndAlso values(3) = "" Then
                        isWrappedRow = True
                    Else
                        isWrappedRow = False
                        rowLineCount = 1
                    End If

                    ' Draw each column
                    For colIndex As Integer = 0 To values.Length - 1
                        Dim text As String = values(colIndex).Trim()
                        If Not String.IsNullOrEmpty(text) Then
                            Dim textSize As SizeF = e.Graphics.MeasureString(text, font)
                            Dim xPosition As Single = columnXPositions(colIndex)
                            If colIndex > 0 Then
                                xPosition += (columnWidths(colIndex) * 6 - textSize.Width)
                            End If
                            e.Graphics.DrawString(text, font, printBrush, xPosition, currentY)
                            Console.WriteLine($"Text drawn (column {colIndex}): '{text}' (x: {xPosition}, y: {currentY}, width: {textSize.Width}, Font: {font.Name}, {font.Size}, {font.Style})")
                        End If
                    Next
                Else
                    ' Draw non-column lines with alignment
                    Dim text As String = values(0)
                    Dim trimmedText As String = text.Trim()
                    Dim textSize As SizeF = e.Graphics.MeasureString(trimmedText, font)
                    Dim xPosition As Single
                    Select Case alignment
                        Case "left"
                            xPosition = 0
                        Case "right"
                            xPosition = MaxWidth - textSize.Width - 10 ' Increased to 10-pixel padding
                        Case Else ' center or empty (default)
                            xPosition = (MaxWidth - textSize.Width) / 2
                    End Select
                    If xPosition < 0 Then xPosition = 0
                    e.Graphics.DrawString(trimmedText, font, printBrush, xPosition, currentY)
                    Console.WriteLine($"Text drawn: '{trimmedText}' (length: {trimmedText.Length}, x: {xPosition}, y: {currentY}, width: {textSize.Width}, Font: {font.Name}, {font.Size}, {font.Style})")
                End If

                ' Advance currentY
                If isColumnRow AndAlso Not isWrappedRow Then
                    currentY += font.GetHeight(e.Graphics) + 5 ' Extra padding for complete rows
                Else
                    currentY += font.GetHeight(e.Graphics) ' Normal spacing for wrapped rows or non-row lines
                End If
            Next

            ' Draw any remaining images
            While imageIndex < sortedImages.Count
                Dim imgData = sortedImages(imageIndex)
                Try
                    Dim img As Image = imgData.Item1
                    Dim x As Integer = imgData.Item2
                    Dim y As Integer = imgData.Item3
                    Dim width As Integer = imgData.Item4
                    Dim height As Integer = imgData.Item5

                    If width <= 0 Or height <= 0 Then
                        Dim scaleFactor As Single = Math.Min(CSng(MaxWidth) / img.Width, 1)
                        width = CInt(img.Width * scaleFactor)
                        height = CInt(img.Height * scaleFactor)
                    ElseIf width > MaxWidth Then
                        Dim scaleFactor As Single = CSng(MaxWidth) / width
                        width = MaxWidth
                        height = CInt(height * scaleFactor)
                    End If

                    e.Graphics.DrawImage(img, x, y, width, height)
                    currentY = Math.Max(currentY, CSng(y + height + 3))
                    Console.WriteLine($"Image drawn at x={x}, y={y}, width={width}, height={height}")
                Catch ex As Exception
                    Console.WriteLine($"Error drawing image: {ex.Message}")
                End Try
                imageIndex += 1
            End While

            e.HasMorePages = False
        Catch ex As Exception
            Console.WriteLine($"Error in OnPrintPage: {ex.Message}")
        End Try
    End Sub

    Public Sub Print()
        Try
            Dim printDoc As New PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf OnPrintPage

            Dim paperSize As New PaperSize("Receipt", MaxWidth, 0)
            printDoc.DefaultPageSettings.PaperSize = paperSize
            printDoc.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

            printDoc.PrinterSettings.PrinterName = printerName

            If Not printDoc.PrinterSettings.IsValid Then
                Throw New Exception($"Printer is not valid or not available: {printerName}")
            End If

            printDoc.Print()
        Catch ex As Exception
            Console.WriteLine($"Error printing: {ex.Message}")
            ' Fallback to raw text
            Dim rawTextLines As New List(Of String)
            For Each lineData In receiptLines
                If lineData.Item2 Then
                    Dim formattedLine As String = String.Join(" ", lineData.Item1.Select(Function(v, i) If(i = 0, v.PadRight(columnWidths(i)), v.PadLeft(columnWidths(i)))))
                    rawTextLines.Add(formattedLine.TrimEnd())
                Else
                    rawTextLines.Add(lineData.Item1(0))
                End If
            Next
            Dim rawText As String = String.Join(vbLf, rawTextLines) & vbLf
            PrintRawText(rawText)
        End Try
    End Sub

    Public Sub PrintRawImage(imagePath As String)
        Try
            Using img As Image = Image.FromFile(imagePath)
                Using bmp As New Bitmap(img.Width, img.Height, Imaging.PixelFormat.Format1bppIndexed)
                    Using g As Graphics = Graphics.FromImage(bmp)
                        g.DrawImage(img, 0, 0)
                    End Using
                    Dim escPosData As New List(Of Byte) From {27, 64}
                    escPosData.AddRange({29, 118, 48, 0})
                    escPosData.Add(CByte(bmp.Width Mod 256))
                    escPosData.Add(CByte(bmp.Width \ 256))
                    escPosData.Add(CByte(bmp.Height Mod 256))
                    escPosData.Add(CByte(bmp.Height \ 256))
                    For y As Integer = 0 To bmp.Height - 1
                        For x As Integer = 0 To bmp.Width - 1 Step 8
                            Dim b As Byte = 0
                            For bit As Integer = 0 To 7
                                If x + bit < bmp.Width Then
                                    If bmp.GetPixel(x + bit, y).R < 128 Then b = b Or CByte(1 << (7 - bit))
                                End If
                            Next
                            escPosData.Add(b)
                        Next
                    Next
                    escPosData.AddRange({10, 27, 100, 4})
                    SendBytesToPrinter(printerName, escPosData.ToArray())
                    Console.WriteLine("Raw image sent successfully")
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error printing raw image: {ex.Message}")
        End Try
    End Sub

    Public Sub PrintRawText(text As String)
        Try
            Dim escPosData As New List(Of Byte) From {27, 64}
            escPosData.AddRange({27, 116, 0}) ' PC437, adjust if needed
            escPosData.AddRange(Encoding.UTF8.GetBytes(text))
            escPosData.AddRange({10, 27, 100, 4})
            SendBytesToPrinter(printerName, escPosData.ToArray())
            Console.WriteLine($"Raw text sent: '{text}' (length: {text.Length})")
        Catch ex As Exception
            Console.WriteLine($"Error printing raw text: {ex.Message}")
        End Try
    End Sub

    Private Sub SendBytesToPrinter(printerName As String, data As Byte())
        Dim hPrinter As IntPtr
        Dim docInfo As DOCINFO
        Dim pcWritten As Int32 = 0
        Dim pBytes As IntPtr = Marshal.AllocHGlobal(data.Length)
        Marshal.Copy(data, 0, pBytes, data.Length)
        docInfo.pDocName = "Receipt"
        docInfo.pOutputFile = Nothing
        docInfo.pDataType = "RAW"
        If OpenPrinter(printerName, hPrinter, IntPtr.Zero) Then
            If StartDocPrinter(hPrinter, 1, docInfo) Then
                WritePrinter(hPrinter, pBytes, data.Length, pcWritten)
                EndDocPrinter(hPrinter)
            End If
            ClosePrinter(hPrinter)
        End If
        Marshal.FreeHGlobal(pBytes)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Structure DOCINFO
        Public pDocName As String
        Public pOutputFile As String
        Public pDataType As String
    End Structure

    <DllImport("winspool.drv", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function OpenPrinter(pPrinterName As String, ByRef hPrinter As IntPtr, pDefault As IntPtr) As Boolean
    End Function
    <DllImport("winspool.drv", SetLastError:=True)>
    Private Shared Function ClosePrinter(hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.drv", SetLastError:=True)>
    Private Shared Function StartDocPrinter(hPrinter As IntPtr, Level As Int32, ByRef pDocInfo As DOCINFO) As Boolean
    End Function
    <DllImport("winspool.drv", SetLastError:=True)>
    Private Shared Function EndDocPrinter(hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.drv", SetLastError:=True)>
    Private Shared Function WritePrinter(hPrinter As IntPtr, pBuf As IntPtr, cbBuf As Int32, ByRef pcWritten As Int32) As Boolean
    End Function
End Class