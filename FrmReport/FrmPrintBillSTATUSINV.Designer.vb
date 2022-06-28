<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrintBillSTATUSINV
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtReportINV_STA = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RPT_DATET = New System.Windows.Forms.DateTimePicker()
        Me.RPT_DATEF = New System.Windows.Forms.DateTimePicker()
        Me.BTN_ReportINVClose = New System.Windows.Forms.Button()
        Me.BTN_PrintStatusINV = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTNReportINV_CUSTT = New System.Windows.Forms.PictureBox()
        Me.BTNReportINV_CUSTF = New System.Windows.Forms.PictureBox()
        Me.txtReportINV_CUSTT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHeaderINV = New System.Windows.Forms.Label()
        Me.txtReportINV_CUSTF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BTNReportINV_CUSTT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNReportINV_CUSTF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtReportINV_STA)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RPT_DATET)
        Me.GroupBox1.Controls.Add(Me.RPT_DATEF)
        Me.GroupBox1.Controls.Add(Me.BTN_ReportINVClose)
        Me.GroupBox1.Controls.Add(Me.BTN_PrintStatusINV)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BTNReportINV_CUSTT)
        Me.GroupBox1.Controls.Add(Me.BTNReportINV_CUSTF)
        Me.GroupBox1.Controls.Add(Me.txtReportINV_CUSTT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtHeaderINV)
        Me.GroupBox1.Controls.Add(Me.txtReportINV_CUSTF)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Cordia New", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(636, 342)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายงาน Status Invoice"
        '
        'txtReportINV_STA
        '
        Me.txtReportINV_STA.FormattingEnabled = True
        Me.txtReportINV_STA.Items.AddRange(New Object() {"Complete", "Not Complete", "All"})
        Me.txtReportINV_STA.Location = New System.Drawing.Point(130, 215)
        Me.txtReportINV_STA.Name = "txtReportINV_STA"
        Me.txtReportINV_STA.Size = New System.Drawing.Size(140, 45)
        Me.txtReportINV_STA.TabIndex = 51
        Me.txtReportINV_STA.Text = "Complete"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 34)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "สถานะ"
        '
        'RPT_DATET
        '
        Me.RPT_DATET.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RPT_DATET.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RPT_DATET.Location = New System.Drawing.Point(405, 144)
        Me.RPT_DATET.Name = "RPT_DATET"
        Me.RPT_DATET.Size = New System.Drawing.Size(140, 42)
        Me.RPT_DATET.TabIndex = 49
        '
        'RPT_DATEF
        '
        Me.RPT_DATEF.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RPT_DATEF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RPT_DATEF.Location = New System.Drawing.Point(130, 143)
        Me.RPT_DATEF.Name = "RPT_DATEF"
        Me.RPT_DATEF.Size = New System.Drawing.Size(140, 42)
        Me.RPT_DATEF.TabIndex = 48
        '
        'BTN_ReportINVClose
        '
        Me.BTN_ReportINVClose.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_ReportINVClose.Location = New System.Drawing.Point(530, 275)
        Me.BTN_ReportINVClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_ReportINVClose.Name = "BTN_ReportINVClose"
        Me.BTN_ReportINVClose.Size = New System.Drawing.Size(99, 35)
        Me.BTN_ReportINVClose.TabIndex = 47
        Me.BTN_ReportINVClose.Text = "Close"
        Me.BTN_ReportINVClose.UseVisualStyleBackColor = True
        '
        'BTN_PrintStatusINV
        '
        Me.BTN_PrintStatusINV.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_PrintStatusINV.Location = New System.Drawing.Point(405, 275)
        Me.BTN_PrintStatusINV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_PrintStatusINV.Name = "BTN_PrintStatusINV"
        Me.BTN_PrintStatusINV.Size = New System.Drawing.Size(99, 35)
        Me.BTN_PrintStatusINV.TabIndex = 46
        Me.BTN_PrintStatusINV.Text = "Print"
        Me.BTN_PrintStatusINV.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(360, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 34)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ถึง"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 34)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "วันที่ Invoice"
        '
        'BTNReportINV_CUSTT
        '
        Me.BTNReportINV_CUSTT.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTNReportINV_CUSTT.Location = New System.Drawing.Point(580, 70)
        Me.BTNReportINV_CUSTT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNReportINV_CUSTT.Name = "BTNReportINV_CUSTT"
        Me.BTNReportINV_CUSTT.Size = New System.Drawing.Size(37, 27)
        Me.BTNReportINV_CUSTT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNReportINV_CUSTT.TabIndex = 35
        Me.BTNReportINV_CUSTT.TabStop = False
        '
        'BTNReportINV_CUSTF
        '
        Me.BTNReportINV_CUSTF.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTNReportINV_CUSTF.Location = New System.Drawing.Point(304, 71)
        Me.BTNReportINV_CUSTF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNReportINV_CUSTF.Name = "BTNReportINV_CUSTF"
        Me.BTNReportINV_CUSTF.Size = New System.Drawing.Size(37, 27)
        Me.BTNReportINV_CUSTF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNReportINV_CUSTF.TabIndex = 34
        Me.BTNReportINV_CUSTF.TabStop = False
        '
        'txtReportINV_CUSTT
        '
        Me.txtReportINV_CUSTT.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReportINV_CUSTT.Location = New System.Drawing.Point(405, 70)
        Me.txtReportINV_CUSTT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReportINV_CUSTT.Name = "txtReportINV_CUSTT"
        Me.txtReportINV_CUSTT.Size = New System.Drawing.Size(160, 42)
        Me.txtReportINV_CUSTT.TabIndex = 30
        Me.txtReportINV_CUSTT.Text = "zzzzzz"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(360, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 34)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "ถึง"
        '
        'txtHeaderINV
        '
        Me.txtHeaderINV.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtHeaderINV.AutoSize = True
        Me.txtHeaderINV.Font = New System.Drawing.Font("Cordia New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHeaderINV.Location = New System.Drawing.Point(277, 27)
        Me.txtHeaderINV.Name = "txtHeaderINV"
        Me.txtHeaderINV.Size = New System.Drawing.Size(0, 28)
        Me.txtHeaderINV.TabIndex = 29
        '
        'txtReportINV_CUSTF
        '
        Me.txtReportINV_CUSTF.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReportINV_CUSTF.Location = New System.Drawing.Point(130, 71)
        Me.txtReportINV_CUSTF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReportINV_CUSTF.Name = "txtReportINV_CUSTF"
        Me.txtReportINV_CUSTF.Size = New System.Drawing.Size(160, 42)
        Me.txtReportINV_CUSTF.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 34)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "รหัสลูกค้า"
        '
        'FrmPrintBillSTATUSINV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 342)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FrmPrintBillSTATUSINV"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BTNReportINV_CUSTT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNReportINV_CUSTF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTN_ReportINVClose As Button
    Friend WithEvents BTN_PrintStatusINV As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BTNReportINV_CUSTT As PictureBox
    Friend WithEvents BTNReportINV_CUSTF As PictureBox
    Friend WithEvents txtReportINV_CUSTT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHeaderINV As Label
    Friend WithEvents txtReportINV_CUSTF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RPT_DATET As DateTimePicker
    Friend WithEvents RPT_DATEF As DateTimePicker
    Friend WithEvents txtReportINV_STA As ComboBox
    Friend WithEvents Label2 As Label
End Class
