<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAddService
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbServiceName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbPriceInfo = New System.Windows.Forms.TextBox()
        Me.btnServiceAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbServiceName)
        Me.GroupBox4.Location = New System.Drawing.Point(36, 57)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(338, 65)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Service name"
        '
        'tbServiceName
        '
        Me.tbServiceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbServiceName.Location = New System.Drawing.Point(6, 19)
        Me.tbServiceName.Name = "tbServiceName"
        Me.tbServiceName.Size = New System.Drawing.Size(326, 38)
        Me.tbServiceName.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbPriceInfo)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 65)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Price Info"
        '
        'tbPriceInfo
        '
        Me.tbPriceInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPriceInfo.Location = New System.Drawing.Point(6, 19)
        Me.tbPriceInfo.Name = "tbPriceInfo"
        Me.tbPriceInfo.Size = New System.Drawing.Size(326, 38)
        Me.tbPriceInfo.TabIndex = 0
        '
        'btnServiceAdd
        '
        Me.btnServiceAdd.Location = New System.Drawing.Point(36, 268)
        Me.btnServiceAdd.Name = "btnServiceAdd"
        Me.btnServiceAdd.Size = New System.Drawing.Size(100, 53)
        Me.btnServiceAdd.TabIndex = 10
        Me.btnServiceAdd.Text = "Add Service"
        Me.btnServiceAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(265, 284)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'UCAddService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnServiceAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "UCAddService"
        Me.Size = New System.Drawing.Size(400, 355)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbServiceName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbPriceInfo As TextBox
    Friend WithEvents btnServiceAdd As Button
    Friend WithEvents btnCancel As Button
End Class
