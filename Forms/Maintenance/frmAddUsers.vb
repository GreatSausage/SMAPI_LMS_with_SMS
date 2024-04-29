
Public Class frmAddUsers

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim roleID As Integer = txtRole.SelectedValue
        Dim roleName As String = txtRole.Text
        If String.IsNullOrEmpty(txtFirstname.Text) OrElse
           String.IsNullOrEmpty(txtLastname.Text) OrElse
           String.IsNullOrEmpty(txtPhoneNumber.Text) OrElse
           String.IsNullOrEmpty(txtUsername.Text) OrElse
           String.IsNullOrEmpty(txtPassword.Text) OrElse
           String.IsNullOrEmpty(txtConfirmPassword.Text) OrElse
           String.IsNullOrEmpty(txtAnswer.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddUser(txtFirstname.Text, txtLastname.Text, txtPhoneNumber.Text, txtUsername.Text, txtPassword.Text, txtAnswer.Text, txtQuestions.Text, roleID, roleName)
        End If
    End Sub

    Private Sub frmAddUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtRoles As DataTable = DisplayRoles()
        txtRole.DataSource = dtRoles
        txtRole.DisplayMember = "roleName"
        txtRole.ValueMember = "roleID"

        txtQuestions.SelectedIndex = 0
    End Sub

    Private Sub AntiDoubleSpace(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress, txtLastname.KeyPress, txtPhoneNumber.KeyPress, txtUsername.KeyPress, txtPassword.KeyPress, txtAnswer.KeyPress
        If e.KeyChar = " " AndAlso txtFirstname.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtLastname.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtPhoneNumber.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtUsername.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtPassword.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtConfirmPassword.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtAnswer.Text.EndsWith(" ") Then
            e.Handled = True
        End If
    End Sub

    Private Sub LetterOnly(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress, txtLastname.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub DigitOnly(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class