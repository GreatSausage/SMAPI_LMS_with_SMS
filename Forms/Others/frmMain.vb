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
        AuditTrail($"{txtFullname.Text} has logged out.")
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        DisplayFormPanel(frmReports, panelDisplay)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayFormPanel(frmDashboard, panelDisplay)
        BackgroundWorker1.RunWorkerAsync()
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
                Using connection As MySqlConnection = ConnectionOpen()
                    Using countCommand As New MySqlCommand("SELECT COUNT(*) FROM tblBorrowedBooks WHERE DATE(dueDate) < DATE(CURDATE()) AND borrowStatus = 'Not Returned' AND smsSent = 'False'", connection)
                        Dim count As Integer = Convert.ToInt32(countCommand.ExecuteScalar())
                        If count > 0 Then
                            Using command As New MySqlCommand("SELECT bb.borrowID, bb.copyID, b.firstName, b.lastName, b.guardianContact, bk.bookTitle, bb.dueDate FROM tblBorrowedBooks bb JOIN tblBorrowers b ON bb.borrowerID = b.borrowerID JOIN tblCopies c ON bb.copyID = c.copyID JOIN tblBooks bk ON c.bookID = bk.bookID WHERE DATE(bb.dueDate) < DATE(CURDATE()) AND bb.borrowStatus = 'Not Returned' AND bb.smsSent = 'False'", connection)
                                Using reader As MySqlDataReader = command.ExecuteReader()
                                    While reader.Read()
                                        Dim firstName As String = reader("firstName").ToString()
                                        Dim lastName As String = reader("lastName").ToString()
                                        Dim bookTitle As String = reader("bookTitle").ToString()
                                        Dim phoneNumber As String = reader("guardianContact").ToString()

                                        Using updateConnection As MySqlConnection = ConnectionOpen()
                                            Dim updateCommand As New MySqlCommand("UPDATE tblBorrowedBooks SET smsSent = 'True' WHERE borrowID = @borrowID", updateConnection)
                                            updateCommand.Parameters.AddWithValue("@borrowID", reader("borrowID"))
                                            updateCommand.ExecuteNonQuery()
                                            Dim message As String = String.Format("The book that {0} {1} borrowed, '{2}', is now overdue.", firstName, lastName, bookTitle)
                                            SMSNotifs(smsport, phoneNumber, message)
                                        End Using
                                    End While
                                End Using
                            End Using
                        End If
                    End Using
                End Using
                Thread.Sleep(10000)
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