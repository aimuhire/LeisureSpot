<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCEdit))
        Me.pbFeatured = New System.Windows.Forms.PictureBox()
        Me.btnPickImage = New System.Windows.Forms.Button()
        Me.lblErrorTip = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btnUpdateSpot = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbDescr = New System.Windows.Forms.TextBox()
        CType(Me.pbFeatured, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbFeatured
        '
        Me.pbFeatured.BackColor = System.Drawing.SystemColors.Window
        Me.pbFeatured.Image = CType(resources.GetObject("pbFeatured.Image"), System.Drawing.Image)
        Me.pbFeatured.InitialImage = Nothing
        Me.pbFeatured.Location = New System.Drawing.Point(472, 139)
        Me.pbFeatured.Name = "pbFeatured"
        Me.pbFeatured.Size = New System.Drawing.Size(286, 269)
        Me.pbFeatured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFeatured.TabIndex = 25
        Me.pbFeatured.TabStop = False
        '
        'btnPickImage
        '
        Me.btnPickImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickImage.Location = New System.Drawing.Point(46, 210)
        Me.btnPickImage.Name = "btnPickImage"
        Me.btnPickImage.Size = New System.Drawing.Size(338, 31)
        Me.btnPickImage.TabIndex = 24
        Me.btnPickImage.Text = "Pick Site Featured Picture"
        Me.btnPickImage.UseVisualStyleBackColor = True
        '
        'lblErrorTip
        '
        Me.lblErrorTip.AutoSize = True
        Me.lblErrorTip.ForeColor = System.Drawing.Color.Crimson
        Me.lblErrorTip.Location = New System.Drawing.Point(43, 244)
        Me.lblErrorTip.Name = "lblErrorTip"
        Me.lblErrorTip.Size = New System.Drawing.Size(134, 13)
        Me.lblErrorTip.TabIndex = 23
        Me.lblErrorTip.Text = "Error: Password Missmatch"
        Me.lblErrorTip.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbName)
        Me.GroupBox4.Location = New System.Drawing.Point(46, 139)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(338, 65)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Site Name"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(6, 19)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(326, 38)
        Me.tbName.TabIndex = 0
        '
        'btnUpdateSpot
        '
        Me.btnUpdateSpot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSpot.Location = New System.Drawing.Point(46, 411)
        Me.btnUpdateSpot.Name = "btnUpdateSpot"
        Me.btnUpdateSpot.Size = New System.Drawing.Size(147, 46)
        Me.btnUpdateSpot.TabIndex = 21
        Me.btnUpdateSpot.Text = "Update Site"
        Me.btnUpdateSpot.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(303, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 31)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Edit Leisure Site"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbDescr)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 134)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Description"
        '
        'tbDescr
        '
        Me.tbDescr.Location = New System.Drawing.Point(6, 19)
        Me.tbDescr.Multiline = True
        Me.tbDescr.Name = "tbDescr"
        Me.tbDescr.Size = New System.Drawing.Size(332, 107)
        Me.tbDescr.TabIndex = 21
        '
        'UCEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbFeatured)
        Me.Controls.Add(Me.btnPickImage)
        Me.Controls.Add(Me.lblErrorTip)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnUpdateSpot)
        Me.Controls.Add(Me.Label2)
        Me.Name = "UCEdit"
        Me.Size = New System.Drawing.Size(800, 500)
        CType(Me.pbFeatured, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbFeatured As PictureBox
    Friend WithEvents btnPickImage As Button
    Friend WithEvents lblErrorTip As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents btnUpdateSpot As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbDescr As TextBox
End Class
