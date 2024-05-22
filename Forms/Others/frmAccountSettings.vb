Public Class frmAccountSettings

    Public id As Integer = Nothing
    Private Sub cbISBN_CheckedChanged(sender As Object, e As EventArgs) Handles cbISBN.CheckedChanged
        If cbISBN.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "✿"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtFirstname.Text) OrElse
       String.IsNullOrEmpty(txtLastname.Text) OrElse
       String.IsNullOrEmpty(txtPhoneNumber.Text) OrElse
       String.IsNullOrEmpty(txtPassword.Text) OrElse
       String.IsNullOrEmpty(txtConfirmpassword.Text) OrElse
       String.IsNullOrEmpty(txtQuestion.Text) OrElse
       String.IsNullOrEmpty(txtAnswer.Text) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtPassword.Text <> txtConfirmpassword.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Proceed with the update if all validations pass
        Dim studentID As String = txtStudentID.Text
        Dim firstName As String = txtFirstname.Text
        Dim lastName As String = txtLastname.Text
        Dim phoneNumber As String = txtPhoneNumber.Text
        Dim password As String = txtPassword.Text
        Dim securityQuestion As String = txtQuestion.Text
        Dim securityAnswer As String = txtAnswer.Text
        UpdateAccount(studentID, firstName, lastName, phoneNumber, password, securityQuestion, securityAnswer, id)
        txtConfirmpassword.Clear()
    End Sub

End Class