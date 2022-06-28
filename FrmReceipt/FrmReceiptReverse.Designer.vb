<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceiptReverse
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGV_REVRECEIPT = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BTNBill_REFRESH = New System.Windows.Forms.Button()
        Me.BTNREVRCP_SAVE = New System.Windows.Forms.Button()
        Me.BTNBill_NEW = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_GETRCPREV = New System.Windows.Forms.PictureBox()
        Me.TXTREVRCP_NAMECUST = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_GETRCP = New System.Windows.Forms.Button()
        Me.TXTREVRCP_BILLNOTo = New System.Windows.Forms.TextBox()
        Me.BTN_REVRCPBILLTO = New System.Windows.Forms.PictureBox()
        Me.BTN_REVRCPBILLFROM = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTREVRCP_BILLNOFrom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_REVRCPFINDCUST = New System.Windows.Forms.PictureBox()
        Me.TXTREVRCP_IDCUST = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_REVRECEIPT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BTN_GETRCPREV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_REVRCPBILLTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_REVRCPBILLFROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_REVRCPFINDCUST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGV_REVRECEIPT)
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
        'DGV_REVRECEIPT
        '
        Me.DGV_REVRECEIPT.AllowUserToAddRows = False
        Me.DGV_REVRECEIPT.AllowUserToDeleteRows = False
        Me.DGV_REVRECEIPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_REVRECEIPT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_REVRECEIPT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_REVRECEIPT.ColumnHeadersHeight = 60
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_REVRECEIPT.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_REVRECEIPT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_REVRECEIPT.Location = New System.Drawing.Point(3, 17)
        Me.DGV_REVRECEIPT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_REVRECEIPT.Name = "DGV_REVRECEIPT"
        Me.DGV_REVRECEIPT.RowHeadersWidth = 51
        Me.DGV_REVRECEIPT.RowTemplate.Height = 24
        Me.DGV_REVRECEIPT.Size = New System.Drawing.Size(1172, 413)
        Me.DGV_REVRECEIPT.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BTNBill_REFRESH)
        Me.GroupBox4.Controls.Add(Me.BTNREVRCP_SAVE)
        Me.GroupBox4.Controls.Add(Me.BTNBill_NEW)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(3, 430)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(1172, 74)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'BTNBill_REFRESH
        '
        Me.BTNBill_REFRESH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBill_REFRESH.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_REFRESH.Location = New System.Drawing.Point(1069, 21)
        Me.BTNBill_REFRESH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBill_REFRESH.Name = "BTNBill_REFRESH"
        Me.BTNBill_REFRESH.Size = New System.Drawing.Size(99, 35)
        Me.BTNBill_REFRESH.TabIndex = 74
        Me.BTNBill_REFRESH.Text = "Close"
        Me.BTNBill_REFRESH.UseVisualStyleBackColor = True
        '
        'BTNREVRCP_SAVE
        '
        Me.BTNREVRCP_SAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNREVRCP_SAVE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNREVRCP_SAVE.Location = New System.Drawing.Point(965, 21)
        Me.BTNREVRCP_SAVE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNREVRCP_SAVE.Name = "BTNREVRCP_SAVE"
        Me.BTNREVRCP_SAVE.Size = New System.Drawing.Size(99, 35)
        Me.BTNREVRCP_SAVE.TabIndex = 73
        Me.BTNREVRCP_SAVE.Text = "Reverse"
        Me.BTNREVRCP_SAVE.UseVisualStyleBackColor = True
        '
        'BTNBill_NEW
        '
        Me.BTNBill_NEW.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBill_NEW.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_NEW.Location = New System.Drawing.Point(861, 21)
        Me.BTNBill_NEW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBill_NEW.Name = "BTNBill_NEW"
        Me.BTNBill_NEW.Size = New System.Drawing.Size(99, 35)
        Me.BTNBill_NEW.TabIndex = 72
        Me.BTNBill_NEW.Text = "New"
        Me.BTNBill_NEW.UseVisualStyleBackColor = True
        Me.BTNBill_NEW.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTN_GETRCPREV)
        Me.GroupBox2.Controls.Add(Me.TXTREVRCP_NAMECUST)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.BTN_GETRCP)
        Me.GroupBox2.Controls.Add(Me.TXTREVRCP_BILLNOTo)
        Me.GroupBox2.Controls.Add(Me.BTN_REVRCPBILLTO)
        Me.GroupBox2.Controls.Add(Me.BTN_REVRCPBILLFROM)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TXTREVRCP_BILLNOFrom)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BTN_REVRCPFINDCUST)
        Me.GroupBox2.Controls.Add(Me.TXTREVRCP_IDCUST)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1178, 167)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'BTN_GETRCPREV
        '
        Me.BTN_GETRCPREV.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_play_96
        Me.BTN_GETRCPREV.Location = New System.Drawing.Point(790, 120)
        Me.BTN_GETRCPREV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_GETRCPREV.Name = "BTN_GETRCPREV"
        Me.BTN_GETRCPREV.Size = New System.Drawing.Size(29, 30)
        Me.BTN_GETRCPREV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_GETRCPREV.TabIndex = 73
        Me.BTN_GETRCPREV.TabStop = False
        '
        'TXTREVRCP_NAMECUST
        '
        Me.TXTREVRCP_NAMECUST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTREVRCP_NAMECUST.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTREVRCP_NAMECUST.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTREVRCP_NAMECUST.Location = New System.Drawing.Point(463, 70)
        Me.TXTREVRCP_NAMECUST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTREVRCP_NAMECUST.Name = "TXTREVRCP_NAMECUST"
        Me.TXTREVRCP_NAMECUST.ReadOnly = True
        Me.TXTREVRCP_NAMECUST.Size = New System.Drawing.Size(392, 35)
        Me.TXTREVRCP_NAMECUST.TabIndex = 72
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(947, 120)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(104, 38)
        Me.CheckBox2.TabIndex = 71
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
        Me.Label4.Size = New System.Drawing.Size(202, 38)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "ยกเลิกใบเสร็จรับเงิน"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN_GETRCP
        '
        Me.BTN_GETRCP.Location = New System.Drawing.Point(905, 55)
        Me.BTN_GETRCP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_GETRCP.Name = "BTN_GETRCP"
        Me.BTN_GETRCP.Size = New System.Drawing.Size(63, 38)
        Me.BTN_GETRCP.TabIndex = 47
        Me.BTN_GETRCP.Text = ">>"
        Me.BTN_GETRCP.UseVisualStyleBackColor = True
        Me.BTN_GETRCP.Visible = False
        '
        'TXTREVRCP_BILLNOTo
        '
        Me.TXTREVRCP_BILLNOTo.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTREVRCP_BILLNOTo.Location = New System.Drawing.Point(505, 119)
        Me.TXTREVRCP_BILLNOTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTREVRCP_BILLNOTo.Name = "TXTREVRCP_BILLNOTo"
        Me.TXTREVRCP_BILLNOTo.Size = New System.Drawing.Size(208, 42)
        Me.TXTREVRCP_BILLNOTo.TabIndex = 46
        Me.TXTREVRCP_BILLNOTo.Text = "zzzzzz"
        '
        'BTN_REVRCPBILLTO
        '
        Me.BTN_REVRCPBILLTO.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTN_REVRCPBILLTO.Location = New System.Drawing.Point(734, 121)
        Me.BTN_REVRCPBILLTO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_REVRCPBILLTO.Name = "BTN_REVRCPBILLTO"
        Me.BTN_REVRCPBILLTO.Size = New System.Drawing.Size(37, 27)
        Me.BTN_REVRCPBILLTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_REVRCPBILLTO.TabIndex = 45
        Me.BTN_REVRCPBILLTO.TabStop = False
        '
        'BTN_REVRCPBILLFROM
        '
        Me.BTN_REVRCPBILLFROM.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTN_REVRCPBILLFROM.Location = New System.Drawing.Point(405, 121)
        Me.BTN_REVRCPBILLFROM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_REVRCPBILLFROM.Name = "BTN_REVRCPBILLFROM"
        Me.BTN_REVRCPBILLFROM.Size = New System.Drawing.Size(37, 27)
        Me.BTN_REVRCPBILLFROM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_REVRCPBILLFROM.TabIndex = 44
        Me.BTN_REVRCPBILLFROM.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(458, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 34)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "ถึง"
        '
        'TXTREVRCP_BILLNOFrom
        '
        Me.TXTREVRCP_BILLNOFrom.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTREVRCP_BILLNOFrom.Location = New System.Drawing.Point(175, 117)
        Me.TXTREVRCP_BILLNOFrom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTREVRCP_BILLNOFrom.Name = "TXTREVRCP_BILLNOFrom"
        Me.TXTREVRCP_BILLNOFrom.Size = New System.Drawing.Size(208, 42)
        Me.TXTREVRCP_BILLNOFrom.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 34)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "เลขที่ใบเสร็จรับเงิน"
        '
        'BTN_REVRCPFINDCUST
        '
        Me.BTN_REVRCPFINDCUST.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTN_REVRCPFINDCUST.Location = New System.Drawing.Point(405, 71)
        Me.BTN_REVRCPFINDCUST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_REVRCPFINDCUST.Name = "BTN_REVRCPFINDCUST"
        Me.BTN_REVRCPFINDCUST.Size = New System.Drawing.Size(37, 27)
        Me.BTN_REVRCPFINDCUST.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_REVRCPFINDCUST.TabIndex = 42
        Me.BTN_REVRCPFINDCUST.TabStop = False
        '
        'TXTREVRCP_IDCUST
        '
        Me.TXTREVRCP_IDCUST.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTREVRCP_IDCUST.Location = New System.Drawing.Point(175, 70)
        Me.TXTREVRCP_IDCUST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTREVRCP_IDCUST.Name = "TXTREVRCP_IDCUST"
        Me.TXTREVRCP_IDCUST.Size = New System.Drawing.Size(208, 42)
        Me.TXTREVRCP_IDCUST.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 34)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "รหัสลูกค้า"
        '
        'FrmReceiptReverse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 692)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmReceiptReverse"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reverse Receipt Bill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGV_REVRECEIPT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BTN_GETRCPREV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_REVRCPBILLTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_REVRCPBILLFROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_REVRCPFINDCUST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTN_GETRCP As Button
    Friend WithEvents TXTREVRCP_BILLNOTo As TextBox
    Friend WithEvents BTN_REVRCPBILLTO As PictureBox
    Friend WithEvents BTN_REVRCPBILLFROM As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTREVRCP_BILLNOFrom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_REVRCPFINDCUST As PictureBox
    Friend WithEvents TXTREVRCP_IDCUST As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DGV_REVRECEIPT As DataGridView
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents BTNBill_REFRESH As Button
    Friend WithEvents BTNREVRCP_SAVE As Button
    Friend WithEvents BTNBill_NEW As Button
    Friend WithEvents TXTREVRCP_NAMECUST As TextBox
    Friend WithEvents BTN_GETRCPREV As PictureBox
End Class
