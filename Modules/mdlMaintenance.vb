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

    Public Function DisplayRoles() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT roleID, roleName FROM tblRoles WHERE roleID IN(1,2,3)", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim datatable As New DataTable
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        End Using
    End Function

    Public Sub AddUser(firstName As String, lastName As String, phoneNumber As String, userName As String, password As String, answer As String, question As String, roleID As Integer, roleName As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedFirstName As String = textInfo.ToTitleCase(firstName.ToLower())
        Dim capitalizedLastName As String = textInfo.ToTitleCase(lastName.ToLower())

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblUsers(firstName, lastName, phoneNumber, userName, password, securityAnswer, securityQuestion, roleID) 
                                                 VALUES (@firstName, @lastName, @phoneNumber, @userName, @password, @answer, @question, @roleID)", connection)
                    With command.Parameters
                        .AddWithValue("@firstName", capitalizedFirstName)
                        .AddWithValue("@lastName", capitalizedLastName)
                        .AddWithValue("@phoneNumber", phoneNumber)
                        .AddWithValue("@userName", userName)
                        .AddWithValue("@password", password)
                        .AddWithValue("@answer", answer)
                        .AddWithValue("@question", question)
                        .AddWithValue("@roleID", roleID)
                    End With
                    command.ExecuteNonQuery()
                    MessageBox.Show($"{capitalizedFirstName} {capitalizedLastName} added as {roleName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmAddUsers.Close()
                    UserDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Some fields are duplicated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show("Supplier already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show("Supplier already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    '    Public Sub DeleteSuppliers(supplierID As Integer)
    '        Using connection As SqlConnection = ConnectionOpen(connString)

    '            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblCopies WHERE supplierID = @supplierID", connection)
    '                checkCommand.Parameters.AddWithValue("@supplierID", supplierID)
    '                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

    '                If count > 0 Then
    '                    MessageBox.Show("Supplier cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Else
    '                    Using command As New SqlCommand("DELETE FROM tblSuppliers WHERE supplierID = @supplierID", connection)
    '                        command.Parameters.AddWithValue("@supplierID", supplierID)
    '                        command.ExecuteNonQuery()
    '                        MessageBox.Show("Supplier has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        SupplierDatatable()
    '                    End Using
    '                End If
    '            End Using
    '        End Using
    '    End Sub

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
    'Public Sub DeleteAuthors(authorID As Integer)
    '    Using connection As MySqlConnection = ConnectionOpen(connString)

    '        Using checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblBooks WHERE authorID = @authorID", connection)
    '            checkCommand.Parameters.AddWithValue("@authorID", authorID)
    '            Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

    '            If count > 0 Then
    '                MessageBox.Show("Author cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Else
    '                Using command As New MySqlCommand("DELETE FROM tblAuthors WHERE authorID = @authorID", connection)
    '                    command.Parameters.AddWithValue("@authorID", authorID)
    '                    command.ExecuteNonQuery()
    '                    MessageBox.Show("Author has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    AuthorDatatable()
    '                End Using
    '            End If
    '        End Using
    '    End Using
    'End Sub

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

    '    Public Sub DeletePublisher(publisherID As Integer)
    '        Using connection As SqlConnection = ConnectionOpen(connString)

    '            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblBooks WHERE publisherID = @publisherID", connection)
    '                checkCommand.Parameters.AddWithValue("@publisherID", publisherID)
    '                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

    '                If count > 0 Then
    '                    MessageBox.Show("Publisher cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Else
    '                    Using command As New SqlCommand("DELETE FROM tblPublishers WHERE publisherID = @publisherID", connection)
    '                        command.Parameters.AddWithValue("@publisherID", publisherID)
    '                        command.ExecuteNonQuery()
    '                        MessageBox.Show("Publisher has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '                        PublisherDatatable()
    '                    End Using
    '                End If
    '            End Using
    '        End Using
    '    End Sub

#End Region

#Region "Genres"

    Public Sub GenreDatatable()
        Dim dtGenre As DataTable = DisplayAlphabeticalData("tblgenres", "genreName")
        frmMainte.dgGenres.DataSource = dtGenre
    End Sub

    'ADD GENRE
    Public Sub AddGenre(genreName As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedGenreName As String = textInfo.ToTitleCase(genreName.ToLower())
        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblGenres(genreName) VALUES (@genreName)", connection)
                    command.Parameters.AddWithValue("@genreName", capitalizedGenreName)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Genre added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GenreDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Genre already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Try
    End Sub

    Public Sub UpdateGenre(genreID As Integer, genreName As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedGenre As String = textInfo.ToTitleCase(genreName.ToLower)

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("UPDATE tblgenres SET genreName = @genreName 
                                                     WHERE genreID = @genreID", connection)
                    command.Parameters.AddWithValue("@genreID", genreID)
                    command.Parameters.AddWithValue("@genreName", capitalizedGenre)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Genre updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GenreDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Genre name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Try
    End Sub

    '    Public Sub DeleteGenre(genreID As Integer)
    '        Using connection As SqlConnection = ConnectionOpen(connString)

    '            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblBooks WHERE genreID = @genreID", connection)
    '                checkCommand.Parameters.AddWithValue("@genreID", genreID)
    '                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

    '                If count > 0 Then
    '                    MessageBox.Show("Genre cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Else
    '                    Using command As New SqlCommand("DELETE FROM tblGenres WHERE genreID = @genreID", connection)
    '                        command.Parameters.AddWithValue("@genreID", genreID)
    '                        command.ExecuteNonQuery()
    '                        MessageBox.Show("Genre has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '                        GenreDatatable()
    '                    End Using
    '                End If
    '            End Using
    '        End Using
    '    End Sub
#End Region

#Region "Bookshelves"

    Public Sub ShelfDatatable()
        Dim dtShelf As DataTable = DisplayAlphabeticalData("tblBookshelves", "shelfNo")
        frmMainte.dgBookshelves.DataSource = dtShelf
    End Sub

    Public Sub AddBookshelves(shelfNo As String, description As String, location As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedDescription As String = textInfo.ToTitleCase(description.ToLower())
        Dim capitalizedLocation As String = textInfo.ToTitleCase(location.ToLower())

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblBookshelves(shelfNo, description, location) 
                                                     VALUES(@shelfNo, @description, @location)", connection)
                    With command.Parameters
                        .AddWithValue("@shelfNo", shelfNo)
                        .AddWithValue("@description", capitalizedDescription)
                        .AddWithValue("@location", capitalizedLocation)
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

    Public Sub UpdateBookshelf(shelfID As Integer, description As String, location As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedlocation As String = textInfo.ToTitleCase(location.ToLower)
        Dim capitalizedDescription As String = textInfo.ToTitleCase(description.ToLower)

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("UPDATE tblBookshelves SET description = @description,
                                                                               location = @location     
                                                     WHERE shelfID = @shelfID", connection)
                    command.Parameters.AddWithValue("@shelfID", shelfID)
                    command.Parameters.AddWithValue("@description", capitalizedDescription)
                    command.Parameters.AddWithValue("@location", capitalizedlocation)
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

    '    Public Sub DeleteShelf(shelfID As Integer)
    '        Using connection As SqlConnection = ConnectionOpen(connString)

    '            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblBooks WHERE shelfID = @shelfID", connection)
    '                checkCommand.Parameters.AddWithValue("@shelfID", shelfID)
    '                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

    '                If count > 0 Then
    '                    MessageBox.Show("Shelf cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Else
    '                    Using command As New SqlCommand("DELETE FROM tblBookshelves WHERE shelfID = @shelfID", connection)
    '                        command.Parameters.AddWithValue("@shelfID", shelfID)
    '                        command.ExecuteNonQuery()
    '                        MessageBox.Show("Shelf has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '                        ShelfDatatable()
    '                    End Using
    '                End If
    '            End Using
    '        End Using
    '    End Sub
#End Region

#Region "Borrow Maintenance"
    'Public Sub ConfigDueDate(interval As Integer)
    '    Using connection As MySqlConnection = ConnectionOpen()
    '    End Using
    'End Sub
#End Region
End Module
