Public Class frmAddSuppliers

    Dim getSupplierID As Integer = Nothing

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim type As String = ""
        If rbDonator.Checked Then
            type = "Donator"
        ElseIf rbSupplier.Checked Then
            type = "Supplier"
        End If

        If String.IsNullOrEmpty(txtSupplierName.Text) OrElse
           String.IsNullOrEmpty(txtContact.Text) OrElse
           String.IsNullOrEmpty(txtAddress.Text) Then
            MessageBox.Show("Please fill in the necessary fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            AddSuppliers(txtSupplierName.Text, txtContact.Text, txtAddress.Text, type)
            Me.Close()
        End If
    End Sub

    Private Sub AntiDoubleSpace(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress, txtContact.KeyPress, txtSupplierName.KeyPress
        If e.KeyChar = " " AndAlso txtAddress.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtContact.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtSupplierName.Text.EndsWith(" ") Then
            e.Handled = True
        End If
    End Sub

    Private Sub LetterOnly(sender As Object, e As KeyPressEventArgs) Handles txtSupplierName.KeyPress, txtAddress.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub DigitOnly(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim type As String = ""
        If rbDonator.Checked Then
            type = "Donator"
        ElseIf rbSupplier.Checked Then
            type = "Supplier"
        End If

        If String.IsNullOrEmpty(txtSupplierName.Text) OrElse
           String.IsNullOrEmpty(txtContact.Text) OrElse
           String.IsNullOrEmpty(txtAddress.Text) Then
            MessageBox.Show("Please fill in the necessary fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            UpdateSuppliers(getSupplierID, txtSupplierName.Text, txtContact.Text, txtAddress.Text, type)
            getSupplierID = Nothing
            Me.Close()
        End If
    End Sub

    Public Sub SetSelectedSuppliersMaintenance(authorID As Integer, authorName As String, contactNo As String, address As String)
        txtSupplierName.Text = authorName
        getSupplierID = authorID
        txtContact.Text = contactNo
        txtAddress.Text = address
    End Sub

    'Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    '    DeleteSuppliers(txtSupplierID.Text)
    '    Me.Close()
    'End Sub

    Private Sub frmAddSuppliers_Load(sender As Object, e As EventArgs) Handles Me.Load
        rbDonator.Checked = True
    End Sub
End Class