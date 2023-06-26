<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomeScreen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookGenre = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookInformation = New System.Windows.Forms.ToolStripMenuItem()
        Me.frmBookAddNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrower = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrowerAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrowerReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportTotalBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportUnreturned = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddNewBook = New System.Windows.Forms.Button()
        Me.btnTitle = New System.Windows.Forms.Button()
        Me.btnGenre = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnUnreturn = New System.Windows.Forms.Button()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Thistle
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBook, Me.mnuBorrower, Me.mnuReport, Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1327, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBook
        '
        Me.mnuBook.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBookGenre, Me.mnuBookInformation, Me.frmBookAddNew})
        Me.mnuBook.Name = "mnuBook"
        Me.mnuBook.Size = New System.Drawing.Size(65, 29)
        Me.mnuBook.Text = "Book"
        '
        'mnuBookGenre
        '
        Me.mnuBookGenre.Name = "mnuBookGenre"
        Me.mnuBookGenre.Size = New System.Drawing.Size(252, 30)
        Me.mnuBookGenre.Text = "Book's Genre"
        '
        'mnuBookInformation
        '
        Me.mnuBookInformation.Name = "mnuBookInformation"
        Me.mnuBookInformation.Size = New System.Drawing.Size(252, 30)
        Me.mnuBookInformation.Text = "Book's Information"
        '
        'frmBookAddNew
        '
        Me.frmBookAddNew.Name = "frmBookAddNew"
        Me.frmBookAddNew.Size = New System.Drawing.Size(252, 30)
        Me.frmBookAddNew.Text = "Add New Book"
        '
        'mnuBorrower
        '
        Me.mnuBorrower.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBorrowerAdd, Me.mnuBorrowerReturn})
        Me.mnuBorrower.Name = "mnuBorrower"
        Me.mnuBorrower.Size = New System.Drawing.Size(96, 29)
        Me.mnuBorrower.Text = "Borrower"
        '
        'mnuBorrowerAdd
        '
        Me.mnuBorrowerAdd.Name = "mnuBorrowerAdd"
        Me.mnuBorrowerAdd.Size = New System.Drawing.Size(252, 30)
        Me.mnuBorrowerAdd.Text = "Add New"
        '
        'mnuBorrowerReturn
        '
        Me.mnuBorrowerReturn.Name = "mnuBorrowerReturn"
        Me.mnuBorrowerReturn.Size = New System.Drawing.Size(252, 30)
        Me.mnuBorrowerReturn.Text = "Return Book"
        '
        'mnuReport
        '
        Me.mnuReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReportTotalBook, Me.mnuReportUnreturned})
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Size = New System.Drawing.Size(77, 29)
        Me.mnuReport.Text = "Report"
        '
        'mnuReportTotalBook
        '
        Me.mnuReportTotalBook.Name = "mnuReportTotalBook"
        Me.mnuReportTotalBook.Size = New System.Drawing.Size(252, 30)
        Me.mnuReportTotalBook.Text = "Total of Book"
        '
        'mnuReportUnreturned
        '
        Me.mnuReportUnreturned.Name = "mnuReportUnreturned"
        Me.mnuReportUnreturned.Size = New System.Drawing.Size(252, 30)
        Me.mnuReportUnreturned.Text = "Unreturned Book"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddNewBook)
        Me.GroupBox1.Controls.Add(Me.btnTitle)
        Me.GroupBox1.Controls.Add(Me.btnGenre)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(167, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 237)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book's Corner"
        '
        'btnAddNewBook
        '
        Me.btnAddNewBook.BackColor = System.Drawing.Color.LightCyan
        Me.btnAddNewBook.Location = New System.Drawing.Point(19, 134)
        Me.btnAddNewBook.Name = "btnAddNewBook"
        Me.btnAddNewBook.Size = New System.Drawing.Size(192, 65)
        Me.btnAddNewBook.TabIndex = 2
        Me.btnAddNewBook.Text = "Add New Book"
        Me.btnAddNewBook.UseVisualStyleBackColor = False
        '
        'btnTitle
        '
        Me.btnTitle.BackColor = System.Drawing.Color.LightCyan
        Me.btnTitle.Location = New System.Drawing.Point(239, 134)
        Me.btnTitle.Name = "btnTitle"
        Me.btnTitle.Size = New System.Drawing.Size(218, 65)
        Me.btnTitle.TabIndex = 1
        Me.btnTitle.Text = "Book's Infromation"
        Me.btnTitle.UseVisualStyleBackColor = False
        '
        'btnGenre
        '
        Me.btnGenre.BackColor = System.Drawing.Color.LightCyan
        Me.btnGenre.Location = New System.Drawing.Point(105, 44)
        Me.btnGenre.Name = "btnGenre"
        Me.btnGenre.Size = New System.Drawing.Size(237, 69)
        Me.btnGenre.TabIndex = 0
        Me.btnGenre.Text = "Book's Genre"
        Me.btnGenre.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReturn)
        Me.GroupBox2.Controls.Add(Me.btnAddNew)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(759, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 237)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Borrower's Corner"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.LightCyan
        Me.btnReturn.Location = New System.Drawing.Point(90, 135)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(321, 65)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return Book"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.LightCyan
        Me.btnAddNew.Location = New System.Drawing.Point(115, 44)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(241, 69)
        Me.btnAddNew.TabIndex = 0
        Me.btnAddNew.Text = "Add New Borrower"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(425, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 104)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome to Mini Library Management System!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightCyan
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(594, 736)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(157, 65)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnTotal)
        Me.GroupBox3.Controls.Add(Me.btnUnreturn)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(378, 525)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(568, 171)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report's Corner"
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.LightCyan
        Me.btnTotal.Location = New System.Drawing.Point(52, 72)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(241, 69)
        Me.btnTotal.TabIndex = 1
        Me.btnTotal.Text = "Total of Book"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'btnUnreturn
        '
        Me.btnUnreturn.BackColor = System.Drawing.Color.LightCyan
        Me.btnUnreturn.Location = New System.Drawing.Point(308, 72)
        Me.btnUnreturn.Name = "btnUnreturn"
        Me.btnUnreturn.Size = New System.Drawing.Size(198, 69)
        Me.btnUnreturn.TabIndex = 0
        Me.btnUnreturn.Text = "Unreturned Book"
        Me.btnUnreturn.UseVisualStyleBackColor = False
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(50, 29)
        Me.mnuFile.Text = "File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(252, 30)
        Me.mnuFileExit.Text = "Exit"
        '
        'frmHomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1327, 921)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHomeScreen"
        Me.Text = "Mini Library Home Screen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuBook As ToolStripMenuItem
    Friend WithEvents mnuBookGenre As ToolStripMenuItem
    Friend WithEvents mnuBookInformation As ToolStripMenuItem
    Friend WithEvents mnuBorrower As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTitle As Button
    Friend WithEvents btnGenre As Button
    Friend WithEvents mnuBorrowerAdd As ToolStripMenuItem
    Friend WithEvents mnuBorrowerReturn As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents MiniLibraryDataSet As MiniLibraryDataSet
    Friend WithEvents GenreBindingSource As BindingSource
    Friend WithEvents GenreTableAdapter As MiniLibraryDataSetTableAdapters.GenreTableAdapter
    Friend WithEvents TableAdapterManager As MiniLibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents MiniLibraryDataSet1 As MiniLibraryDataSet
    Friend WithEvents GenreBindingSource1 As BindingSource
    Friend WithEvents GenreTableAdapter1 As MiniLibraryDataSetTableAdapters.GenreTableAdapter
    Friend WithEvents TableAdapterManager1 As MiniLibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddNewBook As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnUnreturn As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents frmBookAddNew As ToolStripMenuItem
    Friend WithEvents mnuReport As ToolStripMenuItem
    Friend WithEvents mnuReportTotalBook As ToolStripMenuItem
    Friend WithEvents mnuReportUnreturned As ToolStripMenuItem
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
End Class
