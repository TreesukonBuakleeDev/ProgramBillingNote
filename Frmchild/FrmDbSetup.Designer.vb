<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDbSetup
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
        Me.Acc_DB = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BTN_DBNext = New System.Windows.Forms.Button()
        Me.LB_Confirm = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.txtDBID = New System.Windows.Forms.TextBox()
        Me.BTNAUTHEN_NO = New System.Windows.Forms.RadioButton()
        Me.BTNAUTHEN_YES = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Acc_Source = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Acc_Company = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Acc_Password = New System.Windows.Forms.TextBox()
        Me.Acc_UserID = New System.Windows.Forms.TextBox()
        Me.BTNSAVE_DB = New System.Windows.Forms.Button()
        Me.BTNDB_EDIT = New System.Windows.Forms.Button()
        Me.BTNDB_NEW = New System.Windows.Forms.Button()
        Me.BTNDB_DEL = New System.Windows.Forms.Button()
        Me.BTNDB_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_FMSADMIN = New System.Windows.Forms.PictureBox()
        Me.GroupBox6.SuspendLayout()
        CType(Me.BTN_FMSADMIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Acc_DB
        '
        Me.Acc_DB.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Acc_DB.FormattingEnabled = True
        Me.Acc_DB.Location = New System.Drawing.Point(230, 317)
        Me.Acc_DB.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Acc_DB.Name = "Acc_DB"
        Me.Acc_DB.Size = New System.Drawing.Size(340, 42)
        Me.Acc_DB.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(-1, 320)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(164, 34)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Bill Database Name:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BTN_DBNext)
        Me.GroupBox6.Controls.Add(Me.LB_Confirm)
        Me.GroupBox6.Controls.Add(Me.txtConfirmPass)
        Me.GroupBox6.Controls.Add(Me.txtDBID)
        Me.GroupBox6.Controls.Add(Me.BTNAUTHEN_NO)
        Me.GroupBox6.Controls.Add(Me.BTNAUTHEN_YES)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.Acc_DB)
        Me.GroupBox6.Controls.Add(Me.Acc_Source)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Acc_Company)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Acc_Password)
        Me.GroupBox6.Controls.Add(Me.Acc_UserID)
        Me.GroupBox6.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(20, 40)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.GroupBox6.Size = New System.Drawing.Size(665, 415)
        Me.GroupBox6.TabIndex = 41
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Database Setup"
        '
        'BTN_DBNext
        '
        Me.BTN_DBNext.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTN_DBNext.Location = New System.Drawing.Point(590, 65)
        Me.BTN_DBNext.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTN_DBNext.Name = "BTN_DBNext"
        Me.BTN_DBNext.Size = New System.Drawing.Size(47, 39)
        Me.BTN_DBNext.TabIndex = 47
        Me.BTN_DBNext.Text = ">>"
        Me.BTN_DBNext.UseVisualStyleBackColor = True
        '
        'LB_Confirm
        '
        Me.LB_Confirm.AutoSize = True
        Me.LB_Confirm.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LB_Confirm.Location = New System.Drawing.Point(-1, 213)
        Me.LB_Confirm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_Confirm.Name = "LB_Confirm"
        Me.LB_Confirm.Size = New System.Drawing.Size(156, 34)
        Me.LB_Confirm.TabIndex = 46
        Me.LB_Confirm.Text = "Confirm Password :"
        Me.LB_Confirm.Visible = False
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(230, 215)
        Me.txtConfirmPass.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.Size = New System.Drawing.Size(340, 42)
        Me.txtConfirmPass.TabIndex = 45
        Me.txtConfirmPass.Visible = False
        '
        'txtDBID
        '
        Me.txtDBID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDBID.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDBID.Location = New System.Drawing.Point(233, 22)
        Me.txtDBID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDBID.Name = "txtDBID"
        Me.txtDBID.ReadOnly = True
        Me.txtDBID.Size = New System.Drawing.Size(106, 35)
        Me.txtDBID.TabIndex = 44
        Me.txtDBID.Visible = False
        '
        'BTNAUTHEN_NO
        '
        Me.BTNAUTHEN_NO.AutoSize = True
        Me.BTNAUTHEN_NO.Location = New System.Drawing.Point(315, 369)
        Me.BTNAUTHEN_NO.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTNAUTHEN_NO.Name = "BTNAUTHEN_NO"
        Me.BTNAUTHEN_NO.Size = New System.Drawing.Size(57, 38)
        Me.BTNAUTHEN_NO.TabIndex = 40
        Me.BTNAUTHEN_NO.TabStop = True
        Me.BTNAUTHEN_NO.Text = "No"
        Me.BTNAUTHEN_NO.UseVisualStyleBackColor = True
        '
        'BTNAUTHEN_YES
        '
        Me.BTNAUTHEN_YES.AutoSize = True
        Me.BTNAUTHEN_YES.Location = New System.Drawing.Point(233, 369)
        Me.BTNAUTHEN_YES.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTNAUTHEN_YES.Name = "BTNAUTHEN_YES"
        Me.BTNAUTHEN_YES.Size = New System.Drawing.Size(63, 38)
        Me.BTNAUTHEN_YES.TabIndex = 39
        Me.BTNAUTHEN_YES.TabStop = True
        Me.BTNAUTHEN_YES.Text = "Yes"
        Me.BTNAUTHEN_YES.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 370)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 34)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "User Authentication :"
        '
        'Acc_Source
        '
        Me.Acc_Source.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Acc_Source.FormattingEnabled = True
        Me.Acc_Source.Location = New System.Drawing.Point(230, 265)
        Me.Acc_Source.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Acc_Source.Name = "Acc_Source"
        Me.Acc_Source.Size = New System.Drawing.Size(340, 42)
        Me.Acc_Source.TabIndex = 37
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 61)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 34)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Server Name :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(2, 163)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 34)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Password :"
        '
        'Acc_Company
        '
        Me.Acc_Company.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Acc_Company.Location = New System.Drawing.Point(230, 65)
        Me.Acc_Company.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.Acc_Company.Name = "Acc_Company"
        Me.Acc_Company.Size = New System.Drawing.Size(340, 42)
        Me.Acc_Company.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 115)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 34)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "User :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(0, 268)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(214, 34)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Sage300 Database Name :"
        '
        'Acc_Password
        '
        Me.Acc_Password.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Acc_Password.Location = New System.Drawing.Point(230, 165)
        Me.Acc_Password.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.Acc_Password.Name = "Acc_Password"
        Me.Acc_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Acc_Password.Size = New System.Drawing.Size(340, 42)
        Me.Acc_Password.TabIndex = 32
        '
        'Acc_UserID
        '
        Me.Acc_UserID.Font = New System.Drawing.Font("Cordia New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Acc_UserID.Location = New System.Drawing.Point(230, 115)
        Me.Acc_UserID.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.Acc_UserID.Name = "Acc_UserID"
        Me.Acc_UserID.Size = New System.Drawing.Size(340, 42)
        Me.Acc_UserID.TabIndex = 31
        '
        'BTNSAVE_DB
        '
        Me.BTNSAVE_DB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BTNSAVE_DB.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNSAVE_DB.Location = New System.Drawing.Point(265, 475)
        Me.BTNSAVE_DB.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTNSAVE_DB.Name = "BTNSAVE_DB"
        Me.BTNSAVE_DB.Size = New System.Drawing.Size(99, 35)
        Me.BTNSAVE_DB.TabIndex = 43
        Me.BTNSAVE_DB.Text = "Save"
        Me.BTNSAVE_DB.UseVisualStyleBackColor = True
        '
        'BTNDB_EDIT
        '
        Me.BTNDB_EDIT.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNDB_EDIT.Location = New System.Drawing.Point(146, 475)
        Me.BTNDB_EDIT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTNDB_EDIT.Name = "BTNDB_EDIT"
        Me.BTNDB_EDIT.Size = New System.Drawing.Size(99, 35)
        Me.BTNDB_EDIT.TabIndex = 45
        Me.BTNDB_EDIT.Text = "Edit"
        Me.BTNDB_EDIT.UseVisualStyleBackColor = True
        '
        'BTNDB_NEW
        '
        Me.BTNDB_NEW.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNDB_NEW.Location = New System.Drawing.Point(28, 475)
        Me.BTNDB_NEW.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTNDB_NEW.Name = "BTNDB_NEW"
        Me.BTNDB_NEW.Size = New System.Drawing.Size(99, 35)
        Me.BTNDB_NEW.TabIndex = 44
        Me.BTNDB_NEW.Text = "New"
        Me.BTNDB_NEW.UseVisualStyleBackColor = True
        '
        'BTNDB_DEL
        '
        Me.BTNDB_DEL.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNDB_DEL.Location = New System.Drawing.Point(385, 475)
        Me.BTNDB_DEL.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTNDB_DEL.Name = "BTNDB_DEL"
        Me.BTNDB_DEL.Size = New System.Drawing.Size(99, 35)
        Me.BTNDB_DEL.TabIndex = 46
        Me.BTNDB_DEL.Text = "Delete"
        Me.BTNDB_DEL.UseVisualStyleBackColor = True
        '
        'BTNDB_CLOSE
        '
        Me.BTNDB_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNDB_CLOSE.Font = New System.Drawing.Font("Cordia New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BTNDB_CLOSE.Location = New System.Drawing.Point(585, 475)
        Me.BTNDB_CLOSE.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTNDB_CLOSE.Name = "BTNDB_CLOSE"
        Me.BTNDB_CLOSE.Size = New System.Drawing.Size(99, 35)
        Me.BTNDB_CLOSE.TabIndex = 47
        Me.BTNDB_CLOSE.Text = "Close"
        Me.BTNDB_CLOSE.UseVisualStyleBackColor = True
        '
        'BTN_FMSADMIN
        '
        Me.BTN_FMSADMIN.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.log_in
        Me.BTN_FMSADMIN.Location = New System.Drawing.Point(620, 20)
        Me.BTN_FMSADMIN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTN_FMSADMIN.Name = "BTN_FMSADMIN"
        Me.BTN_FMSADMIN.Size = New System.Drawing.Size(31, 35)
        Me.BTN_FMSADMIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_FMSADMIN.TabIndex = 48
        Me.BTN_FMSADMIN.TabStop = False
        '
        'FrmDbSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 524)
        Me.Controls.Add(Me.BTN_FMSADMIN)
        Me.Controls.Add(Me.BTNDB_CLOSE)
        Me.Controls.Add(Me.BTNDB_DEL)
        Me.Controls.Add(Me.BTNDB_EDIT)
        Me.Controls.Add(Me.BTNDB_NEW)
        Me.Controls.Add(Me.BTNSAVE_DB)
        Me.Controls.Add(Me.GroupBox6)
        Me.Font = New System.Drawing.Font("Cordia New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "FrmDbSetup"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Database"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.BTN_FMSADMIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Acc_DB As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Acc_Source As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Acc_Company As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Acc_Password As TextBox
    Friend WithEvents Acc_UserID As TextBox
    Friend WithEvents BTNSAVE_DB As Button
    Friend WithEvents BTNAUTHEN_NO As RadioButton
    Friend WithEvents BTNAUTHEN_YES As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDBID As TextBox
    Friend WithEvents LB_Confirm As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents BTNDB_EDIT As Button
    Friend WithEvents BTNDB_NEW As Button
    Friend WithEvents BTNDB_DEL As Button
    Friend WithEvents BTNDB_CLOSE As Button
    Friend WithEvents BTN_DBNext As Button
    Friend WithEvents BTN_FMSADMIN As PictureBox
End Class
