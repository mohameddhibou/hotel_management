<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chercher_hot
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaDataGridView1
        '
        Me.GunaDataGridView1.AllowUserToAddRows = False
        Me.GunaDataGridView1.AllowUserToDeleteRows = False
        Me.GunaDataGridView1.AllowUserToResizeColumns = False
        Me.GunaDataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView1.ColumnHeadersHeight = 40
        Me.GunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.White
        Me.GunaDataGridView1.Location = New System.Drawing.Point(43, 271)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowHeadersWidth = 62
        Me.GunaDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GunaDataGridView1.RowTemplate.Height = 28
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(1045, 419)
        Me.GunaDataGridView1.TabIndex = 0
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Emerald
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 40
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 28
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'Column1
        '
        Me.Column1.HeaderText = "CODE"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOM"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "PROVINCE"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "TEL"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.BorderSize = 1
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox1.Location = New System.Drawing.Point(43, 39)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Radius = 22
        Me.GunaTextBox1.SelectedText = ""
        Me.GunaTextBox1.Size = New System.Drawing.Size(837, 71)
        Me.GunaTextBox1.TabIndex = 1
        Me.GunaTextBox1.Text = "RECHERCHER PAR NOM"
        Me.GunaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = Nothing
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.Image = Nothing
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(876, 180)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Radius = 3
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(212, 45)
        Me.GunaAdvenceButton3.TabIndex = 4
        Me.GunaAdvenceButton3.Text = "  +     AJOUTER HÔTEL"
        '
        'GunaAdvenceButton4
        '
        Me.GunaAdvenceButton4.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton4.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaAdvenceButton4.BorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.CheckedImage = Nothing
        Me.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton4.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.Image = Global.Table_UI_WIP.My.Resources.Resources.refresh
        Me.GunaAdvenceButton4.ImageSize = New System.Drawing.Size(15, 15)
        Me.GunaAdvenceButton4.LineColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton4.Location = New System.Drawing.Point(43, 180)
        Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
        Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.OnHoverImage = Nothing
        Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.Radius = 3
        Me.GunaAdvenceButton4.Size = New System.Drawing.Size(171, 45)
        Me.GunaAdvenceButton4.TabIndex = 5
        Me.GunaAdvenceButton4.Text = "     ACTUALISER"
        Me.GunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = Nothing
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Global.Table_UI_WIP.My.Resources.Resources.sarch
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(11, 11)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(898, 39)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 3
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(190, 71)
        Me.GunaAdvenceButton1.TabIndex = 2
        Me.GunaAdvenceButton1.Text = "  RECHERCHER"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chercher_hot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1184, 702)
        Me.Controls.Add(Me.GunaAdvenceButton4)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "chercher_hot"
        Me.Text = "Form0"
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
