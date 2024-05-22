Public Class frmAuditTrail
    Private Sub frmAuditTrail_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dt As DataTable = DisplayAudit()
        dgBooks.DataSource = dt
    End Sub
End Class