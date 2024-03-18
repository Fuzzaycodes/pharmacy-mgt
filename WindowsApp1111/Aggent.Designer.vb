<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aggent
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AgentGv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CountyTba = New System.Windows.Forms.ComboBox()
        Me.stockCba = New System.Windows.Forms.ComboBox()
        Me.ManuAddresTba = New System.Windows.Forms.TextBox()
        Me.ManuNameTba = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.AgentGv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AgentGv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AgentGv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AgentGv.BackgroundColor = System.Drawing.SystemColors.Control
        Me.AgentGv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AgentGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AgentGv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AgentGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AgentGv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.AgentGv.DoubleBuffered = True
        Me.AgentGv.EnableHeadersVisualStyles = False
        Me.AgentGv.GridColor = System.Drawing.Color.CadetBlue
        Me.AgentGv.HeaderBgColor = System.Drawing.Color.Purple
        Me.AgentGv.HeaderForeColor = System.Drawing.Color.White
        Me.AgentGv.Location = New System.Drawing.Point(398, 105)
        Me.AgentGv.Name = "AgentGv"
        Me.AgentGv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AgentGv.Size = New System.Drawing.Size(546, 394)
        Me.AgentGv.TabIndex = 19
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(33, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1038, 80)
        Me.Panel3.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Purple
        Me.Label8.Location = New System.Drawing.Point(291, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 35)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Agent"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Purple
        Me.Label9.Location = New System.Drawing.Point(291, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(248, 36)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Pharmacy Center"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Button5.Location = New System.Drawing.Point(132, 318)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(146, 41)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.ForestGreen
        Me.Button6.Location = New System.Drawing.Point(132, 257)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(146, 41)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "Add To Form"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(28, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "County"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Purple
        Me.Label2.Location = New System.Drawing.Point(28, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Agent Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(28, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 19)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Agent  Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Purple
        Me.Label4.Location = New System.Drawing.Point(28, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 19)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Available medicine"
        '
        'CountyTba
        '
        Me.CountyTba.FormattingEnabled = True
        Me.CountyTba.Items.AddRange(New Object() {"Mombasa", "Kwale", "Kilifi", "Tana River", "Lamu", "Taita/Taveta", "Garissa", "Wajir", "Mandera", "Marsabit", "Isiolo", "Meru", "Tharaka-Nithi", "Embu", "Kitui", "Machakos", "Makueni", "Nyandarua", "Nyeri", "Kirinyaga", "Murang'a", "Kiambu", "Turkana", "West Pokot", "Samburu", "Trans Nzoia", "Uasin Gishu", "Elgeyo/Marakwet", "Nandi", "Baringo", "Laikipia", "Nakuru", "Narok", "Kajiado", "Kericho", "Bomet", "Kakamega", "Vihiga", "Bungoma", "Busia", "Siaya", "Kisumu", "Homa Bay", "Migori", "Kisii", "Nyamira", "Nairobi City"})
        Me.CountyTba.Location = New System.Drawing.Point(167, 125)
        Me.CountyTba.Name = "CountyTba"
        Me.CountyTba.Size = New System.Drawing.Size(137, 21)
        Me.CountyTba.TabIndex = 49
        '
        'stockCba
        '
        Me.stockCba.FormattingEnabled = True
        Me.stockCba.Items.AddRange(New Object() {"Abilify", "Adderall", "Adderall XR", "Adrenalin", "Albuterol Sulfate", "Aldactone", "Allegra", "Ambien", "Amikin", "Amoxicillin", "Antivert", "Aricept", "Armour Thyroid", "Atarax ", "Atenolol", "Ativan", "Atropine", "Atrovent HFA", "Augmentin", "Avapro", "Coreg (Carvedilol)", "Augmentin (Amoxicillin Clavulanate)", "Rocephin (Ceftriaxone)", "Lasix (Furosemide)", "Lexapro (Escitalopram Oxalate)", "Flexeril (Cyclobenzaprine Hcl)", "Winstrol (Anabolic steroids)", "Bactrim (Trimethoprim and Sulfamethoxazole)", "Macrobid (Nitrofurantoin)", "Keflex (Cephalexin)"})
        Me.stockCba.Location = New System.Drawing.Point(167, 171)
        Me.stockCba.Name = "stockCba"
        Me.stockCba.Size = New System.Drawing.Size(137, 21)
        Me.stockCba.TabIndex = 52
        '
        'ManuAddresTba
        '
        Me.ManuAddresTba.Location = New System.Drawing.Point(167, 86)
        Me.ManuAddresTba.Name = "ManuAddresTba"
        Me.ManuAddresTba.Size = New System.Drawing.Size(137, 20)
        Me.ManuAddresTba.TabIndex = 50
        '
        'ManuNameTba
        '
        Me.ManuNameTba.FormattingEnabled = True
        Me.ManuNameTba.Items.AddRange(New Object() {"ACE Research", "African Pharmaceutical Network (APN)", "Aspen - SSA", "BF Suma Kenya", "ConnectMed", "Cosmos Limited", "Dawa Life Sciences", "Ecumenical Pharmaceutical Network", "Goodlife Pharmacy Africa", "Goodstrain Pharma", "Haltons Limited", "Haltons Ltd", "HighChem Group of Companies", "Kam Pharmacy Ltd", "Kenya Association of Pharmaceutical Industry (KAPI)", "Laboratory & Allied Ltd.", "Lefri Ventures", "MYDAWA", "Maisha Meds", "MedSource Group Limited", "Meraky Healthcare Limited", "Nextgen Pharmaceuticals (K) Ltd.", "Omaera Pharmaceuticals Ltd", "Orange Pharma Ltd", "Orthomedics & Pharmaceuticals Eldoret", "Orthomedics & Pharmaceuticals Eldoret Ltd.", "PHILMED LIMITED.", "Pharmaceutical Society of Kenya", "Pharmaken Ltd", "Pharmaplus Pharmaceuticals Limited", "Prodigy Pharmaceuticals Limited", "Prunus Pharma", "Sai Pharmaceuticals Kenya Ltd", "Sphinx Pharmaceuticals ltd", "Tasa Pharma", "Transwide Pharmaceuticals Limited", "Universal Corporation Limited"})
        Me.ManuNameTba.Location = New System.Drawing.Point(167, 46)
        Me.ManuNameTba.Name = "ManuNameTba"
        Me.ManuNameTba.Size = New System.Drawing.Size(137, 21)
        Me.ManuNameTba.TabIndex = 51
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.CountyTba)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.stockCba)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ManuAddresTba)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ManuNameTba)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(34, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(358, 397)
        Me.Panel1.TabIndex = 53
        '
        'Column1
        '
        Me.Column1.HeaderText = "AgnName"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Address"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "County"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Medicine"
        Me.Column4.Name = "Column4"
        '
        'Aggent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.AgentGv)
        Me.Name = "Aggent"
        Me.Text = "Aggent"
        CType(Me.AgentGv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AgentGv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CountyTba As ComboBox
    Friend WithEvents stockCba As ComboBox
    Friend WithEvents ManuAddresTba As TextBox
    Friend WithEvents ManuNameTba As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
