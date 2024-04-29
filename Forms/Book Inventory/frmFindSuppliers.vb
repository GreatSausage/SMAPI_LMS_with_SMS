Imports System.Data.SqlTypes

Public Class frmFindSuppliers
    Private Sub frmFindSuppliers_Load(sender As Object, e As EventArgs) Handles Me.Load
        'If frmAddCopies.rbDonated.Checked Then
        '    Dim dtDonator As DataTable = DisplayDonator()
        '    dgSupplier.DataSource = dtDonator
        'ElseIf frmAddCopies.rbPurchased.Checked Then
        '    Dim dtSuppliers As DataTable = DisplaySuppliers()
        '    dgSupplier.DataSource = dtSuppliers
        'End If
    End Sub

    Private Sub dgSupplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSupplier.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgSupplier.Rows(e.RowIndex)
            Dim supplierName As String = row.Cells("supplierName").Value.ToString
            Dim supplierID As Integer = Convert.ToInt32(row.Cells("supplierID").Value)

            Dim frmAddCopiesInstance As frmAddCopies = DirectCast(Application.OpenForms("frmAddCopies"), frmAddCopies)
            If frmAddCopiesInstance IsNot Nothing Then
                frmAddCopiesInstance.SetSelectedSupplier(supplierID, supplierName)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'SearchSuppliers(dgSupplier, txtSearch.Text)
    End Sub
End Class