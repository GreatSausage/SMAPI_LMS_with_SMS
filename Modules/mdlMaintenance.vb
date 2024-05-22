Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Globalization

Module mdlMaintenance

    Public connString As String = "server=localhost;database=dblms;uid=smapi;pwd=0529"

    Public Function DisplayAlphabeticalData(tblName As String, columnName As String) As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand($"SELECT * FROM {tblName} ORDER BY {columnName}", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function


#Region "User Maintenance"
    Public Function DisplayUsers() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT u.userID, u.firstName, u.lastName, u.phoneNumber, 
                                                        r.roleName 
                                                 FROM tblUsers u 
                                                 JOIN tblRoles r 
                                                 ON r.roleID = u.roleID 
                                                 WHERE u.roleID IN(2,3,4)
                                                 ORDER BY u.firstName", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function


    Public Sub UserDatatable()
        Dim dtUser As DataTable = DisplayUsers()
        frmMainte.dgUsers.DataSource = dtUser
    End Sub

    Public Function DisplayRoles(role As String) As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Dim command As String = "SELECT roleID, roleName FROM tblRoles "

            If role = "Principal" Then
                command += "WHERE roleID IN(3,4)"
            ElseIf role = "Librarian" Then
                command += "WHERE roleID IN(4)"
            ElseIf role = "Admin" Then
                command += "WHERE roleID IN(2,3,4)"
            End If

            Using commandOne As New MySqlCommand(command, connection)
                Using adapter As New MySqlDataAdapter(commandOne)
                    Dim datatable As New DataTable
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using

        End Using
    End Function

    Public Sub AddUser(firstName As String, lastName As String, phoneNumber As String, userName As String, password As String, answer As String, question As String, roleID As Integer, roleName As String, id As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedFirstName As String = textInfo.ToTitleCase(firstName.ToLower())
        Dim capitalizedLastName As String = textInfo.ToTitleCase(lastName.ToLower())

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblUsers(firstName, lastName, phoneNumber, userName, password, securityAnswer, securityQuestion, roleID, ID) 
                                                 VALUES (@firstName, @lastName, @phoneNumber, @userName, @password, @answer, @question, @roleID, @ID)", connection)
                    With command.Parameters
                        .AddWithValue("@firstName", capitalizedFirstName)
                        .AddWithValue("@lastName", capitalizedLastName)
                        .AddWithValue("@phoneNumber", phoneNumber)
                        .AddWithValue("@userName", userName)
                        .AddWithValue("@password", password)
                        .AddWithValue("@answer", answer)
                        .AddWithValue("@question", question)
                        .AddWithValue("@roleID", roleID)
                        .AddWithValue("@ID", id)
                    End With
                    command.ExecuteNonQuery()
                    MessageBox.Show($"{capitalizedFirstName} {capitalizedLastName} added as {roleName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmAddUsers.Close()
                    UserDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                Dim errorMessage As String = "Some fields already exist:"
                If ex.Message.Contains("userName") Then
                    errorMessage &= vbCrLf & "- User Name"
                End If
                If ex.Message.Contains("phoneNumber") Then
                    errorMessage &= vbCrLf & "- Phone Number"
                End If
                If ex.Message.Contains("ID") Then
                    errorMessage &= vbCrLf & "- ID"
                End If
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try

    End Sub
#End Region

#Region "Suppliers"

    Public Sub SupplierDatatable()
        Dim dtSupplier As DataTable = DisplayAlphabeticalData("tblSuppliers", "supplierName")
        frmMainte.dgSuppliers.DataSource = dtSupplier
    End Sub

    Public Sub AddSuppliers(supplierName As String, contactNumber As String, address As String, type As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedsupplierName As String = textInfo.ToTitleCase(supplierName.ToLower())
        Dim capitalizedAddress As String = textInfo.ToTitleCase(address.ToLower)

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblSuppliers (supplierName, contactNumber, address, type) 
                                                     VALUES (@supplierName, @contactNumber, @address, @type)", connection)
                    With command.Parameters
                        .AddWithValue("@supplierName", capitalizedsupplierName)
                        .AddWithValue("@contactNumber", contactNumber)
                        .AddWithValue("@address", capitalizedAddress)
                        .AddWithValue("@type", type)
                    End With
                    command.ExecuteNonQuery()
                    MessageBox.Show($"{type} added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SupplierDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                Dim errorMessage As String = "Some fields already exist:"
                If ex.Message.Contains("supplierName") Then
                    errorMessage &= vbCrLf & "- Supplier Name"
                End If
                If ex.Message.Contains("contactNumber") Then
                    errorMessage &= vbCrLf & "- Contact Number"
                End If
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try

    End Sub

    Public Sub UpdateSuppliers(supplierID As Integer, supplierName As String, contact As String, address As String, type As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedSupplier As String = textInfo.ToTitleCase(supplierName.ToLower)

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("UPDATE tblSuppliers SET supplierName = @supplierName,
                                                                             contactNumber = @contactNo, 
                                                                             address = @address, 
                                                                             type = @type 
                                                     WHERE supplierID = @supplierID", connection)
                    command.Parameters.AddWithValue("@supplierID", supplierID)
                    command.Parameters.AddWithValue("@supplierName", capitalizedSupplier)
                    command.Parameters.AddWithValue("@contactNo", contact)
                    command.Parameters.AddWithValue("@address", address)
                    command.Parameters.AddWithValue("@type", type)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SupplierDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                Dim errorMessage As String = "Some fields already exist:"
                If ex.Message.Contains("supplierName") Then
                    errorMessage &= vbCrLf & "- Supplier Name"
                End If
                If ex.Message.Contains("contactNumber") Then
                    errorMessage &= vbCrLf & "- Contact Number"
                End If
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Public Sub DeleteSuppliers(supplierID As Integer)
        Using connection As MySqlConnection = ConnectionOpen()

            Using checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblCopies WHERE supplierID = @supplierID", connection)
                checkCommand.Parameters.AddWithValue("@supplierID", supplierID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Supplier cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using command As New MySqlCommand("DELETE FROM tblSuppliers WHERE supplierID = @supplierID", connection)
                        command.Parameters.AddWithValue("@supplierID", supplierID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Supplier has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        SupplierDatatable()
                    End Using
                End If
            End Using
        End Using
    End Sub

#End Region

#Region "Authors"

    Public Sub AuthorDatatable()
        Dim dtAuthors As DataTable = DisplayAlphabeticalData("tblAuthors", "authorName")
        frmMainte.dgAuthors.DataSource = dtAuthors
    End Sub

    'ADD AUTHORS
    Public Sub AddAuthors(authorName As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedAuthors As String = textInfo.ToTitleCase(authorName.ToLower())
        Try
            Using connection As MySqlConnection = ConnectionOpen()

                Using command As New MySqlCommand("INSERT INTO tblauthors(authorName) VALUES (@authorName)", connection)
                    command.Parameters.AddWithValue("@authorName", capitalizedAuthors)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Author/s added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    AuthorDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Author name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Try

    End Sub

    'UPDATE AUTHORS
    Public Sub UpdateAuthors(authorID As Integer, authorName As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedAuthors As String = textInfo.ToTitleCase(authorName.ToLower)
        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("UPDATE tblauthors SET authorName = @authorName WHERE authorID = @authorID", connection)
                    command.Parameters.AddWithValue("@authorID", authorID)
                    command.Parameters.AddWithValue("@authorName", capitalizedAuthors)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Author updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    AuthorDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Author name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Try
    End Sub

    'DELETE AUTHORS
    Public Sub DeleteAuthors(authorID As Integer)
        Using connection As MySqlConnection = ConnectionOpen()

            Using checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblBooks WHERE authorID = @authorID", connection)
                checkCommand.Parameters.AddWithValue("@authorID", authorID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Author cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using command As New MySqlCommand("DELETE FROM tblAuthors WHERE authorID = @authorID", connection)
                        command.Parameters.AddWithValue("@authorID", authorID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Author has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        AuthorDatatable()
                    End Using
                End If
            End Using
        End Using
    End Sub

#End Region

#Region "Publishers"
    Public Sub PublisherDatatable()
        Dim dtPublisher As DataTable = DisplayAlphabeticalData("tblPublishers", "publisherName")
        frmMainte.dgPublishers.DataSource = dtPublisher
    End Sub

    Public Sub AddPublishers(publisherName As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedPublisher As String = textInfo.ToTitleCase(publisherName.ToLower())

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblPublishers(publisherName) VALUES(@publisherName)", connection)
                    command.Parameters.AddWithValue("@publisherName", capitalizedPublisher)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Publisher/s added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PublisherDatatable()
                End Using
            End Using

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Publisher already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Try
    End Sub

    Public Sub UpdatePublisher(publisherID As Integer, PublisherName As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedPublisher As String = textInfo.ToTitleCase(PublisherName.ToLower)

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("UPDATE tblPublishers SET publisherName = @publisherName WHERE publisherID = @publisherID", connection)
                    command.Parameters.AddWithValue("@publisherID", publisherID)
                    command.Parameters.AddWithValue("@publisherName", capitalizedPublisher)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Publisher updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PublisherDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Publisher already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Public Sub DeletePublisher(publisherID As Integer)
        Using connection As MySqlConnection = ConnectionOpen()

            Using checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblBooks WHERE publisherID = @publisherID", connection)
                checkCommand.Parameters.AddWithValue("@publisherID", publisherID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Publisher cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using command As New MySqlCommand("DELETE FROM tblPublishers WHERE publisherID = @publisherID", connection)
                        command.Parameters.AddWithValue("@publisherID", publisherID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Publisher has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        PublisherDatatable()
                    End Using
                End If
            End Using
        End Using
    End Sub

#End Region

#Region "Bookshelves"
    Public Sub ShelfDatatable()
        Dim dtShelf As DataTable = DisplayAlphabeticalData("tblBookshelves", "shelfNo")
        frmMainte.dgBookshelves.DataSource = dtShelf
    End Sub

    Public Sub AddBookshelves(shelfNo As String, description As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedDescription As String = textInfo.ToTitleCase(description.ToLower())

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblBookshelves(shelfNo, description) 
                                                     VALUES(@shelfNo, @description)", connection)
                    With command.Parameters
                        .AddWithValue("@shelfNo", shelfNo)
                        .AddWithValue("@description", capitalizedDescription)
                    End With
                    command.ExecuteNonQuery()
                    MessageBox.Show("Bookshelf added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShelfDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Shelf number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Public Sub UpdateBookshelf(shelfID As Integer, description As String, shelfNo As Integer)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedDescription As String = textInfo.ToTitleCase(description.ToLower)

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("UPDATE tblBookshelves SET shelfNo = @shelfNo, description = @description 
                                                   WHERE shelfID = @shelfID", connection)
                    command.Parameters.AddWithValue("@shelfID", shelfID)
                    command.Parameters.AddWithValue("@description", capitalizedDescription)
                    command.Parameters.AddWithValue("@shelfNo", shelfNo)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Shelf updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShelfDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Shelf number already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Public Sub DeleteShelf(shelfID As Integer)
        Using connection As MySqlConnection = ConnectionOpen()

            Using checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblBooks WHERE shelfID = @shelfID", connection)
                checkCommand.Parameters.AddWithValue("@shelfID", shelfID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Shelf cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using command As New MySqlCommand("DELETE FROM tblBookshelves WHERE shelfID = @shelfID", connection)
                        command.Parameters.AddWithValue("@shelfID", shelfID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Shelf has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ShelfDatatable()
                    End Using
                End If
            End Using
        End Using
    End Sub
#End Region

#Region "Borrow Maintenance"

    Public Sub UpdateOverdue(charge As Decimal)
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("UPDATE tblmaintenance SET overduePenalty = @penalty", connection)
                command.Parameters.AddWithValue("@penalty", charge)
                command.ExecuteNonQuery()
                MessageBox.Show("Overdue charges has been updated successfully.")
                Dim dt As String = GetPenalty("overduePenalty")
                frmMainte.lblOverdue.Text = dt
                frmDashboard.txtOverdueCharges.Text = dt
            End Using
        End Using
    End Sub

    Public Sub UpdatePenalty(penalty As Decimal)
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("UPDATE tblmaintenance SET damagedLostPenalty = @penalty", connection)
                command.Parameters.AddWithValue("@penalty", penalty)
                command.ExecuteNonQuery()
                MessageBox.Show("Penalty has been updated successfully.")
                Dim dt As String = GetPenalty("damagedLostPenalty")
                frmMainte.lblPenalty.Text = dt
                frmDashboard.txtPenalty.Text = dt
            End Using
        End Using
    End Sub
#End Region
End Module
