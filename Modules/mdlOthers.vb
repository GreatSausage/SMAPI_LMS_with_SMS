﻿Imports System.Data.SqlClient
Imports System.IO.Ports
Imports MySql.Data.MySqlClient

Module mdlOthers

    Public serverconn As New MySqlConnection(My.Settings.connString)

    Public Function ConnectionOpen() As MySqlConnection
        serverconn = New MySqlConnection(My.Settings.connString)
        serverconn.Open()
        Return serverconn
    End Function

    Public Sub DisplayFormPanel(frm As Form, displayPanel As Panel)
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        displayPanel.Controls.Clear()
        displayPanel.Controls.Add(frm)
        frm.Show()
    End Sub

    Public Sub SMSNotif(phoneNumber As String, message As String)
        Dim smsport = New SerialPort
        Try
            With smsport
                .PortName = "COM6"
                .BaudRate = 9600
                .DataBits = 8
                .StopBits = StopBits.One
                .Handshake = Handshake.None
                .DtrEnable = True
                .RtsEnable = True
                .NewLine = vbCrLf

                smsport.Open()
                smsport.WriteLine("AT" & Chr(13))
                Threading.Thread.Sleep(6000)
                smsport.WriteLine("AT+CMGF=1" & Chr(13))
                Threading.Thread.Sleep(6000)
                smsport.WriteLine("AT+CMGS=" & Chr(34) & phoneNumber & Chr(34))
                Threading.Thread.Sleep(6000)
                smsport.WriteLine(message & Chr(26))
                Threading.Thread.Sleep(6000)
            End With

        Catch ex As Exception
        Finally
            If smsport IsNot Nothing AndAlso smsport.IsOpen Then
                smsport.Close()
            End If
        End Try

    End Sub

