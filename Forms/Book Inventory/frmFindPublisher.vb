Public Class frmFindPublisher
    Private Sub dgPublisher_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPublisher.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgPublisher.Rows(e.RowIndex)
            Dim publisherName As String = row.Cells("publisherName").Value.ToString
            Dim publisherID As Integer = Convert.ToInt32(row.Cells("publisherID").Value)

            Dim frmAddBooksInstance As frmAddBooks = DirectCast(Application.OpenForms("frmAddBooks"), frmAddBooks)
            If frmAddBooksInstance IsNot Nothing Then
                frmAddBooksInstance.SetSelectedPublisher(publisherID, publisherName)
            End If

            Dim frmBookInfoInstance As frmBookInfo = DirectCast(Application.OpenForms("frmBookInfo"), frmBookInfo)
            If frmBookInfoInstance IsNot Nothing Then
                frmBookInfoInstance.SetSelectedBookPublisher(publisherID, publisherName)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub frmFindPublisher_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim publisherDt As DataTable = DisplayAlphabeticalData("tblPublishers", "publisherName")
        dgPublisher.DataSource = publisherDt
    End Sub

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchPublishers(dgPublisher, txtSearch.Text)
    End Sub
End Class