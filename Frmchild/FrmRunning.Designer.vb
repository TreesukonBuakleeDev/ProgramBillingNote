<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRunning
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV_RUNNO = New System.Windows.Forms.DataGridView()
        Me.BTNBill_REFRESH = New System.Windows.Forms.Button()
        Me.BTNBill_POST = New System.Windows.Forms.Button()
        Me.BTN_TAXReceiptTYPE = New System.Windows.Forms.RadioButton()
        Me.BTN_ReceiptTYPE = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV_RUNNO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_RUNNO
        '
        Me.DGV_RUNNO.AllowUserToAddRows = False
        Me.DGV_RUNNO.AllowUserToDeleteRows = False
        Me.DGV_RUNNO.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_RUNNO.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_RUNNO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_RUNNO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_RUNNO.Location = New System.Drawing.Point(12, 56)
        Me.DGV_RUNNO.Name = "DGV_RUNNO"
        Me.DGV_RUNNO.RowHeadersWidth = 51
        Me.DGV_RUNNO.RowTemplate.Height = 24
        Me.DGV_RUNNO.Size = New System.Drawing.Size(635, 186)
        Me.DGV_RUNNO.TabIndex = 0
        '
        'BTNBill_REFRESH
        '
        Me.BTNBill_REFRESH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBill_REFRESH.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_REFRESH.Location = New System.Drawing.Point(549, 259)
        Me.BTNBill_REFRESH.Name = "BTNBill_REFRESH"
        Me.BTNBill_REFRESH.Size = New System.Drawing.Size(98, 45)
        Me.BTNBill_REFRESH.TabIndex = 14
        Me.BTNBill_REFRESH.Text = "Close"
        Me.BTNBill_REFRESH.UseVisualStyleBackColor = True
        '
        'BTNBill_POST
        '
        Me.BTNBill_POST.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBill_POST.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_POST.Location = New System.Drawing.Point(430, 259)
        Me.BTNBill_POST.Name = "BTNBill_POST"
        Me.BTNBill_POST.Size = New System.Drawing.Size(98, 45)
        Me.BTNBill_POST.TabIndex = 13
        Me.BTNBill_POST.Text = "Save"
        Me.BTNBill_POST.UseVisualStyleBackColor = True
        '
        'BTN_TAXReceiptTYPE
        '
        Me.BTN_TAXReceiptTYPE.AutoSize = True
        Me.BTN_TAXReceiptTYPE.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_TAXReceiptTYPE.Location = New System.Drawing.Point(135, 280)
        Me.BTN_TAXReceiptTYPE.Name = "BTN_TAXReceiptTYPE"
        Me.BTN_TAXReceiptTYPE.Size = New System.Drawing.Size(123, 38)
        Me.BTN_TAXReceiptTYPE.TabIndex = 50
        Me.BTN_TAXReceiptTYPE.Text = "Tax Receipt"
        Me.BTN_TAXReceiptTYPE.UseVisualStyleBackColor = True
        '
        'BTN_ReceiptTYPE
        '
        Me.BTN_ReceiptTYPE.AutoSize = True
        Me.BTN_ReceiptTYPE.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_ReceiptTYPE.Location = New System.Drawing.Point(15, 280)
        Me.BTN_ReceiptTYPE.Name = "BTN_ReceiptTYPE"
        Me.BTN_ReceiptTYPE.Size = New System.Drawing.Size(92, 38)
        Me.BTN_ReceiptTYPE.TabIndex = 49
        Me.BTN_ReceiptTYPE.Text = "Receipt"
        Me.BTN_ReceiptTYPE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 34)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Default Receipt Type"
        '
        'FrmRunning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 330)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_TAXReceiptTYPE)
        Me.Controls.Add(Me.BTN_ReceiptTYPE)
        Me.Controls.Add(Me.BTNBill_REFRESH)
        Me.Controls.Add(Me.BTNBill_POST)
        Me.Controls.Add(Me.DGV_RUNNO)
        Me.Name = "FrmRunning"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Format ID"
        CType(Me.DGV_RUNNO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_RUNNO As DataGridView
    Friend WithEvents BTNBill_REFRESH As Button
    Friend WithEvents BTNBill_POST As Button
    Friend WithEvents BTN_TAXReceiptTYPE As RadioButton
    Friend WithEvents BTN_ReceiptTYPE As RadioButton
    Friend WithEvents Label1 As Label
End Class
