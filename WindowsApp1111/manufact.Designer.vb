<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manufact
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CountyTb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ManuAddresTb = New System.Windows.Forms.TextBox()
        Me.ManuNameTb = New System.Windows.Forms.ComboBox()
        Me.ManuGV = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.stockCb = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.ManuGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CountyTb
        '
        Me.CountyTb.FormattingEnabled = True
        Me.CountyTb.Items.AddRange(New Object() {"Mombasa", "Kwale", "Kilifi", "Tana River", "Lamu", "Taita/Taveta", "Garissa", "Wajir", "Mandera", "Marsabit", "Isiolo", "Meru", "Tharaka-Nithi", "Embu", "Kitui", "Machakos", "Makueni", "Nyandarua", "Nyeri", "Kirinyaga", "Murang'a", "Kiambu", "Turkana", "West Pokot", "Samburu", "Trans Nzoia", "Uasin Gishu", "Elgeyo/Marakwet", "Nandi", "Baringo", "Laikipia", "Nakuru", "Narok", "Kajiado", "Kericho", "Bomet", "Kakamega", "Vihiga", "Bungoma", "Busia", "Siaya", "Kisumu", "Homa Bay", "Migori", "Kisii", "Nyamira", "Nairobi City"})
        Me.CountyTb.Location = New System.Drawing.Point(201, 118)
        Me.CountyTb.Name = "CountyTb"
        Me.CountyTb.Size = New System.Drawing.Size(137, 21)
        Me.CountyTb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(34, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "County"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Purple
        Me.Label2.Location = New System.Drawing.Point(34, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Manufacturer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(34, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Manufacturer  Address"
        '
        'ManuAddresTb
        '
        Me.ManuAddresTb.Location = New System.Drawing.Point(201, 79)
        Me.ManuAddresTb.Name = "ManuAddresTb"
        Me.ManuAddresTb.Size = New System.Drawing.Size(137, 20)
        Me.ManuAddresTb.TabIndex = 4
        '
        'ManuNameTb
        '
        Me.ManuNameTb.FormattingEnabled = True
        Me.ManuNameTb.Items.AddRange(New Object() {"ACE Research", "African Pharmaceutical Network (APN)", "Aspen - SSA", "BF Suma Kenya", "ConnectMed", "Cosmos Limited", "Dawa Life Sciences", "Ecumenical Pharmaceutical Network", "Goodlife Pharmacy Africa", "Goodstrain Pharma", "Haltons Limited", "Haltons Ltd", "HighChem Group of Companies", "Kam Pharmacy Ltd", "Kenya Association of Pharmaceutical Industry (KAPI)", "Laboratory & Allied Ltd.", "Lefri Ventures", "MYDAWA", "Maisha Meds", "MedSource Group Limited", "Meraky Healthcare Limited", "Nextgen Pharmaceuticals (K) Ltd.", "Omaera Pharmaceuticals Ltd", "Orange Pharma Ltd", "Orthomedics & Pharmaceuticals Eldoret", "Orthomedics & Pharmaceuticals Eldoret Ltd.", "PHILMED LIMITED.", "Pharmaceutical Society of Kenya", "Pharmaken Ltd", "Pharmaplus Pharmaceuticals Limited", "Prodigy Pharmaceuticals Limited", "Prunus Pharma", "Sai Pharmaceuticals Kenya Ltd", "Sphinx Pharmaceuticals ltd", "Tasa Pharma", "Transwide Pharmaceuticals Limited", "Universal Corporation Limited"})
        Me.ManuNameTb.Location = New System.Drawing.Point(201, 39)
        Me.ManuNameTb.Name = "ManuNameTb"
        Me.ManuNameTb.Size = New System.Drawing.Size(137, 21)
        Me.ManuNameTb.TabIndex = 5
        '
        'ManuGV
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ManuGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.ManuGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.ManuGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ManuGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ManuGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.ManuGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ManuGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5})
        Me.ManuGV.DoubleBuffered = True
        Me.ManuGV.EnableHeadersVisualStyles = False
        Me.ManuGV.GridColor = System.Drawing.Color.CadetBlue
        Me.ManuGV.HeaderBgColor = System.Drawing.Color.Purple
        Me.ManuGV.HeaderForeColor = System.Drawing.Color.White
        Me.ManuGV.Location = New System.Drawing.Point(493, 167)
        Me.ManuGV.Name = "ManuGV"
        Me.ManuGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ManuGV.Size = New System.Drawing.Size(495, 402)
        Me.ManuGV.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "MfName"
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Address"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "County"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Stock"
        Me.Column5.Name = "Column5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Purple
        Me.Label4.Location = New System.Drawing.Point(34, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Available medicine"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Button3.Location = New System.Drawing.Point(107, 232)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 41)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Add To Form"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'stockCb
        '
        Me.stockCb.FormattingEnabled = True
        Me.stockCb.Items.AddRange(New Object() {"Abilify", "Adderall", "Adderall XR", "Adrenalin", "Albuterol Sulfate", "Aldactone", "Allegra", "Ambien", "Amikin", "Amoxicillin", "Antivert", "Aricept", "Armour Thyroid", "Atarax ", "Atenolol", "Ativan", "Atropine", "Atrovent HFA", "Augmentin", "Avapro", "Coreg (Carvedilol)", "Augmentin (Amoxicillin Clavulanate)", "Rocephin (Ceftriaxone)", "Lasix (Furosemide)", "Lexapro (Escitalopram Oxalate)", "Flexeril (Cyclobenzaprine Hcl)", "Winstrol (Anabolic steroids)", "Bactrim (Trimethoprim and Sulfamethoxazole)", "Macrobid (Nitrofurantoin)", "Keflex (Cephalexin)"})
        Me.stockCb.Location = New System.Drawing.Point(201, 164)
        Me.stockCb.Name = "stockCb"
        Me.stockCb.Size = New System.Drawing.Size(137, 21)
        Me.stockCb.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 104)
        Me.Panel1.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Purple
        Me.Label5.Location = New System.Drawing.Point(291, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 35)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Manufacturer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Purple
        Me.Label6.Location = New System.Drawing.Point(291, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 36)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Pharmacy Center"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Button1.Location = New System.Drawing.Point(107, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 41)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.CountyTb)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.stockCb)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ManuAddresTb)
        Me.Panel2.Controls.Add(Me.ManuNameTb)
        Me.Panel2.Location = New System.Drawing.Point(12, 167)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(407, 402)
        Me.Panel2.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Purple
        Me.Label7.Location = New System.Drawing.Point(557, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(264, 35)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Manufacturer Form"
        '
        'manufact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1000, 550)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ManuGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manufact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "manufact"
        CType(Me.ManuGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CountyTb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ManuAddresTb As TextBox
    Friend WithEvents ManuNameTb As ComboBox
    Friend WithEvents ManuGV As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents stockCb As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
End Class
