Imports System.Data.SqlClient
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

        With smsport
            .PortName = "COM5"
            .BaudRate = 9600
            .DataBits = 8
            .StopBits = StopBits.One
            .Handshake = Handshake.None
            .DtrEnable = True
            .RtsEnable = True
            .NewLine = vbCrLf
        End With

        smsport.Open()
        smsport.WriteLine("AT" & Chr(13))
        Threading.Thread.Sleep(200)
        smsport.WriteLine("AT+CMGF=1" & Chr(13))
        Threading.Thread.Sleep(200)
        smsport.WriteLine("AT+CMGS=" & Chr(34) & phoneNumber & Chr(34))
        Threading.Thread.Sleep(200)
        smsport.WriteLine(message & Chr(26))
        Threading.Thread.Sleep(200)
    End Sub

#Region "Sign In"
    Public Sub Login(userName As String, password As String)
        Using connection As MySqlConnection = ConnectionOpen()

            Using userCommand As New MySqlCommand("SELECT COUNT(*) FROM tblusers WHERE userName = @userName", connection)
                userCommand.Parameters.AddWithValue("@@userName", userName)

                If Convert.ToInt32(userCommand.ExecuteScalar()) > 0 Then
                    Using passCommand As New MySqlCommand("SELECT Password FROM tblusers WHERE userName = @userName", connection)
                        passCommand.Parameters.AddWithValue("@userName", userName)
                        Dim dbPassword As String = Convert.ToString(passCommand.ExecuteScalar())

                        If dbPassword IsNot Nothing AndAlso dbPassword.Equals(password) Then

                            Using loginCommand As New MySqlCommand("SELECT userName FROM tblUsers WHERE userName = @userName", connection)
                                loginCommand.Parameters.AddWithValue("@userName", userName)
                                Dim getUserName As String = Convert.ToString(loginCommand.ExecuteScalar())

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
                            End Using

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
End Module
