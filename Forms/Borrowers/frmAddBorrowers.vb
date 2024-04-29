Imports MySql.Data.MySqlClient

Public Class frmAddBorrowers

    Private Sub frmAddBorrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbStudent.Checked = True
    End Sub

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT a.studentID, a.firstName, a.lastName, g.grade, s.section 
                                           FROM tblAttendance a 
                                           INNER JOIN tblGrade g ON a.gradeID = g.gradeID 
                                           INNER JOIN tblSection s ON a.sectionID = s.sectionID 
                                           WHERE a.studentID = @studentID", connection)
                command.Parameters.AddWithValue("@studentID", txtStudentID.Text)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        txtStudentID.Text = reader("studentID").ToString()
                        txtFirstname.Text = reader("firstName").ToString()
                        txtLastname.Text = reader("lastName").ToString()
                        txtSelectedGrade.Text = reader("grade").ToString()
                        txtSelectedSection.Text = reader("section").ToString()

                        txtFirstname.ReadOnly = True
                        txtLastname.ReadOnly = True
                        txtSelectedGrade.ReadOnly = True
                        txtSelectedSection.ReadOnly = True
                    Else
                        txtFirstname.Text = ""
                        txtLastname.Text = ""
                        txtSelectedGrade.Text = ""
                        txtSelectedSection.Text = ""
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub rbFaculty_CheckedChanged(sender As Object, e As EventArgs) Handles rbFaculty.CheckedChanged
        If rbFaculty.Checked Then
            labelContact.Text = "Phone Number:"
            txtSelectedGrade.Enabled = False
            txtSelectedSection.Enabled = False
        End If
    End Sub

    Private Sub rbStudent_CheckChanged(sender As Object, e As EventArgs) Handles rbStudent.CheckedChanged
        If rbStudent.Checked Then
            labelContact.Text = "Guardian Contact:"
            txtSelectedGrade.Enabled = True
            txtSelectedSection.Enabled = True
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim type As String = If(rbFaculty.Checked, "Faculty", "Student")
        Dim gradeID As Integer = If(rbFaculty.Checked, 0, GetGradeID(txtSelectedGrade.Text))
        Dim sectionID As Integer = If(rbFaculty.Checked, 0, GetSectionID(txtSelectedSection.Text))

        If (rbFaculty.Checked AndAlso
           (String.IsNullOrEmpty(txtFirstname.Text) OrElse
            String.IsNullOrEmpty(txtLastname.Text) OrElse
            String.IsNullOrEmpty(txtStudentID.Text) OrElse
            String.IsNullOrEmpty(txtGuardianContact.Text))) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddBorrowers(txtStudentID.Text, txtFirstname.Text, txtLastname.Text, gradeID, sectionID, txtGuardianContact.Text, type)
            Me.Close()
        End If
    End Sub




    'Private Sub AntiDoubleSpace(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress, txtGuardianContact.KeyPress, txtLastname.KeyPress, txtStudentID.KeyPress
    '    If e.KeyChar = " " AndAlso txtFirstname.Text.EndsWith(" ") Then
    '        e.Handled = True
    '    ElseIf e.KeyChar = " " AndAlso txtGuardianContact.Text.EndsWith(" ") Then
    '        e.Handled = True
    '    ElseIf e.KeyChar = " " AndAlso txtLastname.Text.EndsWith(" ") Then
    '        e.Handled = True
    '    ElseIf e.KeyChar = " " AndAlso txtStudentID.Text.EndsWith(" ") Then
    '        e.Handled = True
    '    End If
    'End Sub
End Class