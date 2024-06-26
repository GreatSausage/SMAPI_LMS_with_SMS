﻿Imports System.Collections.Specialized.BitVector32
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Globalization

Module mdlBorrower


#Region "Borrower"

    Public Function DisplayBorrowers() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT b.borrowerID, b.studentID, b.firstName, b.lastName, g.grade, s.section, b.guardianContact, b.borrowerType
                                             FROM tblBorrowers b
                                             LEFT JOIN tblGrade g ON b.gradeID = g.gradeID
                                             LEFT JOIN tblSection s ON b.sectionID = s.sectionID", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim datatable As New DataTable
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        End Using
    End Function

    Public Sub BorrowerDatatable()
        Dim dtBorrowers As DataTable = DisplayBorrowers()
        frmMainte.dgBorrowers.DataSource = dtBorrowers
    End Sub

    Public Function DisplayAttendance() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT a.borrowerID, a.studentID, a.firstName, a.lastName, g.grade, s.section, a.timeIn, a.timeOut 
                                               FROM tblAttendance a 
                                               INNER JOIN tblGrade g ON a.gradeID = g.gradeID 
                                               INNER JOIN tblSection s ON a.sectionID = s.sectionID", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Sub AttendanceMonitoring(studentID As String, firstName As String, lastName As String, gradeID As Integer, sectionID As Integer)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedFirstname As String = textInfo.ToTitleCase(firstName.ToLower())
        Dim capitalizedLastname As String = textInfo.ToTitleCase(lastName.ToLower())

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblAttendance (studentID, firstName, lastName, gradeID, sectionID, timeIn) 
                                               VALUES (@studentID, @firstName, @lastName, @gradeID, @sectionID, NOW())", connection)
                    With command.Parameters
                        .AddWithValue("@studentID", studentID)
                        .AddWithValue("@firstName", capitalizedFirstname)
                        .AddWithValue("@lastName", capitalizedLastname)
                        .AddWithValue("@gradeID", gradeID)
                        .AddWithValue("@sectionID", sectionID)
                    End With
                    command.ExecuteNonQuery()
                    MessageBox.Show("Attendance recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim dtAttendance As DataTable = DisplayAttendance()
                    frmAttendanceMonitoring.dgBorrowers.DataSource = dtAttendance
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Some fields already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Public Function GetSectionID(section As String) As Integer
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT sectionID FROM tblSection WHERE section = @section", connection)
                command.Parameters.AddWithValue("@section", section)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function GetGradeID(grade As Integer) As Integer
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT gradeID FROM tblGrade WHERE grade = @grade", connection)
                command.Parameters.AddWithValue("@grade", grade)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Sub AddBorrowers(studentID As String, firstName As String, lastName As String, gradeID As Integer, sectionID As Integer, guardianContact As String, type As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedFirstName As String = textInfo.ToTitleCase(firstName.ToLower())
        Dim capitalizedLastName As String = textInfo.ToTitleCase(lastName.ToLower())
        Dim limit As Integer = 3
        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblBorrowers (studentID, firstName, lastName, gradeID, sectionID, guardianContact, borrowerType, borrowLimit) 
                                               VALUES (@studentID, @firstName, @lastName, @gradeID, @sectionID, @guardianContact, @borrowerType, @limit)", connection)
                    With command.Parameters
                        .AddWithValue("@studentID", studentID)
                        .AddWithValue("@firstName", capitalizedFirstName)
                        .AddWithValue("@lastName", capitalizedLastName)
                        .AddWithValue("@gradeID", gradeID)
                        .AddWithValue("@sectionID", sectionID)
                        .AddWithValue("@guardianContact", guardianContact)
                        .AddWithValue("@borrowerType", type)
                        .AddWithValue("@limit", limit)
                    End With
                    command.ExecuteNonQuery()
                    MessageBox.Show("Borrower added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BorrowerDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Student ID already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Public Sub UpdateBorrowwer(borrower As Integer, studentId As String, firstname As String, lastname As String, grade As Integer, section As Integer, number As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedFirstname As String = textInfo.ToTitleCase(firstname.ToLower)
        Dim capitalizedLastname As String = textInfo.ToTitleCase(lastname.ToLower)

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("UPDATE tblborrowers SET firstname = @firstname, lastname = @lastname, gradeID = @grade, sectionID = @section, guardianContact = @number", connection)
                    command.Parameters.AddWithValue("@firstname", firstname)
                    command.Parameters.AddWithValue("@lastname", lastname)
                    command.Parameters.AddWithValue("@grade", grade)
                    command.Parameters.AddWithValue("@section", section)
                    command.Parameters.AddWithValue("@number", number)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Borrower updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BorrowerDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Student ID already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Try
    End Sub

    Public Sub DeleteBorrower(borrowerID As Integer)
        Using connection As MySqlConnection = ConnectionOpen()

            Using checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblBorrowedBooks WHERE borrowerID = @borrowerID", connection)
                checkCommand.Parameters.AddWithValue("@borrowerID", borrowerID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Borrower cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using command As New MySqlCommand("DELETE FROM tblborrowers WHERE borrowerID = @borrowerID", connection)
                        command.Parameters.AddWithValue("@authorID", borrowerID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Borrower has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        BorrowerDatatable()
                    End Using
                End If
            End Using
        End Using
    End Sub


    Public Sub SearchBorrowers(datagridview As DataGridView, search As String)
        Using connection As MySqlConnection = ConnectionOpen()
            Dim query As String = "SELECT borrowerID, studentID, firstName, lastName FROM tblBorrowers "

            If Not String.IsNullOrEmpty(search) Then
                query += " WHERE borrowerID LIKE @search OR studentID LIKE @search OR firstName LIKE @search OR lastName LIKE @search"
            End If

            Using command As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(search) Then
                    command.Parameters.AddWithValue("@search", "%" & search & "%")
                End If

                Using adapter As New MySqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(ds)
                    datagridview.DataSource = ds.Tables(0)
                End Using
            End Using
        End Using
    End Sub

#End Region

#Region "Grade"
    Public Function DisplayGrade() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT * FROM tblGrade 
                                               ORDER BY grade", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim datatable As New DataTable
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        End Using
    End Function

    Public Sub GradeDatatable()
        Dim dtGrade As DataTable = DisplayGrade()
        frmMainte.dgGrade.DataSource = dtGrade
    End Sub

    Public Sub AddGrade(grade As Integer)
        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblGrade (grade) VALUES (@grade)", connection)
                    command.Parameters.AddWithValue("@grade", grade)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Grade added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GradeDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Grade level already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Public Sub UpdateGrade(gradeLevel As Integer, gradeID As Integer)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("UPDATE tblgrade SET grade = @grade  
                                                   WHERE gradeID = @gradeID", connection)
                    command.Parameters.AddWithValue("@gradeID", gradeID)
                    command.Parameters.AddWithValue("@grade", gradeLevel)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Grade level updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GradeDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Grade level already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Public Sub DeleteGrade(getID As Integer)
        Using connection As MySqlConnection = ConnectionOpen()

            Using checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblattendance WHERE gradeID = @gradeID", connection)
                checkCommand.Parameters.AddWithValue("@gradeID", getID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Grade cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using command As New MySqlCommand("DELETE FROM tblgrade WHERE gradeID = @gradeID", connection)
                        command.Parameters.AddWithValue("@gradeID", getID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Grade has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        GradeDatatable()
                    End Using
                End If
            End Using
        End Using
    End Sub
#End Region

#Region "Section"
    Public Function DisplaySection() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT s.sectionID, s.section, g.grade 
                                               FROM tblSection s 
                                               JOIN tblGrade g ON s.gradeID = g.gradeID
                                               ORDER BY g.grade", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim datatable As New DataTable
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        End Using
    End Function

    Public Function DisplaySectionDependencies(gradeID As Integer) As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT s.sectionID, s.section 
                                           FROM tblSection s 
                                           WHERE s.gradeID = @gradeID 
                                           ORDER BY s.section", connection)
                command.Parameters.AddWithValue("@gradeID", gradeID)
                Using adp As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adp.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function


    Public Sub SectionDatatable()
        Dim sectionDt As DataTable = DisplaySection()
        frmMainte.dgSection.DataSource = sectionDt
    End Sub

    Public Sub AddSection(section As String, gradeID As Integer)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedSection As String = textInfo.ToTitleCase(section.ToLower())

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblSection (section, gradeID) VALUES (@section, @gradeID)", connection)
                    command.Parameters.AddWithValue("@section", capitalizedSection)
                    command.Parameters.AddWithValue("@gradeID", gradeID)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Section added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SectionDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Section already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Public Sub UpdateSection(sectionID As Integer, section As String, gradeID As Integer)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("UPDATE tblsection SET section = @section, gradeID = @gradeID   
                                                   WHERE sectionID = @sectionID", connection)
                    command.Parameters.AddWithValue("@section", section)
                    command.Parameters.AddWithValue("@gradeID", gradeID)
                    command.Parameters.AddWithValue("@sectionID", sectionID)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Section updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SectionDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Section already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Public Sub DeleteSection(sectionID As Integer)
        Using connection As MySqlConnection = ConnectionOpen()

            Using checkCommand As New MySqlCommand("SELECT gradeID FROM tblattendance WHERE sectionID = @sectionID", connection)
                checkCommand.Parameters.AddWithValue("@sectionID", sectionID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Section cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using command As New MySqlCommand("DELETE FROM tblsection WHERE sectionID = @sectionID", connection)
                        command.Parameters.AddWithValue("@sectionID", sectionID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Section has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        SectionDatatable()
                    End Using
                End If
            End Using
        End Using
    End Sub

#End Region

End Module
