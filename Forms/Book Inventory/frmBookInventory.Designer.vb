<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.tabBookMaintenance = New System.Windows.Forms.TabPage()
        Me.dgBooksMainte = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAddBook = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tabBookInventory = New System.Windows.Forms.TabPage()
        Me.dgCopies = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.bookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.authorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.availableCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowedCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.distinctBookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distinctISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distinctTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distinctAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distinctPublisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearPublished = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genreName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shelfNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genreID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shelfID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2TabControl1.SuspendLayout()
        Me.tabBookMaintenance.SuspendLayout()
        CType(Me.dgBooksMainte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tabBookInventory.SuspendLayout()
        CType(Me.dgCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.tabBookMaintenance)
        Me.Guna2TabControl1.Controls.Add(Me.tabBookInventory)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1598, 998)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 1
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'tabBookMaintenance
        '
        Me.tabBookMaintenance.Controls.Add(Me.dgBooksMainte)
        Me.tabBookMaintenance.Controls.Add(Me.Panel1)
        Me.tabBookMaintenance.Location = New System.Drawing.Point(4, 44)
        Me.tabBookMaintenance.Name = "tabBookMaintenance"
        Me.tabBookMaintenance.Size = New System.Drawing.Size(1590, 950)
        Me.tabBookMaintenance.TabIndex = 0
        Me.tabBookMaintenance.Text = "Book Maintenance"
        Me.tabBookMaintenance.UseVisualStyleBackColor = True
        '
        'dgBooksMainte
        '
        Me.dgBooksMainte.AllowUserToAddRows = False
        Me.dgBooksMainte.AllowUserToDeleteRows = False
        Me.dgBooksMainte.AllowUserToResizeColumns = False
        Me.dgBooksMainte.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgBooksMainte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgBooksMainte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBooksMainte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgBooksMainte.ColumnHeadersHeight = 40
        Me.dgBooksMainte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.distinctBookID, Me.distinctISBN, Me.distinctTitle, Me.distinctAuthor, Me.distinctPublisher, Me.yearPublished, Me.genreName, Me.shelfNo, Me.genreID, Me.shelfID})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgBooksMainte.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgBooksMainte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBooksMainte.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBooksMainte.Location = New System.Drawing.Point(0, 50)
        Me.dgBooksMainte.MultiSelect = False
        Me.dgBooksMainte.Name = "dgBooksMainte"
        Me.dgBooksMainte.ReadOnly = True
        Me.dgBooksMainte.RowHeadersVisible = False
        Me.dgBooksMainte.RowHeadersWidth = 51
        Me.dgBooksMainte.RowTemplate.Height = 24
        Me.dgBooksMainte.Size = New System.Drawing.Size(1590, 900)
        Me.dgBooksMainte.TabIndex = 3
        Me.dgBooksMainte.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgBooksMainte.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgBooksMainte.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgBooksMainte.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgBooksMainte.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgBooksMainte.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgBooksMainte.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBooksMainte.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBooksMainte.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgBooksMainte.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBooksMainte.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgBooksMainte.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgBooksMainte.ThemeStyle.HeaderStyle.Height = 40
        Me.dgBooksMainte.ThemeStyle.ReadOnly = True
        Me.dgBooksMainte.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgBooksMainte.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgBooksMainte.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBooksMainte.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgBooksMainte.ThemeStyle.RowsStyle.Height = 24
        Me.dgBooksMainte.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBooksMainte.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAddBook)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1590, 50)
        Me.Panel1.TabIndex = 2
        '
        'btnAddBook
        '
        Me.btnAddBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddBook.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddBook.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddBook.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddBook.ForeColor = System.Drawing.Color.White
        Me.btnAddBook.Location = New System.Drawing.Point(1355, 0)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(235, 45)
        Me.btnAddBook.TabIndex = 1
        Me.btnAddBook.Text = "ADD BOOK"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1590, 5)
        Me.Panel2.TabIndex = 0
        '
        'tabBookInventory
        '
        Me.tabBookInventory.Controls.Add(Me.dgCopies)
        Me.tabBookInventory.Controls.Add(Me.Panel3)
        Me.tabBookInventory.Location = New System.Drawing.Point(4, 44)
        Me.tabBookInventory.Name = "tabBookInventory"
        Me.tabBookInventory.Size = New System.Drawing.Size(1590, 950)
        Me.tabBookInventory.TabIndex = 1
        Me.tabBookInventory.Text = "Book Inventory"
        Me.tabBookInventory.UseVisualStyleBackColor = True
        '
        'dgCopies
        '
        Me.dgCopies.AllowUserToAddRows = False
        Me.dgCopies.AllowUserToDeleteRows = False
        Me.dgCopies.AllowUserToResizeColumns = False
        Me.dgCopies.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgCopies.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgCopies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCopies.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgCopies.ColumnHeadersHeight = 40
        Me.dgCopies.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bookID, Me.bookTitle, Me.ISBN, Me.authorName, Me.totalCopies, Me.availableCopies, Me.borrowedCopies})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCopies.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgCopies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCopies.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCopies.Location = New System.Drawing.Point(0, 50)
        Me.dgCopies.MultiSelect = False
        Me.dgCopies.Name = "dgCopies"
        Me.dgCopies.RowHeadersVisible = False
        Me.dgCopies.RowHeadersWidth = 51
        Me.dgCopies.RowTemplate.Height = 24
        Me.dgCopies.Size = New System.Drawing.Size(1590, 900)
        Me.dgCopies.TabIndex = 4
        Me.dgCopies.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgCopies.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgCopies.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgCopies.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgCopies.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgCopies.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgCopies.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCopies.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCopies.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgCopies.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCopies.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgCopies.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgCopies.ThemeStyle.HeaderStyle.Height = 40
        Me.dgCopies.ThemeStyle.ReadOnly = False
        Me.dgCopies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgCopies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgCopies.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCopies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgCopies.ThemeStyle.RowsStyle.Height = 24
        Me.dgCopies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCopies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'bookID
        '
        Me.bookID.DataPropertyName = "bookID"
        Me.bookID.HeaderText = "Book ID"
        Me.bookID.MinimumWidth = 6
        Me.bookID.Name = "bookID"
        Me.bookID.ReadOnly = True
        Me.bookID.Visible = False
        '
        'bookTitle
        '
        Me.bookTitle.DataPropertyName = "bookTitle"
        Me.bookTitle.HeaderText = "Title"
        Me.bookTitle.MinimumWidth = 6
        Me.bookTitle.Name = "bookTitle"
        Me.bookTitle.ReadOnly = True
        '
        'ISBN
        '
        Me.ISBN.DataPropertyName = "isbn"
        Me.ISBN.HeaderText = "ISBN"
        Me.ISBN.MinimumWidth = 6
        Me.ISBN.Name = "ISBN"
        Me.ISBN.ReadOnly = True
        Me.ISBN.Visible = False
        '
        'authorName
        '
        Me.authorName.DataPropertyName = "authorName"
        Me.authorName.HeaderText = "Authors"
        Me.authorName.MinimumWidth = 6
        Me.authorName.Name = "authorName"
        Me.authorName.ReadOnly = True
        '
        'totalCopies
        '
        Me.totalCopies.DataPropertyName = "totalCopies"
        Me.totalCopies.HeaderText = "Total Copies"
        Me.totalCopies.MinimumWidth = 6
        Me.totalCopies.Name = "totalCopies"
        Me.totalCopies.ReadOnly = True
        '
        'availableCopies
        '
        Me.availableCopies.DataPropertyName = "availableCopies"
        Me.availableCopies.HeaderText = "Available"
        Me.availableCopies.MinimumWidth = 6
        Me.availableCopies.Name = "availableCopies"
        Me.availableCopies.ReadOnly = True
        '
        'borrowedCopies
        '
        Me.borrowedCopies.DataPropertyName = "borrowedCopies"
        Me.borrowedCopies.HeaderText = "Borrowed"
        Me.borrowedCopies.MinimumWidth = 6
        Me.borrowedCopies.Name = "borrowedCopies"
        Me.borrowedCopies.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Guna2Button1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1590, 50)
        Me.Panel3.TabIndex = 3
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(1355, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(235, 45)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "ADD COPIES"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 45)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1590, 5)
        Me.Panel4.TabIndex = 0
        '
        'distinctBookID
        '
        Me.distinctBookID.DataPropertyName = "bookID"
        Me.distinctBookID.HeaderText = "Book ID"
        Me.distinctBookID.MinimumWidth = 6
        Me.distinctBookID.Name = "distinctBookID"
        Me.distinctBookID.ReadOnly = True
        '
        'distinctISBN
        '
        Me.distinctISBN.DataPropertyName = "isbn"
        Me.distinctISBN.HeaderText = "ISBN"
        Me.distinctISBN.MinimumWidth = 6
        Me.distinctISBN.Name = "distinctISBN"
        Me.distinctISBN.ReadOnly = True
        '
        'distinctTitle
        '
        Me.distinctTitle.DataPropertyName = "bookTitle"
        Me.distinctTitle.HeaderText = "Title"
        Me.distinctTitle.MinimumWidth = 6
        Me.distinctTitle.Name = "distinctTitle"
        Me.distinctTitle.ReadOnly = True
        '
        'distinctAuthor
        '
        Me.distinctAuthor.DataPropertyName = "authorName"
        Me.distinctAuthor.HeaderText = "Authors"
        Me.distinctAuthor.MinimumWidth = 6
        Me.distinctAuthor.Name = "distinctAuthor"
        Me.distinctAuthor.ReadOnly = True
        '
        'distinctPublisher
        '
        Me.distinctPublisher.DataPropertyName = "publisherName"
        Me.distinctPublisher.HeaderText = "Publisher"
        Me.distinctPublisher.MinimumWidth = 6
        Me.distinctPublisher.Name = "distinctPublisher"
        Me.distinctPublisher.ReadOnly = True
        '
        'yearPublished
        '
        Me.yearPublished.DataPropertyName = "yearPublished"
        Me.yearPublished.HeaderText = "Year Published"
        Me.yearPublished.MinimumWidth = 6
        Me.yearPublished.Name = "yearPublished"
        Me.yearPublished.ReadOnly = True
        '
        'genreName
        '
        Me.genreName.DataPropertyName = "genreName"
        Me.genreName.HeaderText = "Genre"
        Me.genreName.MinimumWidth = 6
        Me.genreName.Name = "genreName"
        Me.genreName.ReadOnly = True
        '
        'shelfNo
        '
        Me.shelfNo.DataPropertyName = "shelfNo"
        Me.shelfNo.HeaderText = "Shelf No."
        Me.shelfNo.MinimumWidth = 6
        Me.shelfNo.Name = "shelfNo"
        Me.shelfNo.ReadOnly = True
        Me.shelfNo.Visible = False
        '
        'genreID
        '
        Me.genreID.DataPropertyName = "genreID"
        Me.genreID.HeaderText = "genreID"
        Me.genreID.MinimumWidth = 6
        Me.genreID.Name = "genreID"
        Me.genreID.ReadOnly = True
        Me.genreID.Visible = False
        '
        'shelfID
        '
        Me.shelfID.DataPropertyName = "shelfID"
        Me.shelfID.HeaderText = "shelfID"
        Me.shelfID.MinimumWidth = 6
        Me.shelfID.Name = "shelfID"
        Me.shelfID.ReadOnly = True
        Me.shelfID.Visible = False
        '
        'frmBookInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1598, 998)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBookInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.tabBookMaintenance.ResumeLayout(False)
        CType(Me.dgBooksMainte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.tabBookInventory.ResumeLayout(False)
        CType(Me.dgCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tabBookMaintenance As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddBook As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgBooksMainte As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgCopies As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tabBookInventory As TabPage
    Friend WithEvents bookID As DataGridViewTextBoxColumn
    Friend WithEvents bookTitle As DataGridViewTextBoxColumn
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents authorName As DataGridViewTextBoxColumn
    Friend WithEvents totalCopies As DataGridViewTextBoxColumn
    Friend WithEvents availableCopies As DataGridViewTextBoxColumn
    Friend WithEvents borrowedCopies As DataGridViewTextBoxColumn
    Friend WithEvents distinctBookID As DataGridViewTextBoxColumn
    Friend WithEvents distinctISBN As DataGridViewTextBoxColumn
    Friend WithEvents distinctTitle As DataGridViewTextBoxColumn
    Friend WithEvents distinctAuthor As DataGridViewTextBoxColumn
    Friend WithEvents distinctPublisher As DataGridViewTextBoxColumn
    Friend WithEvents yearPublished As DataGridViewTextBoxColumn
    Friend WithEvents genreName As DataGridViewTextBoxColumn
    Friend WithEvents shelfNo As DataGridViewTextBoxColumn
    Friend WithEvents genreID As DataGridViewTextBoxColumn
    Friend WithEvents shelfID As DataGridViewTextBoxColumn
End Class
