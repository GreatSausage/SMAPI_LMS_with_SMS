<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookFinder
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgBooksMainte = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
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
        Me.Panel1.SuspendLayout()
        CType(Me.dgBooksMainte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1406, 50)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FIND BOOKS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.btnClose.LinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(740, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(48, 16)
        Me.btnClose.TabIndex = 7
        Me.btnClose.TabStop = True
        Me.btnClose.Text = "[close]"
        Me.btnClose.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1406, 53)
        Me.Panel1.TabIndex = 8
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtSearch.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtSearch.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(1116, 5)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search Books"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(285, 43)
        Me.txtSearch.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 48)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1401, 5)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1401, 5)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1401, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 53)
        Me.Panel2.TabIndex = 0
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
        Me.dgBooksMainte.Location = New System.Drawing.Point(0, 103)
        Me.dgBooksMainte.MultiSelect = False
        Me.dgBooksMainte.Name = "dgBooksMainte"
        Me.dgBooksMainte.ReadOnly = True
        Me.dgBooksMainte.RowHeadersVisible = False
        Me.dgBooksMainte.RowHeadersWidth = 51
        Me.dgBooksMainte.RowTemplate.Height = 24
        Me.dgBooksMainte.Size = New System.Drawing.Size(1406, 434)
        Me.dgBooksMainte.TabIndex = 9
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
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 434)
        Me.Panel5.TabIndex = 10
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1401, 103)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 434)
        Me.Panel6.TabIndex = 11
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(5, 532)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1396, 5)
        Me.Panel7.TabIndex = 12
        '
        'distinctBookID
        '
        Me.distinctBookID.DataPropertyName = "bookID"
        Me.distinctBookID.HeaderText = "Book ID"
        Me.distinctBookID.MinimumWidth = 6
        Me.distinctBookID.Name = "distinctBookID"
        Me.distinctBookID.ReadOnly = True
        Me.distinctBookID.Visible = False
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
        'frmBookFinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1406, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.dgBooksMainte)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBookFinder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgBooksMainte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgBooksMainte As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
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
    Friend WithEvents Panel7 As Panel
End Class
