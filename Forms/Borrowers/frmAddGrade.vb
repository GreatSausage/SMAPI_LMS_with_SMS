Public Class frmAddGrade
    Dim getGradeID As Integer = Nothing
    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtGradeLevel.Text) Then
            MessageBox.Show("Please fill in the necessary field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtGradeLevel.Text > 12 Then
            MessageBox.Show("Invalid grade level")
        Else
            AddGrade(txtGradeLevel.Text)
            AuditTrail($"{frmMain.txtFullname.Text} added new Grade Level ({txtGradeLevel.Text}).")
            Me.Close()
        End If
    End Sub

    Public Sub SetSelectedGradeLevel(gradeLevel As Integer, gradeID As Integer)
        txtGradeLevel.Text = gradeLevel
        getGradeID = gradeID
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteGrade(getGradeID)
        getGradeID = Nothing
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtGradeLevel.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            UpdateGrade(txtGradeLevel.Text, getGradeID)
            getGradeID = Nothing
            Me.Close()
        End If
    End Sub
End Class