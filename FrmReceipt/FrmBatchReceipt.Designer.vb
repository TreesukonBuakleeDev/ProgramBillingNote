<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBatchReceipt
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CBX_BTCHRCPComplt = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBX_BTCHRCP = New System.Windows.Forms.CheckBox()
        Me.txtBatchRCP_SEARCH = New System.Windows.Forms.TextBox()
        Me.BTNBatchRCP_SEARCH = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TXTRCP_PROGRESS = New System.Windows.Forms.TextBox()
        Me.RCP_PROGRESSBAR = New System.Windows.Forms.ProgressBar()
        Me.BTN_IMPORTCB = New System.Windows.Forms.Button()
        Me.BTNBTCHRCP_CLOSE = New System.Windows.Forms.Button()
        Me.BTNBTCH_REFRESHRCP = New System.Windows.Forms.Button()
        Me.BTNBTCH_PRINTRCP = New System.Windows.Forms.Button()
        Me.BTNBTCH_DELETERCP = New System.Windows.Forms.Button()
        Me.BTNBTCH_POSTRCP = New System.Windows.Forms.Button()
        Me.BTNBTCH_NEWRCP = New System.Windows.Forms.Button()
        Me.BTNBTCH_OPENRCP = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DGV_BATCHRECEIP = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.BTNBatchRCP_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_BATCHRECEIP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.CBX_BTCHRCPComplt)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CBX_BTCHRCP)
        Me.Panel1.Controls.Add(Me.txtBatchRCP_SEARCH)
        Me.Panel1.Controls.Add(Me.BTNBatchRCP_SEARCH)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1568, 96)
        Me.Panel1.TabIndex = 8
        '
        'CBX_BTCHRCPComplt
        '
        Me.CBX_BTCHRCPComplt.AutoSize = True
        Me.CBX_BTCHRCPComplt.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CBX_BTCHRCPComplt.Location = New System.Drawing.Point(900, 28)
        Me.CBX_BTCHRCPComplt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBX_BTCHRCPComplt.Name = "CBX_BTCHRCPComplt"
        Me.CBX_BTCHRCPComplt.Size = New System.Drawing.Size(224, 38)
        Me.CBX_BTCHRCPComplt.TabIndex = 4
        Me.CBX_BTCHRCPComplt.Text = "Show Post and not import"
        Me.CBX_BTCHRCPComplt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เลขที่ใบเสร็จรับเงิน"
        '
        'CBX_BTCHRCP
        '
        Me.CBX_BTCHRCP.AutoSize = True
        Me.CBX_BTCHRCP.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CBX_BTCHRCP.Location = New System.Drawing.Point(535, 28)
        Me.CBX_BTCHRCP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBX_BTCHRCP.Name = "CBX_BTCHRCP"
        Me.CBX_BTCHRCP.Size = New System.Drawing.Size(336, 38)
        Me.CBX_BTCHRCP.TabIndex = 3
        Me.CBX_BTCHRCP.Text = "Show Post, Delete, and Reverse Batches"
        Me.CBX_BTCHRCP.UseVisualStyleBackColor = True
        '
        'txtBatchRCP_SEARCH
        '
        Me.txtBatchRCP_SEARCH.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBatchRCP_SEARCH.Location = New System.Drawing.Point(185, 25)
        Me.txtBatchRCP_SEARCH.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtBatchRCP_SEARCH.Name = "txtBatchRCP_SEARCH"
        Me.txtBatchRCP_SEARCH.Size = New System.Drawing.Size(243, 42)
        Me.txtBatchRCP_SEARCH.TabIndex = 1
        '
        'BTNBatchRCP_SEARCH
        '
        Me.BTNBatchRCP_SEARCH.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.icons8_search_90
        Me.BTNBatchRCP_SEARCH.Location = New System.Drawing.Point(462, 27)
        Me.BTNBatchRCP_SEARCH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBatchRCP_SEARCH.Name = "BTNBatchRCP_SEARCH"
        Me.BTNBatchRCP_SEARCH.Size = New System.Drawing.Size(40, 33)
        Me.BTNBatchRCP_SEARCH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNBatchRCP_SEARCH.TabIndex = 2
        Me.BTNBatchRCP_SEARCH.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.TXTRCP_PROGRESS)
        Me.Panel3.Controls.Add(Me.RCP_PROGRESSBAR)
        Me.Panel3.Controls.Add(Me.BTN_IMPORTCB)
        Me.Panel3.Controls.Add(Me.BTNBTCHRCP_CLOSE)
        Me.Panel3.Controls.Add(Me.BTNBTCH_REFRESHRCP)
        Me.Panel3.Controls.Add(Me.BTNBTCH_PRINTRCP)
        Me.Panel3.Controls.Add(Me.BTNBTCH_DELETERCP)
        Me.Panel3.Controls.Add(Me.BTNBTCH_POSTRCP)
        Me.Panel3.Controls.Add(Me.BTNBTCH_NEWRCP)
        Me.Panel3.Controls.Add(Me.BTNBTCH_OPENRCP)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 635)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1568, 79)
        Me.Panel3.TabIndex = 10
        '
        'TXTRCP_PROGRESS
        '
        Me.TXTRCP_PROGRESS.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TXTRCP_PROGRESS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTRCP_PROGRESS.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTRCP_PROGRESS.Location = New System.Drawing.Point(865, 40)
        Me.TXTRCP_PROGRESS.Name = "TXTRCP_PROGRESS"
        Me.TXTRCP_PROGRESS.Size = New System.Drawing.Size(355, 35)
        Me.TXTRCP_PROGRESS.TabIndex = 10
        '
        'RCP_PROGRESSBAR
        '
        Me.RCP_PROGRESSBAR.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.RCP_PROGRESSBAR.Location = New System.Drawing.Point(865, 15)
        Me.RCP_PROGRESSBAR.Name = "RCP_PROGRESSBAR"
        Me.RCP_PROGRESSBAR.Size = New System.Drawing.Size(310, 25)
        Me.RCP_PROGRESSBAR.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.RCP_PROGRESSBAR.TabIndex = 9
        Me.RCP_PROGRESSBAR.Visible = False
        '
        'BTN_IMPORTCB
        '
        Me.BTN_IMPORTCB.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_IMPORTCB.Location = New System.Drawing.Point(745, 20)
        Me.BTN_IMPORTCB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_IMPORTCB.Name = "BTN_IMPORTCB"
        Me.BTN_IMPORTCB.Size = New System.Drawing.Size(99, 46)
        Me.BTN_IMPORTCB.TabIndex = 8
        Me.BTN_IMPORTCB.Text = "Import"
        Me.BTN_IMPORTCB.UseVisualStyleBackColor = True
        '
        'BTNBTCHRCP_CLOSE
        '
        Me.BTNBTCHRCP_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBTCHRCP_CLOSE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCHRCP_CLOSE.Location = New System.Drawing.Point(1450, 20)
        Me.BTNBTCHRCP_CLOSE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBTCHRCP_CLOSE.Name = "BTNBTCHRCP_CLOSE"
        Me.BTNBTCHRCP_CLOSE.Size = New System.Drawing.Size(91, 43)
        Me.BTNBTCHRCP_CLOSE.TabIndex = 7
        Me.BTNBTCHRCP_CLOSE.Text = "Close"
        Me.BTNBTCHRCP_CLOSE.UseVisualStyleBackColor = True
        '
        'BTNBTCH_REFRESHRCP
        '
        Me.BTNBTCH_REFRESHRCP.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCH_REFRESHRCP.Location = New System.Drawing.Point(625, 20)
        Me.BTNBTCH_REFRESHRCP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBTCH_REFRESHRCP.Name = "BTNBTCH_REFRESHRCP"
        Me.BTNBTCH_REFRESHRCP.Size = New System.Drawing.Size(99, 46)
        Me.BTNBTCH_REFRESHRCP.TabIndex = 6
        Me.BTNBTCH_REFRESHRCP.Text = "Refresh"
        Me.BTNBTCH_REFRESHRCP.UseVisualStyleBackColor = True
        '
        'BTNBTCH_PRINTRCP
        '
        Me.BTNBTCH_PRINTRCP.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCH_PRINTRCP.Location = New System.Drawing.Point(505, 20)
        Me.BTNBTCH_PRINTRCP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBTCH_PRINTRCP.Name = "BTNBTCH_PRINTRCP"
        Me.BTNBTCH_PRINTRCP.Size = New System.Drawing.Size(99, 46)
        Me.BTNBTCH_PRINTRCP.TabIndex = 5
        Me.BTNBTCH_PRINTRCP.Text = "Print"
        Me.BTNBTCH_PRINTRCP.UseVisualStyleBackColor = True
        '
        'BTNBTCH_DELETERCP
        '
        Me.BTNBTCH_DELETERCP.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCH_DELETERCP.Location = New System.Drawing.Point(385, 20)
        Me.BTNBTCH_DELETERCP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBTCH_DELETERCP.Name = "BTNBTCH_DELETERCP"
        Me.BTNBTCH_DELETERCP.Size = New System.Drawing.Size(99, 46)
        Me.BTNBTCH_DELETERCP.TabIndex = 4
        Me.BTNBTCH_DELETERCP.Text = "Delete"
        Me.BTNBTCH_DELETERCP.UseVisualStyleBackColor = True
        '
        'BTNBTCH_POSTRCP
        '
        Me.BTNBTCH_POSTRCP.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCH_POSTRCP.Location = New System.Drawing.Point(265, 20)
        Me.BTNBTCH_POSTRCP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBTCH_POSTRCP.Name = "BTNBTCH_POSTRCP"
        Me.BTNBTCH_POSTRCP.Size = New System.Drawing.Size(99, 46)
        Me.BTNBTCH_POSTRCP.TabIndex = 3
        Me.BTNBTCH_POSTRCP.Text = "Post"
        Me.BTNBTCH_POSTRCP.UseVisualStyleBackColor = True
        '
        'BTNBTCH_NEWRCP
        '
        Me.BTNBTCH_NEWRCP.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCH_NEWRCP.Location = New System.Drawing.Point(144, 20)
        Me.BTNBTCH_NEWRCP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBTCH_NEWRCP.Name = "BTNBTCH_NEWRCP"
        Me.BTNBTCH_NEWRCP.Size = New System.Drawing.Size(99, 46)
        Me.BTNBTCH_NEWRCP.TabIndex = 2
        Me.BTNBTCH_NEWRCP.Text = "New"
        Me.BTNBTCH_NEWRCP.UseVisualStyleBackColor = True
        '
        'BTNBTCH_OPENRCP
        '
        Me.BTNBTCH_OPENRCP.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNBTCH_OPENRCP.Location = New System.Drawing.Point(23, 20)
        Me.BTNBTCH_OPENRCP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNBTCH_OPENRCP.Name = "BTNBTCH_OPENRCP"
        Me.BTNBTCH_OPENRCP.Size = New System.Drawing.Size(99, 46)
        Me.BTNBTCH_OPENRCP.TabIndex = 1
        Me.BTNBTCH_OPENRCP.Text = "Open"
        Me.BTNBTCH_OPENRCP.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(181, 213)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 100)
        Me.Panel4.TabIndex = 0
        '
        'DGV_BATCHRECEIP
        '
        Me.DGV_BATCHRECEIP.AllowUserToAddRows = False
        Me.DGV_BATCHRECEIP.AllowUserToDeleteRows = False
        Me.DGV_BATCHRECEIP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_BATCHRECEIP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_BATCHRECEIP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_BATCHRECEIP.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_BATCHRECEIP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_BATCHRECEIP.ColumnHeadersHeight = 60
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_BATCHRECEIP.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_BATCHRECEIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_BATCHRECEIP.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_BATCHRECEIP.Location = New System.Drawing.Point(0, 96)
        Me.DGV_BATCHRECEIP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_BATCHRECEIP.Name = "DGV_BATCHRECEIP"
        Me.DGV_BATCHRECEIP.RowHeadersWidth = 51
        Me.DGV_BATCHRECEIP.RowTemplate.Height = 24
        Me.DGV_BATCHRECEIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_BATCHRECEIP.Size = New System.Drawing.Size(1568, 539)
        Me.DGV_BATCHRECEIP.TabIndex = 9
        '
        'FrmBatchReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1568, 714)
        Me.Controls.Add(Me.DGV_BATCHRECEIP)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmBatchReceipt"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batch list - Receipt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BTNBatchRCP_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGV_BATCHRECEIP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CBX_BTCHRCP As CheckBox
    Friend WithEvents txtBatchRCP_SEARCH As TextBox
    Friend WithEvents BTNBatchRCP_SEARCH As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTNBTCH_REFRESHRCP As Button
    Friend WithEvents BTNBTCH_PRINTRCP As Button
    Friend WithEvents BTNBTCH_DELETERCP As Button
    Friend WithEvents BTNBTCH_POSTRCP As Button
    Friend WithEvents BTNBTCH_NEWRCP As Button
    Friend WithEvents BTNBTCH_OPENRCP As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BTNBTCHRCP_CLOSE As Button
    Friend WithEvents BTN_IMPORTCB As Button
    Friend WithEvents CBX_BTCHRCPComplt As CheckBox
    Friend WithEvents DGV_BATCHRECEIP As DataGridView
    Friend WithEvents RCP_PROGRESSBAR As ProgressBar
    Friend WithEvents TXTRCP_PROGRESS As TextBox
End Class
