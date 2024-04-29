Imports MySql.Data.MySqlClient
Imports Software_Engineering.My

Public Class Form1

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtUsernameSignIn.Text) OrElse
           String.IsNullOrEmpty(txtPasswordSignIn.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Login(txtUsernameSignIn.Text, txtPasswordSignIn.Text)
        End If
    End Sub
    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim server As String = txtServer.Text.Trim
            Dim username As String = txtUsername.Text.Trim
            Dim password As String = txtPassword.Text.Trim
            Dim database As String = txtDatabase.Text.Trim

            Dim constr As String = "server= " & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";port=3306"
            My.Settings.server = server
            My.Settings.username = username
            My.Settings.password = password
            My.Settings.database = database
            My.Settings.connString = constr
            My.Settings.Save()
            MessageBox.Show("Saved successfully.")
            serverconn.Close()
            Dim connstring As String = My.Settings.connString
            serverconn.ConnectionString = connstring
        Catch ex As MySqlException
            MsgBox("Can't connect to database.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub
End Class