<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTotalBook))
        Me.cboGenre = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lstBook = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstGenre = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboGenre
        '
        Me.cboGenre.BackColor = System.Drawing.Color.LightCyan
        Me.cboGenre.Font = New System.Drawing.Font("Source Code Pro Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGenre.FormattingEnabled = True
        Me.cboGenre.Location = New System.Drawing.Point(298, 89)
        Me.cboGenre.Name = "cboGenre"
        Me.cboGenre.Size = New System.Drawing.Size(171, 33)
        Me.cboGenre.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Thistle
        Me.btnCalculate.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalculate.Location = New System.Drawing.Point(141, 145)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(171, 57)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.LightCyan
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.lblTotal.Location = New System.Drawing.Point(171, 225)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(321, 61)
        Me.lblTotal.TabIndex = 2
        '
        'lstBook
        '
        Me.lstBook.BackColor = System.Drawing.Color.LightCyan
        Me.lstBook.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.lstBook.FormattingEnabled = True
        Me.lstBook.ItemHeight = 26
        Me.lstBook.Location = New System.Drawing.Point(141, 318)
        Me.lstBook.Name = "lstBook"
        Me.lstBook.Size = New System.Drawing.Size(371, 264)
        Me.lstBook.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Thistle
        Me.btnClear.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(341, 145)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(171, 57)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(703, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "For Reference Only! "
        '
        'lstGenre
        '
        Me.lstGenre.BackColor = System.Drawing.Color.Thistle
        Me.lstGenre.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.lstGenre.FormattingEnabled = True
        Me.lstGenre.ItemHeight = 26
        Me.lstGenre.Location = New System.Drawing.Point(678, 159)
        Me.lstGenre.Name = "lstGenre"
        Me.lstGenre.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstGenre.Size = New System.Drawing.Size(319, 290)
        Me.lstGenre.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(102, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 52)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Genre Code"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(703, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "List of Genre Name"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightCyan
        Me.btnBack.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(32, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(118, 43)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmTotalBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1033, 663)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstGenre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstBook)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.cboGenre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTotalBook"
        Me.Text = "Mini Library Management System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboGenre As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lstBook As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstGenre As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBack As Button
End Class
