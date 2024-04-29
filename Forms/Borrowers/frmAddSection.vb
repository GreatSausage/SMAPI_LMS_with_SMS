Public Class frmAddSection

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sectionID As Integer = Convert.ToInt32(txtGrade.Text)
        If String.IsNullOrEmpty(txtSection.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddSection(txtSection.Text, sectionID)
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
End Class