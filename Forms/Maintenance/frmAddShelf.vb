﻿Public Class frmAddShelf

    Dim getShelfID As Integer = Nothing

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtShelfNo.Text) OrElse
           String.IsNullOrEmpty(txtDescription.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddBookshelves(txtShelfNo.Text, txtDescription.Text)
            AuditTrail($"{frmMain.txtFullname.Text} has added new Bookshelf ({txtShelfNo.Text}).")
            Me.Close()
        End If
    End Sub

    Private Sub LetterOnly(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub NumberOnly(sender As Object, e As KeyPressEventArgs) Handles txtShelfNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AntiDoubleSpace(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress, txtShelfNo.KeyPress
        If e.KeyChar = " " AndAlso txtDescription.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtShelfNo.Text.EndsWith(" ") Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteShelf(getShelfID)
        getShelfID = Nothing
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtShelfNo.Text) OrElse
           String.IsNullOrEmpty(txtDescription.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            UpdateBookshelf(getShelfID, txtDescription.Text, txtShelfNo.Text)
            getShelfID = Nothing
            Me.Close()
        End If
    End Sub

    Public Sub SetSelectedShelfMaintenance(shelfID As Integer, description As String, shelfNo As Integer)
        getShelfID = shelfID
        txtShelfNo.Text = shelfNo
        txtDescription.Text = description
    End Sub
End Class