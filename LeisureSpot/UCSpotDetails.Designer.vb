<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSpotDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCSpotDetails))
        Me.pbFeatured = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lbls = New System.Windows.Forms.Label()
        Me.dgvServices = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.sName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sInfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pbFeatured, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbFeatured
        '
        Me.pbFeatured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFeatured.InitialImage = CType(resources.GetObject("pbFeatured.InitialImage"), System.Drawing.Image)
        Me.pbFeatured.Location = New System.Drawing.Point(509, 68)
        Me.pbFeatured.Name = "pbFeatured"
        Me.pbFeatured.Size = New System.Drawing.Size(258, 215)
        Me.pbFeatured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFeatured.TabIndex = 0
        Me.pbFeatured.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(69, 68)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(103, 25)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Site Name"
        '
        'lblDescription
        '
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(70, 135)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(300, 108)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "asd asd jfasfbk ajsdbasd asd jfasfbk ajsdbasd asd jfasfbk ajsdbasd asd jfasfbk aj" &
    "sdbasd asd jfasfbk ajsdb"
        '
        'lbls
        '
        Me.lbls.AutoSize = True
        Me.lbls.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbls.Location = New System.Drawing.Point(70, 283)
        Me.lbls.Name = "lbls"
        Me.lbls.Size = New System.Drawing.Size(82, 24)
        Me.lbls.TabIndex = 4
        Me.lbls.Text = "Services"
        '
        'dgvServices
        '
        Me.dgvServices.AllowUserToAddRows = False
        Me.dgvServices.AllowUserToDeleteRows = False
        Me.dgvServices.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sName, Me.sInfo})
        Me.dgvServices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvServices.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvServices.Location = New System.Drawing.Point(74, 321)
        Me.dgvServices.Name = "dgvServices"
        Me.dgvServices.ReadOnly = True
        Me.dgvServices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvServices.Size = New System.Drawing.Size(693, 176)
        Me.dgvServices.TabIndex = 5
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(74, 246)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 34)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDelete.Location = New System.Drawing.Point(188, 246)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 37)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btnAddService
        '
        Me.btnAddService.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddService.Location = New System.Drawing.Point(295, 249)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(120, 34)
        Me.btnAddService.TabIndex = 8
        Me.btnAddService.Text = "Add Service"
        Me.btnAddService.UseVisualStyleBackColor = True
        '
        'sName
        '
        Me.sName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.sName.HeaderText = "Service Name"
        Me.sName.Name = "sName"
        Me.sName.ReadOnly = True
        '
        'sInfo
        '
        Me.sInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.sInfo.HeaderText = "Price Info"
        Me.sInfo.Name = "sInfo"
        Me.sInfo.ReadOnly = True
        '
        'UCSpotDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAddService)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dgvServices)
        Me.Controls.Add(Me.lbls)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbFeatured)
        Me.Name = "UCSpotDetails"
        Me.Size = New System.Drawing.Size(800, 500)
        CType(Me.pbFeatured, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbFeatured As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lbls As Label
    Friend WithEvents dgvServices As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAddService As Button
    Friend WithEvents sName As DataGridViewTextBoxColumn
    Friend WithEvents sInfo As DataGridViewTextBoxColumn
End Class
