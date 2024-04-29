Public Class frmAddPublishers

    Dim getPublisherID As Integer = Nothing
    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtPublishers.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddPublishers(txtPublishers.Text)
            Me.Close()
        End If
    End Sub

    Private Sub LetterOnly(sender As Object, e As KeyPressEventArgs) Handles txtPublishers.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub AntiDoublespace(sender As Object, e As KeyPressEventArgs) Handles txtPublishers.KeyPress
        If e.KeyChar = " " AndAlso txtPublishers.Text.EndsWith(" ") Then
            e.Handled = True
        End If
    End Sub

    'Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    '    DeletePublisher(txtPublisherID.Text)
    '    Me.Close()
    'End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtPublishers.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            UpdatePublisher(getPublisherID, txtPublishers.Text)
            getPublisherID = Nothing
            Me.Close()
        End If
    End Sub

    Public Sub SetSelectedPublisherMaintenance(publisherID As Integer, publisherName As String)
        txtPublishers.Text = publisherName
        getPublisherID = publisherID
    End Sub
End Class