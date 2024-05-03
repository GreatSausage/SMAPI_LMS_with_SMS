Imports System.Globalization
Imports System.IO
Imports OfficeOpenXml
Imports OfficeOpenXml.Style

Public Class frmReports

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ExportToExcel()
    End Sub

    Private Sub ExportToExcel()
        ' Set the LicenseContext to NonCommercial or Commercial
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        Dim dtReports As DataTable = DisplayReport()

        Using package As New ExcelPackage()
            Dim worksheet = package.Workbook.Worksheets.Add("Report")

            ' Add the title
            worksheet.Cells("A1").Value = "St. Mark Academy of Primarosa, Inc"
            worksheet.Cells("A1").Style.Font.Size = 16
            worksheet.Cells("A1").Style.Font.Bold = True

            ' Adjust column names for better readability
            Dim columnNames As New List(Of String) From {"ISBN", "BookTitle", "Authors", "Fullname", "DateBorrowed", "DateReturned", "Penalty"}

            ' Add the column headers
            For i As Integer = 0 To columnNames.Count - 1
                worksheet.Cells(3, i + 1).Value = FormatColumnName(columnNames(i))
                worksheet.Cells(3, i + 1).Style.Font.Bold = True
                worksheet.Cells(3, i + 1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
            Next

            ' Add the data rows
            For i As Integer = 0 To dtReports.Rows.Count - 1
                For j As Integer = 0 To dtReports.Columns.Count - 1
                    worksheet.Cells(i + 4, j + 1).Value = dtReports.Rows(i)(j).ToString()
                Next
            Next

            ' Auto fit columns for better readability
            worksheet.Cells.AutoFitColumns()

            ' Save the Excel file
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
                saveFileDialog.FileName = "Report.xlsx"
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim file As New FileInfo(saveFileDialog.FileName)
                    package.SaveAs(file)
                End If
            End Using
        End Using
    End Sub

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtReports As DataTable = DisplayReport()
        dgReports.DataSource = dtReports
    End Sub

    Private Function FormatColumnName(columnName As String) As String
        ' Replace underscores with spaces and capitalize the first letter of each word
        Return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(columnName.Replace("_", " ").ToLower())
    End Function
End Class
