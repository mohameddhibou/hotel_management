<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mettre_a_jour
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mettre_a_jour))
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTextBox3 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaComboBox2 = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaComboBox1 = New Guna.UI.WinForms.GunaComboBox()
        Me.FKhotcat1Codho3E52440BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DboDataSet = New Table_UI_WIP.dboDataSet()
        Me.Hot_cat1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hot_cat1TableAdapter = New Table_UI_WIP.dboDataSetTableAdapters.hot_cat1TableAdapter()
        Me.TableAdapterManager = New Table_UI_WIP.dboDataSetTableAdapters.TableAdapterManager()
        Me.HotelsTableAdapter = New Table_UI_WIP.dboDataSetTableAdapters.HotelsTableAdapter()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaComboBox3 = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaComboBox4 = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.FKhotcat1Codho3E52440BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DboDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hot_cat1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaGroupBox1.Controls.Add(Me.GunaComboBox4)
        Me.GunaGroupBox1.Controls.Add(Me.GunaComboBox3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel9)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel8)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel7)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel5)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel4)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaTextBox3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaTextBox2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaTextBox1)
        Me.GunaGroupBox1.Controls.Add(Me.GunaComboBox2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaComboBox1)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaGroupBox1.LineTop = 40
        Me.GunaGroupBox1.Location = New System.Drawing.Point(57, 115)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Radius = 2
        Me.GunaGroupBox1.Size = New System.Drawing.Size(1002, 545)
        Me.GunaGroupBox1.TabIndex = 0
        Me.GunaGroupBox1.Text = "INFORMATIONS HÔTEL"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 13)
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GunaLabel9.Location = New System.Drawing.Point(674, 478)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(83, 22)
        Me.GunaLabel9.TabIndex = 10
        Me.GunaLabel9.Text = "Année fin"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GunaLabel1.Location = New System.Drawing.Point(291, 478)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(108, 22)
        Me.GunaLabel1.TabIndex = 9
        Me.GunaLabel1.Text = "Année début"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(63, 427)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(197, 24)
        Me.GunaLabel8.TabIndex = 8
        Me.GunaLabel8.Text = "PERIODE (PAR ANNEE)"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(618, 438)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(19, 24)
        Me.GunaLabel7.TabIndex = 8
        Me.GunaLabel7.Text = "/"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(63, 356)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(179, 24)
        Me.GunaLabel6.TabIndex = 8
        Me.GunaLabel6.Text = "NOMBRE EMPLOYES"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(63, 285)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(123, 24)
        Me.GunaLabel5.TabIndex = 8
        Me.GunaLabel5.Text = "NOMBRE LITS"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(63, 220)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(185, 24)
        Me.GunaLabel4.TabIndex = 8
        Me.GunaLabel4.Text = "NOMBRE CHAMBRES"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(63, 154)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(157, 24)
        Me.GunaLabel3.TabIndex = 8
        Me.GunaLabel3.Text = "CODE CATEGORIE"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(63, 86)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(114, 24)
        Me.GunaLabel2.TabIndex = 7
        Me.GunaLabel2.Text = "NOM HÔTEL"
        '
        'GunaTextBox3
        '
        Me.GunaTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox3.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox3.BorderColor = System.Drawing.Color.Black
        Me.GunaTextBox3.BorderSize = 1
        Me.GunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox3.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox3.FocusedBorderColor = System.Drawing.Color.White
        Me.GunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GunaTextBox3.Location = New System.Drawing.Point(295, 356)
        Me.GunaTextBox3.Name = "GunaTextBox3"
        Me.GunaTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox3.Radius = 10
        Me.GunaTextBox3.SelectedText = ""
        Me.GunaTextBox3.Size = New System.Drawing.Size(662, 48)
        Me.GunaTextBox3.TabIndex = 4
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Black
        Me.GunaTextBox2.BorderSize = 1
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GunaTextBox2.Location = New System.Drawing.Point(295, 285)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.Radius = 10
        Me.GunaTextBox2.SelectedText = ""
        Me.GunaTextBox2.Size = New System.Drawing.Size(662, 48)
        Me.GunaTextBox2.TabIndex = 3
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Black
        Me.GunaTextBox1.BorderSize = 1
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GunaTextBox1.Location = New System.Drawing.Point(295, 220)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Radius = 10
        Me.GunaTextBox1.SelectedText = ""
        Me.GunaTextBox1.Size = New System.Drawing.Size(662, 48)
        Me.GunaTextBox1.TabIndex = 2
        '
        'GunaComboBox2
        '
        Me.GunaComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox2.BaseColor = System.Drawing.Color.White
        Me.GunaComboBox2.BorderColor = System.Drawing.Color.Black
        Me.GunaComboBox2.BorderSize = 1
        Me.GunaComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox2.ForeColor = System.Drawing.Color.Black
        Me.GunaComboBox2.FormattingEnabled = True
        Me.GunaComboBox2.Location = New System.Drawing.Point(295, 154)
        Me.GunaComboBox2.Name = "GunaComboBox2"
        Me.GunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBox2.Radius = 5
        Me.GunaComboBox2.Size = New System.Drawing.Size(662, 35)
        Me.GunaComboBox2.TabIndex = 1
        '
        'GunaComboBox1
        '
        Me.GunaComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox1.BaseColor = System.Drawing.Color.White
        Me.GunaComboBox1.BorderColor = System.Drawing.Color.Black
        Me.GunaComboBox1.BorderSize = 1
        Me.GunaComboBox1.DataSource = Me.FKhotcat1Codho3E52440BBindingSource
        Me.GunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox1.ForeColor = System.Drawing.Color.Black
        Me.GunaComboBox1.FormattingEnabled = True
        Me.GunaComboBox1.Location = New System.Drawing.Point(295, 86)
        Me.GunaComboBox1.Name = "GunaComboBox1"
        Me.GunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBox1.Radius = 5
        Me.GunaComboBox1.Size = New System.Drawing.Size(662, 35)
        Me.GunaComboBox1.TabIndex = 0
        '
        'FKhotcat1Codho3E52440BBindingSource
        '
        Me.FKhotcat1Codho3E52440BBindingSource.DataMember = "FK__hot_cat1__Cod_ho__3E52440B"
        Me.FKhotcat1Codho3E52440BBindingSource.DataSource = Me.HotelsBindingSource
        '
        'HotelsBindingSource
        '
        Me.HotelsBindingSource.DataMember = "Hotels"
        Me.HotelsBindingSource.DataSource = Me.DboDataSet
        '
        'DboDataSet
        '
        Me.DboDataSet.DataSetName = "dboDataSet"
        Me.DboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Hot_cat1BindingSource
        '
        Me.Hot_cat1BindingSource.DataMember = "hot_cat1"
        Me.Hot_cat1BindingSource.DataSource = Me.DboDataSet
        '
        'Hot_cat1TableAdapter
        '
        Me.Hot_cat1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CatégorieTableAdapter = Nothing
        Me.TableAdapterManager.hot_cat1TableAdapter = Me.Hot_cat1TableAdapter
        Me.TableAdapterManager.HotelsTableAdapter = Me.HotelsTableAdapter
        Me.TableAdapterManager.ProvincesTableAdapter = Nothing
        Me.TableAdapterManager.RégionsTableAdapter = Nothing
        Me.TableAdapterManager.TerritoiresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Table_UI_WIP.dboDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HotelsTableAdapter
        '
        Me.HotelsTableAdapter.ClearBeforeFill = True
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(258, 705)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 10
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(238, 66)
        Me.GunaAdvenceButton1.TabIndex = 2
        Me.GunaAdvenceButton1.Text = "ENREGISTER"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = CType(resources.GetObject("GunaAdvenceButton2.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = Nothing
        Me.GunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(630, 705)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Radius = 10
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(238, 66)
        Me.GunaAdvenceButton2.TabIndex = 3
        Me.GunaAdvenceButton2.Text = "ANNULER"
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaComboBox3
        '
        Me.GunaComboBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox3.BaseColor = System.Drawing.Color.White
        Me.GunaComboBox3.BorderColor = System.Drawing.Color.Black
        Me.GunaComboBox3.BorderSize = 1
        Me.GunaComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox3.ForeColor = System.Drawing.Color.Black
        Me.GunaComboBox3.FormattingEnabled = True
        Me.GunaComboBox3.Location = New System.Drawing.Point(295, 427)
        Me.GunaComboBox3.Name = "GunaComboBox3"
        Me.GunaComboBox3.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaComboBox3.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBox3.Radius = 5
        Me.GunaComboBox3.Size = New System.Drawing.Size(279, 35)
        Me.GunaComboBox3.TabIndex = 11
        '
        'GunaComboBox4
        '
        Me.GunaComboBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox4.BaseColor = System.Drawing.Color.White
        Me.GunaComboBox4.BorderColor = System.Drawing.Color.Black
        Me.GunaComboBox4.BorderSize = 1
        Me.GunaComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox4.ForeColor = System.Drawing.Color.Black
        Me.GunaComboBox4.FormattingEnabled = True
        Me.GunaComboBox4.Location = New System.Drawing.Point(678, 427)
        Me.GunaComboBox4.Name = "GunaComboBox4"
        Me.GunaComboBox4.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GunaComboBox4.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBox4.Radius = 5
        Me.GunaComboBox4.Size = New System.Drawing.Size(279, 35)
        Me.GunaComboBox4.TabIndex = 12
        '
        'mettre_a_jour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1106, 783)
        Me.Controls.Add(Me.GunaAdvenceButton2)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mettre_a_jour"
        Me.Text = "Form2"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.FKhotcat1Codho3E52440BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DboDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hot_cat1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents DboDataSet As dboDataSet
    Friend WithEvents Hot_cat1BindingSource As BindingSource
    Friend WithEvents Hot_cat1TableAdapter As dboDataSetTableAdapters.hot_cat1TableAdapter
    Friend WithEvents TableAdapterManager As dboDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GunaComboBox1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents HotelsTableAdapter As dboDataSetTableAdapters.HotelsTableAdapter
    Friend WithEvents HotelsBindingSource As BindingSource
    Friend WithEvents FKhotcat1Codho3E52440BBindingSource As BindingSource
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTextBox3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaComboBox2 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaComboBox4 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaComboBox3 As Guna.UI.WinForms.GunaComboBox
End Class
