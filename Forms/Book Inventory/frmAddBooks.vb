Public Class frmAddBooks

    Public someVariables As String
    Dim getAuthorID As String = Nothing
    Dim getPublisherID As String = Nothing
    Dim getGenreID As String = Nothing
    Dim getShelfID As String = Nothing

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim yearPublished As Integer

        If Integer.TryParse(txtYearPublished.Text, yearPublished) Then

            If yearPublished > DateTime.Now.Year Then
                MessageBox.Show("Invalid Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf String.IsNullOrEmpty(txtISBN.Text) AndAlso Not cbISBN.Checked OrElse
                   String.IsNullOrEmpty(txtTitle.Text) OrElse
                   String.IsNullOrEmpty(txtYearPublished.Text) Then
                MessageBox.Show("Please fill in the necessary details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim bookID As Integer = AddBooks(txtISBN.Text, txtTitle.Text, getAuthorID, getPublisherID, txtYearPublished.Text, getShelfID)
                Dim initialCopies As Integer = Convert.ToInt32(txtInitialCopies.Value)

                If initialCopies > 0 Then
                    For i As Integer = 1 To initialCopies
                        Dim acn As String = AccessionGenerator()
                        AddInitialCopies(acn, bookID)
                    Next
                End If
                Me.Close()
            End If
        End If
    End Sub


    Private Sub frmAddBooks_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtAuthors As DataTable = DisplayAlphabeticalData("tblAuthors", "authorName")
        txtAuthor.DataSource = dtAuthors
        txtAuthor.DisplayMember = "authorName"
        txtAuthor.ValueMember = "authorID"

        Dim dtPublisher As DataTable = DisplayAlphabeticalData("tblPublishers", "publisherName")
        txtPublisher.DataSource = dtPublisher
        txtPublisher.DisplayMember = "publisherName"
        txtPublisher.ValueMember = "publisherID"

        Dim dtGenre As DataTable = DisplayAlphabeticalData("tblGenres", "genreName")
        txtGenre.DataSource = dtGenre
        txtGenre.DisplayMember = "genreName"
        txtGenre.ValueMember = "genreID"

        Dim dtShelf As DataTable = DisplayShelves()
        txtShelfNo.DataSource = dtShelf
        txtShelfNo.DisplayMember = "shelfNo"
        txtShelfNo.ValueMember = "shelfID"
    End Sub

    Private Sub btnFindAuthor_Click(sender As Object, e As EventArgs) Handles btnFindAuthor.Click
        frmFindAuthor.Show()
    End Sub

    Public Sub SetSelectedAuthor(authorID As Integer, authorName As String)
        txtAuthor.Text = authorName
        getAuthorID = authorID
    End Sub

    Private Sub btnFindPublisher_Click(sender As Object, e As EventArgs) Handles btnFindPublisher.Click
        frmFindPublisher.Show()
    End Sub

    Public Sub SetSelectedPublisher(publisherID As Integer, publisherName As String)
        getPublisherID = publisherID
        txtPublisher.Text = publisherName
    End Sub

    Private Sub txtAuthor_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtAuthor.SelectedValueChanged
        getAuthorID = txtAuthor.SelectedValue.ToString
    End Sub

    Private Sub txtPublisher_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtPublisher.SelectedValueChanged
        getPublisherID = txtPublisher.SelectedValue.ToString
    End Sub

    Private Sub txtGenre_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtGenre.SelectedValueChanged
        getGenreID = txtGenre.SelectedValue.ToString
    End Sub

    Private Sub txtShelfNo_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtShelfNo.SelectedValueChanged
        getShelfID = txtShelfNo.SelectedValue.ToString
    End Sub

    Private Sub DigitOnly(sender As Object, e As KeyPressEventArgs) Handles txtISBN.KeyPress, txtYearPublished.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

End Class