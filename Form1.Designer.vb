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
        Me.cmdRand = New System.Windows.Forms.Button()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdRand
        '
        Me.cmdRand.Location = New System.Drawing.Point(69, 88)
        Me.cmdRand.Name = "cmdRand"
        Me.cmdRand.Size = New System.Drawing.Size(134, 29)
        Me.cmdRand.TabIndex = 0
        Me.cmdRand.Text = "Get Random"
        Me.cmdRand.UseVisualStyleBackColor = True
        '
        'lblNum
        '
        Me.lblNum.Location = New System.Drawing.Point(235, 94)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(117, 25)
        Me.lblNum.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 196)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.cmdRand)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdRand As Button
    Friend WithEvents lblNum As Label
End Class
