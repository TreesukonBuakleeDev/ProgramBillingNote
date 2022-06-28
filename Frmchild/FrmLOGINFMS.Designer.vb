<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLOGINFMS
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
        Me.BTN_LOGINFMS = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTN_LOGINFMS
        '
        Me.BTN_LOGINFMS.Location = New System.Drawing.Point(110, 144)
        Me.BTN_LOGINFMS.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTN_LOGINFMS.Name = "BTN_LOGINFMS"
        Me.BTN_LOGINFMS.Size = New System.Drawing.Size(99, 54)
        Me.BTN_LOGINFMS.TabIndex = 0
        Me.BTN_LOGINFMS.Text = "LOG IN"
        Me.BTN_LOGINFMS.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(89, 29)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(193, 30)
        Me.txtUser.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cordia New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 25)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 22)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "User :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 22)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Password :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(89, 86)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(193, 30)
        Me.txtPassword.TabIndex = 40
        '
        'FrmLOGINFMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 222)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.BTN_LOGINFMS)
        Me.Font = New System.Drawing.Font("Cordia New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FrmLOGINFMS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN FMS"
        me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_LOGINFMS As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
End Class
