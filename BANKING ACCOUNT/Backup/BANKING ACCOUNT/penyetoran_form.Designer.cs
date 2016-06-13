namespace BANKING_ACCOUNT
{
    partial class penyetoran_form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_penarikan = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_batal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BANKING_ACCOUNT.Properties.Resources.uang;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(212, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nominal Setoran";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = ". : penyetoran : .";
            // 
            // txt_penarikan
            // 
            this.txt_penarikan.Location = new System.Drawing.Point(341, 80);
            this.txt_penarikan.Name = "txt_penarikan";
            this.txt_penarikan.Size = new System.Drawing.Size(160, 20);
            this.txt_penarikan.TabIndex = 3;
            // 
            // btn_simpan
            // 
            this.btn_simpan.ForeColor = System.Drawing.Color.Blue;
            this.btn_simpan.Location = new System.Drawing.Point(331, 133);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 4;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.MouseLeave += new System.EventHandler(this.btn_simpan_MouseLeave);
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            this.btn_simpan.MouseEnter += new System.EventHandler(this.btn_simpan_MouseEnter);
            // 
            // btn_batal
            // 
            this.btn_batal.ForeColor = System.Drawing.Color.Blue;
            this.btn_batal.Location = new System.Drawing.Point(412, 133);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(75, 23);
            this.btn_batal.TabIndex = 5;
            this.btn_batal.Text = "BATAL";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.MouseLeave += new System.EventHandler(this.btn_batal_MouseLeave);
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            this.btn_batal.MouseEnter += new System.EventHandler(this.btn_batal_MouseEnter);
            // 
            // penyetoran_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::BANKING_ACCOUNT.Properties.Resources.Books_2_icon1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 168);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.txt_penarikan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "penyetoran_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "penyetoran_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_penarikan;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_batal;
    }
}