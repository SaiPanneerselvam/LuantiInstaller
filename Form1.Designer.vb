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
        Me.title = New System.Windows.Forms.Label()
        Me.description = New System.Windows.Forms.Label()
        Me.option1 = New System.Windows.Forms.Button()
        Me.closebutton = New System.Windows.Forms.Button()
        Me.option2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(17, 16)
        Me.title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(207, 31)
        Me.title.TabIndex = 0
        Me.title.Text = "Luanti Installer"
        '
        'description
        '
        Me.description.AutoSize = True
        Me.description.Location = New System.Drawing.Point(24, 52)
        Me.description.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(150, 16)
        Me.description.TabIndex = 1
        Me.description.Text = "Install Luanti on your PC."
        '
        'option1
        '
        Me.option1.Location = New System.Drawing.Point(491, 315)
        Me.option1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.option1.Name = "option1"
        Me.option1.Size = New System.Drawing.Size(100, 28)
        Me.option1.TabIndex = 2
        Me.option1.Text = "Start"
        Me.option1.UseVisualStyleBackColor = True
        '
        'closebutton
        '
        Me.closebutton.BackColor = System.Drawing.Color.Red
        Me.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebutton.ForeColor = System.Drawing.Color.White
        Me.closebutton.Location = New System.Drawing.Point(531, -1)
        Me.closebutton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(100, 28)
        Me.closebutton.TabIndex = 3
        Me.closebutton.Text = "X - Close"
        Me.closebutton.UseVisualStyleBackColor = False
        '
        'option2
        '
        Me.option2.Location = New System.Drawing.Point(368, 315)
        Me.option2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.option2.Name = "option2"
        Me.option2.Size = New System.Drawing.Size(100, 28)
        Me.option2.TabIndex = 4
        Me.option2.UseVisualStyleBackColor = True
        Me.option2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.option2)
        Me.Controls.Add(Me.closebutton)
        Me.Controls.Add(Me.option1)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.title)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(645, 395)
        Me.MinimumSize = New System.Drawing.Size(645, 395)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Luanti Installer 5.10.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents description As System.Windows.Forms.Label
    Friend WithEvents option1 As System.Windows.Forms.Button
    Friend WithEvents closebutton As System.Windows.Forms.Button
    Friend WithEvents option2 As System.Windows.Forms.Button

End Class
