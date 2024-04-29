Public Class frmAttendanceMonitoring
    Private Sub frmAttendanceMonitoring_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y - (y - Screen.PrimaryScreen.WorkingArea.Height)
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub frmAttendanceMonitoring_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtGrade As DataTable = DisplayGrade()
        txtGrade.DataSource = dtGrade
        txtGrade.DisplayMember = "grade"
        txtGrade.ValueMember = "gradeID"

        Dim dtSection As DataTable = DisplaySection()
        txtSection.DataSource = dtSection
        txtSection.DisplayMember = "section"
        txtSection.ValueMember = "sectionID"

        Dim dtAttendace As DataTable = DisplayAttendance()
        dgBorrowers.DataSource = dtAttendace
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AttendanceMonitoring(txtStudentID.Text, txtFirstname.Text, txtLastname.Text, txtGrade.SelectedValue, txtSection.SelectedValue)
        BorrowerDatatable()
    End Sub

End Class