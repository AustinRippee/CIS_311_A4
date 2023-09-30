<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChezSouSad
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
        Me.lblDish = New System.Windows.Forms.Label()
        Me.lstDish = New System.Windows.Forms.ListBox()
        Me.btnAddDish = New System.Windows.Forms.Button()
        Me.txtDish = New System.Windows.Forms.TextBox()
        Me.lblPrep = New System.Windows.Forms.Label()
        Me.lstPrep = New System.Windows.Forms.ListBox()
        Me.txtPrep = New System.Windows.Forms.TextBox()
        Me.btnAddPrep = New System.Windows.Forms.Button()
        Me.txtRaw = New System.Windows.Forms.TextBox()
        Me.btnAddRaw = New System.Windows.Forms.Button()
        Me.lstRaw = New System.Windows.Forms.ListBox()
        Me.lblRaw = New System.Windows.Forms.Label()
        Me.lstPreppedSelected = New System.Windows.Forms.ListBox()
        Me.lblSelectedDish = New System.Windows.Forms.Label()
        Me.lstRawSelected = New System.Windows.Forms.ListBox()
        Me.lblSelectedPrep = New System.Windows.Forms.Label()
        Me.btnLeftPrep = New System.Windows.Forms.Button()
        Me.btnRightPrep = New System.Windows.Forms.Button()
        Me.btnRightRaw = New System.Windows.Forms.Button()
        Me.btnLeftRaw = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDish
        '
        Me.lblDish.AutoSize = True
        Me.lblDish.Location = New System.Drawing.Point(13, 13)
        Me.lblDish.Name = "lblDish"
        Me.lblDish.Size = New System.Drawing.Size(94, 15)
        Me.lblDish.TabIndex = 0
        Me.lblDish.Text = "List of all Dishes:"
        '
        'lstDish
        '
        Me.lstDish.FormattingEnabled = True
        Me.lstDish.ItemHeight = 15
        Me.lstDish.Location = New System.Drawing.Point(13, 32)
        Me.lstDish.Name = "lstDish"
        Me.lstDish.Size = New System.Drawing.Size(814, 94)
        Me.lstDish.TabIndex = 1
        '
        'btnAddDish
        '
        Me.btnAddDish.Location = New System.Drawing.Point(465, 132)
        Me.btnAddDish.Name = "btnAddDish"
        Me.btnAddDish.Size = New System.Drawing.Size(75, 55)
        Me.btnAddDish.TabIndex = 2
        Me.btnAddDish.Text = "Add New Dish"
        Me.btnAddDish.UseVisualStyleBackColor = True
        '
        'txtDish
        '
        Me.txtDish.Location = New System.Drawing.Point(546, 149)
        Me.txtDish.Name = "txtDish"
        Me.txtDish.Size = New System.Drawing.Size(281, 23)
        Me.txtDish.TabIndex = 3
        '
        'lblPrep
        '
        Me.lblPrep.AutoSize = True
        Me.lblPrep.Location = New System.Drawing.Point(465, 208)
        Me.lblPrep.Name = "lblPrep"
        Me.lblPrep.Size = New System.Drawing.Size(136, 15)
        Me.lblPrep.TabIndex = 4
        Me.lblPrep.Text = "List of all Prepped Items:"
        '
        'lstPrep
        '
        Me.lstPrep.FormattingEnabled = True
        Me.lstPrep.ItemHeight = 15
        Me.lstPrep.Location = New System.Drawing.Point(465, 227)
        Me.lstPrep.Name = "lstPrep"
        Me.lstPrep.Size = New System.Drawing.Size(362, 94)
        Me.lstPrep.TabIndex = 5
        '
        'txtPrep
        '
        Me.txtPrep.Location = New System.Drawing.Point(546, 344)
        Me.txtPrep.Name = "txtPrep"
        Me.txtPrep.Size = New System.Drawing.Size(281, 23)
        Me.txtPrep.TabIndex = 7
        '
        'btnAddPrep
        '
        Me.btnAddPrep.Location = New System.Drawing.Point(465, 327)
        Me.btnAddPrep.Name = "btnAddPrep"
        Me.btnAddPrep.Size = New System.Drawing.Size(75, 55)
        Me.btnAddPrep.TabIndex = 6
        Me.btnAddPrep.Text = "Add New Prepped Item"
        Me.btnAddPrep.UseVisualStyleBackColor = True
        '
        'txtRaw
        '
        Me.txtRaw.Location = New System.Drawing.Point(546, 540)
        Me.txtRaw.Name = "txtRaw"
        Me.txtRaw.Size = New System.Drawing.Size(281, 23)
        Me.txtRaw.TabIndex = 11
        '
        'btnAddRaw
        '
        Me.btnAddRaw.Location = New System.Drawing.Point(465, 523)
        Me.btnAddRaw.Name = "btnAddRaw"
        Me.btnAddRaw.Size = New System.Drawing.Size(75, 55)
        Me.btnAddRaw.TabIndex = 10
        Me.btnAddRaw.Text = "Add New Raw Ingr"
        Me.btnAddRaw.UseVisualStyleBackColor = True
        '
        'lstRaw
        '
        Me.lstRaw.FormattingEnabled = True
        Me.lstRaw.ItemHeight = 15
        Me.lstRaw.Location = New System.Drawing.Point(465, 423)
        Me.lstRaw.Name = "lstRaw"
        Me.lstRaw.Size = New System.Drawing.Size(362, 94)
        Me.lstRaw.TabIndex = 9
        '
        'lblRaw
        '
        Me.lblRaw.AutoSize = True
        Me.lblRaw.Location = New System.Drawing.Point(465, 404)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(114, 15)
        Me.lblRaw.TabIndex = 8
        Me.lblRaw.Text = "List of all Raw Items:"
        '
        'lstPreppedSelected
        '
        Me.lstPreppedSelected.FormattingEnabled = True
        Me.lstPreppedSelected.ItemHeight = 15
        Me.lstPreppedSelected.Location = New System.Drawing.Point(13, 227)
        Me.lstPreppedSelected.Name = "lstPreppedSelected"
        Me.lstPreppedSelected.Size = New System.Drawing.Size(300, 94)
        Me.lstPreppedSelected.TabIndex = 13
        '
        'lblSelectedDish
        '
        Me.lblSelectedDish.AutoSize = True
        Me.lblSelectedDish.Location = New System.Drawing.Point(13, 208)
        Me.lblSelectedDish.Name = "lblSelectedDish"
        Me.lblSelectedDish.Size = New System.Drawing.Size(172, 15)
        Me.lblSelectedDish.TabIndex = 12
        Me.lblSelectedDish.Text = "Prepped Items in Selected Dish:"
        '
        'lstRawSelected
        '
        Me.lstRawSelected.FormattingEnabled = True
        Me.lstRawSelected.ItemHeight = 15
        Me.lstRawSelected.Location = New System.Drawing.Point(13, 423)
        Me.lstRawSelected.Name = "lstRawSelected"
        Me.lstRawSelected.Size = New System.Drawing.Size(300, 94)
        Me.lstRawSelected.TabIndex = 15
        '
        'lblSelectedPrep
        '
        Me.lblSelectedPrep.AutoSize = True
        Me.lblSelectedPrep.Location = New System.Drawing.Point(13, 404)
        Me.lblSelectedPrep.Name = "lblSelectedPrep"
        Me.lblSelectedPrep.Size = New System.Drawing.Size(228, 15)
        Me.lblSelectedPrep.TabIndex = 14
        Me.lblSelectedPrep.Text = "Raw Ingredients in Selected Prepped Item:"
        '
        'btnLeftPrep
        '
        Me.btnLeftPrep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLeftPrep.Location = New System.Drawing.Point(336, 227)
        Me.btnLeftPrep.Name = "btnLeftPrep"
        Me.btnLeftPrep.Size = New System.Drawing.Size(104, 42)
        Me.btnLeftPrep.TabIndex = 16
        Me.btnLeftPrep.Text = "<-"
        Me.btnLeftPrep.UseVisualStyleBackColor = True
        '
        'btnRightPrep
        '
        Me.btnRightPrep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRightPrep.Location = New System.Drawing.Point(336, 279)
        Me.btnRightPrep.Name = "btnRightPrep"
        Me.btnRightPrep.Size = New System.Drawing.Size(104, 42)
        Me.btnRightPrep.TabIndex = 17
        Me.btnRightPrep.Text = "->"
        Me.btnRightPrep.UseVisualStyleBackColor = True
        '
        'btnRightRaw
        '
        Me.btnRightRaw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRightRaw.Location = New System.Drawing.Point(336, 475)
        Me.btnRightRaw.Name = "btnRightRaw"
        Me.btnRightRaw.Size = New System.Drawing.Size(104, 42)
        Me.btnRightRaw.TabIndex = 19
        Me.btnRightRaw.Text = "->"
        Me.btnRightRaw.UseVisualStyleBackColor = True
        '
        'btnLeftRaw
        '
        Me.btnLeftRaw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLeftRaw.Location = New System.Drawing.Point(336, 423)
        Me.btnLeftRaw.Name = "btnLeftRaw"
        Me.btnLeftRaw.Size = New System.Drawing.Size(104, 42)
        Me.btnLeftRaw.TabIndex = 18
        Me.btnLeftRaw.Text = "<-"
        Me.btnLeftRaw.UseVisualStyleBackColor = True
        '
        'frmChezSouSad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 598)
        Me.Controls.Add(Me.btnRightRaw)
        Me.Controls.Add(Me.btnLeftRaw)
        Me.Controls.Add(Me.btnRightPrep)
        Me.Controls.Add(Me.btnLeftPrep)
        Me.Controls.Add(Me.lstRawSelected)
        Me.Controls.Add(Me.lblSelectedPrep)
        Me.Controls.Add(Me.lstPreppedSelected)
        Me.Controls.Add(Me.lblSelectedDish)
        Me.Controls.Add(Me.txtRaw)
        Me.Controls.Add(Me.btnAddRaw)
        Me.Controls.Add(Me.lstRaw)
        Me.Controls.Add(Me.lblRaw)
        Me.Controls.Add(Me.txtPrep)
        Me.Controls.Add(Me.btnAddPrep)
        Me.Controls.Add(Me.lstPrep)
        Me.Controls.Add(Me.lblPrep)
        Me.Controls.Add(Me.txtDish)
        Me.Controls.Add(Me.btnAddDish)
        Me.Controls.Add(Me.lstDish)
        Me.Controls.Add(Me.lblDish)
        Me.Name = "frmChezSouSad"
        Me.Text = "Chez SouSad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDish As Label
    Friend WithEvents lstDish As ListBox
    Friend WithEvents btnAddDish As Button
    Friend WithEvents txtDish As TextBox
    Friend WithEvents lblPrep As Label
    Friend WithEvents lstPrep As ListBox
    Friend WithEvents txtPrep As TextBox
    Friend WithEvents btnAddPrep As Button
    Friend WithEvents txtRaw As TextBox
    Friend WithEvents btnAddRaw As Button
    Friend WithEvents lstRaw As ListBox
    Friend WithEvents lblRaw As Label
    Friend WithEvents lstPreppedSelected As ListBox
    Friend WithEvents lblSelectedDish As Label
    Friend WithEvents lstRawSelected As ListBox
    Friend WithEvents lblSelectedPrep As Label
    Friend WithEvents btnLeftPrep As Button
    Friend WithEvents btnRightPrep As Button
    Friend WithEvents btnRightRaw As Button
    Friend WithEvents btnLeftRaw As Button
End Class
