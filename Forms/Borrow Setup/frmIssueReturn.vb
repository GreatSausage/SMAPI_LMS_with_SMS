﻿Public Class frmIssueReturn
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
            Dim acquisitionType As String = row.Cells("acquisitionType").Value.ToString
            Dim accessionNo As String = row.Cells("acn").Value.ToString
            Dim isbn As String = row.Cells("isbn").Value.ToString
            Dim firstname As String = row.Cells("firstName").Value.ToString
            Dim lastname As String = row.Cells("lastName").Value.ToString
            Dim studentID As Integer = Convert.ToInt32(row.Cells("studentID").Value.ToString)
            Dim title As String = row.Cells("bookTitle").Value.ToString
            Dim author As String = row.Cells("authorName").Value.ToString

            Dim frmReturnBooks As New frmReturnBooks()
            frmReturnBooks.SetSelectedBorrowedBooks(borrowID, studentID, firstname, lastname, isbn, author, accessionNo, title, acquisitionType)
            frmReturnBooks.Show()
        End If
    End Sub

    Private Sub dgPullout_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPullout.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgPullout.Rows(e.RowIndex)
            Dim borrowID As Integer = Convert.ToInt32(row.Cells("borrowID").Value)
            Dim title As String = row.Cells("title").Value.ToString
            Dim fullname As String = row.Cells("pullOutFullname").Value.ToString
            Dim status As String = row.Cells("status").Value.ToString
            Dim penalty As Decimal = row.Cells("penalty").Value.ToString
            Dim returnstatus As String = row.Cells("returnStatus").Value.ToString

            Dim frmPulloutInstance As New frmPullout()
            frmPulloutInstance.SetSelectedPullout(borrowID, title, fullname, status, penalty)
            frmPulloutInstance.Show()
        End If
    End Sub
End Class