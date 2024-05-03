Public Class frmAddSection

    Dim getSectionID As Integer = Nothing
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sectionID As Integer = Convert.ToInt32(txtGrade.Text)
        If String.IsNullOrEmpty(txtSection.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddSection(txtSection.Text, sectionID)
            AuditTrail($"{frmMain.txtFullname.Text} has added new section {txtSection.Text}")
            Me.Close()
        End If
    End Sub

    Private Sub frmAddSection_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dt As DataTable = DisplayGrade()
        txtGrade.DataSource = dt
        txtGrade.ValueMember = "gradeID"
        txtGrade.DisplayMember = "grade"
        SectionDatatable()
    End Sub

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteSection(GetSectionID)
        getSectionID = Nothing
        Me.Close()
    End Sub

    Public Sub SetSelectedSection(gradeID As Integer, section As String, sectionID As Integer)
        getSectionID = sectionID
        txtGrade.SelectedValue = gradeID
        txtSection.Text = section
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim gradeID As Integer = Convert.ToInt32(txtGrade.SelectedValue)
        UpdateSection(getSectionID, txtSection.Text, gradeID)
        getSectionID = Nothing
        Me.Close()
    End Sub
End Class