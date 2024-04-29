<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReports
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgReports = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.isbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.authorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateReturned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penalty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.DataSet1 = New System.Data.DataSet()
        CType(Me.dgReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(5, 793)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1588, 5)
        Me.Panel3.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1593, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 706)
        Me.Panel2.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 706)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1598, 92)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "REPORTS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgReports
        '
        Me.dgReports.AllowUserToAddRows = False
        Me.dgReports.AllowUserToDeleteRows = False
        Me.dgReports.AllowUserToResizeColumns = False
        Me.dgReports.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgReports.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgReports.ColumnHeadersHeight = 40
        Me.dgReports.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.isbn, Me.bookTitle, Me.authorName, Me.fullName, Me.dateBorrowed, Me.dateReturned, Me.penalty})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgReports.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgReports.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgReports.Location = New System.Drawing.Point(5, 92)
        Me.dgReports.MultiSelect = False
        Me.dgReports.Name = "dgReports"
        Me.dgReports.ReadOnly = True
        Me.dgReports.RowHeadersVisible = False
        Me.dgReports.RowHeadersWidth = 51
        Me.dgReports.RowTemplate.Height = 24
        Me.dgReports.Size = New System.Drawing.Size(1588, 701)
        Me.dgReports.TabIndex = 11
        Me.dgReports.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgReports.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgReports.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgReports.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgReports.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgReports.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgReports.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgReports.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgReports.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgReports.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgReports.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgReports.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgReports.ThemeStyle.HeaderStyle.Height = 40
        Me.dgReports.ThemeStyle.ReadOnly = True
        Me.dgReports.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgReports.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgReports.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgReports.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgReports.ThemeStyle.RowsStyle.Height = 24
        Me.dgReports.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgReports.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'isbn
        '
        Me.isbn.DataPropertyName = "isbn"
        Me.isbn.HeaderText = "ISBN"
        Me.isbn.MinimumWidth = 6
        Me.isbn.Name = "isbn"
        Me.isbn.ReadOnly = True
        '
        'bookTitle
        '
        Me.bookTitle.DataPropertyName = "bookTitle"
        Me.bookTitle.HeaderText = "Book Title"
        Me.bookTitle.MinimumWidth = 6
        Me.bookTitle.Name = "bookTitle"
        Me.bookTitle.ReadOnly = True
        '
        'authorName
        '
        Me.authorName.DataPropertyName = "authorName"
        Me.authorName.HeaderText = "Author Name"
        Me.authorName.MinimumWidth = 6
        Me.authorName.Name = "authorName"
        Me.authorName.ReadOnly = True
        '
        'fullName
        '
        Me.fullName.DataPropertyName = "fullName"
        Me.fullName.HeaderText = "Fullname"
        Me.fullName.MinimumWidth = 6
        Me.fullName.Name = "fullName"
        Me.fullName.ReadOnly = True
        '
        'dateBorrowed
        '
        Me.dateBorrowed.DataPropertyName = "dateBorrowed"
        Me.dateBorrowed.HeaderText = "Date Borrowed"
        Me.dateBorrowed.MinimumWidth = 6
        Me.dateBorrowed.Name = "dateBorrowed"
        Me.dateBorrowed.ReadOnly = True
        '
        'dateReturned
        '
        Me.dateReturned.DataPropertyName = "dateReturned"
        Me.dateReturned.HeaderText = "Date Returned"
        Me.dateReturned.MinimumWidth = 6
        Me.dateReturned.Name = "dateReturned"
        Me.dateReturned.ReadOnly = True
        '
        'penalty
        '
        Me.penalty.DataPropertyName = "penalty"
        Me.penalty.HeaderText = "Penalty"
        Me.penalty.MinimumWidth = 6
        Me.penalty.Name = "penalty"
        Me.penalty.ReadOnly = True
        '
        'btnPrint
        '
        Me.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrint.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(1360, 43)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(235, 43)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "PRINT"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1598, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.dgReports)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgReports As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents isbn As DataGridViewTextBoxColumn
    Friend WithEvents bookTitle As DataGridViewTextBoxColumn
    Friend WithEvents authorName As DataGridViewTextBoxColumn
    Friend WithEvents fullName As DataGridViewTextBoxColumn
    Friend WithEvents dateBorrowed As DataGridViewTextBoxColumn
    Friend WithEvents dateReturned As DataGridViewTextBoxColumn
    Friend WithEvents penalty As DataGridViewTextBoxColumn
End Class
