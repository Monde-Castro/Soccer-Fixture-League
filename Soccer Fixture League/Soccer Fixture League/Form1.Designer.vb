<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFirstLeague
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBrazilMatch1 = New System.Windows.Forms.TextBox()
        Me.txtBrazilMatch2 = New System.Windows.Forms.TextBox()
        Me.txtItalyMatch1 = New System.Windows.Forms.TextBox()
        Me.txtItalyMatch2 = New System.Windows.Forms.TextBox()
        Me.txtEnglandMatch2 = New System.Windows.Forms.TextBox()
        Me.txtEnglandMatch1 = New System.Windows.Forms.TextBox()
        Me.lblBrazilTotal = New System.Windows.Forms.Label()
        Me.lblEnglandTotal = New System.Windows.Forms.Label()
        Me.lblItalyTotal = New System.Windows.Forms.Label()
        Me.btnCalcWiinner = New System.Windows.Forms.Button()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(741, 111)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Soccer 2010 First League"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(37, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(689, 314)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Points scored"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Team"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Match 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(427, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Match 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(605, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 31)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TOTAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 31)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Brazil"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(85, 394)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 31)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "England"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(85, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 31)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Italy"
        '
        'txtBrazilMatch1
        '
        Me.txtBrazilMatch1.Location = New System.Drawing.Point(252, 263)
        Me.txtBrazilMatch1.Name = "txtBrazilMatch1"
        Me.txtBrazilMatch1.Size = New System.Drawing.Size(100, 38)
        Me.txtBrazilMatch1.TabIndex = 9
        '
        'txtBrazilMatch2
        '
        Me.txtBrazilMatch2.Location = New System.Drawing.Point(437, 259)
        Me.txtBrazilMatch2.Name = "txtBrazilMatch2"
        Me.txtBrazilMatch2.Size = New System.Drawing.Size(100, 38)
        Me.txtBrazilMatch2.TabIndex = 10
        '
        'txtItalyMatch1
        '
        Me.txtItalyMatch1.Location = New System.Drawing.Point(252, 328)
        Me.txtItalyMatch1.Name = "txtItalyMatch1"
        Me.txtItalyMatch1.Size = New System.Drawing.Size(100, 38)
        Me.txtItalyMatch1.TabIndex = 11
        '
        'txtItalyMatch2
        '
        Me.txtItalyMatch2.Location = New System.Drawing.Point(437, 328)
        Me.txtItalyMatch2.Name = "txtItalyMatch2"
        Me.txtItalyMatch2.Size = New System.Drawing.Size(100, 38)
        Me.txtItalyMatch2.TabIndex = 12
        '
        'txtEnglandMatch2
        '
        Me.txtEnglandMatch2.Location = New System.Drawing.Point(437, 394)
        Me.txtEnglandMatch2.Name = "txtEnglandMatch2"
        Me.txtEnglandMatch2.Size = New System.Drawing.Size(100, 38)
        Me.txtEnglandMatch2.TabIndex = 13
        '
        'txtEnglandMatch1
        '
        Me.txtEnglandMatch1.Location = New System.Drawing.Point(252, 394)
        Me.txtEnglandMatch1.Name = "txtEnglandMatch1"
        Me.txtEnglandMatch1.Size = New System.Drawing.Size(100, 38)
        Me.txtEnglandMatch1.TabIndex = 14
        '
        'lblBrazilTotal
        '
        Me.lblBrazilTotal.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblBrazilTotal.Location = New System.Drawing.Point(605, 257)
        Me.lblBrazilTotal.Name = "lblBrazilTotal"
        Me.lblBrazilTotal.Size = New System.Drawing.Size(102, 40)
        Me.lblBrazilTotal.TabIndex = 15
        '
        'lblEnglandTotal
        '
        Me.lblEnglandTotal.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblEnglandTotal.Location = New System.Drawing.Point(605, 394)
        Me.lblEnglandTotal.Name = "lblEnglandTotal"
        Me.lblEnglandTotal.Size = New System.Drawing.Size(102, 40)
        Me.lblEnglandTotal.TabIndex = 16
        '
        'lblItalyTotal
        '
        Me.lblItalyTotal.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblItalyTotal.Location = New System.Drawing.Point(605, 326)
        Me.lblItalyTotal.Name = "lblItalyTotal"
        Me.lblItalyTotal.Size = New System.Drawing.Size(102, 40)
        Me.lblItalyTotal.TabIndex = 17
        '
        'btnCalcWiinner
        '
        Me.btnCalcWiinner.Location = New System.Drawing.Point(37, 465)
        Me.btnCalcWiinner.Name = "btnCalcWiinner"
        Me.btnCalcWiinner.Size = New System.Drawing.Size(177, 87)
        Me.btnCalcWiinner.TabIndex = 18
        Me.btnCalcWiinner.Text = "&Determine" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wiinner"
        Me.btnCalcWiinner.UseVisualStyleBackColor = True
        '
        'lblWinner
        '
        Me.lblWinner.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblWinner.Location = New System.Drawing.Point(220, 465)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(506, 87)
        Me.lblWinner.TabIndex = 19
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(345, 555)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(177, 67)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(549, 556)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(177, 66)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FrmFirstLeague
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 657)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.btnCalcWiinner)
        Me.Controls.Add(Me.lblItalyTotal)
        Me.Controls.Add(Me.lblEnglandTotal)
        Me.Controls.Add(Me.lblBrazilTotal)
        Me.Controls.Add(Me.txtEnglandMatch1)
        Me.Controls.Add(Me.txtEnglandMatch2)
        Me.Controls.Add(Me.txtItalyMatch2)
        Me.Controls.Add(Me.txtItalyMatch1)
        Me.Controls.Add(Me.txtBrazilMatch2)
        Me.Controls.Add(Me.txtBrazilMatch1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "FrmFirstLeague"
        Me.Text = "First League"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBrazilMatch1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBrazilMatch2 As System.Windows.Forms.TextBox
    Friend WithEvents txtItalyMatch1 As System.Windows.Forms.TextBox
    Friend WithEvents txtItalyMatch2 As System.Windows.Forms.TextBox
    Friend WithEvents txtEnglandMatch2 As System.Windows.Forms.TextBox
    Friend WithEvents txtEnglandMatch1 As System.Windows.Forms.TextBox
    Friend WithEvents lblBrazilTotal As System.Windows.Forms.Label
    Friend WithEvents lblEnglandTotal As System.Windows.Forms.Label
    Friend WithEvents lblItalyTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalcWiinner As System.Windows.Forms.Button
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
