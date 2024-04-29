Public Class frmAddAuthors

    Dim getAuthorID As Integer = Nothing

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtAuthors.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddAuthors(txtAuthors.Text)
            Me.Close()
        End If
    End Sub


    Private Sub LetterOnly(sender As Object, e As KeyPressEventArgs) Handles txtAuthors.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub AntiDoubleSpace(sender As Object, e As KeyPressEventArgs) Handles txtAuthors.KeyPress
        If e.KeyChar = " " AndAlso txtAuthors.Text.EndsWith(" ") Then
            e.Handled = True
        End If
    End Sub

    Public Sub SetSelectedAuthorMaintenance(authorID As Integer, authorName As String)
        txtAuthors.Text = authorName
        getAuthorID = authorID
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtAuthors.Text) Then
            MessageBox.Show("Please fill in the necessary field.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            UpdateAuthors(getAuthorID, txtAuthors.Text)
            getAuthorID = Nothing
            Me.Close()
        End If
    End Sub

    'Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    '    DeleteAuthors(txtAuthorID.Text)
    '    Me.Close()
    'End Sub
End Class