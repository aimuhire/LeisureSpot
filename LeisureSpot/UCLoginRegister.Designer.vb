<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLoginRegister
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.tbaccount = New System.Windows.Forms.TabControl()
        Me.tablogin = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabregister = New System.Windows.Forms.TabPage()
        Me.lblErrorTip = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tbPassregconfirm = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbPassreg = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbEmailreg = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbaccount.SuspendLayout()
        Me.tablogin.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabregister.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbaccount
        '
        Me.tbaccount.Controls.Add(Me.tablogin)
        Me.tbaccount.Controls.Add(Me.tabregister)
        Me.tbaccount.Location = New System.Drawing.Point(3, 3)
        Me.tbaccount.Name = "tbaccount"
        Me.tbaccount.SelectedIndex = 0
        Me.tbaccount.Size = New System.Drawing.Size(794, 494)
        Me.tbaccount.TabIndex = 0
        '
        'tablogin
        '
        Me.tablogin.Controls.Add(Me.GroupBox2)
        Me.tablogin.Controls.Add(Me.GroupBox1)
        Me.tablogin.Controls.Add(Me.btnLogin)
        Me.tablogin.Controls.Add(Me.Label1)
        Me.tablogin.Location = New System.Drawing.Point(4, 22)
        Me.tablogin.Name = "tablogin"
        Me.tablogin.Padding = New System.Windows.Forms.Padding(3)
        Me.tablogin.Size = New System.Drawing.Size(786, 468)
        Me.tablogin.TabIndex = 0
        Me.tablogin.Text = "Login"
        Me.tablogin.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbPassword)
        Me.GroupBox2.Location = New System.Drawing.Point(231, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 66)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Password"
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(6, 19)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(326, 38)
        Me.tbPassword.TabIndex = 1
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbEmail)
        Me.GroupBox1.Location = New System.Drawing.Point(231, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 67)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Email"
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(6, 19)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(326, 38)
        Me.tbEmail.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(237, 269)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(113, 46)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(231, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LeisureSpot Login"
        '
        'tabregister
        '
        Me.tabregister.Controls.Add(Me.lblErrorTip)
        Me.tabregister.Controls.Add(Me.GroupBox5)
        Me.tabregister.Controls.Add(Me.GroupBox3)
        Me.tabregister.Controls.Add(Me.GroupBox4)
        Me.tabregister.Controls.Add(Me.btnRegister)
        Me.tabregister.Controls.Add(Me.Label2)
        Me.tabregister.Location = New System.Drawing.Point(4, 22)
        Me.tabregister.Name = "tabregister"
        Me.tabregister.Padding = New System.Windows.Forms.Padding(3)
        Me.tabregister.Size = New System.Drawing.Size(786, 468)
        Me.tabregister.TabIndex = 1
        Me.tabregister.Text = "Register"
        Me.tabregister.UseVisualStyleBackColor = True
        '
        'lblErrorTip
        '
        Me.lblErrorTip.AutoSize = True
        Me.lblErrorTip.ForeColor = System.Drawing.Color.Crimson
        Me.lblErrorTip.Location = New System.Drawing.Point(234, 325)
        Me.lblErrorTip.Name = "lblErrorTip"
        Me.lblErrorTip.Size = New System.Drawing.Size(134, 13)
        Me.lblErrorTip.TabIndex = 11
        Me.lblErrorTip.Text = "Error: Password Missmatch"
        Me.lblErrorTip.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tbPassregconfirm)
        Me.GroupBox5.Location = New System.Drawing.Point(231, 256)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(338, 66)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Confirm Password"
        '
        'tbPassregconfirm
        '
        Me.tbPassregconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassregconfirm.Location = New System.Drawing.Point(6, 19)
        Me.tbPassregconfirm.Name = "tbPassregconfirm"
        Me.tbPassregconfirm.Size = New System.Drawing.Size(326, 38)
        Me.tbPassregconfirm.TabIndex = 1
        Me.tbPassregconfirm.UseSystemPasswordChar = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbPassreg)
        Me.GroupBox3.Location = New System.Drawing.Point(231, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(338, 66)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Password"
        '
        'tbPassreg
        '
        Me.tbPassreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassreg.Location = New System.Drawing.Point(6, 19)
        Me.tbPassreg.Name = "tbPassreg"
        Me.tbPassreg.Size = New System.Drawing.Size(326, 38)
        Me.tbPassreg.TabIndex = 1
        Me.tbPassreg.UseSystemPasswordChar = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbEmailreg)
        Me.GroupBox4.Location = New System.Drawing.Point(231, 113)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(338, 65)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Email"
        '
        'tbEmailreg
        '
        Me.tbEmailreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmailreg.Location = New System.Drawing.Point(6, 19)
        Me.tbEmailreg.Name = "tbEmailreg"
        Me.tbEmailreg.Size = New System.Drawing.Size(326, 38)
        Me.tbEmailreg.TabIndex = 0
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(237, 365)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(113, 46)
        Me.btnRegister.TabIndex = 7
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(231, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "LeisureSpot Register"
        '
        'UCLoginRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbaccount)
        Me.Name = "UCLoginRegister"
        Me.Size = New System.Drawing.Size(800, 500)
        Me.tbaccount.ResumeLayout(False)
        Me.tablogin.ResumeLayout(False)
        Me.tablogin.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabregister.ResumeLayout(False)
        Me.tabregister.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbaccount As TabControl
    Friend WithEvents tablogin As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tabregister As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents tbPassregconfirm As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbPassreg As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbEmailreg As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblErrorTip As Label
End Class
