namespace BANKING_ACCOUNT
{
    partial class addNewAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_setoranAwal = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_norek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_batal = new System.Windows.Forms.Button();
            this.btn_ulang = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = ". : add new account : .";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_setoranAwal);
            this.groupBox1.Controls.Add(this.txt_nama);
            this.groupBox1.Controls.Add(this.txt_norek);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // txt_setoranAwal
            // 
            this.txt_setoranAwal.Location = new System.Drawing.Point(189, 122);
            this.txt_setoranAwal.Name = "txt_setoranAwal";
            this.txt_setoranAwal.Size = new System.Drawing.Size(100, 20);
            this.txt_setoranAwal.TabIndex = 5;
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(189, 84);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(100, 20);
            this.txt_nama.TabIndex = 4;
            // 
            // txt_norek
            // 
            this.txt_norek.Location = new System.Drawing.Point(189, 44);
            this.txt_norek.Name = "txt_norek";
            this.txt_norek.Size = new System.Drawing.Size(100, 20);
            this.txt_norek.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Setoran Awal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "No Rekening";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_batal);
            this.groupBox2.Controls.Add(this.btn_ulang);
            this.groupBox2.Controls.Add(this.btn_simpan);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 68);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btn_batal
            // 
            this.btn_batal.ForeColor = System.Drawing.Color.Blue;
            this.btn_batal.Location = new System.Drawing.Point(280, 19);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(75, 38);
            this.btn_batal.TabIndex = 2;
            this.btn_batal.Text = "BATAL";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.MouseLeave += new System.EventHandler(this.btn_batal_MouseLeave);
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            this.btn_batal.MouseEnter += new System.EventHandler(this.btn_batal_MouseEnter);
            // 
            // btn_ulang
            // 
            this.btn_ulang.ForeColor = System.Drawing.Color.Blue;
            this.btn_ulang.Location = new System.Drawing.Point(199, 19);
            this.btn_ulang.Name = "btn_ulang";
            this.btn_ulang.Size = new System.Drawing.Size(75, 38);
            this.btn_ulang.TabIndex = 1;
            this.btn_ulang.Text = "ULANG";
            this.btn_ulang.UseVisualStyleBackColor = true;
            this.btn_ulang.MouseLeave += new System.EventHandler(this.btn_ulang_MouseLeave);
            this.btn_ulang.Click += new System.EventHandler(this.btn_ulang_Click);
            this.btn_ulang.MouseEnter += new System.EventHandler(this.btn_ulang_MouseEnter);
            // 
            // btn_simpan
            // 
            this.btn_simpan.ForeColor = System.Drawing.Color.Blue;
            this.btn_simpan.Location = new System.Drawing.Point(118, 19);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 38);
            this.btn_simpan.TabIndex = 0;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.MouseLeave += new System.EventHandler(this.btn_simpan_MouseLeave);
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            this.btn_simpan.MouseEnter += new System.EventHandler(this.btn_simpan_MouseEnter);
            // 
            // addNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::BANKING_ACCOUNT.Properties.Resources.refresh_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addNewAccount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_setoranAwal;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_norek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Button btn_ulang;
        private System.Windows.Forms.Button btn_simpan;
    }
}