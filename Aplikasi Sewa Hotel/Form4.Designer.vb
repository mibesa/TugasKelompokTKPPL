<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPemesanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPemesanan))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblpesan = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.lbltamu = New System.Windows.Forms.Label()
        Me.lbljumlahkamar = New System.Windows.Forms.Label()
        Me.lblpembayaran = New System.Windows.Forms.Label()
        Me.lbltanggalcekout = New System.Windows.Forms.Label()
        Me.lbltanggalcek = New System.Windows.Forms.Label()
        Me.lbltipekamar = New System.Windows.Forms.Label()
        Me.lbltelp = New System.Windows.Forms.Label()
        Me.lbljeniskelamin = New System.Windows.Forms.Label()
        Me.lbllahir = New System.Windows.Forms.Label()
        Me.lblidentitas = New System.Windows.Forms.Label()
        Me.lblkartu = New System.Windows.Forms.Label()
        Me.lblpemesanan = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(169, -4)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(268, 28)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "HOTEL "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpesan
        '
        Me.lblpesan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesan.Location = New System.Drawing.Point(11, 45)
        Me.lblpesan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpesan.Name = "lblpesan"
        Me.lblpesan.Size = New System.Drawing.Size(167, 29)
        Me.lblpesan.TabIndex = 43
        Me.lblpesan.Text = "Pemesanan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(452, 550)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 26)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Pesan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Me.lbltamu)
        Me.GroupBox1.Controls.Add(Me.lbljumlahkamar)
        Me.GroupBox1.Controls.Add(Me.lblpembayaran)
        Me.GroupBox1.Controls.Add(Me.lbltanggalcekout)
        Me.GroupBox1.Controls.Add(Me.lbltanggalcek)
        Me.GroupBox1.Controls.Add(Me.lbltipekamar)
        Me.GroupBox1.Controls.Add(Me.lbltelp)
        Me.GroupBox1.Controls.Add(Me.lbljeniskelamin)
        Me.GroupBox1.Controls.Add(Me.lbllahir)
        Me.GroupBox1.Controls.Add(Me.lblidentitas)
        Me.GroupBox1.Controls.Add(Me.lblkartu)
        Me.GroupBox1.Controls.Add(Me.lblpemesanan)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 75)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(557, 467)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Location = New System.Drawing.Point(248, 269)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 24)
        Me.Panel1.TabIndex = 45
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox3.Location = New System.Drawing.Point(108, 3)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox3.TabIndex = 10
        Me.CheckBox3.Text = "2"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox2.Location = New System.Drawing.Point(195, 3)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "3"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox1.Location = New System.Drawing.Point(21, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"KTP", "SIM"})
        Me.ComboBox1.Location = New System.Drawing.Point(248, 66)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(57, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(248, 134)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox4.Location = New System.Drawing.Point(248, 241)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(57, 21)
        Me.ComboBox4.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(248, 352)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(116, 20)
        Me.TextBox5.TabIndex = 25
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton4.Location = New System.Drawing.Point(392, 428)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton4.TabIndex = 24
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Kredit"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton3.Location = New System.Drawing.Point(248, 428)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton3.TabIndex = 23
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Tunai"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton2.Location = New System.Drawing.Point(372, 170)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Perempuan"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton1.Location = New System.Drawing.Point(248, 172)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Laki-laki"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(248, 208)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(217, 20)
        Me.TextBox4.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"EKONOMI", "PREMIUM", "EKSLUSIVE"})
        Me.ComboBox2.Location = New System.Drawing.Point(248, 313)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(279, 21)
        Me.ComboBox2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(248, 388)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(116, 20)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(248, 98)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(288, 20)
        Me.TextBox2.TabIndex = 3
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(248, 30)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(288, 20)
        Me.txtnama.TabIndex = 1
        '
        'lbltamu
        '
        Me.lbltamu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltamu.Location = New System.Drawing.Point(29, 274)
        Me.lbltamu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltamu.Name = "lbltamu"
        Me.lbltamu.Size = New System.Drawing.Size(116, 22)
        Me.lbltamu.TabIndex = 10
        Me.lbltamu.Text = "Jumlah Tamu"
        '
        'lbljumlahkamar
        '
        Me.lbljumlahkamar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbljumlahkamar.Location = New System.Drawing.Point(29, 241)
        Me.lbljumlahkamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbljumlahkamar.Name = "lbljumlahkamar"
        Me.lbljumlahkamar.Size = New System.Drawing.Size(116, 22)
        Me.lbljumlahkamar.TabIndex = 9
        Me.lbljumlahkamar.Text = "Jumlah Kamar"
        '
        'lblpembayaran
        '
        Me.lblpembayaran.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblpembayaran.Location = New System.Drawing.Point(29, 430)
        Me.lblpembayaran.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpembayaran.Name = "lblpembayaran"
        Me.lblpembayaran.Size = New System.Drawing.Size(116, 22)
        Me.lblpembayaran.TabIndex = 8
        Me.lblpembayaran.Text = "Pembayaran"
        '
        'lbltanggalcekout
        '
        Me.lbltanggalcekout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltanggalcekout.Location = New System.Drawing.Point(29, 391)
        Me.lbltanggalcekout.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltanggalcekout.Name = "lbltanggalcekout"
        Me.lbltanggalcekout.Size = New System.Drawing.Size(116, 22)
        Me.lbltanggalcekout.TabIndex = 7
        Me.lbltanggalcekout.Text = "Tanggal Check Out"
        '
        'lbltanggalcek
        '
        Me.lbltanggalcek.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltanggalcek.Location = New System.Drawing.Point(29, 355)
        Me.lbltanggalcek.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltanggalcek.Name = "lbltanggalcek"
        Me.lbltanggalcek.Size = New System.Drawing.Size(116, 22)
        Me.lbltanggalcek.TabIndex = 7
        Me.lbltanggalcek.Text = "Tanggal Chek In"
        '
        'lbltipekamar
        '
        Me.lbltipekamar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltipekamar.Location = New System.Drawing.Point(31, 316)
        Me.lbltipekamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltipekamar.Name = "lbltipekamar"
        Me.lbltipekamar.Size = New System.Drawing.Size(116, 22)
        Me.lbltipekamar.TabIndex = 6
        Me.lbltipekamar.Text = "Tipe Kamar"
        '
        'lbltelp
        '
        Me.lbltelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltelp.Location = New System.Drawing.Point(31, 208)
        Me.lbltelp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltelp.Name = "lbltelp"
        Me.lbltelp.Size = New System.Drawing.Size(116, 22)
        Me.lbltelp.TabIndex = 5
        Me.lbltelp.Text = "No. Telp/HP"
        '
        'lbljeniskelamin
        '
        Me.lbljeniskelamin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbljeniskelamin.Location = New System.Drawing.Point(31, 172)
        Me.lbljeniskelamin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbljeniskelamin.Name = "lbljeniskelamin"
        Me.lbljeniskelamin.Size = New System.Drawing.Size(116, 22)
        Me.lbljeniskelamin.TabIndex = 4
        Me.lbljeniskelamin.Text = "Jenis Kelamin"
        '
        'lbllahir
        '
        Me.lbllahir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbllahir.Location = New System.Drawing.Point(31, 140)
        Me.lbllahir.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllahir.Name = "lbllahir"
        Me.lbllahir.Size = New System.Drawing.Size(116, 22)
        Me.lbllahir.TabIndex = 3
        Me.lbllahir.Text = "Tanggal Lahir"
        '
        'lblidentitas
        '
        Me.lblidentitas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblidentitas.Location = New System.Drawing.Point(31, 101)
        Me.lblidentitas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidentitas.Name = "lblidentitas"
        Me.lblidentitas.Size = New System.Drawing.Size(116, 22)
        Me.lblidentitas.TabIndex = 2
        Me.lblidentitas.Text = "No. Identitas"
        '
        'lblkartu
        '
        Me.lblkartu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblkartu.Location = New System.Drawing.Point(29, 69)
        Me.lblkartu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblkartu.Name = "lblkartu"
        Me.lblkartu.Size = New System.Drawing.Size(211, 22)
        Me.lblkartu.TabIndex = 1
        Me.lblkartu.Text = "Kartu Identitas (yang digunakan)"
        '
        'lblpemesanan
        '
        Me.lblpemesanan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblpemesanan.Location = New System.Drawing.Point(31, 34)
        Me.lblpemesanan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpemesanan.Name = "lblpemesanan"
        Me.lblpemesanan.Size = New System.Drawing.Size(116, 22)
        Me.lblpemesanan.TabIndex = 0
        Me.lblpemesanan.Text = "Nama Pemesan"
        '
        'FormPemesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.imk_2.My.Resources.Resources._097_example
        Me.ClientSize = New System.Drawing.Size(576, 582)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblpesan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPemesanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Form Pemesanan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblpesan As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents lbltamu As System.Windows.Forms.Label
    Friend WithEvents lbljumlahkamar As System.Windows.Forms.Label
    Friend WithEvents lblpembayaran As System.Windows.Forms.Label
    Friend WithEvents lbltanggalcekout As System.Windows.Forms.Label
    Friend WithEvents lbltanggalcek As System.Windows.Forms.Label
    Friend WithEvents lbltipekamar As System.Windows.Forms.Label
    Friend WithEvents lbltelp As System.Windows.Forms.Label
    Friend WithEvents lbljeniskelamin As System.Windows.Forms.Label
    Friend WithEvents lbllahir As System.Windows.Forms.Label
    Friend WithEvents lblidentitas As System.Windows.Forms.Label
    Friend WithEvents lblkartu As System.Windows.Forms.Label
    Friend WithEvents lblpemesanan As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
