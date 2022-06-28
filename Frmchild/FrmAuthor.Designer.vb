<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAuthor
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
        Me.BTN_SAVEAUTHOR = New System.Windows.Forms.Button()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.txtAuthorized = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lb_ConfirmPass = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.BTN_AuthorNext = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtAuthorUserID = New System.Windows.Forms.TextBox()
        Me.txtAuthorUser = New System.Windows.Forms.TextBox()
        Me.txtAuthorPassword = New System.Windows.Forms.TextBox()
        Me.BTN_AUTHDEL = New System.Windows.Forms.Button()
        Me.BTN_AUTHEDIT = New System.Windows.Forms.Button()
        Me.BTN_AUTHNEW = New System.Windows.Forms.Button()
        Me.BTN_AUTHCLOSE = New System.Windows.Forms.Button()
        Me.GroupBox13.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_SAVEAUTHOR
        '
        Me.BTN_SAVEAUTHOR.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVEAUTHOR.Location = New System.Drawing.Point(229, 391)
        Me.BTN_SAVEAUTHOR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_SAVEAUTHOR.Name = "BTN_SAVEAUTHOR"
        Me.BTN_SAVEAUTHOR.Size = New System.Drawing.Size(91, 40)
        Me.BTN_SAVEAUTHOR.TabIndex = 9
        Me.BTN_SAVEAUTHOR.Text = "Save"
        Me.BTN_SAVEAUTHOR.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.txtAuthorized)
        Me.GroupBox13.Controls.Add(Me.Label1)
        Me.GroupBox13.Controls.Add(Me.Lb_ConfirmPass)
        Me.GroupBox13.Controls.Add(Me.txtConfirmPass)
        Me.GroupBox13.Controls.Add(Me.BTN_AuthorNext)
        Me.GroupBox13.Controls.Add(Me.Label30)
        Me.GroupBox13.Controls.Add(Me.Label31)
        Me.GroupBox13.Controls.Add(Me.Label32)
        Me.GroupBox13.Controls.Add(Me.txtAuthorUserID)
        Me.GroupBox13.Controls.Add(Me.txtAuthorUser)
        Me.GroupBox13.Controls.Add(Me.txtAuthorPassword)
        Me.GroupBox13.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox13.Location = New System.Drawing.Point(5, 14)
        Me.GroupBox13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox13.Size = New System.Drawing.Size(789, 359)
        Me.GroupBox13.TabIndex = 51
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Authorization"
        '
        'txtAuthorized
        '
        Me.txtAuthorized.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAuthorized.FormattingEnabled = True
        Me.txtAuthorized.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.txtAuthorized.Location = New System.Drawing.Point(200, 161)
        Me.txtAuthorized.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAuthorized.Name = "txtAuthorized"
        Me.txtAuthorized.Size = New System.Drawing.Size(345, 42)
        Me.txtAuthorized.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 34)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Authorize :"
        '
        'Lb_ConfirmPass
        '
        Me.Lb_ConfirmPass.AutoSize = True
        Me.Lb_ConfirmPass.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lb_ConfirmPass.Location = New System.Drawing.Point(10, 281)
        Me.Lb_ConfirmPass.Name = "Lb_ConfirmPass"
        Me.Lb_ConfirmPass.Size = New System.Drawing.Size(156, 34)
        Me.Lb_ConfirmPass.TabIndex = 24
        Me.Lb_ConfirmPass.Text = "Confirm-Password :"
        Me.Lb_ConfirmPass.Visible = False
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPass.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(200, 278)
        Me.txtConfirmPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.ReadOnly = True
        Me.txtConfirmPass.Size = New System.Drawing.Size(345, 42)
        Me.txtConfirmPass.TabIndex = 6
        Me.txtConfirmPass.Visible = False
        '
        'BTN_AuthorNext
        '
        Me.BTN_AuthorNext.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_AuthorNext.Location = New System.Drawing.Point(575, 50)
        Me.BTN_AuthorNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_AuthorNext.Name = "BTN_AuthorNext"
        Me.BTN_AuthorNext.Size = New System.Drawing.Size(56, 38)
        Me.BTN_AuthorNext.TabIndex = 2
        Me.BTN_AuthorNext.Text = ">>"
        Me.BTN_AuthorNext.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label30.Location = New System.Drawing.Point(10, 218)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(95, 34)
        Me.Label30.TabIndex = 16
        Me.Label30.Text = "Password :"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label31.Location = New System.Drawing.Point(10, 108)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 34)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "User :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label32.Location = New System.Drawing.Point(8, 55)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(81, 34)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "User ID :"
        '
        'txtAuthorUserID
        '
        Me.txtAuthorUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthorUserID.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAuthorUserID.Location = New System.Drawing.Point(200, 50)
        Me.txtAuthorUserID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAuthorUserID.Name = "txtAuthorUserID"
        Me.txtAuthorUserID.ReadOnly = True
        Me.txtAuthorUserID.Size = New System.Drawing.Size(345, 42)
        Me.txtAuthorUserID.TabIndex = 1
        '
        'txtAuthorUser
        '
        Me.txtAuthorUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthorUser.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAuthorUser.Location = New System.Drawing.Point(200, 106)
        Me.txtAuthorUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAuthorUser.Name = "txtAuthorUser"
        Me.txtAuthorUser.ReadOnly = True
        Me.txtAuthorUser.Size = New System.Drawing.Size(345, 42)
        Me.txtAuthorUser.TabIndex = 3
        '
        'txtAuthorPassword
        '
        Me.txtAuthorPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthorPassword.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAuthorPassword.Location = New System.Drawing.Point(200, 217)
        Me.txtAuthorPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAuthorPassword.Name = "txtAuthorPassword"
        Me.txtAuthorPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAuthorPassword.ReadOnly = True
        Me.txtAuthorPassword.Size = New System.Drawing.Size(345, 42)
        Me.txtAuthorPassword.TabIndex = 5
        '
        'BTN_AUTHDEL
        '
        Me.BTN_AUTHDEL.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_AUTHDEL.Location = New System.Drawing.Point(338, 391)
        Me.BTN_AUTHDEL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_AUTHDEL.Name = "BTN_AUTHDEL"
        Me.BTN_AUTHDEL.Size = New System.Drawing.Size(91, 40)
        Me.BTN_AUTHDEL.TabIndex = 10
        Me.BTN_AUTHDEL.Text = "Delete"
        Me.BTN_AUTHDEL.UseVisualStyleBackColor = True
        '
        'BTN_AUTHEDIT
        '
        Me.BTN_AUTHEDIT.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_AUTHEDIT.Location = New System.Drawing.Point(123, 391)
        Me.BTN_AUTHEDIT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_AUTHEDIT.Name = "BTN_AUTHEDIT"
        Me.BTN_AUTHEDIT.Size = New System.Drawing.Size(91, 40)
        Me.BTN_AUTHEDIT.TabIndex = 8
        Me.BTN_AUTHEDIT.Text = "Edit"
        Me.BTN_AUTHEDIT.UseVisualStyleBackColor = True
        '
        'BTN_AUTHNEW
        '
        Me.BTN_AUTHNEW.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_AUTHNEW.Location = New System.Drawing.Point(17, 391)
        Me.BTN_AUTHNEW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_AUTHNEW.Name = "BTN_AUTHNEW"
        Me.BTN_AUTHNEW.Size = New System.Drawing.Size(91, 40)
        Me.BTN_AUTHNEW.TabIndex = 7
        Me.BTN_AUTHNEW.Text = "New"
        Me.BTN_AUTHNEW.UseVisualStyleBackColor = True
        '
        'BTN_AUTHCLOSE
        '
        Me.BTN_AUTHCLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_AUTHCLOSE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_AUTHCLOSE.Location = New System.Drawing.Point(688, 391)
        Me.BTN_AUTHCLOSE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_AUTHCLOSE.Name = "BTN_AUTHCLOSE"
        Me.BTN_AUTHCLOSE.Size = New System.Drawing.Size(91, 40)
        Me.BTN_AUTHCLOSE.TabIndex = 52
        Me.BTN_AUTHCLOSE.Text = "Close"
        Me.BTN_AUTHCLOSE.UseVisualStyleBackColor = True
        '
        'FrmAuthor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_AUTHCLOSE)
        Me.Controls.Add(Me.BTN_SAVEAUTHOR)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.BTN_AUTHEDIT)
        Me.Controls.Add(Me.BTN_AUTHNEW)
        Me.Controls.Add(Me.BTN_AUTHDEL)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmAuthor"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authorization"
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_SAVEAUTHOR As Button
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents txtAuthorized As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Lb_ConfirmPass As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents BTN_AUTHDEL As Button
    Friend WithEvents BTN_AUTHEDIT As Button
    Friend WithEvents BTN_AuthorNext As Button
    Friend WithEvents BTN_AUTHNEW As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtAuthorUserID As TextBox
    Friend WithEvents txtAuthorUser As TextBox
    Friend WithEvents txtAuthorPassword As TextBox
    Friend WithEvents BTN_AUTHCLOSE As Button
End Class
