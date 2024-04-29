Public Class frmReturnBooks

    Dim getBorrowID As Integer = Nothing

    Public Sub SetSelectedBorrowedBooks(borrowID As Integer, studentID As Integer, firstname As String, lastname As String, isbn As String, author As String, accessionNo As String, title As String)
        getBorrowID = borrowID
        txtStudentID.Text = studentID
        txtFirstname.Text = firstname
        txtLastname.Text = lastname
        txtISBN.Text = isbn
        txtAuthors.Text = author
        txtAcn.Text = accessionNo
        txtTitle.Text = title
    End Sub

    Private Sub frmReturnBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStatus.Items.Remove("Overdue")
        If IsBookOverdue(getBorrowID) Then
            CalculateInOverdue(getBorrowID, txtPenalty, txtStatus)
            txtStatus.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim copyID As Integer = GetCopyIDFunction(txtAcn.Text)

        Try
            If txtStatus.SelectedIndex = 0 Then
                'good condition
                ReturnBookInGood(getBorrowID, copyID, txtStudentID.Text)
            ElseIf txtStatus.SelectedIndex = 1 Then
                'overdue condition
                ReturnOverdue(getBorrowID, txtPenalty.Text)
            ElseIf txtStatus.SelectedIndex = 2 Then
                'damaged condition
                ReturnDamaged(getBorrowID, txtPenalty.Text)
            ElseIf txtStatus.SelectedIndex = 3 Then
            End If

            getBorrowID = Nothing
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub txtStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtStatus.SelectedIndexChanged
        If txtStatus.SelectedIndex = 1 Then
            Dim type As String = GetBookType(txtAcn.Text)
            If type = "Purchased" Then
                txtPenalty.ReadOnly = True
                txtPenalty.Text = GetBookPrice(txtAcn.Text)
            ElseIf type = "Donated" Then
                txtPenalty.Text = GetBookPenalty()
                txtPenalty.ReadOnly = True
            End If

        ElseIf txtStatus.SelectedIndex = 0 Then
            txtPenalty.Clear()
            txtPenalty.ReadOnly = False

        ElseIf txtStatus.SelectedIndex = 2 Then
            Dim type As String = GetBookType(txtAcn.Text)
            If type = "Purchased" Then
                txtPenalty.Text = GetBookPrice(txtAcn.Text)
                txtPenalty.ReadOnly = True
            ElseIf type = "Donated" Then
                txtPenalty.Text = GetBookPenalty()
                txtPenalty.ReadOnly = True
            End If

        End If
    End Sub
End Class