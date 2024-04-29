Public Class frmAddFaculty
    'Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
    '    Me.Close()
    'End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    If String.IsNullOrEmpty(txtFirstname.Text) OrElse
    '       String.IsNullOrEmpty(txtLastname.Text) OrElse
    '       String.IsNullOrEmpty(txtContact.Text) Then
    '        MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Else
    '        AddFaculty(txtFirstname.Text, txtLastname.Text, txtContact.Text)
    '        Me.Close()
    '    End If
    'End Sub

    'Private Sub AntiDoubleSpace(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress, txtFirstname.KeyPress, txtLastname.KeyPress
    '    If e.KeyChar = " " AndAlso txtContact.Text.EndsWith(" ") Then
    '        e.Handled = True
    '    ElseIf e.KeyChar = " " AndAlso txtFirstname.text.EndsWith(" ") Then
    '        e.Handled = True
    '    ElseIf e.KeyChar = " " AndAlso txtLastname.Text.EndsWith(" ") Then
    '        e.Handled = True
    '    End If
    'End Sub
End Class