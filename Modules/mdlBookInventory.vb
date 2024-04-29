Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Globalization

Module mdlBookInventory

#Region "Book Inventory"
    Public Function DisplayBooks() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT b.bookID, b.bookTitle, b.isbn, b.yearPublished, 
                                                      a.authorName,
                                                      p.publisherName, 
                                                      s.shelfNo, s.shelfID 
                                               FROM tblBooks b 
                                               INNER JOIN tblAuthors a ON b.authorID = a.authorID
                                               INNER JOIN tblPublishers p ON b.publisherID = p.publisherID
                                               INNER JOIN tblBookshelves s ON b.shelfID = s.shelfID
                                               LEFT JOIN tblCopies c ON b.bookID = c.bookID
                                               GROUP BY b.bookID, b.bookTitle, b.isbn, b.yearPublished,
                                                        a.authorName,
                                                        p.publisherName, 
                                                        s.shelfNo, s.shelfID", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function DisplayCopies() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT b.bookID, b.bookTitle, b.isbn,
                                                a.authorName,
                                                COUNT(c.copyID) AS totalCopies,
                                                SUM(CASE WHEN c.status = 'Available' THEN 1 ELSE 0 END) AS availableCopies,
                                                SUM(CASE WHEN c.status = 'Borrowed' THEN 1 ELSE 0 END) AS borrowedCopies
                                             FROM tblBooks b 
                                             INNER JOIN tblAuthors a ON b.authorID = a.authorID
                                             INNER JOIN tblPublishers p ON b.publisherID = p.publisherID
                                             LEFT JOIN tblCopies c ON b.bookID = c.bookID
                                             GROUP BY b.bookID, b.bookTitle, b.isbn, b.yearPublished,
                                                      a.authorName,
                                                      p.publisherName 
                                             HAVING COUNT(c.copyID) > 0", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function AddBooks(isbn As String, title As String, authorID As Integer, publisherID As Integer, yearPublished As String, shelfID As Integer) As Integer
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedTitle As String = textInfo.ToTitleCase(title.ToLower())

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblBooks (bookTitle, isbn, authorID, publisherID, yearPublished, shelfID) 
                                                   VALUES (@title, @isbn, @authorID, @publisherID, @yearPublished, @shelfID);
                                                   SELECT LAST_INSERT_ID();", connection)
                    With command.Parameters
                        .AddWithValue("@title", capitalizedTitle)
                        .AddWithValue("@isbn", isbn)
                        .AddWithValue("@authorID", authorID)
                        .AddWithValue("@publisherID", publisherID)
                        .AddWithValue("@yearPublished", yearPublished)
                        .AddWithValue("@shelfID", shelfID)
                    End With
                    Dim bookID As Integer = Convert.ToInt32(command.ExecuteScalar())
                    MessageBox.Show("Book has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim dtBooks As DataTable = DisplayBooks()
                    frmBookInventory.dgBooksMainte.DataSource = dtBooks
                    Dim dtCopies As DataTable = DisplayCopies()
                    frmBookInventory.dgCopies.DataSource = dtCopies
                    Return bookID
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Some fields are duplicated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return -1
        End Try
    End Function


    Public Function AccessionGenerator() As String
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("UPDATE tblAccessionGenerator SET AccessionSequence = AccessionSequence + 1; 
                                                 SELECT AccessionSequence FROM tblAccessionGenerator", connection)
                Dim acs As Integer = CInt(command.ExecuteScalar())
                Dim formatted As String = String.Format("ACN-{0:D5}", acs)
                Return formatted
            End Using
        End Using
    End Function

    Public Sub AddInitialCopies(accessionNo As String, bookID As Integer)
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("INSERT INTO tblCopies (accessionNo, bookID, acquisitionDate, status) 
                                                 VALUES (@accessionNo, @bookID, NOW(), 'Available')", connection)
                With command.Parameters
                    .AddWithValue("@accessionNo", accessionNo)
                    .AddWithValue("@bookID", bookID)
                End With
                command.ExecuteNonQuery()

                Dim dtBooks As DataTable = DisplayBooks()
                frmBookInventory.dgBooksMainte.DataSource = dtBooks
                Dim dtCopies As DataTable = DisplayCopies()
                frmBookInventory.dgCopies.DataSource = dtCopies
            End Using
        End Using
    End Sub

    Public Function DisplayShelves() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT shelfID, shelfNo FROM tblBookshelves", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function


    Public Sub SearchAuthors(datagridview As DataGridView, search As String)
        Using connection As MySqlConnection = ConnectionOpen()
            Dim query As String = "SELECT authorName, authorID FROM tblAuthors "

            If Not String.IsNullOrEmpty(search) Then
                query += " WHERE authorName LIKE @search"
            End If

            Using command As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(search) Then
                    command.Parameters.AddWithValue("@search", "%" & search & "%")
                End If

                Using adapter As New MySqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(ds)
                    datagridview.DataSource = ds.Tables(0)
                End Using
            End Using
        End Using
    End Sub

    Public Sub SearchPublishers(datagridview As DataGridView, search As String)
        Using connection As MySqlConnection = ConnectionOpen()
            Dim query As String = "SELECT publisherName, publisherID FROM tblPublishers "

            If Not String.IsNullOrEmpty(search) Then
                query += " WHERE publisherName LIKE @search OR publisherID LIKE @search"
            End If

            Using command As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(search) Then
                    command.Parameters.AddWithValue("@search", "%" & search & "%")
                End If

                Using adapter As New MySqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(ds)
                    datagridview.DataSource = ds.Tables(0)
                End Using
            End Using
        End Using
    End Sub

    Public Function GetAuthorIDFunction(authorName As String) As Integer
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT authorID FROM tblAuthors WHERE authorName = @authorName", connection)
                command.Parameters.AddWithValue("@authorName", authorName)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function GetPublisherIDFunction(publisherName As String) As Integer
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT publisherID FROM tblPublishers WHERE publisherName = @publisherName", connection)
                command.Parameters.AddWithValue("@publisherName", publisherName)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Sub UpdateBook(authorID As Integer, bookID As Integer, bookTitle As String, isbn As String, publisherID As Integer, shelfID As Integer, yearPublished As Integer)
        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("UPDATE tblBooks SET authorID = @authorID, 
                                                               bookTitle = @bookTitle, 
                                                               isbn = @isbn, 
                                                               publisherID = @publisherID, 
                                                               shelfID = @shelfID, 
                                                               yearPublished = @yearPublished
                                                           WHERE bookID = @bookID", connection)
                    With command.Parameters
                        .AddWithValue("@authorID", authorID)
                        .AddWithValue("@bookTitle", bookTitle)
                        .AddWithValue("@isbn", isbn)
                        .AddWithValue("@publisherID", publisherID)
                        .AddWithValue("@shelfID", shelfID)
                        .AddWithValue("@yearPublished", yearPublished)
                        .AddWithValue("@bookID", bookID)
                    End With
                    command.ExecuteNonQuery()
                    MessageBox.Show("Book has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim dtBooks As DataTable = DisplayBooks()
                    frmBookInventory.dgBooksMainte.DataSource = dtBooks
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Some fields are duplicated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

#End Region

#Region "Copies Inventory"
    Public Function GetBookTitle(isbn As String) As String

        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT bookTitle FROM tblBooks WHERE isbn = @isbn", connection)
                command.Parameters.AddWithValue("@isbn", isbn)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Return reader.GetString(0)
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function

    Public Function GetBookID(isbn As String) As Integer
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT bookID FROM tblBooks WHERE isbn = @isbn", connection)
                command.Parameters.AddWithValue("@isbn", isbn)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Return reader.GetInt32(0)
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function

    Public Function DisplaySuppliers() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT supplierName, supplierID FROM tblSuppliers WHERE type = 'Supplier'", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function DisplayDonator() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT supplierName, supplierID FROM tblSuppliers WHERE type = 'Donator'", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Sub AddCopies(accessionNo As String, bookID As Integer, supplierID As Integer, price As Decimal, acquisitionType As String)
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("INSERT INTO tblCopies (accessionNo, bookID, supplierID, price, status, acquisitionType, acquisitionDate) 
                                                 VALUES (@accessionNo, @bookID, @supplierID, @price, 'Available', @acquisitionType, NOW())", connection)
                With command.Parameters
                    .AddWithValue("@accessionNo", accessionNo)
                    .AddWithValue("@bookID", bookID)
                    .AddWithValue("@supplierID", supplierID)
                    .AddWithValue("@price", price)
                    .AddWithValue("@acquisitionType", acquisitionType)
                End With
                command.ExecuteNonQuery()

                Dim dtCopies As DataTable = DisplayCopies()
                frmBookInventory.dgCopies.DataSource = dtCopies

                Dim dtBooks As DataTable = DisplayBooks()
                frmBookInventory.dgBooksMainte.DataSource = dtBooks
            End Using
        End Using
    End Sub

    '    Public Sub SearchSuppliers(datagridview As DataGridView, search As String)
    '        Using connection As SqlConnection = ConnectionOpen(connString)
    '            Dim query As String = "SELECT supplierName, supplierID FROM tblSuppliers "

    '            If Not String.IsNullOrEmpty(search) Then
    '                query += " WHERE supplierName LIKE @search"
    '            End If

    '            Using command As New SqlCommand(query, connection)
    '                If Not String.IsNullOrEmpty(search) Then
    '                    command.Parameters.AddWithValue("@search", "%" & search & "%")
    '                End If

    '                Using adapter As New SqlDataAdapter(command)
    '                    Dim ds As New DataSet
    '                    adapter.Fill(ds)
    '                    datagridview.DataSource = ds.Tables(0)
    '                End Using
    '            End Using
    '        End Using
    '    End Sub
#End Region
End Module

