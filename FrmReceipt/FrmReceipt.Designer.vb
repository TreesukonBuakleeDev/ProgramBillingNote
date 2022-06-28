<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceipt))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXTRCP_PAYDATE = New System.Windows.Forms.DateTimePicker()
        Me.BTNRCP_ALL = New System.Windows.Forms.CheckBox()
        Me.GroupPAYTYPE = New System.Windows.Forms.GroupBox()
        Me.BTNRCP_CASH = New System.Windows.Forms.RadioButton()
        Me.BTNRCP_TRANSFER = New System.Windows.Forms.RadioButton()
        Me.BTNRCP_Cheque = New System.Windows.Forms.RadioButton()
        Me.BTNRCP_Credit = New System.Windows.Forms.RadioButton()
        Me.GroupPAYMENT = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BTNRCP_CHQBANKCODE = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TXTRCP_CHEQNO = New System.Windows.Forms.TextBox()
        Me.TXTRCP_CHEQBRANCH = New System.Windows.Forms.TextBox()
        Me.TXTRCP_CHEQACCT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TXTRCP_CRCARDNO = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTRCP_TRANSFEE = New System.Windows.Forms.TextBox()
        Me.BTNRCP_TRANSBANK = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TXTRCP_TRANSBANKCODE = New System.Windows.Forms.TextBox()
        Me.TXTRCP_TRANSBANKNO = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_RCPNEWNEW = New System.Windows.Forms.PictureBox()
        Me.BTNRCP_SHOWRECEIVEDATE = New System.Windows.Forms.CheckBox()
        Me.BTN_RCPGET = New System.Windows.Forms.PictureBox()
        Me.TXTRCP_BILLNOTo = New System.Windows.Forms.TextBox()
        Me.BTN_RCPBILLTO = New System.Windows.Forms.PictureBox()
        Me.BTN_RCPBILLFROM = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTRCP_BILLNOFrom = New System.Windows.Forms.TextBox()
        Me.BTN_SHOWCHEQDATE = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_BILLFINDCUST = New System.Windows.Forms.PictureBox()
        Me.txtNAMECUST = New System.Windows.Forms.TextBox()
        Me.TXTRCP_IDCUST = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRCPSTA = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.BTN_TAXReceipt = New System.Windows.Forms.RadioButton()
        Me.BTN_Receipt = New System.Windows.Forms.RadioButton()
        Me.txtRCP_Comment = New System.Windows.Forms.RichTextBox()
        Me.TXTRCP_REF = New System.Windows.Forms.TextBox()
        Me.BTN_RCPOPTFD = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRCP_INVDATE = New System.Windows.Forms.DateTimePicker()
        Me.txtRCP_DOCDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTRCP_RCPNO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRCPAMOUNT = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBANKBATCH = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txt_RCPDATECB = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.BTNRCP_PRINT = New System.Windows.Forms.Button()
        Me.BTNBill_NEW = New System.Windows.Forms.Button()
        Me.BTNBill_REFRESH = New System.Windows.Forms.Button()
        Me.BTNBill_POST = New System.Windows.Forms.Button()
        Me.BTNBill_DELETE = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DGV_RCP = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupPAYTYPE.SuspendLayout()
        Me.GroupPAYMENT.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.BTNRCP_TRANSBANK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BTN_RCPNEWNEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_RCPGET, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_RCPBILLTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_RCPBILLFROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_BILLFINDCUST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DGV_RCP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1574, 505)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(707, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 38)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "ใบเสร็จรับเงิน"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Controls.Add(Me.TXTRCP_PAYDATE)
        Me.GroupBox4.Controls.Add(Me.BTNRCP_ALL)
        Me.GroupBox4.Controls.Add(Me.GroupPAYTYPE)
        Me.GroupBox4.Controls.Add(Me.GroupPAYMENT)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 290)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(1550, 210)
        Me.GroupBox4.TabIndex = 49
        Me.GroupBox4.TabStop = False
        '
        'TXTRCP_PAYDATE
        '
        Me.TXTRCP_PAYDATE.CalendarFont = New System.Drawing.Font("Cordia New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_PAYDATE.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_PAYDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXTRCP_PAYDATE.Location = New System.Drawing.Point(1375, 35)
        Me.TXTRCP_PAYDATE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_PAYDATE.Name = "TXTRCP_PAYDATE"
        Me.TXTRCP_PAYDATE.Size = New System.Drawing.Size(140, 42)
        Me.TXTRCP_PAYDATE.TabIndex = 19
        '
        'BTNRCP_ALL
        '
        Me.BTNRCP_ALL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNRCP_ALL.AutoSize = True
        Me.BTNRCP_ALL.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNRCP_ALL.Location = New System.Drawing.Point(15, 170)
        Me.BTNRCP_ALL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNRCP_ALL.Name = "BTNRCP_ALL"
        Me.BTNRCP_ALL.Size = New System.Drawing.Size(96, 36)
        Me.BTNRCP_ALL.TabIndex = 20
        Me.BTNRCP_ALL.Text = "Select All"
        Me.BTNRCP_ALL.UseVisualStyleBackColor = True
        '
        'GroupPAYTYPE
        '
        Me.GroupPAYTYPE.Controls.Add(Me.BTNRCP_CASH)
        Me.GroupPAYTYPE.Controls.Add(Me.BTNRCP_TRANSFER)
        Me.GroupPAYTYPE.Controls.Add(Me.BTNRCP_Cheque)
        Me.GroupPAYTYPE.Controls.Add(Me.BTNRCP_Credit)
        Me.GroupPAYTYPE.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupPAYTYPE.Location = New System.Drawing.Point(5, 9)
        Me.GroupPAYTYPE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupPAYTYPE.Name = "GroupPAYTYPE"
        Me.GroupPAYTYPE.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupPAYTYPE.Size = New System.Drawing.Size(150, 161)
        Me.GroupPAYTYPE.TabIndex = 69
        Me.GroupPAYTYPE.TabStop = False
        Me.GroupPAYTYPE.Text = "ประเภทการรับเงิน"
        '
        'BTNRCP_CASH
        '
        Me.BTNRCP_CASH.AutoSize = True
        Me.BTNRCP_CASH.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNRCP_CASH.Location = New System.Drawing.Point(11, 25)
        Me.BTNRCP_CASH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNRCP_CASH.Name = "BTNRCP_CASH"
        Me.BTNRCP_CASH.Size = New System.Drawing.Size(74, 38)
        Me.BTNRCP_CASH.TabIndex = 12
        Me.BTNRCP_CASH.TabStop = True
        Me.BTNRCP_CASH.Text = "Cash"
        Me.BTNRCP_CASH.UseVisualStyleBackColor = True
        '
        'BTNRCP_TRANSFER
        '
        Me.BTNRCP_TRANSFER.AutoSize = True
        Me.BTNRCP_TRANSFER.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNRCP_TRANSFER.Location = New System.Drawing.Point(11, 116)
        Me.BTNRCP_TRANSFER.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNRCP_TRANSFER.Name = "BTNRCP_TRANSFER"
        Me.BTNRCP_TRANSFER.Size = New System.Drawing.Size(95, 38)
        Me.BTNRCP_TRANSFER.TabIndex = 15
        Me.BTNRCP_TRANSFER.TabStop = True
        Me.BTNRCP_TRANSFER.Text = "Transfer"
        Me.BTNRCP_TRANSFER.UseVisualStyleBackColor = True
        '
        'BTNRCP_Cheque
        '
        Me.BTNRCP_Cheque.AutoSize = True
        Me.BTNRCP_Cheque.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNRCP_Cheque.Location = New System.Drawing.Point(11, 56)
        Me.BTNRCP_Cheque.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNRCP_Cheque.Name = "BTNRCP_Cheque"
        Me.BTNRCP_Cheque.Size = New System.Drawing.Size(94, 38)
        Me.BTNRCP_Cheque.TabIndex = 13
        Me.BTNRCP_Cheque.TabStop = True
        Me.BTNRCP_Cheque.Text = "Cheque"
        Me.BTNRCP_Cheque.UseVisualStyleBackColor = True
        '
        'BTNRCP_Credit
        '
        Me.BTNRCP_Credit.AutoSize = True
        Me.BTNRCP_Credit.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNRCP_Credit.Location = New System.Drawing.Point(11, 86)
        Me.BTNRCP_Credit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNRCP_Credit.Name = "BTNRCP_Credit"
        Me.BTNRCP_Credit.Size = New System.Drawing.Size(121, 38)
        Me.BTNRCP_Credit.TabIndex = 14
        Me.BTNRCP_Credit.TabStop = True
        Me.BTNRCP_Credit.Text = "Credit Card"
        Me.BTNRCP_Credit.UseVisualStyleBackColor = True
        '
        'GroupPAYMENT
        '
        Me.GroupPAYMENT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPAYMENT.Controls.Add(Me.Label19)
        Me.GroupPAYMENT.Controls.Add(Me.TabControl1)
        Me.GroupPAYMENT.Location = New System.Drawing.Point(161, 18)
        Me.GroupPAYMENT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupPAYMENT.Name = "GroupPAYMENT"
        Me.GroupPAYMENT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupPAYMENT.Size = New System.Drawing.Size(1384, 152)
        Me.GroupPAYMENT.TabIndex = 50
        Me.GroupPAYMENT.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(1090, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 34)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "วันที่รับเงิน"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(11, 19)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(6, 6)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1374, 131)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BTNRCP_CHQBANKCODE)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.TXTRCP_CHEQNO)
        Me.TabPage1.Controls.Add(Me.TXTRCP_CHEQBRANCH)
        Me.TabPage1.Controls.Add(Me.TXTRCP_CHEQACCT)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Location = New System.Drawing.Point(4, 49)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(1366, 78)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cheque"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BTNRCP_CHQBANKCODE
        '
        Me.BTNRCP_CHQBANKCODE.FormattingEnabled = True
        Me.BTNRCP_CHQBANKCODE.Location = New System.Drawing.Point(135, 15)
        Me.BTNRCP_CHQBANKCODE.Name = "BTNRCP_CHQBANKCODE"
        Me.BTNRCP_CHQBANKCODE.Size = New System.Drawing.Size(210, 42)
        Me.BTNRCP_CHQBANKCODE.TabIndex = 15
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 34)
        Me.Label21.TabIndex = 62
        Me.Label21.Text = "ธนาคาร"
        '
        'TXTRCP_CHEQNO
        '
        Me.TXTRCP_CHEQNO.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_CHEQNO.Location = New System.Drawing.Point(795, 15)
        Me.TXTRCP_CHEQNO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_CHEQNO.Name = "TXTRCP_CHEQNO"
        Me.TXTRCP_CHEQNO.Size = New System.Drawing.Size(210, 42)
        Me.TXTRCP_CHEQNO.TabIndex = 17
        Me.TXTRCP_CHEQNO.WordWrap = False
        '
        'TXTRCP_CHEQBRANCH
        '
        Me.TXTRCP_CHEQBRANCH.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_CHEQBRANCH.Location = New System.Drawing.Point(465, 15)
        Me.TXTRCP_CHEQBRANCH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_CHEQBRANCH.Name = "TXTRCP_CHEQBRANCH"
        Me.TXTRCP_CHEQBRANCH.Size = New System.Drawing.Size(210, 42)
        Me.TXTRCP_CHEQBRANCH.TabIndex = 16
        '
        'TXTRCP_CHEQACCT
        '
        Me.TXTRCP_CHEQACCT.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_CHEQACCT.Location = New System.Drawing.Point(1130, 15)
        Me.TXTRCP_CHEQACCT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_CHEQACCT.Name = "TXTRCP_CHEQACCT"
        Me.TXTRCP_CHEQACCT.Size = New System.Drawing.Size(210, 42)
        Me.TXTRCP_CHEQACCT.TabIndex = 52
        Me.TXTRCP_CHEQACCT.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(700, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 34)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "เลขที่เช็ค"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(385, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 34)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "สาขา"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(1040, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 34)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "บัญชีเลขที่"
        Me.Label12.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TXTRCP_CRCARDNO)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Location = New System.Drawing.Point(4, 49)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(1366, 78)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Credit Card "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TXTRCP_CRCARDNO
        '
        Me.TXTRCP_CRCARDNO.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_CRCARDNO.Location = New System.Drawing.Point(93, 15)
        Me.TXTRCP_CRCARDNO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_CRCARDNO.Name = "TXTRCP_CRCARDNO"
        Me.TXTRCP_CRCARDNO.Size = New System.Drawing.Size(208, 42)
        Me.TXTRCP_CRCARDNO.TabIndex = 63
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 34)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "เลขที่บัตร"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.TXTRCP_TRANSFEE)
        Me.TabPage3.Controls.Add(Me.BTNRCP_TRANSBANK)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.TextBox9)
        Me.TabPage3.Controls.Add(Me.TXTRCP_TRANSBANKCODE)
        Me.TabPage3.Controls.Add(Me.TXTRCP_TRANSBANKNO)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Location = New System.Drawing.Point(4, 49)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Size = New System.Drawing.Size(1366, 78)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Transfer"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(755, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 34)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "ค่าธรรมเนียม"
        '
        'TXTRCP_TRANSFEE
        '
        Me.TXTRCP_TRANSFEE.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_TRANSFEE.Location = New System.Drawing.Point(865, 15)
        Me.TXTRCP_TRANSFEE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_TRANSFEE.Name = "TXTRCP_TRANSFEE"
        Me.TXTRCP_TRANSFEE.Size = New System.Drawing.Size(208, 42)
        Me.TXTRCP_TRANSFEE.TabIndex = 70
        Me.TXTRCP_TRANSFEE.Text = "0.00"
        '
        'BTNRCP_TRANSBANK
        '
        Me.BTNRCP_TRANSBANK.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTNRCP_TRANSBANK.Location = New System.Drawing.Point(336, 16)
        Me.BTNRCP_TRANSBANK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNRCP_TRANSBANK.Name = "BTNRCP_TRANSBANK"
        Me.BTNRCP_TRANSBANK.Size = New System.Drawing.Size(37, 27)
        Me.BTNRCP_TRANSBANK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNRCP_TRANSBANK.TabIndex = 39
        Me.BTNRCP_TRANSBANK.TabStop = False
        Me.BTNRCP_TRANSBANK.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(380, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 34)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "เลขที่บัญชีเงินฝาก"
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(1100, 20)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(250, 35)
        Me.TextBox9.TabIndex = 69
        '
        'TXTRCP_TRANSBANKCODE
        '
        Me.TXTRCP_TRANSBANKCODE.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_TRANSBANKCODE.Location = New System.Drawing.Point(120, 16)
        Me.TXTRCP_TRANSBANKCODE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_TRANSBANKCODE.Name = "TXTRCP_TRANSBANKCODE"
        Me.TXTRCP_TRANSBANKCODE.Size = New System.Drawing.Size(208, 42)
        Me.TXTRCP_TRANSBANKCODE.TabIndex = 57
        '
        'TXTRCP_TRANSBANKNO
        '
        Me.TXTRCP_TRANSBANKNO.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_TRANSBANKNO.Location = New System.Drawing.Point(525, 15)
        Me.TXTRCP_TRANSBANKNO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_TRANSBANKNO.Name = "TXTRCP_TRANSBANKNO"
        Me.TXTRCP_TRANSBANKNO.Size = New System.Drawing.Size(208, 42)
        Me.TXTRCP_TRANSBANKNO.TabIndex = 58
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 34)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "รหัสธนาคาร"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.BTN_RCPNEWNEW)
        Me.GroupBox2.Controls.Add(Me.BTNRCP_SHOWRECEIVEDATE)
        Me.GroupBox2.Controls.Add(Me.BTN_RCPGET)
        Me.GroupBox2.Controls.Add(Me.TXTRCP_BILLNOTo)
        Me.GroupBox2.Controls.Add(Me.BTN_RCPBILLTO)
        Me.GroupBox2.Controls.Add(Me.BTN_RCPBILLFROM)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TXTRCP_BILLNOFrom)
        Me.GroupBox2.Controls.Add(Me.BTN_SHOWCHEQDATE)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BTN_BILLFINDCUST)
        Me.GroupBox2.Controls.Add(Me.txtNAMECUST)
        Me.GroupBox2.Controls.Add(Me.TXTRCP_IDCUST)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1550, 126)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'BTN_RCPNEWNEW
        '
        Me.BTN_RCPNEWNEW.Image = CType(resources.GetObject("BTN_RCPNEWNEW.Image"), System.Drawing.Image)
        Me.BTN_RCPNEWNEW.Location = New System.Drawing.Point(450, 20)
        Me.BTN_RCPNEWNEW.Name = "BTN_RCPNEWNEW"
        Me.BTN_RCPNEWNEW.Size = New System.Drawing.Size(25, 25)
        Me.BTN_RCPNEWNEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_RCPNEWNEW.TabIndex = 35
        Me.BTN_RCPNEWNEW.TabStop = False
        '
        'BTNRCP_SHOWRECEIVEDATE
        '
        Me.BTNRCP_SHOWRECEIVEDATE.AutoSize = True
        Me.BTNRCP_SHOWRECEIVEDATE.Checked = True
        Me.BTNRCP_SHOWRECEIVEDATE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BTNRCP_SHOWRECEIVEDATE.Font = New System.Drawing.Font("Cordia New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNRCP_SHOWRECEIVEDATE.Location = New System.Drawing.Point(1082, 85)
        Me.BTNRCP_SHOWRECEIVEDATE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNRCP_SHOWRECEIVEDATE.Name = "BTNRCP_SHOWRECEIVEDATE"
        Me.BTNRCP_SHOWRECEIVEDATE.Size = New System.Drawing.Size(123, 32)
        Me.BTNRCP_SHOWRECEIVEDATE.TabIndex = 57
        Me.BTNRCP_SHOWRECEIVEDATE.Text = "แสดงวันที่รับเงิน"
        Me.BTNRCP_SHOWRECEIVEDATE.UseVisualStyleBackColor = True
        Me.BTNRCP_SHOWRECEIVEDATE.Visible = False
        '
        'BTN_RCPGET
        '
        Me.BTN_RCPGET.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_play_96
        Me.BTN_RCPGET.Location = New System.Drawing.Point(795, 75)
        Me.BTN_RCPGET.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_RCPGET.Name = "BTN_RCPGET"
        Me.BTN_RCPGET.Size = New System.Drawing.Size(29, 30)
        Me.BTN_RCPGET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_RCPGET.TabIndex = 38
        Me.BTN_RCPGET.TabStop = False
        '
        'TXTRCP_BILLNOTo
        '
        Me.TXTRCP_BILLNOTo.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_BILLNOTo.Location = New System.Drawing.Point(513, 72)
        Me.TXTRCP_BILLNOTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_BILLNOTo.Name = "TXTRCP_BILLNOTo"
        Me.TXTRCP_BILLNOTo.Size = New System.Drawing.Size(210, 42)
        Me.TXTRCP_BILLNOTo.TabIndex = 3
        '
        'BTN_RCPBILLTO
        '
        Me.BTN_RCPBILLTO.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTN_RCPBILLTO.Location = New System.Drawing.Point(740, 75)
        Me.BTN_RCPBILLTO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_RCPBILLTO.Name = "BTN_RCPBILLTO"
        Me.BTN_RCPBILLTO.Size = New System.Drawing.Size(37, 27)
        Me.BTN_RCPBILLTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_RCPBILLTO.TabIndex = 35
        Me.BTN_RCPBILLTO.TabStop = False
        '
        'BTN_RCPBILLFROM
        '
        Me.BTN_RCPBILLFROM.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTN_RCPBILLFROM.Location = New System.Drawing.Point(400, 75)
        Me.BTN_RCPBILLFROM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_RCPBILLFROM.Name = "BTN_RCPBILLFROM"
        Me.BTN_RCPBILLFROM.Size = New System.Drawing.Size(37, 27)
        Me.BTN_RCPBILLFROM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_RCPBILLFROM.TabIndex = 33
        Me.BTN_RCPBILLFROM.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(452, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 34)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "ถึง"
        '
        'TXTRCP_BILLNOFrom
        '
        Me.TXTRCP_BILLNOFrom.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_BILLNOFrom.Location = New System.Drawing.Point(170, 70)
        Me.TXTRCP_BILLNOFrom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_BILLNOFrom.Name = "TXTRCP_BILLNOFrom"
        Me.TXTRCP_BILLNOFrom.Size = New System.Drawing.Size(210, 42)
        Me.TXTRCP_BILLNOFrom.TabIndex = 2
        '
        'BTN_SHOWCHEQDATE
        '
        Me.BTN_SHOWCHEQDATE.AutoSize = True
        Me.BTN_SHOWCHEQDATE.Checked = True
        Me.BTN_SHOWCHEQDATE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BTN_SHOWCHEQDATE.Font = New System.Drawing.Font("Cordia New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_SHOWCHEQDATE.Location = New System.Drawing.Point(965, 85)
        Me.BTN_SHOWCHEQDATE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_SHOWCHEQDATE.Name = "BTN_SHOWCHEQDATE"
        Me.BTN_SHOWCHEQDATE.Size = New System.Drawing.Size(109, 32)
        Me.BTN_SHOWCHEQDATE.TabIndex = 56
        Me.BTN_SHOWCHEQDATE.Text = "แสดงวันที่เช็ค"
        Me.BTN_SHOWCHEQDATE.UseVisualStyleBackColor = True
        Me.BTN_SHOWCHEQDATE.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 34)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "เลขที่ใบวางบิล"
        '
        'BTN_BILLFINDCUST
        '
        Me.BTN_BILLFINDCUST.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTN_BILLFINDCUST.Location = New System.Drawing.Point(400, 20)
        Me.BTN_BILLFINDCUST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_BILLFINDCUST.Name = "BTN_BILLFINDCUST"
        Me.BTN_BILLFINDCUST.Size = New System.Drawing.Size(37, 27)
        Me.BTN_BILLFINDCUST.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_BILLFINDCUST.TabIndex = 31
        Me.BTN_BILLFINDCUST.TabStop = False
        '
        'txtNAMECUST
        '
        Me.txtNAMECUST.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNAMECUST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNAMECUST.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtNAMECUST.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNAMECUST.Location = New System.Drawing.Point(510, 20)
        Me.txtNAMECUST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNAMECUST.Name = "txtNAMECUST"
        Me.txtNAMECUST.ReadOnly = True
        Me.txtNAMECUST.Size = New System.Drawing.Size(620, 35)
        Me.txtNAMECUST.TabIndex = 30
        '
        'TXTRCP_IDCUST
        '
        Me.TXTRCP_IDCUST.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_IDCUST.Location = New System.Drawing.Point(170, 20)
        Me.TXTRCP_IDCUST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_IDCUST.Name = "TXTRCP_IDCUST"
        Me.TXTRCP_IDCUST.Size = New System.Drawing.Size(210, 42)
        Me.TXTRCP_IDCUST.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 34)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "รหัสลูกค้า"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Controls.Add(Me.txtRCPSTA)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.BTN_TAXReceipt)
        Me.GroupBox3.Controls.Add(Me.BTN_Receipt)
        Me.GroupBox3.Controls.Add(Me.txtRCP_Comment)
        Me.GroupBox3.Controls.Add(Me.TXTRCP_REF)
        Me.GroupBox3.Controls.Add(Me.BTN_RCPOPTFD)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtRCP_INVDATE)
        Me.GroupBox3.Controls.Add(Me.txtRCP_DOCDATE)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TXTRCP_RCPNO)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(1550, 124)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'txtRCPSTA
        '
        Me.txtRCPSTA.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtRCPSTA.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCPSTA.Location = New System.Drawing.Point(745, 20)
        Me.txtRCPSTA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRCPSTA.Name = "txtRCPSTA"
        Me.txtRCPSTA.ReadOnly = True
        Me.txtRCPSTA.Size = New System.Drawing.Size(140, 42)
        Me.txtRCPSTA.TabIndex = 46
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label22.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(665, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 34)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "สถานะ"
        '
        'BTN_TAXReceipt
        '
        Me.BTN_TAXReceipt.AutoSize = True
        Me.BTN_TAXReceipt.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_TAXReceipt.Location = New System.Drawing.Point(515, 20)
        Me.BTN_TAXReceipt.Name = "BTN_TAXReceipt"
        Me.BTN_TAXReceipt.Size = New System.Drawing.Size(123, 38)
        Me.BTN_TAXReceipt.TabIndex = 6
        Me.BTN_TAXReceipt.Text = "Tax Receipt"
        Me.BTN_TAXReceipt.UseVisualStyleBackColor = True
        '
        'BTN_Receipt
        '
        Me.BTN_Receipt.AutoSize = True
        Me.BTN_Receipt.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_Receipt.Location = New System.Drawing.Point(405, 20)
        Me.BTN_Receipt.Name = "BTN_Receipt"
        Me.BTN_Receipt.Size = New System.Drawing.Size(92, 38)
        Me.BTN_Receipt.TabIndex = 5
        Me.BTN_Receipt.Text = "Receipt"
        Me.BTN_Receipt.UseVisualStyleBackColor = True
        '
        'txtRCP_Comment
        '
        Me.txtRCP_Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRCP_Comment.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCP_Comment.Location = New System.Drawing.Point(515, 70)
        Me.txtRCP_Comment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRCP_Comment.Name = "txtRCP_Comment"
        Me.txtRCP_Comment.Size = New System.Drawing.Size(370, 45)
        Me.txtRCP_Comment.TabIndex = 10
        Me.txtRCP_Comment.Text = ""
        '
        'TXTRCP_REF
        '
        Me.TXTRCP_REF.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_REF.Location = New System.Drawing.Point(170, 70)
        Me.TXTRCP_REF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_REF.Name = "TXTRCP_REF"
        Me.TXTRCP_REF.Size = New System.Drawing.Size(210, 42)
        Me.TXTRCP_REF.TabIndex = 9
        '
        'BTN_RCPOPTFD
        '
        Me.BTN_RCPOPTFD.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_RCPOPTFD.Location = New System.Drawing.Point(900, 75)
        Me.BTN_RCPOPTFD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_RCPOPTFD.Name = "BTN_RCPOPTFD"
        Me.BTN_RCPOPTFD.Size = New System.Drawing.Size(120, 35)
        Me.BTN_RCPOPTFD.TabIndex = 11
        Me.BTN_RCPOPTFD.Text = "Optional"
        Me.BTN_RCPOPTFD.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(405, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 34)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "รายละเอียด"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 34)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "อ้างอิง"
        '
        'txtRCP_INVDATE
        '
        Me.txtRCP_INVDATE.CalendarFont = New System.Drawing.Font("Cordia New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCP_INVDATE.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCP_INVDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtRCP_INVDATE.Location = New System.Drawing.Point(1375, 20)
        Me.txtRCP_INVDATE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRCP_INVDATE.Name = "txtRCP_INVDATE"
        Me.txtRCP_INVDATE.Size = New System.Drawing.Size(140, 42)
        Me.txtRCP_INVDATE.TabIndex = 8
        '
        'txtRCP_DOCDATE
        '
        Me.txtRCP_DOCDATE.CalendarFont = New System.Drawing.Font("Cordia New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCP_DOCDATE.Enabled = False
        Me.txtRCP_DOCDATE.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCP_DOCDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtRCP_DOCDATE.Location = New System.Drawing.Point(1080, 20)
        Me.txtRCP_DOCDATE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRCP_DOCDATE.Name = "txtRCP_DOCDATE"
        Me.txtRCP_DOCDATE.Size = New System.Drawing.Size(140, 42)
        Me.txtRCP_DOCDATE.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(1245, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 34)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "วันที่เอกสาร"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(935, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 34)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "วันที่ทำรายการ"
        '
        'TXTRCP_RCPNO
        '
        Me.TXTRCP_RCPNO.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_RCPNO.Location = New System.Drawing.Point(170, 20)
        Me.TXTRCP_RCPNO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTRCP_RCPNO.Name = "TXTRCP_RCPNO"
        Me.TXTRCP_RCPNO.ReadOnly = True
        Me.TXTRCP_RCPNO.Size = New System.Drawing.Size(210, 42)
        Me.TXTRCP_RCPNO.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 34)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "เลขที่ใบเสร็จรับเงิน"
        '
        'txtRCPAMOUNT
        '
        Me.txtRCPAMOUNT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRCPAMOUNT.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtRCPAMOUNT.Enabled = False
        Me.txtRCPAMOUNT.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCPAMOUNT.ForeColor = System.Drawing.Color.Black
        Me.txtRCPAMOUNT.Location = New System.Drawing.Point(1337, 11)
        Me.txtRCPAMOUNT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRCPAMOUNT.Name = "txtRCPAMOUNT"
        Me.txtRCPAMOUNT.ReadOnly = True
        Me.txtRCPAMOUNT.Size = New System.Drawing.Size(210, 42)
        Me.txtRCPAMOUNT.TabIndex = 57
        Me.txtRCPAMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(1175, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(147, 34)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "รวมจำนวนเงินที่รับ"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBANKBATCH
        '
        Me.txtBANKBATCH.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBANKBATCH.FormattingEnabled = True
        Me.txtBANKBATCH.Location = New System.Drawing.Point(205, 10)
        Me.txtBANKBATCH.Name = "txtBANKBATCH"
        Me.txtBANKBATCH.Size = New System.Drawing.Size(209, 42)
        Me.txtBANKBATCH.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(181, 34)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Cash book Bank Code"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.Controls.Add(Me.GroupBox10)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox7.Location = New System.Drawing.Point(0, 760)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox7.Size = New System.Drawing.Size(1574, 145)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtRCPAMOUNT)
        Me.GroupBox9.Controls.Add(Me.txt_RCPDATECB)
        Me.GroupBox9.Controls.Add(Me.Label16)
        Me.GroupBox9.Controls.Add(Me.Label20)
        Me.GroupBox9.Controls.Add(Me.txtBANKBATCH)
        Me.GroupBox9.Controls.Add(Me.Label18)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox9.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(1568, 58)
        Me.GroupBox9.TabIndex = 50
        Me.GroupBox9.TabStop = False
        '
        'txt_RCPDATECB
        '
        Me.txt_RCPDATECB.CalendarFont = New System.Drawing.Font("Cordia New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_RCPDATECB.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_RCPDATECB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_RCPDATECB.Location = New System.Drawing.Point(620, 10)
        Me.txt_RCPDATECB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_RCPDATECB.Name = "txt_RCPDATECB"
        Me.txt_RCPDATECB.Size = New System.Drawing.Size(140, 42)
        Me.txt_RCPDATECB.TabIndex = 23
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(430, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(172, 34)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Cash book entry date"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.BTNRCP_PRINT)
        Me.GroupBox10.Controls.Add(Me.BTNBill_NEW)
        Me.GroupBox10.Controls.Add(Me.BTNBill_REFRESH)
        Me.GroupBox10.Controls.Add(Me.BTNBill_POST)
        Me.GroupBox10.Controls.Add(Me.BTNBill_DELETE)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox10.Location = New System.Drawing.Point(3, 77)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1568, 66)
        Me.GroupBox10.TabIndex = 13
        Me.GroupBox10.TabStop = False
        '
        'BTNRCP_PRINT
        '
        Me.BTNRCP_PRINT.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNRCP_PRINT.Location = New System.Drawing.Point(295, 15)
        Me.BTNRCP_PRINT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNRCP_PRINT.Name = "BTNRCP_PRINT"
        Me.BTNRCP_PRINT.Size = New System.Drawing.Size(99, 35)
        Me.BTNRCP_PRINT.TabIndex = 26
        Me.BTNRCP_PRINT.Text = "Print"
        Me.BTNRCP_PRINT.UseVisualStyleBackColor = True
        '
        'BTNBill_NEW
        '
        Me.BTNBill_NEW.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BTNBill_NEW.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_NEW.Location = New System.Drawing.Point(572, 15)
        Me.BTNBill_NEW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBill_NEW.Name = "BTNBill_NEW"
        Me.BTNBill_NEW.Size = New System.Drawing.Size(99, 35)
        Me.BTNBill_NEW.TabIndex = 8
        Me.BTNBill_NEW.Text = "New"
        Me.BTNBill_NEW.UseVisualStyleBackColor = True
        Me.BTNBill_NEW.Visible = False
        '
        'BTNBill_REFRESH
        '
        Me.BTNBill_REFRESH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBill_REFRESH.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_REFRESH.Location = New System.Drawing.Point(1442, 16)
        Me.BTNBill_REFRESH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBill_REFRESH.Name = "BTNBill_REFRESH"
        Me.BTNBill_REFRESH.Size = New System.Drawing.Size(99, 35)
        Me.BTNBill_REFRESH.TabIndex = 27
        Me.BTNBill_REFRESH.Text = "Close"
        Me.BTNBill_REFRESH.UseVisualStyleBackColor = True
        '
        'BTNBill_POST
        '
        Me.BTNBill_POST.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_POST.Location = New System.Drawing.Point(11, 15)
        Me.BTNBill_POST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBill_POST.Name = "BTNBill_POST"
        Me.BTNBill_POST.Size = New System.Drawing.Size(99, 35)
        Me.BTNBill_POST.TabIndex = 24
        Me.BTNBill_POST.Text = "Save"
        Me.BTNBill_POST.UseVisualStyleBackColor = True
        '
        'BTNBill_DELETE
        '
        Me.BTNBill_DELETE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_DELETE.Location = New System.Drawing.Point(153, 15)
        Me.BTNBill_DELETE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBill_DELETE.Name = "BTNBill_DELETE"
        Me.BTNBill_DELETE.Size = New System.Drawing.Size(99, 35)
        Me.BTNBill_DELETE.TabIndex = 25
        Me.BTNBill_DELETE.Text = "Delete"
        Me.BTNBill_DELETE.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.DGV_RCP)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Location = New System.Drawing.Point(0, 505)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.Size = New System.Drawing.Size(1574, 255)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        '
        'DGV_RCP
        '
        Me.DGV_RCP.AllowUserToAddRows = False
        Me.DGV_RCP.AllowUserToDeleteRows = False
        Me.DGV_RCP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_RCP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_RCP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_RCP.ColumnHeadersHeight = 29
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_RCP.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_RCP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_RCP.Location = New System.Drawing.Point(3, 17)
        Me.DGV_RCP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_RCP.Name = "DGV_RCP"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_RCP.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_RCP.RowHeadersWidth = 51
        Me.DGV_RCP.RowTemplate.Height = 24
        Me.DGV_RCP.Size = New System.Drawing.Size(1568, 236)
        Me.DGV_RCP.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1574, 905)
        Me.Panel1.TabIndex = 4
        '
        'FrmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1574, 905)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmReceipt"
        Me.ShowIcon = False
        Me.Text = "Receipt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupPAYTYPE.ResumeLayout(False)
        Me.GroupPAYTYPE.PerformLayout()
        Me.GroupPAYMENT.ResumeLayout(False)
        Me.GroupPAYMENT.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.BTNRCP_TRANSBANK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BTN_RCPNEWNEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_RCPGET, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_RCPBILLTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_RCPBILLFROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_BILLFINDCUST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DGV_RCP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXTRCP_BILLNOFrom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_BILLFINDCUST As PictureBox
    Friend WithEvents txtNAMECUST As TextBox
    Friend WithEvents TXTRCP_IDCUST As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_RCPBILLTO As PictureBox
    Friend WithEvents BTN_RCPBILLFROM As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTRCP_BILLNOTo As TextBox
    Friend WithEvents TXTRCP_RCPNO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRCP_INVDATE As DateTimePicker
    Friend WithEvents txtRCP_DOCDATE As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRCP_Comment As RichTextBox
    Friend WithEvents TXTRCP_REF As TextBox
    Friend WithEvents BTN_RCPOPTFD As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BTN_SHOWCHEQDATE As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTRCP_CHEQACCT As TextBox
    Friend WithEvents TXTRCP_CHEQBRANCH As TextBox
    Friend WithEvents TXTRCP_CHEQNO As TextBox
    Friend WithEvents BTNRCP_Credit As RadioButton
    Friend WithEvents BTNRCP_TRANSFER As RadioButton
    Friend WithEvents BTNRCP_CASH As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TXTRCP_TRANSBANKNO As TextBox
    Friend WithEvents TXTRCP_TRANSBANKCODE As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents BTNRCP_TRANSBANK As PictureBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents GroupPAYMENT As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TXTRCP_CRCARDNO As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TXTRCP_PAYDATE As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupPAYTYPE As GroupBox
    Friend WithEvents BTNRCP_ALL As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXTRCP_TRANSFEE As TextBox
    Friend WithEvents txtRCPAMOUNT As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents BTNBill_REFRESH As Button
    Friend WithEvents BTNRCP_PRINT As Button
    Friend WithEvents BTNBill_DELETE As Button
    Friend WithEvents BTNBill_POST As Button
    Friend WithEvents BTNBill_NEW As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents DGV_RCP As DataGridView
    Friend WithEvents BTNRCP_SHOWRECEIVEDATE As CheckBox
    Friend WithEvents BTN_RCPGET As PictureBox
    Friend WithEvents BTN_TAXReceipt As RadioButton
    Friend WithEvents BTN_Receipt As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBANKBATCH As ComboBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txt_RCPDATECB As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents BTN_RCPNEWNEW As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents BTNRCP_CHQBANKCODE As ComboBox
    Friend WithEvents txtRCPSTA As TextBox
    Friend WithEvents Label22 As Label
    Public WithEvents BTNRCP_Cheque As RadioButton
End Class
