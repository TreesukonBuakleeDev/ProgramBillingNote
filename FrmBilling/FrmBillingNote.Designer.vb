<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBillingNote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBillingNote))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSTA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BTN_BILLNEWNEW = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbmBOI = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBILL_TERMCODE = New System.Windows.Forms.TextBox()
        Me.txtBILL_Comment = New System.Windows.Forms.RichTextBox()
        Me.TXTBILL_REF = New System.Windows.Forms.TextBox()
        Me.CHBXBILL_SHOW = New System.Windows.Forms.CheckBox()
        Me.BTN_GETBILL = New System.Windows.Forms.PictureBox()
        Me.BTN_BILLFINDCUST = New System.Windows.Forms.PictureBox()
        Me.txtBILL_DueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtBILL_INVDATE = New System.Windows.Forms.DateTimePicker()
        Me.txtBill_DOCDATE = New System.Windows.Forms.DateTimePicker()
        Me.TXTBILL_DATEF = New System.Windows.Forms.DateTimePicker()
        Me.TXTBILL_DATET = New System.Windows.Forms.DateTimePicker()
        Me.txtNAMECUST = New System.Windows.Forms.TextBox()
        Me.TXTBILL_IDCUST = New System.Windows.Forms.TextBox()
        Me.TXTBILL_BILLNO = New System.Windows.Forms.TextBox()
        Me.BTN_BILLALL = New System.Windows.Forms.CheckBox()
        Me.BTN_BILLOPTFD = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DGV_BILL = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBILLAMOUNT = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BTNBill_REFRESH = New System.Windows.Forms.Button()
        Me.BTNBill_PRINT = New System.Windows.Forms.Button()
        Me.BTNBill_DELETE = New System.Windows.Forms.Button()
        Me.BTNBill_POST = New System.Windows.Forms.Button()
        Me.BTNBill_NEW = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BTN_BILLNEWNEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_GETBILL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_BILLFINDCUST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_BILL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.txtSTA)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.BTN_BILLNEWNEW)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.CbmBOI)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtBILL_TERMCODE)
        Me.GroupBox1.Controls.Add(Me.txtBILL_Comment)
        Me.GroupBox1.Controls.Add(Me.TXTBILL_REF)
        Me.GroupBox1.Controls.Add(Me.CHBXBILL_SHOW)
        Me.GroupBox1.Controls.Add(Me.BTN_GETBILL)
        Me.GroupBox1.Controls.Add(Me.BTN_BILLFINDCUST)
        Me.GroupBox1.Controls.Add(Me.txtBILL_DueDate)
        Me.GroupBox1.Controls.Add(Me.txtBILL_INVDATE)
        Me.GroupBox1.Controls.Add(Me.txtBill_DOCDATE)
        Me.GroupBox1.Controls.Add(Me.TXTBILL_DATEF)
        Me.GroupBox1.Controls.Add(Me.TXTBILL_DATET)
        Me.GroupBox1.Controls.Add(Me.txtNAMECUST)
        Me.GroupBox1.Controls.Add(Me.TXTBILL_IDCUST)
        Me.GroupBox1.Controls.Add(Me.TXTBILL_BILLNO)
        Me.GroupBox1.Controls.Add(Me.BTN_BILLALL)
        Me.GroupBox1.Controls.Add(Me.BTN_BILLOPTFD)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1513, 412)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtSTA
        '
        Me.txtSTA.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtSTA.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSTA.Location = New System.Drawing.Point(700, 65)
        Me.txtSTA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSTA.Name = "txtSTA"
        Me.txtSTA.ReadOnly = True
        Me.txtSTA.Size = New System.Drawing.Size(140, 42)
        Me.txtSTA.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label11.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(565, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 34)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "สถานะ"
        '
        'BTN_BILLNEWNEW
        '
        Me.BTN_BILLNEWNEW.Image = CType(resources.GetObject("BTN_BILLNEWNEW.Image"), System.Drawing.Image)
        Me.BTN_BILLNEWNEW.Location = New System.Drawing.Point(480, 70)
        Me.BTN_BILLNEWNEW.Name = "BTN_BILLNEWNEW"
        Me.BTN_BILLNEWNEW.Size = New System.Drawing.Size(25, 25)
        Me.BTN_BILLNEWNEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_BILLNEWNEW.TabIndex = 34
        Me.BTN_BILLNEWNEW.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label12.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(565, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 34)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "BOI"
        '
        'CbmBOI
        '
        Me.CbmBOI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbmBOI.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CbmBOI.FormattingEnabled = True
        Me.CbmBOI.Items.AddRange(New Object() {"BOI", "NON BOI"})
        Me.CbmBOI.Location = New System.Drawing.Point(700, 165)
        Me.CbmBOI.Name = "CbmBOI"
        Me.CbmBOI.Size = New System.Drawing.Size(140, 42)
        Me.CbmBOI.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label13.Font = New System.Drawing.Font("Cordia New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label13.Location = New System.Drawing.Point(585, 360)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 28)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Term code"
        Me.Label13.Visible = False
        '
        'txtBILL_TERMCODE
        '
        Me.txtBILL_TERMCODE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBILL_TERMCODE.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtBILL_TERMCODE.Font = New System.Drawing.Font("Cordia New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBILL_TERMCODE.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtBILL_TERMCODE.Location = New System.Drawing.Point(700, 365)
        Me.txtBILL_TERMCODE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBILL_TERMCODE.Name = "txtBILL_TERMCODE"
        Me.txtBILL_TERMCODE.Size = New System.Drawing.Size(137, 28)
        Me.txtBILL_TERMCODE.TabIndex = 30
        Me.txtBILL_TERMCODE.Visible = False
        '
        'txtBILL_Comment
        '
        Me.txtBILL_Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBILL_Comment.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBILL_Comment.Location = New System.Drawing.Point(700, 305)
        Me.txtBILL_Comment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBILL_Comment.Name = "txtBILL_Comment"
        Me.txtBILL_Comment.Size = New System.Drawing.Size(365, 50)
        Me.txtBILL_Comment.TabIndex = 12
        Me.txtBILL_Comment.Text = ""
        '
        'TXTBILL_REF
        '
        Me.TXTBILL_REF.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTBILL_REF.Location = New System.Drawing.Point(235, 305)
        Me.TXTBILL_REF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTBILL_REF.Name = "TXTBILL_REF"
        Me.TXTBILL_REF.Size = New System.Drawing.Size(210, 42)
        Me.TXTBILL_REF.TabIndex = 11
        '
        'CHBXBILL_SHOW
        '
        Me.CHBXBILL_SHOW.AutoSize = True
        Me.CHBXBILL_SHOW.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CHBXBILL_SHOW.Location = New System.Drawing.Point(915, 255)
        Me.CHBXBILL_SHOW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CHBXBILL_SHOW.Name = "CHBXBILL_SHOW"
        Me.CHBXBILL_SHOW.Size = New System.Drawing.Size(98, 38)
        Me.CHBXBILL_SHOW.TabIndex = 7
        Me.CHBXBILL_SHOW.Text = "Show All"
        Me.CHBXBILL_SHOW.UseVisualStyleBackColor = True
        '
        'BTN_GETBILL
        '
        Me.BTN_GETBILL.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_play_96
        Me.BTN_GETBILL.Location = New System.Drawing.Point(850, 260)
        Me.BTN_GETBILL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_GETBILL.Name = "BTN_GETBILL"
        Me.BTN_GETBILL.Size = New System.Drawing.Size(29, 30)
        Me.BTN_GETBILL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_GETBILL.TabIndex = 26
        Me.BTN_GETBILL.TabStop = False
        '
        'BTN_BILLFINDCUST
        '
        Me.BTN_BILLFINDCUST.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTN_BILLFINDCUST.Location = New System.Drawing.Point(475, 165)
        Me.BTN_BILLFINDCUST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_BILLFINDCUST.Name = "BTN_BILLFINDCUST"
        Me.BTN_BILLFINDCUST.Size = New System.Drawing.Size(37, 27)
        Me.BTN_BILLFINDCUST.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_BILLFINDCUST.TabIndex = 25
        Me.BTN_BILLFINDCUST.TabStop = False
        '
        'txtBILL_DueDate
        '
        Me.txtBILL_DueDate.CalendarFont = New System.Drawing.Font("Cordia New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBILL_DueDate.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBILL_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtBILL_DueDate.Location = New System.Drawing.Point(1059, 110)
        Me.txtBILL_DueDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBILL_DueDate.Name = "txtBILL_DueDate"
        Me.txtBILL_DueDate.Size = New System.Drawing.Size(140, 42)
        Me.txtBILL_DueDate.TabIndex = 10
        '
        'txtBILL_INVDATE
        '
        Me.txtBILL_INVDATE.CalendarFont = New System.Drawing.Font("Cordia New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBILL_INVDATE.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBILL_INVDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtBILL_INVDATE.Location = New System.Drawing.Point(700, 115)
        Me.txtBILL_INVDATE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBILL_INVDATE.Name = "txtBILL_INVDATE"
        Me.txtBILL_INVDATE.Size = New System.Drawing.Size(140, 42)
        Me.txtBILL_INVDATE.TabIndex = 9
        '
        'txtBill_DOCDATE
        '
        Me.txtBill_DOCDATE.CalendarFont = New System.Drawing.Font("Cordia New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBill_DOCDATE.Enabled = False
        Me.txtBill_DOCDATE.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBill_DOCDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtBill_DOCDATE.Location = New System.Drawing.Point(237, 115)
        Me.txtBill_DOCDATE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBill_DOCDATE.Name = "txtBill_DOCDATE"
        Me.txtBill_DOCDATE.Size = New System.Drawing.Size(130, 42)
        Me.txtBill_DOCDATE.TabIndex = 8
        '
        'TXTBILL_DATEF
        '
        Me.TXTBILL_DATEF.CalendarFont = New System.Drawing.Font("Cordia New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTBILL_DATEF.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTBILL_DATEF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXTBILL_DATEF.Location = New System.Drawing.Point(235, 255)
        Me.TXTBILL_DATEF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTBILL_DATEF.Name = "TXTBILL_DATEF"
        Me.TXTBILL_DATEF.Size = New System.Drawing.Size(140, 42)
        Me.TXTBILL_DATEF.TabIndex = 4
        '
        'TXTBILL_DATET
        '
        Me.TXTBILL_DATET.CalendarFont = New System.Drawing.Font("Cordia New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTBILL_DATET.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTBILL_DATET.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXTBILL_DATET.Location = New System.Drawing.Point(700, 255)
        Me.TXTBILL_DATET.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTBILL_DATET.Name = "TXTBILL_DATET"
        Me.TXTBILL_DATET.Size = New System.Drawing.Size(140, 42)
        Me.TXTBILL_DATET.TabIndex = 5
        '
        'txtNAMECUST
        '
        Me.txtNAMECUST.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNAMECUST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNAMECUST.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtNAMECUST.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNAMECUST.Location = New System.Drawing.Point(235, 215)
        Me.txtNAMECUST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNAMECUST.Name = "txtNAMECUST"
        Me.txtNAMECUST.ReadOnly = True
        Me.txtNAMECUST.Size = New System.Drawing.Size(970, 35)
        Me.txtNAMECUST.TabIndex = 18
        '
        'TXTBILL_IDCUST
        '
        Me.TXTBILL_IDCUST.AcceptsTab = True
        Me.TXTBILL_IDCUST.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTBILL_IDCUST.Location = New System.Drawing.Point(236, 165)
        Me.TXTBILL_IDCUST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTBILL_IDCUST.Name = "TXTBILL_IDCUST"
        Me.TXTBILL_IDCUST.Size = New System.Drawing.Size(210, 42)
        Me.TXTBILL_IDCUST.TabIndex = 2
        Me.TXTBILL_IDCUST.WordWrap = False
        '
        'TXTBILL_BILLNO
        '
        Me.TXTBILL_BILLNO.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTBILL_BILLNO.Location = New System.Drawing.Point(237, 65)
        Me.TXTBILL_BILLNO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTBILL_BILLNO.Name = "TXTBILL_BILLNO"
        Me.TXTBILL_BILLNO.Size = New System.Drawing.Size(210, 42)
        Me.TXTBILL_BILLNO.TabIndex = 1
        '
        'BTN_BILLALL
        '
        Me.BTN_BILLALL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_BILLALL.AutoSize = True
        Me.BTN_BILLALL.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_BILLALL.Location = New System.Drawing.Point(10, 370)
        Me.BTN_BILLALL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_BILLALL.Name = "BTN_BILLALL"
        Me.BTN_BILLALL.Size = New System.Drawing.Size(104, 38)
        Me.BTN_BILLALL.TabIndex = 15
        Me.BTN_BILLALL.Text = "Select All"
        Me.BTN_BILLALL.UseVisualStyleBackColor = True
        '
        'BTN_BILLOPTFD
        '
        Me.BTN_BILLOPTFD.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_BILLOPTFD.Location = New System.Drawing.Point(1085, 312)
        Me.BTN_BILLOPTFD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_BILLOPTFD.Name = "BTN_BILLOPTFD"
        Me.BTN_BILLOPTFD.Size = New System.Drawing.Size(99, 40)
        Me.BTN_BILLOPTFD.TabIndex = 13
        Me.BTN_BILLOPTFD.Text = "Optional"
        Me.BTN_BILLOPTFD.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label10.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(570, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 34)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "รายละเอียด"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label9.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 34)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "อ้างอิง"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label8.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(920, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 34)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "วันที่นัดชำระ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label7.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(565, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 34)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "วันที่เอกสาร"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label6.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(570, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 34)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "ถึง"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 34)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "วันที่ทำรายการ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 34)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Invoice ระหว่างวันที่"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 34)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "เลขที่ใบวางบิล"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "รหัสลูกค้า"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(703, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 38)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ใบวางบิล"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_BILL
        '
        Me.DGV_BILL.AllowUserToAddRows = False
        Me.DGV_BILL.AllowUserToDeleteRows = False
        Me.DGV_BILL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_BILL.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_BILL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_BILL.ColumnHeadersHeight = 60
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_BILL.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_BILL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_BILL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DGV_BILL.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_BILL.Location = New System.Drawing.Point(3, 429)
        Me.DGV_BILL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_BILL.Name = "DGV_BILL"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_BILL.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_BILL.RowHeadersWidth = 51
        Me.DGV_BILL.RowTemplate.Height = 24
        Me.DGV_BILL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_BILL.Size = New System.Drawing.Size(1513, 286)
        Me.DGV_BILL.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBILLAMOUNT)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.BTNBill_REFRESH)
        Me.GroupBox3.Controls.Add(Me.BTNBill_PRINT)
        Me.GroupBox3.Controls.Add(Me.BTNBill_DELETE)
        Me.GroupBox3.Controls.Add(Me.BTNBill_POST)
        Me.GroupBox3.Controls.Add(Me.BTNBill_NEW)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(3, 715)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(1513, 75)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'txtBILLAMOUNT
        '
        Me.txtBILLAMOUNT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBILLAMOUNT.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtBILLAMOUNT.Enabled = False
        Me.txtBILLAMOUNT.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBILLAMOUNT.ForeColor = System.Drawing.Color.Black
        Me.txtBILLAMOUNT.Location = New System.Drawing.Point(1115, 25)
        Me.txtBILLAMOUNT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBILLAMOUNT.Name = "txtBILLAMOUNT"
        Me.txtBILLAMOUNT.ReadOnly = True
        Me.txtBILLAMOUNT.Size = New System.Drawing.Size(210, 42)
        Me.txtBILLAMOUNT.TabIndex = 59
        Me.txtBILLAMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(935, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(164, 34)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "รวมจำนวนเงินวางบิล"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BTNBill_REFRESH
        '
        Me.BTNBill_REFRESH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBill_REFRESH.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_REFRESH.Location = New System.Drawing.Point(1380, 25)
        Me.BTNBill_REFRESH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBill_REFRESH.Name = "BTNBill_REFRESH"
        Me.BTNBill_REFRESH.Size = New System.Drawing.Size(99, 40)
        Me.BTNBill_REFRESH.TabIndex = 20
        Me.BTNBill_REFRESH.Text = "Close"
        Me.BTNBill_REFRESH.UseVisualStyleBackColor = True
        '
        'BTNBill_PRINT
        '
        Me.BTNBill_PRINT.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_PRINT.Location = New System.Drawing.Point(285, 25)
        Me.BTNBill_PRINT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBill_PRINT.Name = "BTNBill_PRINT"
        Me.BTNBill_PRINT.Size = New System.Drawing.Size(99, 40)
        Me.BTNBill_PRINT.TabIndex = 19
        Me.BTNBill_PRINT.Text = "Print"
        Me.BTNBill_PRINT.UseVisualStyleBackColor = True
        '
        'BTNBill_DELETE
        '
        Me.BTNBill_DELETE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_DELETE.Location = New System.Drawing.Point(156, 25)
        Me.BTNBill_DELETE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBill_DELETE.Name = "BTNBill_DELETE"
        Me.BTNBill_DELETE.Size = New System.Drawing.Size(99, 40)
        Me.BTNBill_DELETE.TabIndex = 18
        Me.BTNBill_DELETE.Text = "Delete"
        Me.BTNBill_DELETE.UseVisualStyleBackColor = True
        '
        'BTNBill_POST
        '
        Me.BTNBill_POST.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_POST.Location = New System.Drawing.Point(28, 25)
        Me.BTNBill_POST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBill_POST.Name = "BTNBill_POST"
        Me.BTNBill_POST.Size = New System.Drawing.Size(99, 40)
        Me.BTNBill_POST.TabIndex = 17
        Me.BTNBill_POST.Text = "Save"
        Me.BTNBill_POST.UseVisualStyleBackColor = True
        '
        'BTNBill_NEW
        '
        Me.BTNBill_NEW.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_NEW.Location = New System.Drawing.Point(440, 25)
        Me.BTNBill_NEW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBill_NEW.Name = "BTNBill_NEW"
        Me.BTNBill_NEW.Size = New System.Drawing.Size(99, 40)
        Me.BTNBill_NEW.TabIndex = 16
        Me.BTNBill_NEW.Text = "New"
        Me.BTNBill_NEW.UseVisualStyleBackColor = True
        Me.BTNBill_NEW.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1519, 792)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_BILL)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1519, 792)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'FrmBillingNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1519, 792)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmBillingNote"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Note"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BTN_BILLNEWNEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_GETBILL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_BILLFINDCUST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_BILL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DGV_BILL As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_BILLOPTFD As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CHBXBILL_SHOW As CheckBox
    Friend WithEvents BTN_GETBILL As PictureBox
    Friend WithEvents BTN_BILLFINDCUST As PictureBox
    Friend WithEvents txtBILL_DueDate As DateTimePicker
    Friend WithEvents txtBILL_INVDATE As DateTimePicker
    Friend WithEvents txtBill_DOCDATE As DateTimePicker
    Friend WithEvents TXTBILL_DATEF As DateTimePicker
    Friend WithEvents TXTBILL_DATET As DateTimePicker
    Friend WithEvents txtNAMECUST As TextBox
    Friend WithEvents TXTBILL_IDCUST As TextBox
    Friend WithEvents TXTBILL_BILLNO As TextBox
    Friend WithEvents BTN_BILLALL As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BTNBill_REFRESH As Button
    Friend WithEvents BTNBill_PRINT As Button
    Friend WithEvents BTNBill_DELETE As Button
    Friend WithEvents BTNBill_POST As Button
    Friend WithEvents BTNBill_NEW As Button
    Friend WithEvents txtBILL_Comment As RichTextBox
    Friend WithEvents TXTBILL_REF As TextBox
    Friend WithEvents txtBILL_TERMCODE As TextBox
    Friend WithEvents CbmBOI As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BTN_BILLNEWNEW As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBILLAMOUNT As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtSTA As TextBox
    Friend WithEvents Label11 As Label
End Class
