<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOPTFDVALUE
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
        Me.DGV_OPTFDVALUE = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNBill_OPTFDCLOSE = New System.Windows.Forms.Button()
        Me.BTNBill_OPTFDSAVE = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_OPTFDVALUE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_OPTFDVALUE)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(834, 432)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DGV_OPTFDVALUE
        '
        Me.DGV_OPTFDVALUE.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_OPTFDVALUE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_OPTFDVALUE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_OPTFDVALUE.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_OPTFDVALUE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_OPTFDVALUE.Location = New System.Drawing.Point(3, 18)
        Me.DGV_OPTFDVALUE.Name = "DGV_OPTFDVALUE"
        Me.DGV_OPTFDVALUE.RowHeadersWidth = 51
        Me.DGV_OPTFDVALUE.RowTemplate.Height = 24
        Me.DGV_OPTFDVALUE.Size = New System.Drawing.Size(828, 411)
        Me.DGV_OPTFDVALUE.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNBill_OPTFDCLOSE)
        Me.GroupBox2.Controls.Add(Me.BTNBill_OPTFDSAVE)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 432)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(834, 68)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'BTNBill_OPTFDCLOSE
        '
        Me.BTNBill_OPTFDCLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBill_OPTFDCLOSE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_OPTFDCLOSE.Location = New System.Drawing.Point(687, 21)
        Me.BTNBill_OPTFDCLOSE.Name = "BTNBill_OPTFDCLOSE"
        Me.BTNBill_OPTFDCLOSE.Size = New System.Drawing.Size(98, 45)
        Me.BTNBill_OPTFDCLOSE.TabIndex = 16
        Me.BTNBill_OPTFDCLOSE.Text = "Close"
        Me.BTNBill_OPTFDCLOSE.UseVisualStyleBackColor = True
        '
        'BTNBill_OPTFDSAVE
        '
        Me.BTNBill_OPTFDSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBill_OPTFDSAVE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBill_OPTFDSAVE.Location = New System.Drawing.Point(568, 21)
        Me.BTNBill_OPTFDSAVE.Name = "BTNBill_OPTFDSAVE"
        Me.BTNBill_OPTFDSAVE.Size = New System.Drawing.Size(98, 45)
        Me.BTNBill_OPTFDSAVE.TabIndex = 15
        Me.BTNBill_OPTFDSAVE.Text = "Save"
        Me.BTNBill_OPTFDSAVE.UseVisualStyleBackColor = True
        '
        'FrmOPTFDVALUE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 500)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmOPTFDVALUE"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Note User Defined Field"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_OPTFDVALUE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTNBill_OPTFDCLOSE As Button
    Friend WithEvents BTNBill_OPTFDSAVE As Button
    Friend WithEvents DGV_OPTFDVALUE As DataGridView
End Class
