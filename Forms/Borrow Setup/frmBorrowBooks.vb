Imports System.IO.Ports
Imports MySql.Data.MySqlClient
Public Class frmBorrowBooks

    Dim getBorrowerID As Integer = 0

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged

        Dim acnDt As DataTable = AvailableAcn(txtTitle.Text)
        txtAcn.DataSource = acnDt
        txtAcn.DisplayMember = "accessionNo"
        txtAcn.ValueMember = "accessionNo"
    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        BorrowerInfo(txtStudentID.Text, txtFirstname, txtLastname)
    End Sub

    Private Sub btnFindSuppliers_Click(sender As Object, e As EventArgs) Handles btnFindSuppliers.Click
        frmBookFinder.Show()
    End Sub

    Public Sub SetSelectedBooksWithISBN(isbn As String, title As String, authorName As String)
        txtISBN.Text = isbn
        txtTitle.Text = title
        txtAuthors.Text = authorName
    End Sub

    Public Sub SetSelectedBookWithoutISBN(title As String, authorName As String)
        txtTitle.Text = title
        txtAuthors.Text = authorName
    End Sub

    Public Sub SetSelectedBorrower(borrowerID As Integer, studentID As String, firstName As String, lastName As String)
        getBorrowerID = borrowerID
        txtStudentID.Text = studentID
        txtFirstname.Text = firstName
        txtLastname.Text = lastName
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmBorrowerFinder.Show()
    End Sub

    Public smsMessage As String = ""

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim smsport As New SerialPort
        Try
            If smsport.IsOpen Then
                MessageBox.Show("The COM port is already open.")
                Return
            End If

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

            If String.IsNullOrEmpty(txtStudentID.Text) OrElse String.IsNullOrEmpty(txtTitle.Text) Then
                MessageBox.Show("Please fill in the necessary fields.")
            ElseIf dgBooks.Rows.Cast(Of DataGridViewRow)().Any(Function(row) row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) Not String.IsNullOrEmpty(cell.Value?.ToString()))) = False Then
                MessageBox.Show("Please add at least one book.")
            Else
                smsMessage = ""

                For Each row As DataGridViewRow In dgBooks.Rows
                    If Not row.IsNewRow Then
                        Dim title As String = row.Cells("distinctTitle").Value.ToString()
                        smsMessage &= title & ", "
                        Dim accessionNo As String = row.Cells("acnNo").Value.ToString()
                        Dim copyID As Integer = GetCopyIDFunction(accessionNo)

                        BorrowBooks(copyID, getBorrowerID)
                    End If
                Next

                smsMessage = smsMessage.TrimEnd(", ".ToCharArray())

                MessageBox.Show("Book has been borrowed successfully.")
                AuditTrail($"{txtFirstname.Text} {txtLastname.Text} borrowed {smsMessage}.")
                Using connection As MySqlConnection = ConnectionOpen()
                    Using getPhoneNumber As New MySqlCommand("SELECT b.guardianContact, CONCAT(b.firstName, ' ', b.lastName) AS fullName
                          FROM tblBorrowers b
                          WHERE b.borrowerID = @borrowerID", connection)
                        getPhoneNumber.Parameters.AddWithValue("@borrowerID", getBorrowerID)
                        Dim reader As MySqlDataReader = getPhoneNumber.ExecuteReader()

                        If reader.Read() Then
                            Dim number As String = reader("guardianContact").ToString()
                            Dim fullName As String = reader("fullName").ToString()
                            Dim message As String = $"Dear {fullName}, your child has borrowed the following books: {smsMessage}. Please ensure their return on time. Thank you."
                            SMSNotifs(smsport, number, message)
                        End If
                    End Using
                End Using
                Me.Close()
            End If
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Access to the port 'COM6' is denied.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If smsport IsNot Nothing AndAlso smsport.IsOpen Then
                smsport.Close()
            End If
        End Try
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


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim borrowLimit As Integer = GetBorrowLimit(getBorrowerID)

        If dgBooks.Rows.Count >= borrowLimit Then
            MessageBox.Show("You have reached the maximum limit.")
            Return
        ElseIf borrowLimit = 0 Then
            MessageBox.Show("This borrower has reached its borrow limit.")
            Return
        End If


        Dim isbn As String = txtISBN.Text
        Dim author As String = txtAuthors.Text
        Dim title As String = txtTitle.Text
        Dim acn As String = txtAcn.Text

        For Each row As DataGridViewRow In dgBooks.Rows
            If row.Cells("acnNo").Value IsNot Nothing AndAlso row.Cells("acnNo").Value.ToString() = acn Then
                MessageBox.Show("The ACN number already exists in the list.")
                Return
            End If
        Next

        Dim newRow As DataGridViewRow = dgBooks.Rows(dgBooks.Rows.Add())

        newRow.Cells("distinctISBN").Value = isbn
        newRow.Cells("distinctAuthor").Value = author
        newRow.Cells("distinctTitle").Value = title
        newRow.Cells("acnNo").Value = acn
    End Sub

End Class