<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOPEN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOPEN))
        Me.BTN_LOGIN = New System.Windows.Forms.Button()
        Me.txtComName = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BTN_CONFIG = New System.Windows.Forms.Button()
        Me.BTN_EXIT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_LOGIN
        '
        Me.BTN_LOGIN.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_LOGIN.Location = New System.Drawing.Point(225, 105)
        Me.BTN_LOGIN.Name = "BTN_LOGIN"
        Me.BTN_LOGIN.Size = New System.Drawing.Size(99, 35)
        Me.BTN_LOGIN.TabIndex = 0
        Me.BTN_LOGIN.Text = "Log In"
        Me.BTN_LOGIN.UseVisualStyleBackColor = True
        '
        'txtComName
        '
        Me.txtComName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtComName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtComName.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtComName.FormattingEnabled = True
        Me.txtComName.Location = New System.Drawing.Point(140, 35)
        Me.txtComName.Name = "txtComName"
        Me.txtComName.Size = New System.Drawing.Size(630, 42)
        Me.txtComName.TabIndex = 39
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(25, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 34)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "ชื่อบริษัท :"
        '
        'BTN_CONFIG
        '
        Me.BTN_CONFIG.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_CONFIG.Location = New System.Drawing.Point(391, 105)
        Me.BTN_CONFIG.Name = "BTN_CONFIG"
        Me.BTN_CONFIG.Size = New System.Drawing.Size(114, 35)
        Me.BTN_CONFIG.TabIndex = 40
        Me.BTN_CONFIG.Text = "Configure"
        Me.BTN_CONFIG.UseVisualStyleBackColor = True
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_EXIT.Location = New System.Drawing.Point(558, 105)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(99, 35)
        Me.BTN_EXIT.TabIndex = 41
        Me.BTN_EXIT.Text = "Exit"
        Me.BTN_EXIT.UseVisualStyleBackColor = True
        '
        'FrmOPEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 174)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_CONFIG)
        Me.Controls.Add(Me.txtComName)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BTN_LOGIN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmOPEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_LOGIN As Button
    Friend WithEvents txtComName As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents BTN_CONFIG As Button
    Friend WithEvents BTN_EXIT As Button
End Class
