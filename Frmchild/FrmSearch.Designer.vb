<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DGV_CUSTSEARCH = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_AutoSearch = New System.Windows.Forms.CheckBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TXTFILTER = New System.Windows.Forms.ToolStripTextBox()
        Me.BTN_SEARCH = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.COMBO_CONDITION = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.COMBO_FIELDS = New System.Windows.Forms.ToolStripComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_CUSTSEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.DGV_CUSTSEARCH)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(840, 527)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Location = New System.Drawing.Point(615, 10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(190, 15)
        Me.txtSearch.TabIndex = 4
        Me.txtSearch.Visible = False
        '
        'DGV_CUSTSEARCH
        '
        Me.DGV_CUSTSEARCH.AllowUserToAddRows = False
        Me.DGV_CUSTSEARCH.AllowUserToDeleteRows = False
        Me.DGV_CUSTSEARCH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_CUSTSEARCH.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGV_CUSTSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_CUSTSEARCH.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_CUSTSEARCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_CUSTSEARCH.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_CUSTSEARCH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_CUSTSEARCH.Location = New System.Drawing.Point(4, 195)
        Me.DGV_CUSTSEARCH.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV_CUSTSEARCH.Name = "DGV_CUSTSEARCH"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_CUSTSEARCH.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_CUSTSEARCH.RowHeadersWidth = 51
        Me.DGV_CUSTSEARCH.RowTemplate.ReadOnly = True
        Me.DGV_CUSTSEARCH.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_CUSTSEARCH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_CUSTSEARCH.Size = New System.Drawing.Size(832, 328)
        Me.DGV_CUSTSEARCH.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTN_AutoSearch)
        Me.GroupBox2.Controls.Add(Me.ToolStrip3)
        Me.GroupBox2.Controls.Add(Me.ToolStrip2)
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(4, 19)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(832, 176)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'BTN_AutoSearch
        '
        Me.BTN_AutoSearch.AutoSize = True
        Me.BTN_AutoSearch.Location = New System.Drawing.Point(530, 85)
        Me.BTN_AutoSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_AutoSearch.Name = "BTN_AutoSearch"
        Me.BTN_AutoSearch.Size = New System.Drawing.Size(102, 20)
        Me.BTN_AutoSearch.TabIndex = 3
        Me.BTN_AutoSearch.Text = "Auto Search"
        Me.BTN_AutoSearch.UseVisualStyleBackColor = True
        Me.BTN_AutoSearch.Visible = False
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.TXTFILTER, Me.BTN_SEARCH})
        Me.ToolStrip3.Location = New System.Drawing.Point(4, 115)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(824, 55)
        Me.ToolStrip3.TabIndex = 2
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.AutoSize = False
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripLabel3.Text = "Filter text"
        Me.ToolStripLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXTFILTER
        '
        Me.TXTFILTER.AutoSize = False
        Me.TXTFILTER.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFILTER.Name = "TXTFILTER"
        Me.TXTFILTER.Size = New System.Drawing.Size(450, 42)
        '
        'BTN_SEARCH
        '
        Me.BTN_SEARCH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTN_SEARCH.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTN_SEARCH.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_SEARCH.Name = "BTN_SEARCH"
        Me.BTN_SEARCH.Size = New System.Drawing.Size(29, 52)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.COMBO_CONDITION})
        Me.ToolStrip2.Location = New System.Drawing.Point(4, 65)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(824, 50)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.AutoSize = False
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'COMBO_CONDITION
        '
        Me.COMBO_CONDITION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMBO_CONDITION.DropDownWidth = 300
        Me.COMBO_CONDITION.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.COMBO_CONDITION.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMBO_CONDITION.Name = "COMBO_CONDITION"
        Me.COMBO_CONDITION.Size = New System.Drawing.Size(300, 50)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.COMBO_FIELDS})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 19)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(824, 46)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripLabel1.Text = "Filter by"
        Me.ToolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'COMBO_FIELDS
        '
        Me.COMBO_FIELDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMBO_FIELDS.DropDownWidth = 300
        Me.COMBO_FIELDS.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.COMBO_FIELDS.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMBO_FIELDS.Name = "COMBO_FIELDS"
        Me.COMBO_FIELDS.Size = New System.Drawing.Size(300, 46)
        '
        'FrmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 527)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmSearch"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_CUSTSEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV_CUSTSEARCH As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTN_AutoSearch As CheckBox
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents TXTFILTER As ToolStripTextBox
    Friend WithEvents BTN_SEARCH As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents COMBO_CONDITION As ToolStripComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents COMBO_FIELDS As ToolStripComboBox
    Friend WithEvents txtSearch As TextBox
End Class
