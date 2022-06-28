<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBatchBillingNote
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBatchBILL_SEARCH = New System.Windows.Forms.TextBox()
        Me.BTNBatchBILL_SEARCH = New System.Windows.Forms.PictureBox()
        Me.CBX_BTCHBILL = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DGV_BATCHBILL = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTNBTCHBILL_CLOSE = New System.Windows.Forms.Button()
        Me.BTNBTCH_REFRESH = New System.Windows.Forms.Button()
        Me.BTNBTCH_PRINT = New System.Windows.Forms.Button()
        Me.BTNBTCH_DELETE = New System.Windows.Forms.Button()
        Me.BTNBTCH_POST = New System.Windows.Forms.Button()
        Me.BTNBTCH_NEW = New System.Windows.Forms.Button()
        Me.BTNBTCH_OPEN = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        CType(Me.BTNBatchBILL_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DGV_BATCHBILL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เลขที่ใบวางบิล"
        '
        'txtBatchBILL_SEARCH
        '
        Me.txtBatchBILL_SEARCH.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBatchBILL_SEARCH.Location = New System.Drawing.Point(146, 29)
        Me.txtBatchBILL_SEARCH.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtBatchBILL_SEARCH.Name = "txtBatchBILL_SEARCH"
        Me.txtBatchBILL_SEARCH.Size = New System.Drawing.Size(273, 42)
        Me.txtBatchBILL_SEARCH.TabIndex = 1
        '
        'BTNBatchBILL_SEARCH
        '
        Me.BTNBatchBILL_SEARCH.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTNBatchBILL_SEARCH.Location = New System.Drawing.Point(438, 33)
        Me.BTNBatchBILL_SEARCH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBatchBILL_SEARCH.Name = "BTNBatchBILL_SEARCH"
        Me.BTNBatchBILL_SEARCH.Size = New System.Drawing.Size(34, 36)
        Me.BTNBatchBILL_SEARCH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNBatchBILL_SEARCH.TabIndex = 2
        Me.BTNBatchBILL_SEARCH.TabStop = False
        '
        'CBX_BTCHBILL
        '
        Me.CBX_BTCHBILL.AutoSize = True
        Me.CBX_BTCHBILL.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CBX_BTCHBILL.Location = New System.Drawing.Point(512, 34)
        Me.CBX_BTCHBILL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBX_BTCHBILL.Name = "CBX_BTCHBILL"
        Me.CBX_BTCHBILL.Size = New System.Drawing.Size(336, 38)
        Me.CBX_BTCHBILL.TabIndex = 3
        Me.CBX_BTCHBILL.Text = "Show Post, Delete, and Reverse Batches"
        Me.CBX_BTCHBILL.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CBX_BTCHBILL)
        Me.Panel1.Controls.Add(Me.txtBatchBILL_SEARCH)
        Me.Panel1.Controls.Add(Me.BTNBatchBILL_SEARCH)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 117)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1132, 653)
        Me.Panel2.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DGV_BATCHBILL)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 117)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1132, 453)
        Me.Panel5.TabIndex = 6
        '
        'DGV_BATCHBILL
        '
        Me.DGV_BATCHBILL.AllowUserToAddRows = False
        Me.DGV_BATCHBILL.AllowUserToDeleteRows = False
        Me.DGV_BATCHBILL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_BATCHBILL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_BATCHBILL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_BATCHBILL.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_BATCHBILL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_BATCHBILL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_BATCHBILL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_BATCHBILL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DGV_BATCHBILL.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_BATCHBILL.Location = New System.Drawing.Point(0, 0)
        Me.DGV_BATCHBILL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_BATCHBILL.Name = "DGV_BATCHBILL"
        Me.DGV_BATCHBILL.ReadOnly = True
        Me.DGV_BATCHBILL.RowHeadersWidth = 51
        Me.DGV_BATCHBILL.RowTemplate.Height = 24
        Me.DGV_BATCHBILL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_BATCHBILL.Size = New System.Drawing.Size(1132, 453)
        Me.DGV_BATCHBILL.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.BTNBTCHBILL_CLOSE)
        Me.Panel3.Controls.Add(Me.BTNBTCH_REFRESH)
        Me.Panel3.Controls.Add(Me.BTNBTCH_PRINT)
        Me.Panel3.Controls.Add(Me.BTNBTCH_DELETE)
        Me.Panel3.Controls.Add(Me.BTNBTCH_POST)
        Me.Panel3.Controls.Add(Me.BTNBTCH_NEW)
        Me.Panel3.Controls.Add(Me.BTNBTCH_OPEN)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 570)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1132, 83)
        Me.Panel3.TabIndex = 5
        '
        'BTNBTCHBILL_CLOSE
        '
        Me.BTNBTCHBILL_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBTCHBILL_CLOSE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCHBILL_CLOSE.Location = New System.Drawing.Point(995, 20)
        Me.BTNBTCHBILL_CLOSE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBTCHBILL_CLOSE.Name = "BTNBTCHBILL_CLOSE"
        Me.BTNBTCHBILL_CLOSE.Size = New System.Drawing.Size(99, 40)
        Me.BTNBTCHBILL_CLOSE.TabIndex = 10
        Me.BTNBTCHBILL_CLOSE.Text = "Close"
        Me.BTNBTCHBILL_CLOSE.UseVisualStyleBackColor = True
        '
        'BTNBTCH_REFRESH
        '
        Me.BTNBTCH_REFRESH.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCH_REFRESH.Location = New System.Drawing.Point(688, 20)
        Me.BTNBTCH_REFRESH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBTCH_REFRESH.Name = "BTNBTCH_REFRESH"
        Me.BTNBTCH_REFRESH.Size = New System.Drawing.Size(99, 40)
        Me.BTNBTCH_REFRESH.TabIndex = 9
        Me.BTNBTCH_REFRESH.Text = "Refresh"
        Me.BTNBTCH_REFRESH.UseVisualStyleBackColor = True
        '
        'BTNBTCH_PRINT
        '
        Me.BTNBTCH_PRINT.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCH_PRINT.Location = New System.Drawing.Point(556, 20)
        Me.BTNBTCH_PRINT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBTCH_PRINT.Name = "BTNBTCH_PRINT"
        Me.BTNBTCH_PRINT.Size = New System.Drawing.Size(99, 40)
        Me.BTNBTCH_PRINT.TabIndex = 8
        Me.BTNBTCH_PRINT.Text = "Print"
        Me.BTNBTCH_PRINT.UseVisualStyleBackColor = True
        '
        'BTNBTCH_DELETE
        '
        Me.BTNBTCH_DELETE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCH_DELETE.Location = New System.Drawing.Point(418, 20)
        Me.BTNBTCH_DELETE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBTCH_DELETE.Name = "BTNBTCH_DELETE"
        Me.BTNBTCH_DELETE.Size = New System.Drawing.Size(99, 40)
        Me.BTNBTCH_DELETE.TabIndex = 7
        Me.BTNBTCH_DELETE.Text = "Delete"
        Me.BTNBTCH_DELETE.UseVisualStyleBackColor = True
        '
        'BTNBTCH_POST
        '
        Me.BTNBTCH_POST.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCH_POST.Location = New System.Drawing.Point(288, 20)
        Me.BTNBTCH_POST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBTCH_POST.Name = "BTNBTCH_POST"
        Me.BTNBTCH_POST.Size = New System.Drawing.Size(99, 40)
        Me.BTNBTCH_POST.TabIndex = 6
        Me.BTNBTCH_POST.Text = "Post"
        Me.BTNBTCH_POST.UseVisualStyleBackColor = True
        '
        'BTNBTCH_NEW
        '
        Me.BTNBTCH_NEW.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCH_NEW.Location = New System.Drawing.Point(158, 20)
        Me.BTNBTCH_NEW.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBTCH_NEW.Name = "BTNBTCH_NEW"
        Me.BTNBTCH_NEW.Size = New System.Drawing.Size(99, 40)
        Me.BTNBTCH_NEW.TabIndex = 5
        Me.BTNBTCH_NEW.Text = "New"
        Me.BTNBTCH_NEW.UseVisualStyleBackColor = True
        '
        'BTNBTCH_OPEN
        '
        Me.BTNBTCH_OPEN.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCH_OPEN.Location = New System.Drawing.Point(27, 20)
        Me.BTNBTCH_OPEN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBTCH_OPEN.Name = "BTNBTCH_OPEN"
        Me.BTNBTCH_OPEN.Size = New System.Drawing.Size(99, 40)
        Me.BTNBTCH_OPEN.TabIndex = 4
        Me.BTNBTCH_OPEN.Text = "Open"
        Me.BTNBTCH_OPEN.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(204, 259)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(225, 121)
        Me.Panel4.TabIndex = 0
        '
        'FrmBatchBillingNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1132, 653)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "FrmBatchBillingNote"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batch List - Billing"
        CType(Me.BTNBatchBILL_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DGV_BATCHBILL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBatchBILL_SEARCH As TextBox
    Friend WithEvents BTNBatchBILL_SEARCH As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DGV_BATCHBILL As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BTNBTCH_REFRESH As Button
    Friend WithEvents BTNBTCH_PRINT As Button
    Friend WithEvents BTNBTCH_DELETE As Button
    Friend WithEvents BTNBTCH_POST As Button
    Friend WithEvents BTNBTCH_NEW As Button
    Friend WithEvents BTNBTCH_OPEN As Button
    Friend WithEvents BTNBTCHBILL_CLOSE As Button
    Public WithEvents CBX_BTCHBILL As CheckBox
End Class
