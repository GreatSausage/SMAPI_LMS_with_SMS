Imports System.Drawing.Printing

Public Class frmReports

    Private printDocument As New PrintDocument()
    Private printPreviewDialog As New PrintPreviewDialog()

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtReports As DataTable = DisplayReport()
        dgReports.DataSource = dtReports
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintReport()
    End Sub
    Private Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Dim printArea As RectangleF = e.MarginBounds

        Dim font As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)

        Dim xPos As Single = printArea.Left
        Dim yPos As Single = printArea.Top

        Dim rowHeight As Single = font.GetHeight() + 5

        Dim dt As DataTable = DisplayReport()

        ' Define column widths and alignment
        Dim columnWidths As New List(Of Single)({110, 100, 100, 100, 140, 140, 100}) ' Adjust widths as needed
        Dim columnAlignments As New List(Of String)({"Left", "Left", "Left", "Left", "Left", "Left", "Right"})
        Dim columnHeaders As New List(Of String)({"ISBN", "Book Title", "Authors", "Fullname", "Date Borrowed", "Date Returned", "Penalty"})

        ' Display column headers
        For i As Integer = 0 To columnHeaders.Count - 1
            Dim columnText As String = columnHeaders(i)
            Dim alignment As String = columnAlignments(i)
            Dim columnWidth As Single = columnWidths(i)
            If alignment = "Right" Then
                xPos += columnWidth - e.Graphics.MeasureString(columnText, font).Width
            End If
            e.Graphics.DrawString(columnText, font, brush, xPos, yPos)
            If alignment = "Center" OrElse alignment = "Right" Then
                xPos -= columnWidth - e.Graphics.MeasureString(columnText, font).Width
            End If
            xPos += columnWidth + 10
        Next

        yPos += rowHeight

        ' Display rows
        For Each row As DataRow In dt.Rows
            xPos = printArea.Left
            For i As Integer = 0 To dt.Columns.Count - 1
                Dim columnText As String = row(i).ToString()
                Dim alignment As String = columnAlignments(i)
                Dim columnWidth As Single = columnWidths(i)
                If alignment = "Right" Then
                    xPos += columnWidth - e.Graphics.MeasureString(columnText, font).Width
                End If
                e.Graphics.DrawString(columnText, font, brush, xPos, yPos)
                If alignment = "Center" OrElse alignment = "Right" Then
                    xPos -= columnWidth - e.Graphics.MeasureString(columnText, font).Width
                End If
                xPos += columnWidth + 10
            Next
            yPos += rowHeight
        Next
        e.HasMorePages = False
    End Sub






    Private Sub PrintReport()
        ' Set landscape orientation
        printDocument.DefaultPageSettings.Landscape = True

        ' Attach event handler
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        ' Show print preview dialog
        printPreviewDialog.Document = printDocument
        printPreviewDialog.ShowDialog()
    End Sub

End Class