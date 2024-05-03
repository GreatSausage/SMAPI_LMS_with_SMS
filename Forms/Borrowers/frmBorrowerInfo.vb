Public Class frmBorrowerInfo
    Dim getBorrowerID As Integer = Nothing

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim gradeID As Integer = Convert.ToInt32(txtSelectedGrade.SelectedValue())
        Dim sectionID As Integer = Convert.ToInt32(txtSelectedSection.SelectedValue())
        If String.IsNullOrEmpty(txtStudentID.Text) OrElse
            String.IsNullOrEmpty(txtFirstname.Text) OrElse
            String.IsNullOrEmpty(txtLastname.Text) OrElse
            String.IsNullOrEmpty(txtGuardianContact.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            UpdateBorrowwer(getBorrowerID, txtStudentID.Text, txtFirstname.Text, txtLastname.Text, gradeID, sectionID, txtGuardianContact.Text)
            getBorrowerID = Nothing
            Me.Close()
        End If
    End Sub

    Private Sub frmBorrowerInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtGrade As DataTable = DisplayGrade()
        txtSelectedGrade.DataSource = dtGrade
        txtSelectedGrade.DisplayMember = "grade"
        txtSelectedGrade.ValueMember = "gradeID"
        txtSelectedGrade.SelectedIndex = 0
    End Sub

    Public Sub SetSelectedBorrower(borrowerID As Integer, studentID As String, firstname As String, lastname As String, gradelevel As Integer, section As String, number As String)
        getBorrowerID = borrowerID
        txtStudentID.Text = studentID
        txtFirstname.Text = firstname
        txtLastname.Text = lastname
        txtSelectedGrade.Text = gradelevel
        txtSelectedSection.Text = section
        txtGuardianContact.Text = number
    End Sub

    Private Sub txtSelectedGrade_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtSelectedGrade.SelectedValueChanged
        If TypeOf txtSelectedGrade.SelectedItem Is DataRowView Then
            Dim grade As Integer = Convert.ToInt32(DirectCast(txtSelectedGrade.SelectedItem, DataRowView).Row("gradeID"))
            Dim dtSection As DataTable = DisplaySectionDependencies(grade)
            txtSelectedSection.DataSource = dtSection
            txtSelectedSection.DisplayMember = "section"
            txtSelectedSection.ValueMember = "sectionID"
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteBorrower(getBorrowerID)
        getBorrowerID = Nothing
        Me.Close()
    End Sub

End Class