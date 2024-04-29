<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssueReturn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.tabBorrow = New System.Windows.Forms.TabPage()
        Me.dgBorrowed = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.borrowedID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.copyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.authorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowerType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAddBook = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tabPullout = New System.Windows.Forms.TabPage()
        Me.dgPullout = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.borrowID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pullOutFullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penalty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.returnStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2TabControl1.SuspendLayout()
        Me.tabBorrow.SuspendLayout()
        CType(Me.dgBorrowed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tabPullout.SuspendLayout()
        CType(Me.dgPullout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.tabBorrow)
        Me.Guna2TabControl1.Controls.Add(Me.tabPullout)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1598, 798)
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
        'tabBorrow
        '
        Me.tabBorrow.Controls.Add(Me.dgBorrowed)
        Me.tabBorrow.Controls.Add(Me.Panel1)
        Me.tabBorrow.Location = New System.Drawing.Point(4, 44)
        Me.tabBorrow.Name = "tabBorrow"
        Me.tabBorrow.Size = New System.Drawing.Size(1590, 750)
        Me.tabBorrow.TabIndex = 0
        Me.tabBorrow.Text = "Borrow"
        Me.tabBorrow.UseVisualStyleBackColor = True
        '
        'dgBorrowed
        '
        Me.dgBorrowed.AllowUserToAddRows = False
        Me.dgBorrowed.AllowUserToDeleteRows = False
        Me.dgBorrowed.AllowUserToResizeColumns = False
        Me.dgBorrowed.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgBorrowed.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBorrowed.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgBorrowed.ColumnHeadersHeight = 40
        Me.dgBorrowed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.borrowedID, Me.acn, Me.ISBN, Me.firstName, Me.lastName, Me.studentID, Me.copyID, Me.borrowerID, Me.bookTitle, Me.authorName, Me.fullName, Me.dateBorrowed, Me.dueDate, Me.borrowerType})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgBorrowed.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgBorrowed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBorrowed.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBorrowed.Location = New System.Drawing.Point(0, 50)
        Me.dgBorrowed.MultiSelect = False
        Me.dgBorrowed.Name = "dgBorrowed"
        Me.dgBorrowed.ReadOnly = True
        Me.dgBorrowed.RowHeadersVisible = False
        Me.dgBorrowed.RowHeadersWidth = 51
        Me.dgBorrowed.RowTemplate.Height = 24
        Me.dgBorrowed.Size = New System.Drawing.Size(1590, 700)
        Me.dgBorrowed.TabIndex = 4
        Me.dgBorrowed.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgBorrowed.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgBorrowed.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgBorrowed.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgBorrowed.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgBorrowed.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgBorrowed.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBorrowed.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBorrowed.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgBorrowed.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBorrowed.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgBorrowed.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgBorrowed.ThemeStyle.HeaderStyle.Height = 40
        Me.dgBorrowed.ThemeStyle.ReadOnly = True
        Me.dgBorrowed.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgBorrowed.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgBorrowed.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBorrowed.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgBorrowed.ThemeStyle.RowsStyle.Height = 24
        Me.dgBorrowed.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBorrowed.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'borrowedID
        '
        Me.borrowedID.DataPropertyName = "borrowID"
        Me.borrowedID.HeaderText = "Borrowed ID"
        Me.borrowedID.MinimumWidth = 6
        Me.borrowedID.Name = "borrowedID"
        Me.borrowedID.ReadOnly = True
        Me.borrowedID.Visible = False
        '
        'acn
        '
        Me.acn.DataPropertyName = "accessionNo"
        Me.acn.HeaderText = "Accession No."
        Me.acn.MinimumWidth = 6
        Me.acn.Name = "acn"
        Me.acn.ReadOnly = True
        Me.acn.Visible = False
        '
        'ISBN
        '
        Me.ISBN.DataPropertyName = "isbn"
        Me.ISBN.HeaderText = "ISBN"
        Me.ISBN.MinimumWidth = 6
        Me.ISBN.Name = "ISBN"
        Me.ISBN.ReadOnly = True
        '
        'firstName
        '
        Me.firstName.DataPropertyName = "firstName"
        Me.firstName.HeaderText = "Firstname"
        Me.firstName.MinimumWidth = 6
        Me.firstName.Name = "firstName"
        Me.firstName.ReadOnly = True
        Me.firstName.Visible = False
        '
        'lastName
        '
        Me.lastName.DataPropertyName = "lastName"
        Me.lastName.HeaderText = "Lastname"
        Me.lastName.MinimumWidth = 6
        Me.lastName.Name = "lastName"
        Me.lastName.ReadOnly = True
        Me.lastName.Visible = False
        '
        'studentID
        '
        Me.studentID.DataPropertyName = "studentID"
        Me.studentID.HeaderText = "StudentID"
        Me.studentID.MinimumWidth = 6
        Me.studentID.Name = "studentID"
        Me.studentID.ReadOnly = True
        '
        'copyID
        '
        Me.copyID.DataPropertyName = "copyID"
        Me.copyID.HeaderText = "Copy ID"
        Me.copyID.MinimumWidth = 6
        Me.copyID.Name = "copyID"
        Me.copyID.ReadOnly = True
        Me.copyID.Visible = False
        '
        'borrowerID
        '
        Me.borrowerID.DataPropertyName = "borrowerID"
        Me.borrowerID.HeaderText = "Borrower ID"
        Me.borrowerID.MinimumWidth = 6
        Me.borrowerID.Name = "borrowerID"
        Me.borrowerID.ReadOnly = True
        Me.borrowerID.Visible = False
        '
        'bookTitle
        '
        Me.bookTitle.DataPropertyName = "bookTitle"
        Me.bookTitle.HeaderText = "Title"
        Me.bookTitle.MinimumWidth = 6
        Me.bookTitle.Name = "bookTitle"
        Me.bookTitle.ReadOnly = True
        '
        'authorName
        '
        Me.authorName.DataPropertyName = "authorName"
        Me.authorName.HeaderText = "Author"
        Me.authorName.MinimumWidth = 6
        Me.authorName.Name = "authorName"
        Me.authorName.ReadOnly = True
        Me.authorName.Visible = False
        '
        'fullName
        '
        Me.fullName.DataPropertyName = "FullName"
        Me.fullName.HeaderText = "Borrower"
        Me.fullName.MinimumWidth = 6
        Me.fullName.Name = "fullName"
        Me.fullName.ReadOnly = True
        '
        'dateBorrowed
        '
        Me.dateBorrowed.DataPropertyName = "dateBorrowed"
        DataGridViewCellStyle3.Format = "MMMM dd yyyy"
        Me.dateBorrowed.DefaultCellStyle = DataGridViewCellStyle3
        Me.dateBorrowed.HeaderText = "Date Borrowed"
        Me.dateBorrowed.MinimumWidth = 6
        Me.dateBorrowed.Name = "dateBorrowed"
        Me.dateBorrowed.ReadOnly = True
        '
        'dueDate
        '
        Me.dueDate.DataPropertyName = "dueDate"
        DataGridViewCellStyle4.Format = "MMMM dd yyyy"
        Me.dueDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.dueDate.HeaderText = "Due Date"
        Me.dueDate.MinimumWidth = 6
        Me.dueDate.Name = "dueDate"
        Me.dueDate.ReadOnly = True
        '
        'borrowerType
        '
        Me.borrowerType.DataPropertyName = "borrowerType"
        Me.borrowerType.HeaderText = "Borrower Type"
        Me.borrowerType.MinimumWidth = 6
        Me.borrowerType.Name = "borrowerType"
        Me.borrowerType.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAddBook)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1590, 50)
        Me.Panel1.TabIndex = 3
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
        Me.btnAddBook.Text = "BORROW"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1590, 5)
        Me.Panel2.TabIndex = 0
        '
        'tabPullout
        '
        Me.tabPullout.Controls.Add(Me.dgPullout)
        Me.tabPullout.Location = New System.Drawing.Point(4, 44)
        Me.tabPullout.Name = "tabPullout"
        Me.tabPullout.Size = New System.Drawing.Size(1590, 750)
        Me.tabPullout.TabIndex = 2
        Me.tabPullout.Text = "Pullout"
        Me.tabPullout.UseVisualStyleBackColor = True
        '
        'dgPullout
        '
        Me.dgPullout.AllowUserToAddRows = False
        Me.dgPullout.AllowUserToDeleteRows = False
        Me.dgPullout.AllowUserToResizeColumns = False
        Me.dgPullout.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.dgPullout.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgPullout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPullout.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgPullout.ColumnHeadersHeight = 40
        Me.dgPullout.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.borrowID, Me.DataGridViewTextBoxColumn6, Me.pullOutFullname, Me.status, Me.penalty, Me.returnStatus})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPullout.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgPullout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPullout.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgPullout.Location = New System.Drawing.Point(0, 0)
        Me.dgPullout.MultiSelect = False
        Me.dgPullout.Name = "dgPullout"
        Me.dgPullout.RowHeadersVisible = False
        Me.dgPullout.RowHeadersWidth = 51
        Me.dgPullout.RowTemplate.Height = 24
        Me.dgPullout.Size = New System.Drawing.Size(1590, 750)
        Me.dgPullout.TabIndex = 6
        Me.dgPullout.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgPullout.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgPullout.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgPullout.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgPullout.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgPullout.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgPullout.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgPullout.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgPullout.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgPullout.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPullout.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgPullout.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPullout.ThemeStyle.HeaderStyle.Height = 40
        Me.dgPullout.ThemeStyle.ReadOnly = False
        Me.dgPullout.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgPullout.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgPullout.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPullout.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgPullout.ThemeStyle.RowsStyle.Height = 24
        Me.dgPullout.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgPullout.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'borrowID
        '
        Me.borrowID.DataPropertyName = "borrowID"
        Me.borrowID.HeaderText = "Borrow ID"
        Me.borrowID.MinimumWidth = 6
        Me.borrowID.Name = "borrowID"
        Me.borrowID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "bookTitle"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'pullOutFullname
        '
        Me.pullOutFullname.DataPropertyName = "fullName"
        Me.pullOutFullname.HeaderText = "Borrower"
        Me.pullOutFullname.MinimumWidth = 6
        Me.pullOutFullname.Name = "pullOutFullname"
        Me.pullOutFullname.ReadOnly = True
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'penalty
        '
        Me.penalty.DataPropertyName = "penalty"
        Me.penalty.HeaderText = "Penalty"
        Me.penalty.MinimumWidth = 6
        Me.penalty.Name = "penalty"
        '
        'returnStatus
        '
        Me.returnStatus.DataPropertyName = "returnStatus"
        Me.returnStatus.HeaderText = ""
        Me.returnStatus.MinimumWidth = 6
        Me.returnStatus.Name = "returnStatus"
        '
        'frmIssueReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1598, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmIssueReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.tabBorrow.ResumeLayout(False)
        CType(Me.dgBorrowed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.tabPullout.ResumeLayout(False)
        CType(Me.dgPullout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tabBorrow As TabPage
    Friend WithEvents tabPullout As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddBook As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgBorrowed As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgPullout As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents borrowedID As DataGridViewTextBoxColumn
    Friend WithEvents acn As DataGridViewTextBoxColumn
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents firstName As DataGridViewTextBoxColumn
    Friend WithEvents lastName As DataGridViewTextBoxColumn
    Friend WithEvents studentID As DataGridViewTextBoxColumn
    Friend WithEvents copyID As DataGridViewTextBoxColumn
    Friend WithEvents borrowerID As DataGridViewTextBoxColumn
    Friend WithEvents bookTitle As DataGridViewTextBoxColumn
    Friend WithEvents authorName As DataGridViewTextBoxColumn
    Friend WithEvents fullName As DataGridViewTextBoxColumn
    Friend WithEvents dateBorrowed As DataGridViewTextBoxColumn
    Friend WithEvents dueDate As DataGridViewTextBoxColumn
    Friend WithEvents borrowerType As DataGridViewTextBoxColumn
    Friend WithEvents borrowID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents pullOutFullname As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents penalty As DataGridViewTextBoxColumn
    Friend WithEvents returnStatus As DataGridViewTextBoxColumn
End Class
