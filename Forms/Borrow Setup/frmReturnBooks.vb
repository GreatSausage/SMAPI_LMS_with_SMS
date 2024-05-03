Imports System.ComponentModel.Design
Imports MySql.Data.MySqlClient

Public Class frmReturnBooks

    Dim getBorrowID As Integer = Nothing

    Public Sub SetSelectedBorrowedBooks(borrowID As Integer, studentID As Integer, firstname As String, lastname As String, isbn As String, author As String, accessionNo As String, title As String, acquisitionType As String)
        getBorrowID = borrowID
        txtStudentID.Text = studentID
        txtFirstname.Text = firstname
        txtLastname.Text = lastname
        txtISBN.Text = isbn
        txtAuthors.Text = author
        txtAcn.Text = accessionNo
        txtTitle.Text = title
        txtType.Text = acquisitionType
    End Sub

    Private Sub frmReturnBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsBookOverdue(getBorrowID) Then
            Dim currentDate As Date = Date.Now
            Dim dueDate As Date
            Dim dateBorrowed As DateTime
            Dim instantLost As Date
            Try
                Using connection As MySqlConnection = ConnectionOpen()
                    Using selectCommand As New MySqlCommand("SELECT dueDate, dateBorrowed, instantLost FROM tblBorrowedBooks WHERE borrowID = @borrowID", connection)
                        selectCommand.Parameters.AddWithValue("@borrowID", getBorrowID)

                        Using reader As MySqlDataReader = selectCommand.ExecuteReader()
                            If reader.Read() Then
                                dueDate = reader("dueDate")
                                dateBorrowed = reader("dateBorrowed")
                                instantLost = reader("instantLost")
                            End If
                        End Using
                    End Using

                    Dim overDue As Integer = (currentDate - dueDate).Days

                    If overDue >= 1 AndAlso overDue <= 7 Then
                        Using getOverdueCommand As New MySqlCommand("SELECT overduePenalty FROM tblMaintenance WHERE id = 1", connection)
                            Dim overdueCharge As Decimal = Convert.ToDecimal(getOverdueCommand.ExecuteScalar())
                            Dim penalty As Decimal = Convert.ToDecimal(overDue) * overdueCharge
                            MsgBox(penalty)
                            txtPenalty.Text = penalty.ToString
                            txtStatus.SelectedItem = "Overdue"
                            txtStatus.Enabled = False
                        End Using

                    ElseIf overDue <= 0 Then
                        txtStatus.SelectedIndex = 0
                        txtStatus.Items.Remove("Overdue")

                    ElseIf currentDate >= instantLost Then
                        txtStatus.SelectedIndex = 3
                        txtStatus.Enabled = False
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        Else
            txtStatus.SelectedItem = "Good Condition"
            txtStatus.Items.Remove("Overdue")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim copyID As Integer = GetCopyIDFunction(txtAcn.Text)

        Try
            If txtStatus.SelectedItem = "Good Condition" Then
                ReturnBookInGood(getBorrowID, copyID, txtStudentID.Text)
                AuditTrail($"{txtFirstname.Text} {txtLastname.Text} returned {txtTitle.Text} in good condition.")
            ElseIf txtStatus.SelectedItem = "Overdue" Then
                ReturnOverdue(getBorrowID, txtPenalty.Text)
                AuditTrail($"{txtFirstname.Text} {txtLastname.Text} returned {txtTitle.Text} overdue.")
            ElseIf txtStatus.SelectedItem = "Damaged" Then
                ReturnDamaged(getBorrowID, txtPenalty.Text)
                AuditTrail($"{txtFirstname.Text} {txtLastname.Text} returned {txtTitle.Text} in damaged condition.")
            ElseIf txtStatus.SelectedItem = "Lost" Then
                ReturnLost(getBorrowID, txtPenalty.Text)
                AuditTrail($"{txtFirstname.Text} {txtLastname.Text} lost the {txtTitle.Text} book.")
            End If

            getBorrowID = Nothing
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub txtStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtStatus.SelectedIndexChanged
        If txtStatus.SelectedItem = "Lost" OrElse txtStatus.SelectedItem = "Damaged" Then
            Dim type As String = GetBookType(txtAcn.Text)
            If type = "Purchased" Then
                txtPenalty.ReadOnly = False
                txtPenalty.Text = GetBookPrice(txtAcn.Text)
                txtPenalty.ReadOnly = True
            ElseIf type = "Donated" Then
                txtPenalty.ReadOnly = False
                txtPenalty.Text = GetBookPenalty()
                txtPenalty.ReadOnly = True
            ElseIf type = "Initial Copy" Then
                txtPenalty.ReadOnly = False
                txtPenalty.Text = GetBookPenalty()
                txtPenalty.ReadOnly = True
            End If

        Else
            txtPenalty.Clear()
            txtPenalty.ReadOnly = False

        End If
    End Sub

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub
End Class