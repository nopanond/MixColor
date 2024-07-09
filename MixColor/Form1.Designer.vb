<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.trcRed = New System.Windows.Forms.TrackBar()
        Me.trcGreen = New System.Windows.Forms.TrackBar()
        Me.trcBlue = New System.Windows.Forms.TrackBar()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTransparent = New System.Windows.Forms.Label()
        Me.trcTransparent = New System.Windows.Forms.TrackBar()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtTransparent = New System.Windows.Forms.TextBox()
        CType(Me.trcRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trcGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trcBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trcTransparent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trcRed
        '
        Me.trcRed.Location = New System.Drawing.Point(189, 20)
        Me.trcRed.Maximum = 255
        Me.trcRed.Name = "trcRed"
        Me.trcRed.Size = New System.Drawing.Size(422, 56)
        Me.trcRed.TabIndex = 0
        '
        'trcGreen
        '
        Me.trcGreen.Location = New System.Drawing.Point(189, 103)
        Me.trcGreen.Maximum = 255
        Me.trcGreen.Name = "trcGreen"
        Me.trcGreen.Size = New System.Drawing.Size(422, 56)
        Me.trcGreen.TabIndex = 1
        '
        'trcBlue
        '
        Me.trcBlue.Location = New System.Drawing.Point(189, 184)
        Me.trcBlue.Maximum = 255
        Me.trcBlue.Name = "trcBlue"
        Me.trcBlue.Size = New System.Drawing.Size(422, 56)
        Me.trcBlue.TabIndex = 2
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRed.Location = New System.Drawing.Point(641, 20)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(26, 29)
        Me.lblRed.TabIndex = 3
        Me.lblRed.Text = "0"
        Me.lblRed.Visible = False
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblGreen.Location = New System.Drawing.Point(641, 103)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(26, 29)
        Me.lblGreen.TabIndex = 4
        Me.lblGreen.Text = "0"
        Me.lblGreen.Visible = False
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBlue.Location = New System.Drawing.Point(641, 184)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(26, 29)
        Me.lblBlue.TabIndex = 5
        Me.lblBlue.Text = "0"
        Me.lblBlue.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(121, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 29)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Red"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(99, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 29)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Green"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(117, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 29)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Blue"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(36, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Transparent"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTransparent
        '
        Me.lblTransparent.AutoSize = True
        Me.lblTransparent.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTransparent.Location = New System.Drawing.Point(641, 262)
        Me.lblTransparent.Name = "lblTransparent"
        Me.lblTransparent.Size = New System.Drawing.Size(26, 29)
        Me.lblTransparent.TabIndex = 11
        Me.lblTransparent.Text = "0"
        Me.lblTransparent.Visible = False
        '
        'trcTransparent
        '
        Me.trcTransparent.Location = New System.Drawing.Point(189, 262)
        Me.trcTransparent.Maximum = 255
        Me.trcTransparent.Name = "trcTransparent"
        Me.trcTransparent.Size = New System.Drawing.Size(422, 56)
        Me.trcTransparent.TabIndex = 10
        Me.trcTransparent.Value = 255
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.White
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtColor.Location = New System.Drawing.Point(189, 357)
        Me.txtColor.Multiline = True
        Me.txtColor.Name = "txtColor"
        Me.txtColor.ReadOnly = True
        Me.txtColor.Size = New System.Drawing.Size(422, 68)
        Me.txtColor.TabIndex = 13
        Me.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtColor.Visible = False
        '
        'lblColor
        '
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblColor.Location = New System.Drawing.Point(189, 357)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(422, 68)
        Me.lblColor.TabIndex = 14
        Me.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRed
        '
        Me.txtRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRed.Location = New System.Drawing.Point(673, 17)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(88, 34)
        Me.txtRed.TabIndex = 15
        Me.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGreen
        '
        Me.txtGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtGreen.Location = New System.Drawing.Point(673, 100)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(88, 34)
        Me.txtGreen.TabIndex = 16
        Me.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBlue
        '
        Me.txtBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBlue.Location = New System.Drawing.Point(673, 181)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(88, 34)
        Me.txtBlue.TabIndex = 17
        Me.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTransparent
        '
        Me.txtTransparent.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTransparent.Location = New System.Drawing.Point(673, 259)
        Me.txtTransparent.Name = "txtTransparent"
        Me.txtTransparent.Size = New System.Drawing.Size(88, 34)
        Me.txtTransparent.TabIndex = 18
        Me.txtTransparent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTransparent)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtGreen)
        Me.Controls.Add(Me.txtRed)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTransparent)
        Me.Controls.Add(Me.trcTransparent)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.trcBlue)
        Me.Controls.Add(Me.trcGreen)
        Me.Controls.Add(Me.trcRed)
        Me.Name = "Form1"
        Me.Text = "MixColor"
        CType(Me.trcRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trcGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trcBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trcTransparent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents trcRed As TrackBar
    Friend WithEvents trcGreen As TrackBar
    Friend WithEvents trcBlue As TrackBar
    Friend WithEvents lblRed As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTransparent As Label
    Friend WithEvents trcTransparent As TrackBar
    Friend WithEvents txtColor As TextBox
    Friend WithEvents lblColor As Label
    Friend WithEvents txtRed As TextBox
    Friend WithEvents txtGreen As TextBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents txtTransparent As TextBox
End Class
