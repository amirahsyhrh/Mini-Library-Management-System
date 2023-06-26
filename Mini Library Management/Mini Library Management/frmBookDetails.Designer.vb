<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookDetails
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
        Dim Book_CodeLabel As System.Windows.Forms.Label
        Dim Book_TitleLabel As System.Windows.Forms.Label
        Dim Book_AuthorLabel As System.Windows.Forms.Label
        Dim Book_PublisherLabel As System.Windows.Forms.Label
        Dim Book_Publication_DateLabel As System.Windows.Forms.Label
        Dim Genre_CodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookDetails))
        Me.MiniLibraryDataSet = New Mini_Library_Management.MiniLibraryDataSet()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookTableAdapter = New Mini_Library_Management.MiniLibraryDataSetTableAdapters.BookTableAdapter()
        Me.TableAdapterManager = New Mini_Library_Management.MiniLibraryDataSetTableAdapters.TableAdapterManager()
        Me.BookBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BookBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Book_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Book_TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Book_AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.Book_PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.Book_Publication_DateTextBox = New System.Windows.Forms.TextBox()
        Me.Genre_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Book_CodeLabel = New System.Windows.Forms.Label()
        Book_TitleLabel = New System.Windows.Forms.Label()
        Book_AuthorLabel = New System.Windows.Forms.Label()
        Book_PublisherLabel = New System.Windows.Forms.Label()
        Book_Publication_DateLabel = New System.Windows.Forms.Label()
        Genre_CodeLabel = New System.Windows.Forms.Label()
        CType(Me.MiniLibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BookBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Book_CodeLabel
        '
        Book_CodeLabel.AutoSize = True
        Book_CodeLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Book_CodeLabel.Location = New System.Drawing.Point(203, 195)
        Book_CodeLabel.Name = "Book_CodeLabel"
        Book_CodeLabel.Size = New System.Drawing.Size(140, 26)
        Book_CodeLabel.TabIndex = 1
        Book_CodeLabel.Text = "Book Code:"
        '
        'Book_TitleLabel
        '
        Book_TitleLabel.AutoSize = True
        Book_TitleLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Book_TitleLabel.Location = New System.Drawing.Point(708, 195)
        Book_TitleLabel.Name = "Book_TitleLabel"
        Book_TitleLabel.Size = New System.Drawing.Size(136, 26)
        Book_TitleLabel.TabIndex = 3
        Book_TitleLabel.Text = "Book Title:"
        '
        'Book_AuthorLabel
        '
        Book_AuthorLabel.AutoSize = True
        Book_AuthorLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Book_AuthorLabel.Location = New System.Drawing.Point(203, 292)
        Book_AuthorLabel.Name = "Book_AuthorLabel"
        Book_AuthorLabel.Size = New System.Drawing.Size(162, 26)
        Book_AuthorLabel.TabIndex = 5
        Book_AuthorLabel.Text = "Book Author:"
        '
        'Book_PublisherLabel
        '
        Book_PublisherLabel.AutoSize = True
        Book_PublisherLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Book_PublisherLabel.Location = New System.Drawing.Point(203, 409)
        Book_PublisherLabel.Name = "Book_PublisherLabel"
        Book_PublisherLabel.Size = New System.Drawing.Size(194, 26)
        Book_PublisherLabel.TabIndex = 7
        Book_PublisherLabel.Text = "Book Publisher:"
        '
        'Book_Publication_DateLabel
        '
        Book_Publication_DateLabel.AutoSize = True
        Book_Publication_DateLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Book_Publication_DateLabel.Location = New System.Drawing.Point(708, 299)
        Book_Publication_DateLabel.Name = "Book_Publication_DateLabel"
        Book_Publication_DateLabel.Size = New System.Drawing.Size(273, 26)
        Book_Publication_DateLabel.TabIndex = 9
        Book_Publication_DateLabel.Text = "Book Publication Date:"
        '
        'Genre_CodeLabel
        '
        Genre_CodeLabel.AutoSize = True
        Genre_CodeLabel.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Genre_CodeLabel.Location = New System.Drawing.Point(708, 409)
        Genre_CodeLabel.Name = "Genre_CodeLabel"
        Genre_CodeLabel.Size = New System.Drawing.Size(152, 26)
        Genre_CodeLabel.TabIndex = 11
        Genre_CodeLabel.Text = "Genre Code:"
        '
        'MiniLibraryDataSet
        '
        Me.MiniLibraryDataSet.DataSetName = "MiniLibraryDataSet"
        Me.MiniLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "Book"
        Me.BookBindingSource.DataSource = Me.MiniLibraryDataSet
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Me.BookTableAdapter
        Me.TableAdapterManager.BorrowTableAdapter = Nothing
        Me.TableAdapterManager.GenreTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mini_Library_Management.MiniLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BookBindingNavigator
        '
        Me.BookBindingNavigator.AddNewItem = Nothing
        Me.BookBindingNavigator.BindingSource = Me.BookBindingSource
        Me.BookBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BookBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BookBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BookBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.BookBindingNavigatorSaveItem})
        Me.BookBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BookBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BookBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BookBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BookBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BookBindingNavigator.Name = "BookBindingNavigator"
        Me.BookBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BookBindingNavigator.Size = New System.Drawing.Size(1305, 31)
        Me.BookBindingNavigator.TabIndex = 0
        Me.BookBindingNavigator.Text = "BindingNavigator1"
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
        'BookBindingNavigatorSaveItem
        '
        Me.BookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BookBindingNavigatorSaveItem.Image = CType(resources.GetObject("BookBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BookBindingNavigatorSaveItem.Name = "BookBindingNavigatorSaveItem"
        Me.BookBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.BookBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Book_CodeTextBox
        '
        Me.Book_CodeTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Book_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Book Code", True))
        Me.Book_CodeTextBox.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Book_CodeTextBox.Location = New System.Drawing.Point(304, 241)
        Me.Book_CodeTextBox.Name = "Book_CodeTextBox"
        Me.Book_CodeTextBox.ReadOnly = True
        Me.Book_CodeTextBox.Size = New System.Drawing.Size(131, 34)
        Me.Book_CodeTextBox.TabIndex = 2
        '
        'Book_TitleTextBox
        '
        Me.Book_TitleTextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Book_TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Book Title", True))
        Me.Book_TitleTextBox.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Book_TitleTextBox.Location = New System.Drawing.Point(817, 241)
        Me.Book_TitleTextBox.Name = "Book_TitleTextBox"
        Me.Book_TitleTextBox.Size = New System.Drawing.Size(318, 34)
        Me.Book_TitleTextBox.TabIndex = 4
        '
        'Book_AuthorTextBox
        '
        Me.Book_AuthorTextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Book_AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Book Author", True))
        Me.Book_AuthorTextBox.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Book_AuthorTextBox.Location = New System.Drawing.Point(304, 328)
        Me.Book_AuthorTextBox.Name = "Book_AuthorTextBox"
        Me.Book_AuthorTextBox.Size = New System.Drawing.Size(308, 34)
        Me.Book_AuthorTextBox.TabIndex = 6
        '
        'Book_PublisherTextBox
        '
        Me.Book_PublisherTextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Book_PublisherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Book Publisher", True))
        Me.Book_PublisherTextBox.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Book_PublisherTextBox.Location = New System.Drawing.Point(304, 452)
        Me.Book_PublisherTextBox.Name = "Book_PublisherTextBox"
        Me.Book_PublisherTextBox.Size = New System.Drawing.Size(308, 34)
        Me.Book_PublisherTextBox.TabIndex = 8
        '
        'Book_Publication_DateTextBox
        '
        Me.Book_Publication_DateTextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Book_Publication_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Book Publication Date", True))
        Me.Book_Publication_DateTextBox.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Book_Publication_DateTextBox.Location = New System.Drawing.Point(817, 328)
        Me.Book_Publication_DateTextBox.Name = "Book_Publication_DateTextBox"
        Me.Book_Publication_DateTextBox.Size = New System.Drawing.Size(169, 34)
        Me.Book_Publication_DateTextBox.TabIndex = 10
        '
        'Genre_CodeTextBox
        '
        Me.Genre_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Genre Code", True))
        Me.Genre_CodeTextBox.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Genre_CodeTextBox.Location = New System.Drawing.Point(817, 452)
        Me.Genre_CodeTextBox.Name = "Genre_CodeTextBox"
        Me.Genre_CodeTextBox.ReadOnly = True
        Me.Genre_CodeTextBox.Size = New System.Drawing.Size(129, 34)
        Me.Genre_CodeTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(426, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 62)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "BOOK'S INFORMATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightCyan
        Me.btnDelete.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(39, 24)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(143, 42)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightCyan
        Me.btnSave.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(214, 24)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(143, 41)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
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
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightCyan
        Me.btnBack.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(25, 50)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(118, 43)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPrevious)
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(248, 540)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 83)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Moves"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(740, 540)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 83)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control"
        '
        'frmBookDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1305, 709)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Genre_CodeLabel)
        Me.Controls.Add(Me.Genre_CodeTextBox)
        Me.Controls.Add(Book_Publication_DateLabel)
        Me.Controls.Add(Me.Book_Publication_DateTextBox)
        Me.Controls.Add(Book_PublisherLabel)
        Me.Controls.Add(Me.Book_PublisherTextBox)
        Me.Controls.Add(Book_AuthorLabel)
        Me.Controls.Add(Me.Book_AuthorTextBox)
        Me.Controls.Add(Book_TitleLabel)
        Me.Controls.Add(Me.Book_TitleTextBox)
        Me.Controls.Add(Book_CodeLabel)
        Me.Controls.Add(Me.Book_CodeTextBox)
        Me.Controls.Add(Me.BookBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBookDetails"
        Me.Text = "Mini Library Management System"
        CType(Me.MiniLibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BookBindingNavigator.ResumeLayout(False)
        Me.BookBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MiniLibraryDataSet As MiniLibraryDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As MiniLibraryDataSetTableAdapters.BookTableAdapter
    Friend WithEvents TableAdapterManager As MiniLibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BookBindingNavigator As BindingNavigator
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
    Friend WithEvents BookBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Book_CodeTextBox As TextBox
    Friend WithEvents Book_TitleTextBox As TextBox
    Friend WithEvents Book_AuthorTextBox As TextBox
    Friend WithEvents Book_PublisherTextBox As TextBox
    Friend WithEvents Book_Publication_DateTextBox As TextBox
    Friend WithEvents Genre_CodeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
