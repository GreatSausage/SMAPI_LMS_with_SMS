Public Class frmMainte

    Private Sub frmMainte_Load(sender As Object, e As EventArgs) Handles Me.Load
        AuthorDatatable()
        PublisherDatatable()
        ShelfDatatable()
        SupplierDatatable()
        UserDatatable()
        GradeDatatable()
        SectionDatatable()
        BorrowerDatatable()

    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        frmAddSuppliers.Show()
    End Sub

    Private Sub dgSuppliers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSuppliers.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgSuppliers.Rows(e.RowIndex)
            Dim supplierName As String = row.Cells("supplierName").Value.ToString
            Dim supplierID As Integer = Convert.ToInt32(row.Cells("supplierID").Value)
            Dim contactNo As String = row.Cells("contactNumber").Value.ToString
            Dim address As String = row.Cells("address").Value.ToString

            Dim frmSuppliersInstance As New frmAddSuppliers()
            frmSuppliersInstance.SetSelectedSuppliersMaintenance(supplierID, supplierName, contactNo, address)
            frmSuppliersInstance.Show()
            frmSuppliersInstance.btnSave.Visible = False
            frmSuppliersInstance.lblSupplier.Text = "SUPPLIER INFORMATION"
        End If
    End Sub

    Private Sub btnAddAuthors_Click(sender As Object, e As EventArgs) Handles btnAddAuthors.Click
        frmAddAuthors.Show()
    End Sub

    Private Sub dgAuthors_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAuthors.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgAuthors.Rows(e.RowIndex)
            Dim authorName As String = row.Cells("authorName").Value.ToString
            Dim authorID As Integer = Convert.ToInt32(row.Cells("authorID").Value)

            Dim frmAuthorsInstance As New frmAddAuthors()
            frmAuthorsInstance.SetSelectedAuthorMaintenance(authorID, authorName)
            frmAuthorsInstance.Show()
            frmAuthorsInstance.btnSave.Visible = False
            frmAuthorsInstance.lblAuthors.Text = "AUTHOR INFORMATION"
        End If
    End Sub

    Private Sub btnAddPublishers_Click(sender As Object, e As EventArgs) Handles btnAddPublishers.Click
        frmAddPublishers.Show()
    End Sub

    Private Sub dgPublishers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPublishers.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgPublishers.Rows(e.RowIndex)
            Dim publisherName As String = row.Cells("publisherName").Value.ToString
            Dim publisherID As Integer = Convert.ToInt32(row.Cells("publisherID").Value)

            Dim frmPublisherInstance As New frmAddPublishers()
            frmPublisherInstance.SetSelectedPublisherMaintenance(publisherID, publisherName)
            frmPublisherInstance.Show()
            frmPublisherInstance.btnSave.Visible = False
            frmPublisherInstance.lblPublishers.Text = "PUBLISHER INFORMATION"
        End If
    End Sub

    Private Sub btnAddBookshelf_Click(sender As Object, e As EventArgs) Handles btnAddBookshelf.Click
        frmAddShelf.Show()
    End Sub

    Private Sub dgBookshelves_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBookshelves.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgBookshelves.Rows(e.RowIndex)
            Dim shelfID As Integer = Convert.ToInt32(row.Cells("shelfID").Value)
            Dim description As String = row.Cells("shelfDescription").Value.ToString
            Dim shelfNo As Integer = Convert.ToInt32(row.Cells("shelfNo").Value)

            Dim frmShelfInstance As New frmAddShelf()
            frmShelfInstance.SetSelectedShelfMaintenance(shelfID, description, shelfNo)
            frmShelfInstance.Show()
            frmShelfInstance.btnSave.Visible = False
            frmShelfInstance.txtShelfNo.ReadOnly = True
            frmShelfInstance.lblShelf.Text = "SHELF INFORMATION"
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchBorrowers(dgBorrowers, txtSearch.Text)
    End Sub

    Private Sub btnAddGrade_Click(sender As Object, e As EventArgs) Handles btnAddGrade.Click
        frmAddGrade.Show()
    End Sub


    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        frmAddUsers.Show()
    End Sub

    Private Sub btnAddBorrower_Click(sender As Object, e As EventArgs) Handles btnAddBorrower.Click
        frmAddBorrowers.Show()
    End Sub

    Private Sub btnAddSection_Click(sender As Object, e As EventArgs) Handles btnAddSection.Click
        frmAddSection.Show()
    End Sub

    Private Sub refreshOne_Click(sender As Object, e As EventArgs) Handles refreshOne.Click, refreshTwo.Click, refreshThree.Click, refreshFour.Click, refreshSix.Click
        AuthorDatatable()
        PublisherDatatable()
        ShelfDatatable()
        SupplierDatatable()
        UserDatatable()
        GradeDatatable()
        SectionDatatable()
        BorrowerDatatable()
        BorrowerDatatable()
    End Sub

    Private Sub dgGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgGrade.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgGrade.Rows(e.RowIndex)
            Dim gradeID As Integer = Convert.ToInt32(row.Cells("gradeID").Value)
            Dim gradeLevel As Integer = Convert.ToInt32(row.Cells("grade").Value)

            Dim frmGradeInstance As New frmAddGrade()
            frmGradeInstance.SetSelectedGradeLevel(gradeID, gradeLevel)
            frmGradeInstance.Show()
            frmGradeInstance.btnSave.Visible = False
        End If
    End Sub

    Private Sub dgSection_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSection.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgSection.Rows(e.RowIndex)
            Dim section As String = row.Cells("sectionMainte").Value.ToString
            Dim sectionID As Integer = Convert.ToInt32(row.Cells("sectionID").Value)
            Dim gradeID As Integer = Convert.ToInt32(row.Cells("gradeMainte").Value)

            Dim frmSectionInstance As New frmAddSection()
            frmSectionInstance.SetSelectedSection(gradeID, section, sectionID)
            frmSectionInstance.Show()
            frmSectionInstance.btnSave.Visible = False
        End If
    End Sub

    Private Sub dgBorrowers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBorrowers.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgBorrowers.Rows(e.RowIndex)
            Dim borrowerID As Integer = Convert.ToInt32(row.Cells("borrowerID").Value)
            Dim studentID As String = row.Cells("studentID").Value.ToString
            Dim firstName As String = row.Cells("firstName").Value.ToString
            Dim lastName As String = row.Cells("lastName").Value.ToString
            Dim gradeID As Integer = Convert.ToInt32(row.Cells("gradeLevel").Value)
            Dim section As String = row.Cells("section").Value.ToString
            Dim guardianContact As String = row.Cells("guardianContact").Value.ToString

            Dim frmBorrowerInstance As New frmAddBorrowers
            frmBorrowerInstance.SetSelectedBorrower(borrowerID, studentID, firstName, lastName, gradeID, section, guardianContact)
            frmBorrowerInstance.Show()
            frmBorrowerInstance.btnSave.Visible = False
        End If
    End Sub
End Class