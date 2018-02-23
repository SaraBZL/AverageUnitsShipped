<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtInputDisplay = New System.Windows.Forms.TextBox()
        Me.lblAveragePerDay = New System.Windows.Forms.Label()
        Me.lblDisplayForUnitsShipped = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AverageUnitsShippedTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.Location = New System.Drawing.Point(56, 15)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(39, 17)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "&Units:"
        Me.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblInput, "Units per day")
        '
        'lblDays
        '
        Me.lblDays.Location = New System.Drawing.Point(184, 15)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(39, 13)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "&Day 1:"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblDays, "Day of the week")
        '
        'txtInputDisplay
        '
        Me.txtInputDisplay.Location = New System.Drawing.Point(105, 12)
        Me.txtInputDisplay.Name = "txtInputDisplay"
        Me.txtInputDisplay.Size = New System.Drawing.Size(61, 20)
        Me.txtInputDisplay.TabIndex = 1
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtInputDisplay, "Enter amount shipped per day")
        '
        'lblAveragePerDay
        '
        Me.lblAveragePerDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAveragePerDay.Location = New System.Drawing.Point(36, 187)
        Me.lblAveragePerDay.Name = "lblAveragePerDay"
        Me.lblAveragePerDay.Size = New System.Drawing.Size(201, 27)
        Me.lblAveragePerDay.TabIndex = 4
        Me.lblAveragePerDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblAveragePerDay, "Displays the average shipped per week")
        '
        'lblDisplayForUnitsShipped
        '
        Me.lblDisplayForUnitsShipped.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDisplayForUnitsShipped.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayForUnitsShipped.Location = New System.Drawing.Point(36, 47)
        Me.lblDisplayForUnitsShipped.Name = "lblDisplayForUnitsShipped"
        Me.lblDisplayForUnitsShipped.Size = New System.Drawing.Size(201, 130)
        Me.lblDisplayForUnitsShipped.TabIndex = 3
        Me.lblDisplayForUnitsShipped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblDisplayForUnitsShipped, "Displays the average units shipped ")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 226)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnCalculate, "Select to calculate average units shipped")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(105, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnReset, "Select to clear form and revert to default")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnExit, "Select to exit form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'AverageUnitsShipped
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDisplayForUnitsShipped)
        Me.Controls.Add(Me.lblAveragePerDay)
        Me.Controls.Add(Me.txtInputDisplay)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblInput)
        Me.Name = "AverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.AverageUnitsShippedTips.SetToolTip(Me, "Calculates units shipped per week")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInput As Label
    Friend WithEvents AverageUnitsShippedTips As ToolTip
    Friend WithEvents lblDays As Label
    Friend WithEvents txtInputDisplay As TextBox
    Friend WithEvents lblAveragePerDay As Label
    Friend WithEvents lblDisplayForUnitsShipped As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
