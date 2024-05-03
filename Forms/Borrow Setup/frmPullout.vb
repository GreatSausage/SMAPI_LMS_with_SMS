Public Class frmPullout

    Dim getborrowID As Integer = Nothing
    Private Sub frmPullout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbPaid.Checked = True
    End Sub

    Public Sub SetSelectedPullout(borrowID As Integer, title As String, fullname As String, status As String, penalty As Decimal)
        getborrowID = borrowID
        txtTitle.Text = title
        txtFullname.Text = fullname
        txtStatus.Text = status
        txtPenalty.Text = penalty
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim status As String = ""

        If rbPaid.Checked Then
            status = "Paid"
        ElseIf rbReplaced.Checked Then
            status = "Replaced"
        End If
        UpdatePullout(status, getborrowID)
        getborrowID = Nothing
        Me.Close()
    End Sub
End Class