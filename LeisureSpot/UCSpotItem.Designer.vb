<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSpotItem
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
        Me.pbSpot = New System.Windows.Forms.PictureBox()
        Me.lblSpotName = New System.Windows.Forms.Label()
        CType(Me.pbSpot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbSpot
        '
        Me.pbSpot.Location = New System.Drawing.Point(0, 0)
        Me.pbSpot.Name = "pbSpot"
        Me.pbSpot.Size = New System.Drawing.Size(380, 380)
        Me.pbSpot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbSpot.TabIndex = 0
        Me.pbSpot.TabStop = False
        '
        'lblSpotName
        '
        Me.lblSpotName.BackColor = System.Drawing.Color.Indigo
        Me.lblSpotName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpotName.ForeColor = System.Drawing.Color.White
        Me.lblSpotName.Location = New System.Drawing.Point(0, 317)
        Me.lblSpotName.Name = "lblSpotName"
        Me.lblSpotName.Size = New System.Drawing.Size(380, 30)
        Me.lblSpotName.TabIndex = 1
        Me.lblSpotName.Text = "Kiyovu Peace Plazza"
        Me.lblSpotName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCSpotItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSpotName)
        Me.Controls.Add(Me.pbSpot)
        Me.Name = "UCSpotItem"
        Me.Size = New System.Drawing.Size(380, 380)
        CType(Me.pbSpot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbSpot As PictureBox
    Friend WithEvents lblSpotName As Label
End Class
