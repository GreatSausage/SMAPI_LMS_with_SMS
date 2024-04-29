Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtBorrowers.Text = GetCount("tblBorrowers")
        txtFaculties.Text = GetBorrowerTypeCount("tblBorrowers", "Faculty")
        txtStudents.Text = GetBorrowerTypeCount("tblBorrowers", "Student")
        txtBooks.Text = GetCount("tblBooks")
        txtBorrowed.Text = GetBorrowedCount()
        txtOverdue.Text = GetBorrowStatusCount("Overdue")
        txtDamaged.Text = GetBorrowStatusCount("Damaged")
        txtLost.Text = GetBorrowStatusCount("Lost")
        txtOverdueCharges.Text = GetPenalty("overduePenalty")
        txtPenalty.Text = GetPenalty("damagedLostPenalty")
    End Sub
End Class