<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrintBillSummary
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTN_ReportClose = New System.Windows.Forms.Button()
        Me.BTN_PrintSumm = New System.Windows.Forms.Button()
        Me.txtReport_DATET = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReport_DATEF = New System.Windows.Forms.DateTimePicker()
        Me.lb_date = New System.Windows.Forms.Label()
        Me.BTNReportS_BILLTO = New System.Windows.Forms.PictureBox()
        Me.BTNReportS_BILLF = New System.Windows.Forms.PictureBox()
        Me.txtReport_BILLNOT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReport_BILLNOF = New System.Windows.Forms.TextBox()
        Me.lb_Doc = New System.Windows.Forms.Label()
        Me.BTNReportS_CUSTTO = New System.Windows.Forms.PictureBox()
        Me.BTNReportS_CUSTF = New System.Windows.Forms.PictureBox()
        Me.txtReport_CUSTT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHeader = New System.Windows.Forms.Label()
        Me.txtReport_CUSTF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReport_CBIMPORT = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BTNReportS_BILLTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNReportS_BILLF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNReportS_CUSTTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNReportS_CUSTF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtReport_CBIMPORT)
        Me.GroupBox1.Controls.Add(Me.BTN_ReportClose)
        Me.GroupBox1.Controls.Add(Me.BTN_PrintSumm)
        Me.GroupBox1.Controls.Add(Me.txtReport_DATET)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtReport_DATEF)
        Me.GroupBox1.Controls.Add(Me.lb_date)
        Me.GroupBox1.Controls.Add(Me.BTNReportS_BILLTO)
        Me.GroupBox1.Controls.Add(Me.BTNReportS_BILLF)
        Me.GroupBox1.Controls.Add(Me.txtReport_BILLNOT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtReport_BILLNOF)
        Me.GroupBox1.Controls.Add(Me.lb_Doc)
        Me.GroupBox1.Controls.Add(Me.BTNReportS_CUSTTO)
        Me.GroupBox1.Controls.Add(Me.BTNReportS_CUSTF)
        Me.GroupBox1.Controls.Add(Me.txtReport_CUSTT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtHeader)
        Me.GroupBox1.Controls.Add(Me.txtReport_CUSTF)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Cordia New", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(636, 342)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BTN_ReportClose
        '
        Me.BTN_ReportClose.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_ReportClose.Location = New System.Drawing.Point(510, 285)
        Me.BTN_ReportClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_ReportClose.Name = "BTN_ReportClose"
        Me.BTN_ReportClose.Size = New System.Drawing.Size(99, 35)
        Me.BTN_ReportClose.TabIndex = 47
        Me.BTN_ReportClose.Text = "Close"
        Me.BTN_ReportClose.UseVisualStyleBackColor = True
        '
        'BTN_PrintSumm
        '
        Me.BTN_PrintSumm.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_PrintSumm.Location = New System.Drawing.Point(374, 285)
        Me.BTN_PrintSumm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_PrintSumm.Name = "BTN_PrintSumm"
        Me.BTN_PrintSumm.Size = New System.Drawing.Size(99, 35)
        Me.BTN_PrintSumm.TabIndex = 46
        Me.BTN_PrintSumm.Text = "Print"
        Me.BTN_PrintSumm.UseVisualStyleBackColor = True
        '
        'txtReport_DATET
        '
        Me.txtReport_DATET.CalendarFont = New System.Drawing.Font("Cordia New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReport_DATET.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReport_DATET.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtReport_DATET.Location = New System.Drawing.Point(415, 76)
        Me.txtReport_DATET.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReport_DATET.Name = "txtReport_DATET"
        Me.txtReport_DATET.Size = New System.Drawing.Size(170, 42)
        Me.txtReport_DATET.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(375, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 34)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "ถึง"
        '
        'txtReport_DATEF
        '
        Me.txtReport_DATEF.CalendarFont = New System.Drawing.Font("Cordia New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReport_DATEF.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReport_DATEF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtReport_DATEF.Location = New System.Drawing.Point(160, 76)
        Me.txtReport_DATEF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReport_DATEF.Name = "txtReport_DATEF"
        Me.txtReport_DATEF.Size = New System.Drawing.Size(170, 42)
        Me.txtReport_DATEF.TabIndex = 43
        '
        'lb_date
        '
        Me.lb_date.AutoSize = True
        Me.lb_date.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_date.Location = New System.Drawing.Point(10, 76)
        Me.lb_date.Name = "lb_date"
        Me.lb_date.Size = New System.Drawing.Size(46, 34)
        Me.lb_date.TabIndex = 42
        Me.lb_date.Text = "วันที่"
        '
        'BTNReportS_BILLTO
        '
        Me.BTNReportS_BILLTO.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTNReportS_BILLTO.Location = New System.Drawing.Point(590, 186)
        Me.BTNReportS_BILLTO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNReportS_BILLTO.Name = "BTNReportS_BILLTO"
        Me.BTNReportS_BILLTO.Size = New System.Drawing.Size(37, 27)
        Me.BTNReportS_BILLTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNReportS_BILLTO.TabIndex = 41
        Me.BTNReportS_BILLTO.TabStop = False
        '
        'BTNReportS_BILLF
        '
        Me.BTNReportS_BILLF.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTNReportS_BILLF.Location = New System.Drawing.Point(335, 186)
        Me.BTNReportS_BILLF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNReportS_BILLF.Name = "BTNReportS_BILLF"
        Me.BTNReportS_BILLF.Size = New System.Drawing.Size(37, 27)
        Me.BTNReportS_BILLF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNReportS_BILLF.TabIndex = 40
        Me.BTNReportS_BILLF.TabStop = False
        '
        'txtReport_BILLNOT
        '
        Me.txtReport_BILLNOT.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReport_BILLNOT.Location = New System.Drawing.Point(415, 185)
        Me.txtReport_BILLNOT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReport_BILLNOT.Name = "txtReport_BILLNOT"
        Me.txtReport_BILLNOT.Size = New System.Drawing.Size(168, 42)
        Me.txtReport_BILLNOT.TabIndex = 38
        Me.txtReport_BILLNOT.Text = "zzzzzz"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(375, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 34)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ถึง"
        '
        'txtReport_BILLNOF
        '
        Me.txtReport_BILLNOF.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReport_BILLNOF.Location = New System.Drawing.Point(160, 185)
        Me.txtReport_BILLNOF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReport_BILLNOF.Name = "txtReport_BILLNOF"
        Me.txtReport_BILLNOF.Size = New System.Drawing.Size(168, 42)
        Me.txtReport_BILLNOF.TabIndex = 36
        '
        'lb_Doc
        '
        Me.lb_Doc.AutoSize = True
        Me.lb_Doc.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_Doc.Location = New System.Drawing.Point(10, 186)
        Me.lb_Doc.Name = "lb_Doc"
        Me.lb_Doc.Size = New System.Drawing.Size(50, 34)
        Me.lb_Doc.TabIndex = 37
        Me.lb_Doc.Text = "เลขที่"
        '
        'BTNReportS_CUSTTO
        '
        Me.BTNReportS_CUSTTO.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTNReportS_CUSTTO.Location = New System.Drawing.Point(590, 129)
        Me.BTNReportS_CUSTTO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNReportS_CUSTTO.Name = "BTNReportS_CUSTTO"
        Me.BTNReportS_CUSTTO.Size = New System.Drawing.Size(37, 27)
        Me.BTNReportS_CUSTTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNReportS_CUSTTO.TabIndex = 35
        Me.BTNReportS_CUSTTO.TabStop = False
        '
        'BTNReportS_CUSTF
        '
        Me.BTNReportS_CUSTF.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTNReportS_CUSTF.Location = New System.Drawing.Point(335, 130)
        Me.BTNReportS_CUSTF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNReportS_CUSTF.Name = "BTNReportS_CUSTF"
        Me.BTNReportS_CUSTF.Size = New System.Drawing.Size(37, 27)
        Me.BTNReportS_CUSTF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNReportS_CUSTF.TabIndex = 34
        Me.BTNReportS_CUSTF.TabStop = False
        '
        'txtReport_CUSTT
        '
        Me.txtReport_CUSTT.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReport_CUSTT.Location = New System.Drawing.Point(415, 128)
        Me.txtReport_CUSTT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReport_CUSTT.Name = "txtReport_CUSTT"
        Me.txtReport_CUSTT.Size = New System.Drawing.Size(168, 42)
        Me.txtReport_CUSTT.TabIndex = 30
        Me.txtReport_CUSTT.Text = "zzzzzz"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(375, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 34)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "ถึง"
        '
        'txtHeader
        '
        Me.txtHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtHeader.AutoSize = True
        Me.txtHeader.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHeader.Location = New System.Drawing.Point(260, 30)
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(0, 34)
        Me.txtHeader.TabIndex = 29
        '
        'txtReport_CUSTF
        '
        Me.txtReport_CUSTF.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReport_CUSTF.Location = New System.Drawing.Point(160, 129)
        Me.txtReport_CUSTF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReport_CUSTF.Name = "txtReport_CUSTF"
        Me.txtReport_CUSTF.Size = New System.Drawing.Size(168, 42)
        Me.txtReport_CUSTF.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 34)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "รหัสลูกค้า"
        '
        'txtReport_CBIMPORT
        '
        Me.txtReport_CBIMPORT.AutoSize = True
        Me.txtReport_CBIMPORT.Location = New System.Drawing.Point(160, 240)
        Me.txtReport_CBIMPORT.Name = "txtReport_CBIMPORT"
        Me.txtReport_CBIMPORT.Size = New System.Drawing.Size(140, 43)
        Me.txtReport_CBIMPORT.TabIndex = 48
        Me.txtReport_CBIMPORT.Text = "Import to CB"
        Me.txtReport_CBIMPORT.UseVisualStyleBackColor = True
        Me.txtReport_CBIMPORT.Visible = False
        '
        'FrmPrintBillSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 342)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FrmPrintBillSummary"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BTNReportS_BILLTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNReportS_BILLF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNReportS_CUSTTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNReportS_CUSTF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHeader As Label
    Friend WithEvents txtReport_CUSTF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReport_CUSTT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTNReportS_CUSTF As PictureBox
    Friend WithEvents BTNReportS_BILLTO As PictureBox
    Friend WithEvents BTNReportS_BILLF As PictureBox
    Friend WithEvents txtReport_BILLNOT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReport_BILLNOF As TextBox
    Friend WithEvents lb_Doc As Label
    Friend WithEvents BTNReportS_CUSTTO As PictureBox
    Friend WithEvents lb_date As Label
    Friend WithEvents txtReport_DATET As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtReport_DATEF As DateTimePicker
    Friend WithEvents BTN_PrintSumm As Button
    Friend WithEvents BTN_ReportClose As Button
    Friend WithEvents txtReport_CBIMPORT As CheckBox
End Class
