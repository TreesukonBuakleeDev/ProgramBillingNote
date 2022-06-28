<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MAIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MAIN))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_MIN = New System.Windows.Forms.PictureBox()
        Me.BTN_MAX = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtForm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtDBBILL = New System.Windows.Forms.TextBox()
        Me.txtDBSOURCE = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LISTMENU = New System.Windows.Forms.TreeView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BTN_MIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_MAX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PanelMain)
        Me.Panel5.Controls.Add(Me.Panel1)
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.Name = "Panel5"
        '
        'PanelMain
        '
        resources.ApplyResources(Me.PanelMain, "PanelMain")
        Me.PanelMain.Name = "PanelMain"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BTN_MIN)
        Me.Panel1.Controls.Add(Me.BTN_MAX)
        Me.Panel1.Name = "Panel1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Name = "Label2"
        '
        'BTN_MIN
        '
        resources.ApplyResources(Me.BTN_MIN, "BTN_MIN")
        Me.BTN_MIN.Name = "BTN_MIN"
        Me.BTN_MIN.TabStop = False
        '
        'BTN_MAX
        '
        resources.ApplyResources(Me.BTN_MAX, "BTN_MAX")
        Me.BTN_MAX.Name = "BTN_MAX"
        Me.BTN_MAX.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.txtForm)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtServer)
        Me.Panel4.Controls.Add(Me.txtDBBILL)
        Me.Panel4.Controls.Add(Me.txtDBSOURCE)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'txtForm
        '
        Me.txtForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtForm.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtForm.ForeColor = System.Drawing.SystemColors.ActiveBorder
        resources.ApplyResources(Me.txtForm, "txtForm")
        Me.txtForm.Name = "txtForm"
        Me.txtForm.ReadOnly = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Name = "Label3"
        '
        'txtServer
        '
        resources.ApplyResources(Me.txtServer, "txtServer")
        Me.txtServer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtServer.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtServer.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtServer.Name = "txtServer"
        Me.txtServer.ReadOnly = True
        '
        'txtDBBILL
        '
        resources.ApplyResources(Me.txtDBBILL, "txtDBBILL")
        Me.txtDBBILL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDBBILL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDBBILL.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDBBILL.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtDBBILL.Name = "txtDBBILL"
        Me.txtDBBILL.ReadOnly = True
        '
        'txtDBSOURCE
        '
        resources.ApplyResources(Me.txtDBSOURCE, "txtDBSOURCE")
        Me.txtDBSOURCE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDBSOURCE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDBSOURCE.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDBSOURCE.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtDBSOURCE.Name = "txtDBSOURCE"
        Me.txtDBSOURCE.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.Controls.Add(Me.LISTMENU)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'LISTMENU
        '
        Me.LISTMENU.BackColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.LISTMENU, "LISTMENU")
        Me.LISTMENU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LISTMENU.LineColor = System.Drawing.Color.RoyalBlue
        Me.LISTMENU.Name = "LISTMENU"
        Me.LISTMENU.Nodes.AddRange(New System.Windows.Forms.TreeNode() {CType(resources.GetObject("LISTMENU.Nodes"), System.Windows.Forms.TreeNode), CType(resources.GetObject("LISTMENU.Nodes1"), System.Windows.Forms.TreeNode), CType(resources.GetObject("LISTMENU.Nodes2"), System.Windows.Forms.TreeNode), CType(resources.GetObject("LISTMENU.Nodes3"), System.Windows.Forms.TreeNode)})
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Navy
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Image = Global.PROGRAMBILLING_2021.My.Resources.Resources.FMS_Logo
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'MAIN
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel2)
        Me.Name = "MAIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BTN_MIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_MAX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_MIN As PictureBox
    Friend WithEvents BTN_MAX As PictureBox
    Friend WithEvents LISTMENU As TreeView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtDBBILL As TextBox
    Friend WithEvents txtDBSOURCE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtForm As TextBox
End Class
