<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAddSpot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCAddSpot))
        Me.lblErrorTip = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btnCreateSpot = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPickImage = New System.Windows.Forms.Button()
        Me.pbFeatured = New System.Windows.Forms.PictureBox()
        Me.tbDescr = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pbFeatured, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblErrorTip
        '
        Me.lblErrorTip.AutoSize = True
        Me.lblErrorTip.ForeColor = System.Drawing.Color.Crimson
        Me.lblErrorTip.Location = New System.Drawing.Point(46, 379)
        Me.lblErrorTip.Name = "lblErrorTip"
        Me.lblErrorTip.Size = New System.Drawing.Size(134, 13)
        Me.lblErrorTip.TabIndex = 17
        Me.lblErrorTip.Text = "Error: Password Missmatch"
        Me.lblErrorTip.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbName)
        Me.GroupBox4.Location = New System.Drawing.Point(43, 123)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(338, 65)
        Me.GroupBox4.TabIndex = 14
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
        'btnCreateSpot
        '
        Me.btnCreateSpot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateSpot.Location = New System.Drawing.Point(43, 405)
        Me.btnCreateSpot.Name = "btnCreateSpot"
        Me.btnCreateSpot.Size = New System.Drawing.Size(147, 46)
        Me.btnCreateSpot.TabIndex = 13
        Me.btnCreateSpot.Text = "Create Site"
        Me.btnCreateSpot.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(300, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 31)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Add Leisure Site"
        '
        'btnPickImage
        '
        Me.btnPickImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickImage.Location = New System.Drawing.Point(43, 194)
        Me.btnPickImage.Name = "btnPickImage"
        Me.btnPickImage.Size = New System.Drawing.Size(338, 31)
        Me.btnPickImage.TabIndex = 18
        Me.btnPickImage.Text = "Pick Site Featured Picture"
        Me.btnPickImage.UseVisualStyleBackColor = True
        '
        'pbFeatured
        '
        Me.pbFeatured.BackColor = System.Drawing.SystemColors.Window
        Me.pbFeatured.Image = CType(resources.GetObject("pbFeatured.Image"), System.Drawing.Image)
        Me.pbFeatured.InitialImage = CType(resources.GetObject("pbFeatured.InitialImage"), System.Drawing.Image)
        Me.pbFeatured.Location = New System.Drawing.Point(469, 123)
        Me.pbFeatured.Name = "pbFeatured"
        Me.pbFeatured.Size = New System.Drawing.Size(286, 269)
        Me.pbFeatured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFeatured.TabIndex = 19
        Me.pbFeatured.TabStop = False
        '
        'tbDescr
        '
        Me.tbDescr.Location = New System.Drawing.Point(6, 19)
        Me.tbDescr.Multiline = True
        Me.tbDescr.Name = "tbDescr"
        Me.tbDescr.Size = New System.Drawing.Size(332, 107)
        Me.tbDescr.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbDescr)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 134)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Description"
        '
        'UCAddSpot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbFeatured)
        Me.Controls.Add(Me.btnPickImage)
        Me.Controls.Add(Me.lblErrorTip)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnCreateSpot)
        Me.Controls.Add(Me.Label2)
        Me.Name = "UCAddSpot"
        Me.Size = New System.Drawing.Size(800, 500)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pbFeatured, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblErrorTip As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents btnCreateSpot As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPickImage As Button
    Friend WithEvents pbFeatured As PictureBox
    Friend WithEvents tbDescr As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
