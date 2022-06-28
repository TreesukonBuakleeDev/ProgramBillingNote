<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPromtPrint
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBillPrintFileName = New System.Windows.Forms.TextBox()
        Me.BTNBILLPROMT_PRINTING = New System.Windows.Forms.Button()
        Me.BTNBILL_PRNTBROWSE = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBillno = New System.Windows.Forms.TextBox()
        Me.BTN_PromtCLOSE = New System.Windows.Forms.Button()
        Me.txtBillrptFile = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 34)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ชื่อไฟล์"
        '
        'txtBillPrintFileName
        '
        Me.txtBillPrintFileName.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBillPrintFileName.Location = New System.Drawing.Point(79, 36)
        Me.txtBillPrintFileName.Name = "txtBillPrintFileName"
        Me.txtBillPrintFileName.Size = New System.Drawing.Size(398, 42)
        Me.txtBillPrintFileName.TabIndex = 6
        '
        'BTNBILLPROMT_PRINTING
        '
        Me.BTNBILLPROMT_PRINTING.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBILLPROMT_PRINTING.Location = New System.Drawing.Point(79, 279)
        Me.BTNBILLPROMT_PRINTING.Name = "BTNBILLPROMT_PRINTING"
        Me.BTNBILLPROMT_PRINTING.Size = New System.Drawing.Size(99, 35)
        Me.BTNBILLPROMT_PRINTING.TabIndex = 5
        Me.BTNBILLPROMT_PRINTING.Text = "Print"
        Me.BTNBILLPROMT_PRINTING.UseVisualStyleBackColor = True
        '
        'BTNBILL_PRNTBROWSE
        '
        Me.BTNBILL_PRNTBROWSE.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBILL_PRNTBROWSE.Location = New System.Drawing.Point(496, 31)
        Me.BTNBILL_PRNTBROWSE.Name = "BTNBILL_PRNTBROWSE"
        Me.BTNBILL_PRNTBROWSE.Size = New System.Drawing.Size(90, 43)
        Me.BTNBILL_PRNTBROWSE.TabIndex = 4
        Me.BTNBILL_PRNTBROWSE.Text = "Browse"
        Me.BTNBILL_PRNTBROWSE.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 34)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "เลขที่"
        '
        'txtBillno
        '
        Me.txtBillno.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBillno.Location = New System.Drawing.Point(75, 140)
        Me.txtBillno.Name = "txtBillno"
        Me.txtBillno.Size = New System.Drawing.Size(507, 42)
        Me.txtBillno.TabIndex = 8
        '
        'BTN_PromtCLOSE
        '
        Me.BTN_PromtCLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_PromtCLOSE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_PromtCLOSE.Location = New System.Drawing.Point(496, 279)
        Me.BTN_PromtCLOSE.Name = "BTN_PromtCLOSE"
        Me.BTN_PromtCLOSE.Size = New System.Drawing.Size(99, 35)
        Me.BTN_PromtCLOSE.TabIndex = 10
        Me.BTN_PromtCLOSE.Text = "Close"
        Me.BTN_PromtCLOSE.UseVisualStyleBackColor = True
        '
        'txtBillrptFile
        '
        Me.txtBillrptFile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBillrptFile.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBillrptFile.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txtBillrptFile.Location = New System.Drawing.Point(10, 90)
        Me.txtBillrptFile.Name = "txtBillrptFile"
        Me.txtBillrptFile.ReadOnly = True
        Me.txtBillrptFile.Size = New System.Drawing.Size(610, 35)
        Me.txtBillrptFile.TabIndex = 11
        '
        'FrmPromtPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 334)
        Me.Controls.Add(Me.txtBillrptFile)
        Me.Controls.Add(Me.BTN_PromtCLOSE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBillno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBillPrintFileName)
        Me.Controls.Add(Me.BTNBILLPROMT_PRINTING)
        Me.Controls.Add(Me.BTNBILL_PRNTBROWSE)
        Me.MaximizeBox = False
        Me.Name = "FrmPromtPrint"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBillPrintFileName As TextBox
    Friend WithEvents BTNBILLPROMT_PRINTING As Button
    Friend WithEvents BTNBILL_PRNTBROWSE As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBillno As TextBox
    Friend WithEvents BTN_PromtCLOSE As Button
    Friend WithEvents txtBillrptFile As TextBox
End Class
