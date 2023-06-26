<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewBorrower
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
        Me.components = New System.ComponentModel.Container()
        Dim Borrow_IDLabel As System.Windows.Forms.Label
        Dim Borrow_NameLabel As System.Windows.Forms.Label
        Dim Borrow_PnumberLabel As System.Windows.Forms.Label
        Dim Borrow_BNameLabel As System.Windows.Forms.Label
        Dim Book_CodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewBorrower))
        Me.MiniLibraryDataSet = New Mini_Library_Management.MiniLibraryDataSet()
        Me.BorrowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BorrowTableAdapter = New Mini_Library_Management.MiniLibraryDataSetTableAdapters.BorrowTableAdapter()
        Me.TableAdapterManager = New Mini_Library_Management.MiniLibraryDataSetTableAdapters.TableAdapterManager()
        Me.BorrowBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BorrowBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Borrow_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Borrow_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Borrow_PnumberTextBox = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.Book_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.lstBook = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.chkSort = New System.Windows.Forms.CheckBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Borrow_IDLabel = New System.Windows.Forms.Label()
        Borrow_NameLabel = New System.Windows.Forms.Label()
        Borrow_PnumberLabel = New System.Windows.Forms.Label()
        Borrow_BNameLabel = New System.Windows.Forms.Label()
        Book_CodeLabel = New System.Windows.Forms.Label()
        CType(Me.MiniLibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BorrowBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Borrow_IDLabel
        '
        Borrow_IDLabel.AutoSize = True
        Borrow_IDLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Borrow_IDLabel.Location = New System.Drawing.Point(193, 158)
        Borrow_IDLabel.Name = "Borrow_IDLabel"
        Borrow_IDLabel.Size = New System.Drawing.Size(46, 26)
        Borrow_IDLabel.TabIndex = 1
        Borrow_IDLabel.Text = "ID:"
        '
        'Borrow_NameLabel
        '
        Borrow_NameLabel.AutoSize = True
        Borrow_NameLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Borrow_NameLabel.Location = New System.Drawing.Point(103, 228)
        Borrow_NameLabel.Name = "Borrow_NameLabel"
        Borrow_NameLabel.Size = New System.Drawing.Size(136, 26)
        Borrow_NameLabel.TabIndex = 3
        Borrow_NameLabel.Text = "Full Name:"
        '
        'Borrow_PnumberLabel
        '
        Borrow_PnumberLabel.AutoSize = True
        Borrow_PnumberLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Borrow_PnumberLabel.Location = New System.Drawing.Point(53, 306)
        Borrow_PnumberLabel.Name = "Borrow_PnumberLabel"
        Borrow_PnumberLabel.Size = New System.Drawing.Size(186, 26)
        Borrow_PnumberLabel.TabIndex = 5
        Borrow_PnumberLabel.Text = "Phone number:"
        '
        'Borrow_BNameLabel
        '
        Borrow_BNameLabel.AutoSize = True
        Borrow_BNameLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Borrow_BNameLabel.Location = New System.Drawing.Point(103, 393)
        Borrow_BNameLabel.Name = "Borrow_BNameLabel"
        Borrow_BNameLabel.Size = New System.Drawing.Size(136, 26)
        Borrow_BNameLabel.TabIndex = 7
        Borrow_BNameLabel.Text = "Book Title:"
        '
        'Book_CodeLabel
        '
        Book_CodeLabel.AutoSize = True
        Book_CodeLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Book_CodeLabel.Location = New System.Drawing.Point(99, 485)
        Book_CodeLabel.Name = "Book_CodeLabel"
        Book_CodeLabel.Size = New System.Drawing.Size(140, 26)
        Book_CodeLabel.TabIndex = 9
        Book_CodeLabel.Text = "Book Code:"
        '
        'MiniLibraryDataSet
        '
        Me.MiniLibraryDataSet.DataSetName = "MiniLibraryDataSet"
        Me.MiniLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BorrowBindingSource
        '
        Me.BorrowBindingSource.DataMember = "Borrow"
        Me.BorrowBindingSource.DataSource = Me.MiniLibraryDataSet
        '
        'BorrowTableAdapter
        '
        Me.BorrowTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.BorrowTableAdapter = Me.BorrowTableAdapter
        Me.TableAdapterManager.GenreTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mini_Library_Management.MiniLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BorrowBindingNavigator
        '
        Me.BorrowBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BorrowBindingNavigator.BindingSource = Me.BorrowBindingSource
        Me.BorrowBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BorrowBindingNavigator.DeleteItem = Nothing
        Me.BorrowBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BorrowBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BorrowBindingNavigatorSaveItem})
        Me.BorrowBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BorrowBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BorrowBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BorrowBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BorrowBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BorrowBindingNavigator.Name = "BorrowBindingNavigator"
        Me.BorrowBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BorrowBindingNavigator.Size = New System.Drawing.Size(1240, 31)
        Me.BorrowBindingNavigator.TabIndex = 0
        Me.BorrowBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BorrowBindingNavigatorSaveItem
        '
        Me.BorrowBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BorrowBindingNavigatorSaveItem.Image = CType(resources.GetObject("BorrowBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BorrowBindingNavigatorSaveItem.Name = "BorrowBindingNavigatorSaveItem"
        Me.BorrowBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.BorrowBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Borrow_IDTextBox
        '
        Me.Borrow_IDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Borrow_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Borrow ID", True))
        Me.Borrow_IDTextBox.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrow_IDTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Borrow_IDTextBox.Location = New System.Drawing.Point(279, 155)
        Me.Borrow_IDTextBox.Name = "Borrow_IDTextBox"
        Me.Borrow_IDTextBox.ReadOnly = True
        Me.Borrow_IDTextBox.Size = New System.Drawing.Size(138, 32)
        Me.Borrow_IDTextBox.TabIndex = 2
        '
        'Borrow_NameTextBox
        '
        Me.Borrow_NameTextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Borrow_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Borrow Name", True))
        Me.Borrow_NameTextBox.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrow_NameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Borrow_NameTextBox.Location = New System.Drawing.Point(279, 228)
        Me.Borrow_NameTextBox.Name = "Borrow_NameTextBox"
        Me.Borrow_NameTextBox.Size = New System.Drawing.Size(256, 32)
        Me.Borrow_NameTextBox.TabIndex = 4
        '
        'Borrow_PnumberTextBox
        '
        Me.Borrow_PnumberTextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Borrow_PnumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Borrow Pnumber", True))
        Me.Borrow_PnumberTextBox.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrow_PnumberTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Borrow_PnumberTextBox.Location = New System.Drawing.Point(279, 304)
        Me.Borrow_PnumberTextBox.Name = "Borrow_PnumberTextBox"
        Me.Borrow_PnumberTextBox.Size = New System.Drawing.Size(204, 32)
        Me.Borrow_PnumberTextBox.TabIndex = 6
        '
        'txtBookName
        '
        Me.txtBookName.BackColor = System.Drawing.Color.LightCyan
        Me.txtBookName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Borrow BName", True))
        Me.txtBookName.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBookName.Location = New System.Drawing.Point(279, 393)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.ReadOnly = True
        Me.txtBookName.Size = New System.Drawing.Size(294, 32)
        Me.txtBookName.TabIndex = 8
        '
        'Book_CodeTextBox
        '
        Me.Book_CodeTextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Book_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Book Code", True))
        Me.Book_CodeTextBox.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Book_CodeTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Book_CodeTextBox.Location = New System.Drawing.Point(279, 485)
        Me.Book_CodeTextBox.Name = "Book_CodeTextBox"
        Me.Book_CodeTextBox.ReadOnly = True
        Me.Book_CodeTextBox.Size = New System.Drawing.Size(138, 32)
        Me.Book_CodeTextBox.TabIndex = 10
        '
        'lstBook
        '
        Me.lstBook.BackColor = System.Drawing.Color.Thistle
        Me.lstBook.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBook.FormattingEnabled = True
        Me.lstBook.ItemHeight = 26
        Me.lstBook.Location = New System.Drawing.Point(805, 97)
        Me.lstBook.Name = "lstBook"
        Me.lstBook.Size = New System.Drawing.Size(367, 342)
        Me.lstBook.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(889, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "List Book Title"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightCyan
        Me.btnAdd.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.Location = New System.Drawing.Point(805, 505)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(178, 50)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add Book"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'chkSort
        '
        Me.chkSort.AutoSize = True
        Me.chkSort.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSort.Location = New System.Drawing.Point(805, 457)
        Me.chkSort.Name = "chkSort"
        Me.chkSort.Size = New System.Drawing.Size(76, 25)
        Me.chkSort.TabIndex = 14
        Me.chkSort.Text = "Sort"
        Me.chkSort.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightCyan
        Me.btnBack.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(24, 49)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(118, 43)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(418, 62)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "BORROWER'S DETAILS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAd)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(611, 580)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 83)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control"
        '
        'btnAd
        '
        Me.btnAd.BackColor = System.Drawing.Color.LightCyan
        Me.btnAd.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAd.Location = New System.Drawing.Point(32, 25)
        Me.btnAd.Name = "btnAd"
        Me.btnAd.Size = New System.Drawing.Size(143, 41)
        Me.btnAd.TabIndex = 21
        Me.btnAd.Text = "Add"
        Me.btnAd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightCyan
        Me.btnSave.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(201, 24)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(143, 42)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPrevious)
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(119, 580)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 83)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Moves"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.LightCyan
        Me.btnPrevious.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(25, 25)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(143, 41)
        Me.btnPrevious.TabIndex = 19
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightCyan
        Me.btnNext.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(198, 25)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(143, 41)
        Me.btnNext.TabIndex = 20
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'frmNewBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1240, 703)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.chkSort)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBook)
        Me.Controls.Add(Book_CodeLabel)
        Me.Controls.Add(Me.Book_CodeTextBox)
        Me.Controls.Add(Borrow_BNameLabel)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Borrow_PnumberLabel)
        Me.Controls.Add(Me.Borrow_PnumberTextBox)
        Me.Controls.Add(Borrow_NameLabel)
        Me.Controls.Add(Me.Borrow_NameTextBox)
        Me.Controls.Add(Borrow_IDLabel)
        Me.Controls.Add(Me.Borrow_IDTextBox)
        Me.Controls.Add(Me.BorrowBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNewBorrower"
        Me.Text = "Mini Library Management System"
        CType(Me.MiniLibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BorrowBindingNavigator.ResumeLayout(False)
        Me.BorrowBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MiniLibraryDataSet As MiniLibraryDataSet
    Friend WithEvents BorrowBindingSource As BindingSource
    Friend WithEvents BorrowTableAdapter As MiniLibraryDataSetTableAdapters.BorrowTableAdapter
    Friend WithEvents TableAdapterManager As MiniLibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BorrowBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BorrowBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Borrow_IDTextBox As TextBox
    Friend WithEvents Borrow_NameTextBox As TextBox
    Friend WithEvents Borrow_PnumberTextBox As TextBox
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents Book_CodeTextBox As TextBox
    Friend WithEvents lstBook As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents chkSort As CheckBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
