Public Class frmIssueReturn
    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        frmBorrowBooks.Show()
    End Sub

    Private Sub frmIssueReturn_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtBorrowed As DataTable = DisplayBorrowedBooks()
        dgBorrowed.DataSource = dtBorrowed
        Dim dtPullout As DataTable = DisplayPullout()
        dgPullout.DataSource = dtPullout
    End Sub

    Private Sub dgBorrowed_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBorrowed.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgBorrowed.Rows(e.RowIndex)
            Dim borrowID As Integer = Convert.ToInt32(row.Cells("borrowedID").Value)
            Dim studentID As String = row.Cells("studentID").Value.ToString
            Dim firstname As String = row.Cells("firstName").Value.ToString
            Dim lastname As String = row.Cells("lastName").Value.ToString
            Dim isbn As String = row.Cells("isbn").Value.ToString
            Dim author As String = row.Cells("authorName").Value.ToString
            Dim accessionNo As String = row.Cells("acn").Value.ToString
            Dim title As String = row.Cells("bookTitle").Value.ToString

            Dim frmReturnBooks As New frmReturnBooks()
            frmReturnBooks.SetSelectedBorrowedBooks(borrowID, studentID, firstname, lastname, isbn, author, accessionNo, title)
            frmReturnBooks.Show()
        End If
    End Sub
End Class