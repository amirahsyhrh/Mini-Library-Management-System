<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnBook
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
        Me.components = New System.ComponentModel.Container()
        Dim Borrow_IDLabel As System.Windows.Forms.Label
        Dim Borrow_NameLabel As System.Windows.Forms.Label
        Dim Borrow_PnumberLabel As System.Windows.Forms.Label
        Dim Borrow_BNameLabel As System.Windows.Forms.Label
        Dim Book_CodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReturnBook))
        Dim Label1 As System.Windows.Forms.Label
        Me.MiniLibraryDataSet = New Mini_Library_Management.MiniLibraryDataSet()
        Me.BorrowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BorrowTableAdapter = New Mini_Library_Management.MiniLibraryDataSetTableAdapters.BorrowTableAdapter()
        Me.TableAdapterManager = New Mini_Library_Management.MiniLibraryDataSetTableAdapters.TableAdapterManager()
        Me.BorrowBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
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
        Me.Borrow_BNameTextBox = New System.Windows.Forms.TextBox()
        Me.Book_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Borrow_IDLabel = New System.Windows.Forms.Label()
        Borrow_NameLabel = New System.Windows.Forms.Label()
        Borrow_PnumberLabel = New System.Windows.Forms.Label()
        Borrow_BNameLabel = New System.Windows.Forms.Label()
        Book_CodeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.MiniLibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BorrowBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Borrow_IDLabel
        '
        Borrow_IDLabel.AutoSize = True
        Borrow_IDLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Borrow_IDLabel.Location = New System.Drawing.Point(239, 154)
        Borrow_IDLabel.Name = "Borrow_IDLabel"
        Borrow_IDLabel.Size = New System.Drawing.Size(46, 26)
        Borrow_IDLabel.TabIndex = 1
        Borrow_IDLabel.Text = "ID:"
        '
        'Borrow_NameLabel
        '
        Borrow_NameLabel.AutoSize = True
        Borrow_NameLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Borrow_NameLabel.Location = New System.Drawing.Point(149, 219)
        Borrow_NameLabel.Name = "Borrow_NameLabel"
        Borrow_NameLabel.Size = New System.Drawing.Size(136, 26)
        Borrow_NameLabel.TabIndex = 3
        Borrow_NameLabel.Text = "Full Name:"
        '
        'Borrow_PnumberLabel
        '
        Borrow_PnumberLabel.AutoSize = True
        Borrow_PnumberLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Borrow_PnumberLabel.Location = New System.Drawing.Point(96, 295)
        Borrow_PnumberLabel.Name = "Borrow_PnumberLabel"
        Borrow_PnumberLabel.Size = New System.Drawing.Size(189, 26)
        Borrow_PnumberLabel.TabIndex = 5
        Borrow_PnumberLabel.Text = "Phone Number:"
        '
        'Borrow_BNameLabel
        '
        Borrow_BNameLabel.AutoSize = True
        Borrow_BNameLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Borrow_BNameLabel.Location = New System.Drawing.Point(138, 439)
        Borrow_BNameLabel.Name = "Borrow_BNameLabel"
        Borrow_BNameLabel.Size = New System.Drawing.Size(147, 26)
        Borrow_BNameLabel.TabIndex = 7
        Borrow_BNameLabel.Text = "Book Name:"
        '
        'Book_CodeLabel
        '
        Book_CodeLabel.AutoSize = True
        Book_CodeLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Book_CodeLabel.Location = New System.Drawing.Point(145, 506)
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
        Me.BorrowBindingNavigator.AddNewItem = Nothing
        Me.BorrowBindingNavigator.BindingSource = Me.BorrowBindingSource
        Me.BorrowBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BorrowBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BorrowBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BorrowBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.BorrowBindingNavigatorSaveItem})
        Me.BorrowBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BorrowBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BorrowBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BorrowBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BorrowBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BorrowBindingNavigator.Name = "BorrowBindingNavigator"
        Me.BorrowBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BorrowBindingNavigator.Size = New System.Drawing.Size(1108, 31)
        Me.BorrowBindingNavigator.TabIndex = 0
        Me.BorrowBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        Me.Borrow_IDTextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Borrow_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Borrow ID", True))
        Me.Borrow_IDTextBox.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrow_IDTextBox.Location = New System.Drawing.Point(323, 152)
        Me.Borrow_IDTextBox.Name = "Borrow_IDTextBox"
        Me.Borrow_IDTextBox.ReadOnly = True
        Me.Borrow_IDTextBox.Size = New System.Drawing.Size(116, 32)
        Me.Borrow_IDTextBox.TabIndex = 2
        '
        'Borrow_NameTextBox
        '
        Me.Borrow_NameTextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Borrow_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Borrow Name", True))
        Me.Borrow_NameTextBox.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrow_NameTextBox.Location = New System.Drawing.Point(323, 217)
        Me.Borrow_NameTextBox.Name = "Borrow_NameTextBox"
        Me.Borrow_NameTextBox.ReadOnly = True
        Me.Borrow_NameTextBox.Size = New System.Drawing.Size(287, 32)
        Me.Borrow_NameTextBox.TabIndex = 4
        '
        'Borrow_PnumberTextBox
        '
        Me.Borrow_PnumberTextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Borrow_PnumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Borrow Pnumber", True))
        Me.Borrow_PnumberTextBox.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrow_PnumberTextBox.Location = New System.Drawing.Point(323, 291)
        Me.Borrow_PnumberTextBox.Name = "Borrow_PnumberTextBox"
        Me.Borrow_PnumberTextBox.ReadOnly = True
        Me.Borrow_PnumberTextBox.Size = New System.Drawing.Size(273, 32)
        Me.Borrow_PnumberTextBox.TabIndex = 6
        '
        'Borrow_BNameTextBox
        '
        Me.Borrow_BNameTextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Borrow_BNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Borrow BName", True))
        Me.Borrow_BNameTextBox.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrow_BNameTextBox.Location = New System.Drawing.Point(323, 431)
        Me.Borrow_BNameTextBox.Name = "Borrow_BNameTextBox"
        Me.Borrow_BNameTextBox.ReadOnly = True
        Me.Borrow_BNameTextBox.Size = New System.Drawing.Size(273, 32)
        Me.Borrow_BNameTextBox.TabIndex = 8
        '
        'Book_CodeTextBox
        '
        Me.Book_CodeTextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Book_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Book Code", True))
        Me.Book_CodeTextBox.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Book_CodeTextBox.Location = New System.Drawing.Point(323, 498)
        Me.Book_CodeTextBox.Name = "Book_CodeTextBox"
        Me.Book_CodeTextBox.ReadOnly = True
        Me.Book_CodeTextBox.Size = New System.Drawing.Size(116, 32)
        Me.Book_CodeTextBox.TabIndex = 10
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightCyan
        Me.btnBack.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 50)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(118, 43)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(418, 62)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "BOOK RETURN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPrevious)
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(686, 219)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 83)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Moves"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.LightCyan
        Me.btnPrevious.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(30, 25)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(143, 41)
        Me.btnPrevious.TabIndex = 6
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightCyan
        Me.btnNext.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(204, 25)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(143, 41)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(686, 325)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(381, 83)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Control"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightCyan
        Me.Button5.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(48, 25)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 41)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightCyan
        Me.Button6.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(223, 25)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(143, 41)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Save"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(195, 365)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(90, 26)
        Label1.TabIndex = 20
        Label1.Text = "Status:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Return", "Unreturned"})
        Me.ComboBox1.Location = New System.Drawing.Point(324, 365)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(209, 28)
        Me.ComboBox1.TabIndex = 21
        '
        'frmReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1108, 572)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Book_CodeLabel)
        Me.Controls.Add(Me.Book_CodeTextBox)
        Me.Controls.Add(Borrow_BNameLabel)
        Me.Controls.Add(Me.Borrow_BNameTextBox)
        Me.Controls.Add(Borrow_PnumberLabel)
        Me.Controls.Add(Me.Borrow_PnumberTextBox)
        Me.Controls.Add(Borrow_NameLabel)
        Me.Controls.Add(Me.Borrow_NameTextBox)
        Me.Controls.Add(Borrow_IDLabel)
        Me.Controls.Add(Me.Borrow_IDTextBox)
        Me.Controls.Add(Me.BorrowBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReturnBook"
        Me.Text = "Mini Library Management System"
        CType(Me.MiniLibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BorrowBindingNavigator.ResumeLayout(False)
        Me.BorrowBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MiniLibraryDataSet As MiniLibraryDataSet
    Friend WithEvents BorrowBindingSource As BindingSource
    Friend WithEvents BorrowTableAdapter As MiniLibraryDataSetTableAdapters.BorrowTableAdapter
    Friend WithEvents TableAdapterManager As MiniLibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BorrowBindingNavigator As BindingNavigator
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
    Friend WithEvents BorrowBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Borrow_IDTextBox As TextBox
    Friend WithEvents Borrow_NameTextBox As TextBox
    Friend WithEvents Borrow_PnumberTextBox As TextBox
    Friend WithEvents Borrow_BNameTextBox As TextBox
    Friend WithEvents Book_CodeTextBox As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
