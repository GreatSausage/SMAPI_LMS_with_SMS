Public Class frmAddCopies

    Dim getSupplierID As Integer = Nothing

    Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtISBN.TextChanged
        Dim bookTitle As String = GetBookTitle(txtISBN.Text)

        If Not String.IsNullOrEmpty(txtISBN.Text) Then
            txtTitle.Text = bookTitle
        Else
            txtTitle.Clear()
        End If
    End Sub

    Private Sub frmAddCopies_Load(sender As Object, e As EventArgs) Handles Me.Load
        rbPurchased.Checked = True

        getSupplierID = txtSupplier.SelectedValue
    End Sub

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim price As Decimal

        If rbPurchased.Checked Then
            If String.IsNullOrEmpty(txtPrice.Text) Then
                MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf Not String.IsNullOrEmpty(txtPrice.Text) Then
                price = Convert.ToDecimal(txtPrice.Text)
            End If
        End If

        If rbDonated.Checked Then

            If Not String.IsNullOrEmpty(txtPrice.Text) Then
                price = Convert.ToDecimal(txtPrice.Text)
            ElseIf String.IsNullOrEmpty(txtPrice.Text) Then
                Dim penalty As Decimal = GetPenaltyCopy()
                price = penalty
            End If
        End If

        Dim copiesToAdd As Integer = Convert.ToInt32(txtCopiesToAdd.Value)
        Dim bookID As Integer = Convert.ToInt32(GetBookID(txtTitle.Text))
        Dim type As String = If(rbDonated.Checked, "Donated", "Purchased")

        For i As Integer = 1 To copiesToAdd
            Dim acn As String = AccessionGenerator()
            AddCopies(acn, bookID, getSupplierID, price, type)
        Next
        AuditTrail($"{frmMain.txtFullname.Text} added {copiesToAdd} copies of {txtTitle.Text}.")
        MessageBox.Show("Copies added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnFindSuppliers_Click(sender As Object, e As EventArgs) Handles btnFindSuppliers.Click
        frmFindSuppliers.Show()
    End Sub

    Private Sub btnBookFinder_Click(sender As Object, e As EventArgs) Handles btnBookFinder.Click
        frmBookFinder.Show()
    End Sub

    Public Sub SetSelectedSupplier(supplierID As Integer, supplierName As String)
        txtSupplier.Text = supplierName
        getSupplierID = supplierID
    End Sub

    Private Sub rbDonated_CheckedChanged(sender As Object, e As EventArgs) Handles rbDonated.CheckedChanged
        If rbDonated.Checked Then
            Dim dtDonator As DataTable = DisplayDonator()
            txtSupplier.DataSource = dtDonator
            txtSupplier.DisplayMember = "supplierName"
            txtSupplier.ValueMember = "supplierID"
            txtPrice.Enabled = False
        End If
    End Sub

    Private Sub rbPurchased_CheckedChanged(sender As Object, e As EventArgs) Handles rbPurchased.CheckedChanged
        If rbPurchased.Checked Then
            Dim dtSuppliers As DataTable = DisplaySuppliers()
            txtSupplier.DataSource = dtSuppliers
            txtSupplier.DisplayMember = "supplierName"
            txtSupplier.ValueMember = "supplierID"
            txtPrice.Enabled = True
        End If
    End Sub

    Public Sub SetSelectedBooks(isbn As String, title As String)
        txtISBN.Text = isbn
        txtTitle.Text = title
    End Sub

End Class