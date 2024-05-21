Imports System.ComponentModel
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Public Class frmMain
    Private Sub frmMain_Resized(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y - (y - Screen.PrimaryScreen.WorkingArea.Height)
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        DisplayFormPanel(frmMainte, panelDisplay)
    End Sub

    Private Sub btnBookInventory_Click(sender As Object, e As EventArgs) Handles btnBookInventory.Click
        DisplayFormPanel(frmBookInventory, panelDisplay)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        DisplayFormPanel(frmIssueReturn, panelDisplay)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        DisplayFormPanel(frmDashboard, panelDisplay)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles btnAudit.Click
        DisplayFormPanel(frmAuditTrail, panelDisplay)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        'If BackgroundWorker1.IsBusy Then
        '    BackgroundWorker1.CancelAsync()
        'End If
        AuditTrail($"{txtFullname.Text} has logged out.")
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        DisplayFormPanel(frmReports, panelDisplay)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayFormPanel(frmDashboard, panelDisplay)
    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Using smsport As New SerialPort
            With smsport
                .PortName = "COM6"
                .BaudRate = 9600
                .DataBits = 8
                .StopBits = StopBits.One
                .Handshake = Handshake.None
                .DtrEnable = True
                .RtsEnable = True
                .NewLine = vbCrLf
            End With
            smsport.Open()

            Do

                Dim currentDate As Date = Date.Today

                ' Check for books due today
                Using connection As MySqlConnection = ConnectionOpen()
                    Using command As New MySqlCommand("SELECT bb.borrowID, bb.copyID, b.firstName, b.lastName, b.guardianContact, bk.bookTitle, bb.dueDate 
                                                   FROM tblBorrowedBooks bb 
                                                   JOIN tblBorrowers b ON bb.borrowerID = b.borrowerID 
                                                   JOIN tblCopies c ON bb.copyID = c.copyID 
                                                   JOIN tblBooks bk ON c.bookID = bk.bookID 
                                                   WHERE DATE(bb.dueDate) = @currentDate AND bb.borrowStatus = 'Not Returned' AND bb.dayBeforeDue = 'True' AND bb.dueDateNow = 'False' AND bb.afterDueDate = 'False' AND bb.smsInstantLost = 'False'", connection)
                        command.Parameters.AddWithValue("@currentDate", currentDate)
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            While reader.Read()
                                Dim firstName As String = reader("firstName").ToString()
                                Dim lastName As String = reader("lastName").ToString()
                                Dim bookTitle As String = reader("bookTitle").ToString()
                                Dim phoneNumber As String = reader("guardianContact").ToString()

                                ' Update smsSent to 'True' for the current book
                                Using updateConnection As MySqlConnection = ConnectionOpen()
                                    Using updateCommand As New MySqlCommand("UPDATE tblBorrowedBooks SET dueDateNow = 'True' WHERE borrowID = @borrowID", updateConnection)
                                        updateCommand.Parameters.AddWithValue("@borrowID", reader("borrowID"))
                                        updateCommand.ExecuteNonQuery()
                                    End Using
                                End Using

                                Dim message As String = String.Format("Dear {0} {1} from St. Mark Academy of Primarosa, Inc., we kindly remind you that the book '{2}' you borrowed is due today. Please return it as soon as possible to avoid any inconvenience. Thank you.", firstName, lastName, bookTitle)
                                SMSNotifs(smsport, phoneNumber, message)
                            End While
                        End Using
                    End Using
                End Using

                ' Check for books due tomorrow
                Dim tomorrowDate As Date = currentDate.AddDays(1)
                Using connection As MySqlConnection = ConnectionOpen()
                    Using command As New MySqlCommand("SELECT bb.borrowID, bb.copyID, b.firstName, b.lastName, b.guardianContact, bk.bookTitle, bb.dueDate 
                                                   FROM tblBorrowedBooks bb 
                                                   JOIN tblBorrowers b ON bb.borrowerID = b.borrowerID 
                                                   JOIN tblCopies c ON bb.copyID = c.copyID 
                                                   JOIN tblBooks bk ON c.bookID = bk.bookID 
                                                   WHERE DATE(bb.dueDate) = @tomorrowDate AND bb.borrowStatus = 'Not Returned' AND bb.dayBeforeDue = 'False' AND bb.dueDateNow = 'False' AND bb.afterDueDate = 'False' AND bb.smsInstantLost = 'False'", connection)
                        command.Parameters.AddWithValue("@tomorrowDate", tomorrowDate)
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            While reader.Read()
                                Dim firstName As String = reader("firstName").ToString()
                                Dim lastName As String = reader("lastName").ToString()
                                Dim bookTitle As String = reader("bookTitle").ToString()
                                Dim phoneNumber As String = reader("guardianContact").ToString()

                                ' Update smsSent to 'True' for the current book
                                Using updateConnection As MySqlConnection = ConnectionOpen()
                                    Using updateCommand As New MySqlCommand("UPDATE tblBorrowedBooks SET dayBeforeDue = 'True' WHERE borrowID = @borrowID", updateConnection)
                                        updateCommand.Parameters.AddWithValue("@borrowID", reader("borrowID"))
                                        updateCommand.ExecuteNonQuery()
                                    End Using
                                End Using

                                Dim message As String = String.Format("Dear {0} {1} from St. Mark Academy of Primarosa, Inc., we kindly remind you that the book '{2}' you borrowed is due tomorrow. Please return it as soon as possible to avoid any inconvenience. Thank you.", firstName, lastName, bookTitle)
                                SMSNotifs(smsport, phoneNumber, message)
                            End While
                        End Using
                    End Using
                End Using

                ' Check for books that are 1 day overdue
                Using connection As MySqlConnection = ConnectionOpen()
                    Using command As New MySqlCommand("SELECT bb.borrowID, bb.copyID, b.firstName, b.lastName, b.guardianContact, bk.bookTitle, bb.dueDate 
                                       FROM tblBorrowedBooks bb 
                                       JOIN tblBorrowers b ON bb.borrowerID = b.borrowerID 
                                       JOIN tblCopies c ON bb.copyID = c.copyID 
                                       JOIN tblBooks bk ON c.bookID = bk.bookID 
                                       WHERE DATEDIFF(CURDATE(), bb.dueDate) = 1 AND bb.borrowStatus = 'Not Returned' AND bb.dayBeforeDue = 'True' AND bb.dueDateNow = 'True' AND bb.afterDueDate = 'False' AND bb.smsInstantLost = 'False'", connection)
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            While reader.Read()
                                Dim firstName As String = reader("firstName").ToString()
                                Dim lastName As String = reader("lastName").ToString()
                                Dim bookTitle As String = reader("bookTitle").ToString()
                                Dim phoneNumber As String = reader("guardianContact").ToString()

                                ' Update afterDueDate to 'True' for the current book
                                Using updateConnection As MySqlConnection = ConnectionOpen()
                                    Using updateCommand As New MySqlCommand("UPDATE tblBorrowedBooks SET afterDueDate = 'True' WHERE borrowID = @borrowID", updateConnection)
                                        updateCommand.Parameters.AddWithValue("@borrowID", reader("borrowID"))
                                        updateCommand.ExecuteNonQuery()
                                    End Using
                                End Using

                                Dim message As String = String.Format("Dear {0} {1} from St. Mark Academy of Primarosa, Inc., we kindly remind you that the book '{2}' you borrowed is now 1 day overdue. Please return it as soon as possible to avoid any inconvenience. Thank you.", firstName, lastName, bookTitle)
                                SMSNotifs(smsport, phoneNumber, message)
                            End While
                        End Using
                    End Using
                End Using

                ' Check for books that are instantly lost
                Using connection As MySqlConnection = ConnectionOpen()
                    Using command As New MySqlCommand("SELECT bb.borrowID, bb.copyID, b.firstName, b.lastName, b.guardianContact, bk.bookTitle, bb.instantLost
                                       FROM tblBorrowedBooks bb 
                                       JOIN tblBorrowers b ON bb.borrowerID = b.borrowerID 
                                       JOIN tblCopies c ON bb.copyID = c.copyID 
                                       JOIN tblBooks bk ON c.bookID = bk.bookID 
                                       WHERE DATE(bb.instantLost) = CURDATE() AND bb.borrowStatus = 'Not Returned' AND bb.dayBeforeDue = 'True' AND bb.dueDateNow = 'True' AND bb.afterDueDate = 'True' AND bb.smsInstantLost = 'False'", connection)
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            While reader.Read()
                                Dim firstName As String = reader("firstName").ToString()
                                Dim lastName As String = reader("lastName").ToString()
                                Dim bookTitle As String = reader("bookTitle").ToString()
                                Dim phoneNumber As String = reader("guardianContact").ToString()

                                ' Update smsInstantLost to 'True' for the current book
                                Using updateConnection As MySqlConnection = ConnectionOpen()
                                    Using updateCommand As New MySqlCommand("UPDATE tblBorrowedBooks SET smsInstantLost = 'True' WHERE borrowID = @borrowID", updateConnection)
                                        updateCommand.Parameters.AddWithValue("@borrowID", reader("borrowID"))
                                        updateCommand.ExecuteNonQuery()
                                    End Using
                                End Using

                                Dim message As String = String.Format("Dear {0} {1} from St. Mark Academy of Primarosa, Inc., we regret to inform you that the book '{2}' you borrowed is now considered lost. Please contact the library for further instructions on how to settle the lost book fee. Thank you.", firstName, lastName, bookTitle)
                                SMSNotifs(smsport, phoneNumber, message)
                            End While
                        End Using
                    End Using
                End Using

                Thread.Sleep(30000) ' Sleep for 30 seconds
            Loop
        End Using
    End Sub

    Private Sub SMSNotifs(smsport As SerialPort, phoneNumber As String, message As String)
        smsport.WriteLine("AT" & Chr(13))
        Threading.Thread.Sleep(1000) ' Wait for modem response
        smsport.WriteLine("AT+CMGF=1" & Chr(13))
        Threading.Thread.Sleep(1000) ' Wait for modem response
        smsport.WriteLine("AT+CMGS=" & Chr(34) & phoneNumber & Chr(34))
        Threading.Thread.Sleep(1000) ' Wait for modem response
        smsport.WriteLine(message & Chr(26))
        Threading.Thread.Sleep(1000) ' Wait for modem response
    End Sub



End Class