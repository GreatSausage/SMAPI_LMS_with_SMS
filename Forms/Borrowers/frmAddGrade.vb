Public Class frmAddGrade
    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtGradeLevel.Text) Then
            MessageBox.Show("Please fill in the necessary field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            AddGrade(txtGradeLevel.Text)
            Me.Close()
        End If
    End Sub
End Class