Public Class frmBorrowerFinder

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchBorrowerForFinder(dgBorrowers, txtSearch.Text)
    End Sub


    Private Sub dgBorrowers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBorrowers.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgBorrowers.Rows(e.RowIndex)
            Dim borrowerID As Integer = Convert.ToInt32(row.Cells("borrowerID").Value.ToString)
            Dim studentID As String = row.Cells("studentID").Value.ToString
            Dim firstName As String = row.Cells("firstName").Value.ToString
            Dim lastName As String = row.Cells("lastName").Value.ToString

            Dim frmBorrowBooksInstance As frmBorrowBooks = DirectCast(Application.OpenForms("frmBorrowBooks"), frmBorrowBooks)
            If frmBorrowBooksInstance IsNot Nothing Then
                frmBorrowBooksInstance.SetSelectedBorrower(borrowerID, studentID, firstName, lastName)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub frmBorrowerFinder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtBorrower As DataTable = DisplayBorrowers()
        dgBorrowers.DataSource = dtBorrower
    End Sub
End Class