Imports MySql.Data.MySqlClient

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

    Private Sub btnTimeout_Click(sender As Object, e As EventArgs) Handles btntimeOut.Click
        Dim studentID As String = txtStudentID.Text.Trim()
        If Not String.IsNullOrEmpty(studentID) Then
            TimeoutUpdate(studentID)
        Else
            MessageBox.Show("Please select a student first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TimeoutUpdate(studentID As String)
        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("UPDATE tblAttendance SET timeOut = NOW() WHERE studentID = @studentID AND timeOut IS NULL", connection)
                    command.Parameters.AddWithValue("@studentID", studentID)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Timeout recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Clear the textboxes
                        txtStudentID.Clear()
                        txtFirstname.Clear()
                        txtLastname.Clear()
                        ' Enable the btnSave button and disable the btnTimeout button
                        btnSave.Enabled = True
                        btntimeOut.Enabled = False
                        ' Refresh the DataGridView
                        Dim dtAttendance As DataTable = DisplayAttendance()
                        dgBorrowers.DataSource = dtAttendance
                    Else
                        MessageBox.Show("Student ID not found or already timed out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgBorrowers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBorrowers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgBorrowers.Rows(e.RowIndex)
            txtStudentID.Text = row.Cells("studentID").Value.ToString
            txtFirstname.Text = row.Cells("firstName").Value.ToString
            txtLastname.Text = row.Cells("lastName").Value.ToString

            Dim studentID As String = txtStudentID.Text.Trim()
            If Not String.IsNullOrEmpty(studentID) Then
                CheckStudentAttendance(studentID)
            End If
        End If
    End Sub

    Private Sub CheckStudentAttendance(studentID As String)
        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("SELECT * FROM tblAttendance WHERE studentID = @studentID AND timeOut IS NULL", connection)
                    command.Parameters.AddWithValue("@studentID", studentID)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' Student has timed in but not timed out
                            btnSave.Enabled = False
                            btntimeOut.Enabled = True
                        Else
                            ' Student has not timed in yet
                            btnSave.Enabled = True
                            btntimeOut.Enabled = False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class