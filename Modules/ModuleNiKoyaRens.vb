Imports MySql.Data.MySqlClient
Module ModuleNiKoyaRens
    Public con1 As New MySqlConnection(My.Settings.connString)
    Public com1 As New MySqlCommand
    Public ds1 As DataSet
    Public dt1 As DataTable
    Public adp1 As New MySqlDataAdapter

    Public Sub KoyaRensConnection()
        If con1.State = ConnectionState.Closed Then
            con1.Open()
        End If
    End Sub
    Public Sub Query(statement As String)
        adp1 = New MySqlDataAdapter(statement, con1)
        ds1 = New DataSet
        adp1.Fill(ds1, "querytable")
    End Sub
    Public Sub KoyaRensCommand(statement As String)
        com1 = New MySqlCommand(statement, con1)
    End Sub

End Module
