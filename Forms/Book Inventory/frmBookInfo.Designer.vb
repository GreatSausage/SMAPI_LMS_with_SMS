<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookInfo))
        Me.txtInitialCopies = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtShelfNo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGenre = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnFindPublisher = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFindAuthor = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtYearPublished = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtISBN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLabel = New System.Windows.Forms.Label()
        Me.txtAuthor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPublisher = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnFindGenres = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.txtInitialCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInitialCopies
        '
        Me.txtInitialCopies.BackColor = System.Drawing.Color.Transparent
        Me.txtInitialCopies.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtInitialCopies.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInitialCopies.Enabled = False
        Me.txtInitialCopies.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtInitialCopies.Location = New System.Drawing.Point(5, 321)
        Me.txtInitialCopies.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInitialCopies.Name = "txtInitialCopies"
        Me.txtInitialCopies.Size = New System.Drawing.Size(350, 44)
        Me.txtInitialCopies.TabIndex = 64
        Me.txtInitialCopies.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtInitialCopies.UpDownButtonForeColor = System.Drawing.Color.White
        Me.txtInitialCopies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(5, 372)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(350, 44)
        Me.Guna2Button1.TabIndex = 63
        Me.Guna2Button1.Text = "CANCEL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 20)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Initial Copies:"
        '
        'txtShelfNo
        '
        Me.txtShelfNo.BackColor = System.Drawing.Color.Transparent
        Me.txtShelfNo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtShelfNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtShelfNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtShelfNo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtShelfNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtShelfNo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtShelfNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtShelfNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtShelfNo.ItemHeight = 30
        Me.txtShelfNo.Location = New System.Drawing.Point(389, 320)
        Me.txtShelfNo.Name = "txtShelfNo"
        Me.txtShelfNo.Size = New System.Drawing.Size(348, 36)
        Me.txtShelfNo.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(385, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Shelf No:"
        '
        'txtGenre
        '
        Me.txtGenre.BackColor = System.Drawing.Color.Transparent
        Me.txtGenre.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGenre.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtGenre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtGenre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtGenre.ItemHeight = 30
        Me.txtGenre.Location = New System.Drawing.Point(389, 248)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(290, 36)
        Me.txtGenre.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(385, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Genre:"
        '
        'btnFindPublisher
        '
        Me.btnFindPublisher.BackgroundImage = CType(resources.GetObject("btnFindPublisher.BackgroundImage"), System.Drawing.Image)
        Me.btnFindPublisher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindPublisher.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFindPublisher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFindPublisher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFindPublisher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFindPublisher.FillColor = System.Drawing.Color.Transparent
        Me.btnFindPublisher.FocusedColor = System.Drawing.Color.Transparent
        Me.btnFindPublisher.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFindPublisher.ForeColor = System.Drawing.Color.White
        Me.btnFindPublisher.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnFindPublisher.Location = New System.Drawing.Point(685, 176)
        Me.btnFindPublisher.Name = "btnFindPublisher"
        Me.btnFindPublisher.Size = New System.Drawing.Size(54, 44)
        Me.btnFindPublisher.TabIndex = 53
        '
        'btnFindAuthor
        '
        Me.btnFindAuthor.BackgroundImage = CType(resources.GetObject("btnFindAuthor.BackgroundImage"), System.Drawing.Image)
        Me.btnFindAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindAuthor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFindAuthor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFindAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFindAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFindAuthor.FillColor = System.Drawing.Color.Transparent
        Me.btnFindAuthor.FocusedColor = System.Drawing.Color.Transparent
        Me.btnFindAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFindAuthor.ForeColor = System.Drawing.Color.White
        Me.btnFindAuthor.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnFindAuthor.Location = New System.Drawing.Point(685, 104)
        Me.btnFindAuthor.Name = "btnFindAuthor"
        Me.btnFindAuthor.Size = New System.Drawing.Size(54, 44)
        Me.btnFindAuthor.TabIndex = 52
        '
        'btnSave
        '
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(389, 372)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(350, 44)
        Me.btnSave.TabIndex = 51
        Me.btnSave.Text = "UPDATE"
        '
        'txtYearPublished
        '
        Me.txtYearPublished.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtYearPublished.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYearPublished.DefaultText = ""
        Me.txtYearPublished.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtYearPublished.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtYearPublished.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYearPublished.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYearPublished.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtYearPublished.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtYearPublished.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtYearPublished.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtYearPublished.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtYearPublished.Location = New System.Drawing.Point(5, 249)
        Me.txtYearPublished.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtYearPublished.MaxLength = 4
        Me.txtYearPublished.Name = "txtYearPublished"
        Me.txtYearPublished.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtYearPublished.PlaceholderText = ""
        Me.txtYearPublished.SelectedText = ""
        Me.txtYearPublished.Size = New System.Drawing.Size(350, 44)
        Me.txtYearPublished.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Year Published:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(385, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Publisher:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(385, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Author:"
        '
        'txtTitle
        '
        Me.txtTitle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTitle.DefaultText = ""
        Me.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtTitle.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtTitle.Location = New System.Drawing.Point(5, 177)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTitle.PlaceholderText = ""
        Me.txtTitle.SelectedText = ""
        Me.txtTitle.Size = New System.Drawing.Size(350, 44)
        Me.txtTitle.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Title:"
        '
        'txtISBN
        '
        Me.txtISBN.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtISBN.DefaultText = ""
        Me.txtISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtISBN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.Location = New System.Drawing.Point(5, 105)
        Me.txtISBN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtISBN.MaxLength = 13
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtISBN.PlaceholderText = ""
        Me.txtISBN.SelectedText = ""
        Me.txtISBN.Size = New System.Drawing.Size(350, 44)
        Me.txtISBN.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "ISBN:"
        '
        'txtLabel
        '
        Me.txtLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtLabel.Location = New System.Drawing.Point(0, 0)
        Me.txtLabel.Name = "txtLabel"
        Me.txtLabel.Size = New System.Drawing.Size(744, 50)
        Me.txtLabel.TabIndex = 40
        Me.txtLabel.Text = "ADD BOOK"
        Me.txtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAuthor
        '
        Me.txtAuthor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAuthor.DefaultText = ""
        Me.txtAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthor.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthor.Location = New System.Drawing.Point(389, 105)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAuthor.MaxLength = 13
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAuthor.PlaceholderText = ""
        Me.txtAuthor.ReadOnly = True
        Me.txtAuthor.SelectedText = ""
        Me.txtAuthor.Size = New System.Drawing.Size(290, 44)
        Me.txtAuthor.TabIndex = 65
        '
        'txtPublisher
        '
        Me.txtPublisher.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPublisher.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPublisher.DefaultText = ""
        Me.txtPublisher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPublisher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPublisher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPublisher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPublisher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPublisher.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPublisher.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPublisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPublisher.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPublisher.Location = New System.Drawing.Point(389, 177)
        Me.txtPublisher.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPublisher.MaxLength = 13
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPublisher.PlaceholderText = ""
        Me.txtPublisher.ReadOnly = True
        Me.txtPublisher.SelectedText = ""
        Me.txtPublisher.Size = New System.Drawing.Size(290, 44)
        Me.txtPublisher.TabIndex = 65
        '
        'btnFindGenres
        '
        Me.btnFindGenres.BackgroundImage = CType(resources.GetObject("btnFindGenres.BackgroundImage"), System.Drawing.Image)
        Me.btnFindGenres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindGenres.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFindGenres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFindGenres.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFindGenres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFindGenres.FillColor = System.Drawing.Color.Transparent
        Me.btnFindGenres.FocusedColor = System.Drawing.Color.Transparent
        Me.btnFindGenres.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFindGenres.ForeColor = System.Drawing.Color.White
        Me.btnFindGenres.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnFindGenres.Location = New System.Drawing.Point(685, 249)
        Me.btnFindGenres.Name = "btnFindGenres"
        Me.btnFindGenres.Size = New System.Drawing.Size(54, 44)
        Me.btnFindGenres.TabIndex = 66
        '
        'frmBookInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFindGenres)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtInitialCopies)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtShelfNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtGenre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnFindPublisher)
        Me.Controls.Add(Me.btnFindAuthor)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtYearPublished)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBookInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtInitialCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInitialCopies As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtShelfNo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtGenre As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnFindPublisher As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFindAuthor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtYearPublished As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtISBN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLabel As Label
    Friend WithEvents txtAuthor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPublisher As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnFindGenres As Guna.UI2.WinForms.Guna2Button
End Class
