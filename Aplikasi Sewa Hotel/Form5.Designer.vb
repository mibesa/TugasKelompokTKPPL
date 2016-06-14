<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.lblHotel = New System.Windows.Forms.Label()
        Me.btnpesan = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.gbpembayaran = New System.Windows.Forms.GroupBox()
        Me.txttotalPembayaran = New System.Windows.Forms.TextBox()
        Me.txtPembayaran = New System.Windows.Forms.Label()
        Me.lbljnsbayar = New System.Windows.Forms.Label()
        Me.lbltotbayar = New System.Windows.Forms.Label()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.panelpremium = New System.Windows.Forms.TabPage()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.lblEkslusive = New System.Windows.Forms.Label()
        Me.lblPremium = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.paneldiskon = New System.Windows.Forms.Panel()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbljenispembayaran = New System.Windows.Forms.Label()
        Me.rbtunai = New System.Windows.Forms.RadioButton()
        Me.rbkredit = New System.Windows.Forms.RadioButton()
        Me.gbpembayaran.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.panelpremium.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.paneldiskon.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHotel
        '
        Me.lblHotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHotel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotel.ForeColor = System.Drawing.Color.Black
        Me.lblHotel.Location = New System.Drawing.Point(189, 24)
        Me.lblHotel.Name = "lblHotel"
        Me.lblHotel.Size = New System.Drawing.Size(382, 45)
        Me.lblHotel.TabIndex = 26
        Me.lblHotel.Text = "HOTEL "
        Me.lblHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnpesan
        '
        Me.btnpesan.Location = New System.Drawing.Point(535, 360)
        Me.btnpesan.Name = "btnpesan"
        Me.btnpesan.Size = New System.Drawing.Size(81, 42)
        Me.btnpesan.TabIndex = 25
        Me.btnpesan.Text = "PESAN"
        Me.btnpesan.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(445, 360)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 42)
        Me.btnbatal.TabIndex = 24
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'gbpembayaran
        '
        Me.gbpembayaran.BackColor = System.Drawing.Color.Transparent
        Me.gbpembayaran.Controls.Add(Me.txttotalPembayaran)
        Me.gbpembayaran.Controls.Add(Me.txtPembayaran)
        Me.gbpembayaran.Controls.Add(Me.lbljnsbayar)
        Me.gbpembayaran.Controls.Add(Me.lbltotbayar)
        Me.gbpembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbpembayaran.Location = New System.Drawing.Point(485, 110)
        Me.gbpembayaran.Name = "gbpembayaran"
        Me.gbpembayaran.Size = New System.Drawing.Size(166, 244)
        Me.gbpembayaran.TabIndex = 22
        Me.gbpembayaran.TabStop = False
        Me.gbpembayaran.Text = "Data Pembayaran"
        '
        'txttotalPembayaran
        '
        Me.txttotalPembayaran.Location = New System.Drawing.Point(9, 55)
        Me.txttotalPembayaran.Name = "txttotalPembayaran"
        Me.txttotalPembayaran.Size = New System.Drawing.Size(137, 26)
        Me.txttotalPembayaran.TabIndex = 19
        '
        'txtPembayaran
        '
        Me.txtPembayaran.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPembayaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPembayaran.Location = New System.Drawing.Point(9, 144)
        Me.txtPembayaran.Name = "txtPembayaran"
        Me.txtPembayaran.Size = New System.Drawing.Size(140, 31)
        Me.txtPembayaran.TabIndex = 18
        '
        'lbljnsbayar
        '
        Me.lbljnsbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljnsbayar.Location = New System.Drawing.Point(6, 116)
        Me.lbljnsbayar.Name = "lbljnsbayar"
        Me.lbljnsbayar.Size = New System.Drawing.Size(151, 31)
        Me.lbljnsbayar.TabIndex = 17
        Me.lbljnsbayar.Text = "Jenis Pembayaran"
        '
        'lbltotbayar
        '
        Me.lbltotbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotbayar.Location = New System.Drawing.Point(16, 26)
        Me.lbltotbayar.Name = "lbltotbayar"
        Me.lbltotbayar.Size = New System.Drawing.Size(130, 42)
        Me.lbltotbayar.TabIndex = 15
        Me.lbltotbayar.Text = "Total Pembayaran"
        '
        'btnedit
        '
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedit.Location = New System.Drawing.Point(350, 360)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(76, 42)
        Me.btnedit.TabIndex = 27
        Me.btnedit.Text = "&Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.panelpremium)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(148, 100)
        Me.TabControl1.TabIndex = 28
        '
        'panelpremium
        '
        Me.panelpremium.Controls.Add(Me.RadioButton2)
        Me.panelpremium.Controls.Add(Me.RadioButton1)
        Me.panelpremium.Location = New System.Drawing.Point(4, 22)
        Me.panelpremium.Name = "panelpremium"
        Me.panelpremium.Padding = New System.Windows.Forms.Padding(3)
        Me.panelpremium.Size = New System.Drawing.Size(140, 74)
        Me.panelpremium.TabIndex = 0
        Me.panelpremium.Text = "Discount"
        Me.panelpremium.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(16, 38)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "20%"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 6)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "10%"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Splitter1)
        Me.TabPage2.Controls.Add(Me.RadioButton4)
        Me.TabPage2.Controls.Add(Me.RadioButton3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(140, 74)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Jangka Waktu"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(3, 3)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 68)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 39)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton4.TabIndex = 1
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "2Minggu"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "1Minggu"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'lblEkslusive
        '
        Me.lblEkslusive.AutoSize = True
        Me.lblEkslusive.Location = New System.Drawing.Point(13, 25)
        Me.lblEkslusive.Name = "lblEkslusive"
        Me.lblEkslusive.Size = New System.Drawing.Size(52, 13)
        Me.lblEkslusive.TabIndex = 29
        Me.lblEkslusive.Text = "Ekslusive"
        '
        'lblPremium
        '
        Me.lblPremium.AutoSize = True
        Me.lblPremium.Location = New System.Drawing.Point(18, 22)
        Me.lblPremium.Name = "lblPremium"
        Me.lblPremium.Size = New System.Drawing.Size(47, 13)
        Me.lblPremium.TabIndex = 3
        Me.lblPremium.Text = "Premium"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "1000000"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(12, 48)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(148, 100)
        Me.TabControl2.TabIndex = 39
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.paneldiskon)
        Me.TabPage3.Controls.Add(Me.RadioButton5)
        Me.TabPage3.Controls.Add(Me.RadioButton6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(140, 74)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Discount"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'paneldiskon
        '
        Me.paneldiskon.Controls.Add(Me.RadioButton7)
        Me.paneldiskon.Controls.Add(Me.RadioButton10)
        Me.paneldiskon.Location = New System.Drawing.Point(0, 0)
        Me.paneldiskon.Name = "paneldiskon"
        Me.paneldiskon.Size = New System.Drawing.Size(200, 100)
        Me.paneldiskon.TabIndex = 2
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(16, 47)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton7.TabIndex = 3
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "20%"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(16, 15)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton10.TabIndex = 2
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "10%"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(16, 38)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "20%"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(16, 6)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton6.TabIndex = 0
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "10%"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Splitter2)
        Me.TabPage4.Controls.Add(Me.RadioButton8)
        Me.TabPage4.Controls.Add(Me.RadioButton9)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(140, 74)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Jangka Waktu"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(3, 3)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 68)
        Me.Splitter2.TabIndex = 2
        Me.Splitter2.TabStop = False
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(6, 39)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton8.TabIndex = 1
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "2Minggu"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(6, 4)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton9.TabIndex = 0
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "1Minggu"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "1500000"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblPremium)
        Me.Panel2.Location = New System.Drawing.Point(12, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(179, 153)
        Me.Panel2.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblEkslusive)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.TabControl2)
        Me.Panel3.Location = New System.Drawing.Point(12, 247)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(179, 155)
        Me.Panel3.TabIndex = 42
        '
        'lbljenispembayaran
        '
        Me.lbljenispembayaran.AutoSize = True
        Me.lbljenispembayaran.Location = New System.Drawing.Point(217, 138)
        Me.lbljenispembayaran.Name = "lbljenispembayaran"
        Me.lbljenispembayaran.Size = New System.Drawing.Size(93, 13)
        Me.lbljenispembayaran.TabIndex = 43
        Me.lbljenispembayaran.Text = "Jenis Pembayaran"
        '
        'rbtunai
        '
        Me.rbtunai.AutoSize = True
        Me.rbtunai.Location = New System.Drawing.Point(316, 136)
        Me.rbtunai.Name = "rbtunai"
        Me.rbtunai.Size = New System.Drawing.Size(52, 17)
        Me.rbtunai.TabIndex = 44
        Me.rbtunai.TabStop = True
        Me.rbtunai.Text = "Tunai"
        Me.rbtunai.UseVisualStyleBackColor = True
        '
        'rbkredit
        '
        Me.rbkredit.AutoSize = True
        Me.rbkredit.Location = New System.Drawing.Point(316, 171)
        Me.rbkredit.Name = "rbkredit"
        Me.rbkredit.Size = New System.Drawing.Size(52, 17)
        Me.rbkredit.TabIndex = 45
        Me.rbkredit.TabStop = True
        Me.rbkredit.Text = "Kredit"
        Me.rbkredit.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 442)
        Me.Controls.Add(Me.rbkredit)
        Me.Controls.Add(Me.rbtunai)
        Me.Controls.Add(Me.lbljenispembayaran)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.lblHotel)
        Me.Controls.Add(Me.btnpesan)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.gbpembayaran)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "Form Pembayaran"
        Me.gbpembayaran.ResumeLayout(False)
        Me.gbpembayaran.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.panelpremium.ResumeLayout(False)
        Me.panelpremium.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.paneldiskon.ResumeLayout(False)
        Me.paneldiskon.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHotel As System.Windows.Forms.Label
    Friend WithEvents btnpesan As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents gbpembayaran As System.Windows.Forms.GroupBox
    Friend WithEvents txtPembayaran As System.Windows.Forms.Label
    Friend WithEvents lbljnsbayar As System.Windows.Forms.Label
    Friend WithEvents lbltotbayar As System.Windows.Forms.Label
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents panelpremium As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents txttotalPembayaran As System.Windows.Forms.TextBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents lblEkslusive As System.Windows.Forms.Label
    Friend WithEvents lblPremium As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents paneldiskon As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents lbljenispembayaran As System.Windows.Forms.Label
    Friend WithEvents rbtunai As System.Windows.Forms.RadioButton
    Friend WithEvents rbkredit As System.Windows.Forms.RadioButton
End Class