#Region "Sign In"
    Public Sub Login(userName As String, password As String)
        Using connection As MySqlConnection = ConnectionOpen()
            Using userCommand As New MySqlCommand("SELECT COUNT(*) FROM tblusers WHERE userName = @userName", connection)
                userCommand.Parameters.AddWithValue("@userName", userName)

                If Convert.ToInt32(userCommand.ExecuteScalar()) > 0 Then
                    Using passCommand As New MySqlCommand("SELECT Password FROM tblusers WHERE userName = @userName", connection)
                        passCommand.Parameters.AddWithValue("@userName", userName)
                        Dim dbPassword As String = Convert.ToString(passCommand.ExecuteScalar())

                        If dbPassword IsNot Nothing AndAlso dbPassword.Equals(password) Then
                            Using getUserCommand As New MySqlCommand("SELECT * FROM tblUsers WHERE userName = @userName", connection)
                                getUserCommand.Parameters.AddWithValue("@userName", userName)
                                Using reader As MySqlDataReader = getUserCommand.ExecuteReader()
                                    If reader.Read() Then
                                        frmAccountSettings.txtFirstname.Text = reader("firstName").ToString()
                                        frmAccountSettings.txtLastname.Text = reader("lastName").ToString()
                                        frmAccountSettings.txtPhoneNumber.Text = reader("phoneNumber").ToString()
                                        frmAccountSettings.txtQuestion.Text = reader("securityQuestion").ToString()
                                        frmAccountSettings.txtAnswer.Text = reader("securityAnswer").ToString()
                                        frmAccountSettings.txtPassword.Text = reader("password").ToString
                                        frmAccountSettings.txtStudentID.Text = reader("ID").ToString
                                        frmAccountSettings.id = reader("userID")
                                        frmAccountSettings.txtRole.Text = GetRoleName(userName)
                                        frmAccountSettings.txtUsername.Text = userName
                                    End If
                                End Using
                            End Using

                            Dim getUserName As String = Convert.ToString(userName)

                            If getUserName IsNot Nothing AndAlso getUserName.Equals("browsing") Then
                                MessageBox.Show("Logged in successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                frmBrowsing.Show()
                                Form1.Close()
                            ElseIf getUserName IsNot Nothing AndAlso getUserName.Equals("attendance") Then
                                MessageBox.Show("Logged in successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                frmAttendanceMonitoring.Show()
                                Form1.Close()
                            Else
                                frmMain.Show()
                                Form1.Close()
                            End If
                        Else
                            MessageBox.Show("Incorrect Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Else
                    MessageBox.Show("Email not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Public Sub UpdateAccount(studentID As String, firstName As String, lastName As String, phoneNumber As String, password As String, securityQuestion As String, securityAnswer As String, userID As Integer)
        Using connection As MySqlConnection = ConnectionOpen()
            Using updateCommand As New MySqlCommand("UPDATE tblUsers SET ID = @id, firstName = @firstName, lastName = @lastName, phoneNumber = @phoneNumber, password = @password, securityQuestion = @securityQuestion, securityAnswer = @securityAnswer WHERE userID = @userID", connection)
                updateCommand.Parameters.AddWithValue("@firstName", firstName)
                updateCommand.Parameters.AddWithValue("@lastName", lastName)
                updateCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                updateCommand.Parameters.AddWithValue("@password", password)
                updateCommand.Parameters.AddWithValue("@securityQuestion", securityQuestion)
                updateCommand.Parameters.AddWithValue("@securityAnswer", securityAnswer)
                updateCommand.Parameters.AddWithValue("@id", studentID)
                updateCommand.Parameters.AddWithValue("@userID", userID)

                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to update account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub



#End Region

#Region "DisplayReports"
    Public Function DisplayReport() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT b.isbn, b.bookTitle,
                                                      a.authorName,
                                                      CONCAT(br.firstName, ' ', br.lastName) AS fullName,
                                                      bb.dateBorrowed,
                                                      bb.dateReturned,
                                                      p.penalty
                                               FROM tblBorrowedBooks bb
                                               JOIN tblCopies c ON bb.copyID = c.copyID
                                               JOIN tblBooks b ON c.bookID = b.bookID
                                               JOIN tblAuthors a ON b.authorID = a.authorID
                                               JOIN tblBorrowers br ON bb.borrowerID = br.borrowerID
                                               LEFT JOIN tblPullout p ON bb.borrowID = p.borrowID", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Audit Trail"
    Public Function GetFullName(username As String) As String
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT CONCAT(firstName, ' ', lastName) AS Fullname FROM tblUsers WHERE userName = @userName", connection)
                command.Parameters.AddWithValue("@userName", username)
                Return Convert.ToString(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function GetRoleName(userName As String) As String
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT r.roleName FROM tblRoles r
                                               JOIN tblUsers u ON r.roleID = u.roleID 
                                               WHERE u.userName = @userName", connection)
                command.Parameters.AddWithValue("@userName", userName)
                Return Convert.ToString(command.ExecuteScalar())
            End Using
        End Using
    End Function


    Public Sub AuditTrail(action As String)
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("INSERT INTO tblAudit (action, dateActed) VALUES (@action, NOW())", connection)
                command.Parameters.AddWithValue("@action", action)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function DisplayAudit() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT * FROM tblAudit", connection)
                Using adp As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adp.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Dashboard"
    Public Function GetCount(table As String) As Integer
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand($"SELECT COUNT(*) FROM {table}", connection)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function GetBorrowerTypeCount(table As String, type As String) As Integer
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand($"SELECT COUNT(*) FROM {table} WHERE borrowerType = @type", connection)
                command.Parameters.AddWithValue("@type", type)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function GetBorrowedCount() As Integer
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT COUNT(*) FROM tblBorrowedBooks WHERE borrowStatus = 'Not Returned'", connection)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function GetBorrowStatusCount(status As String) As Integer
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT COUNT(*) FROM tblBorrowedBooks WHERE borrowStatus = @status", connection)
                command.Parameters.AddWithValue("@status", status)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function GetPenalty(column As String) As String
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand($"SELECT {column} FROM tblMaintenance WHERE id = 1", connection)
                Return Convert.ToString(command.ExecuteScalar())
            End Using
        End Using
    End Function
#End Region
End Module

