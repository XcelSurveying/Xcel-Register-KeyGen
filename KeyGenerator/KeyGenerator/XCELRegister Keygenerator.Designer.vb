<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.label1 = New System.Windows.Forms.Label()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.cmdGetSerial = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblActivationKey = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(71, 49)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Serial:"
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Location = New System.Drawing.Point(12, 127)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(151, 22)
        Me.cmdGenerate.TabIndex = 2
        Me.cmdGenerate.Text = "Generate Activation Key"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Activation Key:"
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(113, 46)
        Me.txtSerial.MaxLength = 9
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(99, 20)
        Me.txtSerial.TabIndex = 6
        '
        'cmdGetSerial
        '
        Me.cmdGetSerial.Location = New System.Drawing.Point(236, 125)
        Me.cmdGetSerial.Name = "cmdGetSerial"
        Me.cmdGetSerial.Size = New System.Drawing.Size(151, 23)
        Me.cmdGetSerial.TabIndex = 7
        Me.cmdGetSerial.Text = "Get Serial of this computer"
        Me.cmdGetSerial.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Generate Activation Key for XcelRegister"
        '
        'lblActivationKey
        '
        Me.lblActivationKey.Location = New System.Drawing.Point(112, 68)
        Me.lblActivationKey.Name = "lblActivationKey"
        Me.lblActivationKey.ReadOnly = True
        Me.lblActivationKey.Size = New System.Drawing.Size(187, 20)
        Me.lblActivationKey.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 160)
        Me.Controls.Add(Me.lblActivationKey)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdGetSerial)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Key Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents cmdGetSerial As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblActivationKey As System.Windows.Forms.TextBox

End Class
