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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaButton6 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Controls.Add(Me.GunaAdvenceButton3)
        Me.GunaPanel1.Controls.Add(Me.GunaAdvenceButton2)
        Me.GunaPanel1.Controls.Add(Me.GunaAdvenceButton1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(270, 875)
        Me.GunaPanel1.TabIndex = 0
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.LightGray
        Me.GunaLabel2.Location = New System.Drawing.Point(46, 822)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(179, 22)
        Me.GunaLabel2.TabIndex = 7
        Me.GunaLabel2.Text = "Réalisation : M.DHIBOU"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.LightGray
        Me.GunaLabel1.Location = New System.Drawing.Point(58, 844)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(153, 22)
        Me.GunaLabel1.TabIndex = 6
        Me.GunaLabel1.Text = "COPYRIGHT © 2021"
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Controls.Add(Me.GunaButton6)
        Me.GunaPanel3.Controls.Add(Me.GunaButton5)
        Me.GunaPanel3.Controls.Add(Me.GunaButton1)
        Me.GunaPanel3.Controls.Add(Me.GunaButton2)
        Me.GunaPanel3.Controls.Add(Me.Label1)
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel3.Location = New System.Drawing.Point(270, 0)
        Me.GunaPanel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(1130, 77)
        Me.GunaPanel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(377, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GESTION DES HÔTELS"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanel3
        '
        'GunaButton6
        '
        Me.GunaButton6.AnimationHoverSpeed = 0.07!
        Me.GunaButton6.AnimationSpeed = 0.03!
        Me.GunaButton6.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton6.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton6.BorderColor = System.Drawing.Color.Transparent
        Me.GunaButton6.Cursor = System.Windows.Forms.Cursors.Default
        Me.GunaButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton6.ForeColor = System.Drawing.Color.White
        Me.GunaButton6.Image = Global.Table_UI_WIP.My.Resources.Resources.stars
        Me.GunaButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton6.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton6.Location = New System.Drawing.Point(720, 19)
        Me.GunaButton6.Name = "GunaButton6"
        Me.GunaButton6.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton6.OnHoverImage = Global.Table_UI_WIP.My.Resources.Resources.stars
        Me.GunaButton6.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaButton6.Radius = 50
        Me.GunaButton6.Size = New System.Drawing.Size(35, 35)
        Me.GunaButton6.TabIndex = 7
        Me.GunaButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton5
        '
        Me.GunaButton5.AnimationHoverSpeed = 0.07!
        Me.GunaButton5.AnimationSpeed = 0.03!
        Me.GunaButton5.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton5.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton5.BorderColor = System.Drawing.Color.Transparent
        Me.GunaButton5.Cursor = System.Windows.Forms.Cursors.Default
        Me.GunaButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton5.ForeColor = System.Drawing.Color.White
        Me.GunaButton5.Image = Global.Table_UI_WIP.My.Resources.Resources.stars
        Me.GunaButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton5.Location = New System.Drawing.Point(338, 19)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = Global.Table_UI_WIP.My.Resources.Resources.stars
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaButton5.Radius = 50
        Me.GunaButton5.Size = New System.Drawing.Size(35, 35)
        Me.GunaButton5.TabIndex = 6
        Me.GunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Global.Table_UI_WIP.My.Resources.Resources.reduire
        Me.GunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(1031, 19)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Global.Table_UI_WIP.My.Resources.Resources.reduire_H
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaButton1.Radius = 50
        Me.GunaButton1.Size = New System.Drawing.Size(35, 35)
        Me.GunaButton1.TabIndex = 3
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BorderColor = System.Drawing.Color.Transparent
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Global.Table_UI_WIP.My.Resources.Resources.cancel1
        Me.GunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton2.ImageSize = New System.Drawing.Size(19, 19)
        Me.GunaButton2.Location = New System.Drawing.Point(1083, 19)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Global.Table_UI_WIP.My.Resources.Resources.cancel4
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaButton2.Radius = 50
        Me.GunaButton2.Size = New System.Drawing.Size(35, 35)
        Me.GunaButton2.TabIndex = 2
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Table_UI_WIP.My.Resources.Resources.maroc_tourisime2
        Me.GunaPictureBox1.Location = New System.Drawing.Point(77, 19)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaPictureBox1.TabIndex = 5
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.GunaAdvenceButton3.CheckedImage = Global.Table_UI_WIP.My.Resources.Resources.icons8_activity_history_50
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GunaAdvenceButton3.Image = Global.Table_UI_WIP.My.Resources.Resources.icons8_activity_history_50
        Me.GunaAdvenceButton3.ImageOffsetX = 15
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton3.LineLeft = 5
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(0, 415)
        Me.GunaAdvenceButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnPressedDepth = 0
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(270, 77)
        Me.GunaAdvenceButton3.TabIndex = 3
        Me.GunaAdvenceButton3.Text = "VOIR HISTORIQUE"
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.GunaAdvenceButton2.CheckedImage = Global.Table_UI_WIP.My.Resources.Resources.edit_icon_icons1
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GunaAdvenceButton2.Image = Global.Table_UI_WIP.My.Resources.Resources.edit_icon_icons1
        Me.GunaAdvenceButton2.ImageOffsetX = 15
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton2.LineLeft = 5
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(0, 337)
        Me.GunaAdvenceButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnPressedDepth = 0
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(270, 77)
        Me.GunaAdvenceButton2.TabIndex = 2
        Me.GunaAdvenceButton2.Text = "METTRE A JOUR"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.GunaAdvenceButton1.Checked = True
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageOffsetX = 15
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton1.LineLeft = 5
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(0, 258)
        Me.GunaAdvenceButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnPressedDepth = 0
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(270, 77)
        Me.GunaAdvenceButton1.TabIndex = 1
        Me.GunaAdvenceButton1.Text = "CHERCHER HÔTEL"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1400, 875)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des hôtels"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel3.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
