﻿Public Class frmBookInfo

    Dim getBookID As Integer = Nothing
    Dim getShelfID As Integer = Nothing
    Dim getAuthorID As Integer = Nothing
    Dim getPublisherID As Integer = Nothing
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub frmBookInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtShelves As DataTable = DisplayShelves()
        txtShelfNo.DataSource = dtShelves
        txtShelfNo.DisplayMember = "shelfNo"
        txtShelfNo.ValueMember = "shelfID"
        getShelfID = txtShelfNo.SelectedValue

        Dim authorID As Integer = GetAuthorIDFunction(txtAuthor.Text)
        getAuthorID = authorID

        Dim publisherID As Integer = GetPublisherIDFunction(txtPublisher.Text)
        getPublisherID = publisherID
    End Sub

    Public Sub SetSelectedBooks(bookID As Integer, isbn As String, title As String, author As String, publisher As String, yearPublished As String, shelfNo As Integer, shelfID As Integer, genres As String)
        getBookID = bookID
        txtISBN.Text = isbn
        txtTitle.Text = title
        txtAuthor.Text = author
        txtPublisher.Text = publisher
        txtYearPublished.Text = yearPublished
        txtShelfNo.Text = shelfNo
        getShelfID = shelfID
        txtGenre.Text = genres
    End Sub

    Private Sub btnFindAuthor_Click(sender As Object, e As EventArgs) Handles btnFindAuthor.Click
        frmFindAuthor.Show()
    End Sub

    Public Sub SetSelectedBookAuthor(authorID As Integer, authorName As String)
        txtAuthor.Text = authorName
        getAuthorID = authorID
    End Sub

    Private Sub btnFindPublisher_Click(sender As Object, e As EventArgs) Handles btnFindPublisher.Click
        frmFindPublisher.Show()
    End Sub

    Public Sub SetSelectedBookPublisher(publisherID As Integer, publisherName As String)
        getPublisherID = publisherID
        txtPublisher.Text = publisherName
    End Sub


    Private Sub btnFindGenres_Click(sender As Object, e As EventArgs)
        frmFindGenres.Show()
    End Sub

    Private Sub txtAuthor_TextChanged(sender As Object, e As EventArgs) Handles txtAuthor.TextChanged
        Dim authorID As Integer = GetAuthorIDFunction(txtAuthor.Text)
        getAuthorID = authorID
    End Sub

    Private Sub txtPublisher_TextChanged(sender As Object, e As EventArgs) Handles txtPublisher.TextChanged, txtGenre.TextChanged
        Dim publisherID As Integer = GetPublisherIDFunction(txtPublisher.Text)
        getPublisherID = publisherID
    End Sub

    Private Sub txtShelfNo_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtShelfNo.SelectedValueChanged
        If TypeOf txtShelfNo.SelectedItem Is DataRowView Then
            Dim drv As DataRowView = DirectCast(txtShelfNo.SelectedItem, DataRowView)
            getShelfID = Convert.ToInt32(drv.Row("ShelfID"))
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UpdateBook(getAuthorID, getBookID, txtTitle.Text, txtISBN.Text, getPublisherID, getShelfID, txtYearPublished.Text, txtGenre.Text)
        AuditTrail($"{frmMain.txtFullname.Text} updated {txtTitle.Text} information.")
        Me.Close()
    End Sub
End Class