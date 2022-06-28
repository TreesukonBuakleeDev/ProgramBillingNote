<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBillingReverse
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
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTREVBILL_BILLNOTo = New System.Windows.Forms.TextBox()
        Me.BTN_REVBILLTO = New System.Windows.Forms.PictureBox()
        Me.BTN_REVBILLFROM = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTREVBILL_BILLNOFrom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_REVBILLFINDCUST = New System.Windows.Forms.PictureBox()
        Me.TXTREVBILL_IDCUST = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNREVBill_CLOSE = New System.Windows.Forms.Button()
        Me.BTNREVBILL_SAVE = New System.Windows.Forms.Button()
        Me.DGV_REVBILL = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_GETREVBILL = New System.Windows.Forms.PictureBox()
        Me.TXTREVBILL__NAMECUST = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.BTN_REVBILLTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_REVBILLFROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_REVBILLFINDCUST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_REVBILL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BTN_GETREVBILL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(947, 123)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(104, 38)
        Me.CheckBox2.TabIndex = 8
        Me.CheckBox2.Text = "Select All"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(487, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 38)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "ยกเลิกใบวางบิล"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTREVBILL_BILLNOTo
        '
        Me.TXTREVBILL_BILLNOTo.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTREVBILL_BILLNOTo.Location = New System.Drawing.Point(475, 119)
        Me.TXTREVBILL_BILLNOTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTREVBILL_BILLNOTo.Name = "TXTREVBILL_BILLNOTo"
        Me.TXTREVBILL_BILLNOTo.Size = New System.Drawing.Size(208, 42)
        Me.TXTREVBILL_BILLNOTo.TabIndex = 5
        Me.TXTREVBILL_BILLNOTo.Text = "zzzzzz"
        '
        'BTN_REVBILLTO
        '
        Me.BTN_REVBILLTO.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTN_REVBILLTO.Location = New System.Drawing.Point(704, 121)
        Me.BTN_REVBILLTO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_REVBILLTO.Name = "BTN_REVBILLTO"
        Me.BTN_REVBILLTO.Size = New System.Drawing.Size(29, 30)
        Me.BTN_REVBILLTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_REVBILLTO.TabIndex = 45
        Me.BTN_REVBILLTO.TabStop = False
        '
        'BTN_REVBILLFROM
        '
        Me.BTN_REVBILLFROM.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTN_REVBILLFROM.Location = New System.Drawing.Point(375, 121)
        Me.BTN_REVBILLFROM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_REVBILLFROM.Name = "BTN_REVBILLFROM"
        Me.BTN_REVBILLFROM.Size = New System.Drawing.Size(29, 30)
        Me.BTN_REVBILLFROM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_REVBILLFROM.TabIndex = 44
        Me.BTN_REVBILLFROM.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(428, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 34)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "ถึง"
        '
        'TXTREVBILL_BILLNOFrom
        '
        Me.TXTREVBILL_BILLNOFrom.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTREVBILL_BILLNOFrom.Location = New System.Drawing.Point(145, 117)
        Me.TXTREVBILL_BILLNOFrom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTREVBILL_BILLNOFrom.Name = "TXTREVBILL_BILLNOFrom"
        Me.TXTREVBILL_BILLNOFrom.Size = New System.Drawing.Size(208, 42)
        Me.TXTREVBILL_BILLNOFrom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 34)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "เลขที่ใบวางบิล"
        '
        'BTN_REVBILLFINDCUST
        '
        Me.BTN_REVBILLFINDCUST.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTN_REVBILLFINDCUST.Location = New System.Drawing.Point(375, 71)
        Me.BTN_REVBILLFINDCUST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_REVBILLFINDCUST.Name = "BTN_REVBILLFINDCUST"
        Me.BTN_REVBILLFINDCUST.Size = New System.Drawing.Size(29, 30)
        Me.BTN_REVBILLFINDCUST.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_REVBILLFINDCUST.TabIndex = 42
        Me.BTN_REVBILLFINDCUST.TabStop = False
        '
        'TXTREVBILL_IDCUST
        '
        Me.TXTREVBILL_IDCUST.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTREVBILL_IDCUST.Location = New System.Drawing.Point(145, 70)
        Me.TXTREVBILL_IDCUST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTREVBILL_IDCUST.Name = "TXTREVBILL_IDCUST"
        Me.TXTREVBILL_IDCUST.Size = New System.Drawing.Size(208, 42)
        Me.TXTREVBILL_IDCUST.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 34)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "รหัสลูกค้า"
        '
        'BTNREVBill_CLOSE
        '
        Me.BTNREVBill_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNREVBill_CLOSE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNREVBill_CLOSE.Location = New System.Drawing.Point(1069, 21)
        Me.BTNREVBill_CLOSE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNREVBill_CLOSE.Name = "BTNREVBill_CLOSE"
        Me.BTNREVBill_CLOSE.Size = New System.Drawing.Size(99, 35)
        Me.BTNREVBill_CLOSE.TabIndex = 11
        Me.BTNREVBill_CLOSE.Text = "Close"
        Me.BTNREVBill_CLOSE.UseVisualStyleBackColor = True
        '
        'BTNREVBILL_SAVE
        '
        Me.BTNREVBILL_SAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNREVBILL_SAVE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNREVBILL_SAVE.Location = New System.Drawing.Point(965, 21)
        Me.BTNREVBILL_SAVE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNREVBILL_SAVE.Name = "BTNREVBILL_SAVE"
        Me.BTNREVBILL_SAVE.Size = New System.Drawing.Size(99, 35)
        Me.BTNREVBILL_SAVE.TabIndex = 10
        Me.BTNREVBILL_SAVE.Text = "Reverse"
        Me.BTNREVBILL_SAVE.UseVisualStyleBackColor = True
        '
        'DGV_REVBILL
        '
        Me.DGV_REVBILL.AllowUserToAddRows = False
        Me.DGV_REVBILL.AllowUserToDeleteRows = False
        Me.DGV_REVBILL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_REVBILL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_REVBILL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_REVBILL.ColumnHeadersHeight = 30
        Me.DGV_REVBILL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_REVBILL.Location = New System.Drawing.Point(3, 17)
        Me.DGV_REVBILL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_REVBILL.Name = "DGV_REVBILL"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_REVBILL.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_REVBILL.RowHeadersWidth = 51
        Me.DGV_REVBILL.RowTemplate.Height = 24
        Me.DGV_REVBILL.Size = New System.Drawing.Size(1172, 413)
        Me.DGV_REVBILL.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BTNREVBill_CLOSE)
        Me.GroupBox4.Controls.Add(Me.BTNREVBILL_SAVE)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(3, 430)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(1172, 74)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGV_REVBILL)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 184)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(1178, 506)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTN_GETREVBILL)
        Me.GroupBox2.Controls.Add(Me.TXTREVBILL__NAMECUST)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TXTREVBILL_BILLNOTo)
        Me.GroupBox2.Controls.Add(Me.BTN_REVBILLTO)
        Me.GroupBox2.Controls.Add(Me.BTN_REVBILLFROM)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TXTREVBILL_BILLNOFrom)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BTN_REVBILLFINDCUST)
        Me.GroupBox2.Controls.Add(Me.TXTREVBILL_IDCUST)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1178, 167)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'BTN_GETREVBILL
        '
        Me.BTN_GETREVBILL.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_play_96
        Me.BTN_GETREVBILL.Location = New System.Drawing.Point(757, 121)
        Me.BTN_GETREVBILL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_GETREVBILL.Name = "BTN_GETREVBILL"
        Me.BTN_GETREVBILL.Size = New System.Drawing.Size(29, 30)
        Me.BTN_GETREVBILL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_GETREVBILL.TabIndex = 74
        Me.BTN_GETREVBILL.TabStop = False
        '
        'TXTREVBILL__NAMECUST
        '
        Me.TXTREVBILL__NAMECUST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTREVBILL__NAMECUST.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTREVBILL__NAMECUST.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTREVBILL__NAMECUST.Location = New System.Drawing.Point(433, 71)
        Me.TXTREVBILL__NAMECUST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTREVBILL__NAMECUST.Name = "TXTREVBILL__NAMECUST"
        Me.TXTREVBILL__NAMECUST.ReadOnly = True
        Me.TXTREVBILL__NAMECUST.Size = New System.Drawing.Size(502, 35)
        Me.TXTREVBILL__NAMECUST.TabIndex = 73
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1184, 692)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'FrmBillingReverse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 692)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmBillingReverse"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reverse Billing"
        CType(Me.BTN_REVBILLTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_REVBILLFROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_REVBILLFINDCUST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_REVBILL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BTN_GETREVBILL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTREVBILL_BILLNOTo As TextBox
    Friend WithEvents BTN_REVBILLTO As PictureBox
    Friend WithEvents BTN_REVBILLFROM As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTREVBILL_BILLNOFrom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_REVBILLFINDCUST As PictureBox
    Friend WithEvents TXTREVBILL_IDCUST As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNREVBill_CLOSE As Button
    Friend WithEvents BTNREVBILL_SAVE As Button
    Friend WithEvents DGV_REVBILL As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXTREVBILL__NAMECUST As TextBox
    Friend WithEvents BTN_GETREVBILL As PictureBox
End Class
