<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class success
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(5, 100)
        Me.GunaPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(81, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NON STATIQUE"
        '
        'Timer1
        '
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaPictureBox2.Image = Global.Table_UI_WIP.My.Resources.Resources.close
        Me.GunaPictureBox2.Location = New System.Drawing.Point(527, 34)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 3
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Table_UI_WIP.My.Resources.Resources.error2
        Me.GunaPictureBox1.Location = New System.Drawing.Point(31, 34)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 1
        Me.GunaPictureBox1.TabStop = False
        '
        'success
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 100)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "success"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "success"
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Timer1 As Timer
End Class
