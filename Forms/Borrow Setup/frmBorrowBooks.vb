Public Class frmBorrowBooks

    Dim getBorrowerID As Integer = 0

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtISBN.TextChanged
        BorrowBookInfo(txtISBN.Text, txtTitle, txtAuthors)

        Dim acnDt As DataTable = AvailableAcn(txtISBN.Text)
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

    Public Sub SetSelectedBooks(isbn As String, title As String, authorName As String)
        txtISBN.Text = isbn
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
        ' Reset smsMessage before adding new titles
        smsMessage = ""

        For Each row As DataGridViewRow In dgBooks.Rows
            Dim title As String = row.Cells("distinctTitle").Value.ToString()
            smsMessage &= title & ", " ' Concatenate titles with commas
            Dim accessionNo As String = row.Cells("acnNo").Value.ToString()
            Dim copyID As Integer = GetCopyIDFunction(accessionNo)

            BorrowBooks(copyID, getBorrowerID)
        Next

        ' Remove the trailing comma and space
        smsMessage = smsMessage.TrimEnd(", ".ToCharArray())

        MessageBox.Show("Book has been borrowed successfully.")
        SMSBorrow(getBorrowerID)
        Me.Close()
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

        Dim newRow As DataGridViewRow = dgBooks.Rows(dgBooks.Rows.Add())

        newRow.Cells("distinctISBN").Value = isbn
        newRow.Cells("distinctAuthor").Value = author
        newRow.Cells("distinctTitle").Value = title
        newRow.Cells("acnNo").Value = acn
    End Sub
End Class