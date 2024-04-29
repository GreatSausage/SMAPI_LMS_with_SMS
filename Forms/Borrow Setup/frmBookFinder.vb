Public Class frmBookFinder
    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub frmBookFinder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtBooks As DataTable = DisplayBooks()
        dgBooksMainte.DataSource = dtBooks
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchBookForFinder(dgBooksMainte, txtSearch.Text)
    End Sub

    Private Sub dgBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBooksMainte.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgBooksMainte.Rows(e.RowIndex)
            Dim isbn As String = row.Cells("distinctISBN").Value.ToString
            Dim title As String = row.Cells("distinctTitle").Value.ToString
            Dim authorName As String = row.Cells("distinctAuthor").Value.ToString

            Dim frmBorrowBooksInstance As frmBorrowBooks = DirectCast(Application.OpenForms("frmBorrowBooks"), frmBorrowBooks)
            If frmBorrowBooksInstance IsNot Nothing Then
                frmBorrowBooksInstance.SetSelectedBooks(isbn, title, authorName)
            End If
            Me.Close()
        End If
    End Sub
End Class