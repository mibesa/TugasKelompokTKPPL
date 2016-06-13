namespace Suit
{
    partial class Suit
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
            this.components = new System.ComponentModel.Container();
            this.lblsuit = new System.Windows.Forms.Label();
            this.btnmulai = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picturekertas = new System.Windows.Forms.PictureBox();
            this.picturegunting = new System.Windows.Forms.PictureBox();
            this.picturebatu = new System.Windows.Forms.PictureBox();
            this.pictureutama = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBatu = new System.Windows.Forms.Label();
            this.lblGunting = new System.Windows.Forms.Label();
            this.lblKertas = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblwin = new System.Windows.Forms.Label();
            this.lbllose = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturekertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturegunting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebatu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureutama)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsuit
            // 
            this.lblsuit.AutoSize = true;
            this.lblsuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuit.Location = new System.Drawing.Point(243, 162);
            this.lblsuit.Name = "lblsuit";
            this.lblsuit.Size = new System.Drawing.Size(109, 42);
            this.lblsuit.TabIndex = 4;
            this.lblsuit.Text = "Draw";
            // 
            // btnmulai
            // 
            this.btnmulai.Location = new System.Drawing.Point(201, 229);
            this.btnmulai.Name = "btnmulai";
            this.btnmulai.Size = new System.Drawing.Size(75, 23);
            this.btnmulai.TabIndex = 5;
            this.btnmulai.Text = "Mulai";
            this.btnmulai.UseVisualStyleBackColor = true;
            this.btnmulai.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picturekertas
            // 
            this.picturekertas.Image = global::Suit.Properties.Resources.kertas1;
            this.picturekertas.Location = new System.Drawing.Point(384, 65);
            this.picturekertas.Name = "picturekertas";
            this.picturekertas.Size = new System.Drawing.Size(61, 63);
            this.picturekertas.TabIndex = 3;
            this.picturekertas.TabStop = false;
            this.picturekertas.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // picturegunting
            // 
            this.picturegunting.Image = global::Suit.Properties.Resources.gunting;
            this.picturegunting.Location = new System.Drawing.Point(319, 65);
            this.picturegunting.Name = "picturegunting";
            this.picturegunting.Size = new System.Drawing.Size(59, 63);
            this.picturegunting.TabIndex = 2;
            this.picturegunting.TabStop = false;
            this.picturegunting.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picturebatu
            // 
            this.picturebatu.Image = global::Suit.Properties.Resources.Batu;
            this.picturebatu.Location = new System.Drawing.Point(250, 65);
            this.picturebatu.Name = "picturebatu";
            this.picturebatu.Size = new System.Drawing.Size(62, 63);
            this.picturebatu.TabIndex = 1;
            this.picturebatu.TabStop = false;
            this.picturebatu.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureutama
            // 
            this.pictureutama.Image = global::Suit.Properties.Resources.Batu1;
            this.pictureutama.Location = new System.Drawing.Point(77, 65);
            this.pictureutama.Name = "pictureutama";
            this.pictureutama.Size = new System.Drawing.Size(75, 75);
            this.pictureutama.TabIndex = 0;
            this.pictureutama.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "VS";
            // 
            // lblBatu
            // 
            this.lblBatu.AutoSize = true;
            this.lblBatu.Location = new System.Drawing.Point(262, 39);
            this.lblBatu.Name = "lblBatu";
            this.lblBatu.Size = new System.Drawing.Size(29, 13);
            this.lblBatu.TabIndex = 7;
            this.lblBatu.Text = "Batu";
            // 
            // lblGunting
            // 
            this.lblGunting.AutoSize = true;
            this.lblGunting.Location = new System.Drawing.Point(330, 39);
            this.lblGunting.Name = "lblGunting";
            this.lblGunting.Size = new System.Drawing.Size(44, 13);
            this.lblGunting.TabIndex = 8;
            this.lblGunting.Text = "Gunting";
            this.lblGunting.Click += new System.EventHandler(this.lblGunting_Click);
            // 
            // lblKertas
            // 
            this.lblKertas.AutoSize = true;
            this.lblKertas.Location = new System.Drawing.Point(398, 39);
            this.lblKertas.Name = "lblKertas";
            this.lblKertas.Size = new System.Drawing.Size(37, 13);
            this.lblKertas.TabIndex = 9;
            this.lblKertas.Text = "Kertas";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(448, 162);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score :";
            // 
            // lblwin
            // 
            this.lblwin.AutoSize = true;
            this.lblwin.Location = new System.Drawing.Point(448, 186);
            this.lblwin.Name = "lblwin";
            this.lblwin.Size = new System.Drawing.Size(26, 13);
            this.lblwin.TabIndex = 11;
            this.lblwin.Text = "Win";
            // 
            // lbllose
            // 
            this.lbllose.AutoSize = true;
            this.lbllose.Location = new System.Drawing.Point(448, 206);
            this.lbllose.Name = "lbllose";
            this.lbllose.Size = new System.Drawing.Size(30, 13);
            this.lbllose.TabIndex = 12;
            this.lbllose.Text = "Lose";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Location = new System.Drawing.Point(448, 229);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(32, 13);
            this.lblDraw.TabIndex = 13;
            this.lblDraw.Text = "Draw";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(499, 186);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(13, 13);
            this.lblW.TabIndex = 14;
            this.lblW.Text = "0";
            this.lblW.Click += new System.EventHandler(this.lblW_Click);
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(499, 206);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(13, 13);
            this.lblL.TabIndex = 15;
            this.lblL.Text = "0";
            this.lblL.Click += new System.EventHandler(this.lblL_Click);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(499, 229);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(13, 13);
            this.lblD.TabIndex = 16;
            this.lblD.Text = "0";
            this.lblD.Click += new System.EventHandler(this.lblD_Click);
            // 
            // Suit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 315);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lbllose);
            this.Controls.Add(this.lblwin);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblKertas);
            this.Controls.Add(this.lblGunting);
            this.Controls.Add(this.lblBatu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmulai);
            this.Controls.Add(this.lblsuit);
            this.Controls.Add(this.picturekertas);
            this.Controls.Add(this.picturegunting);
            this.Controls.Add(this.picturebatu);
            this.Controls.Add(this.pictureutama);
            this.Name = "Suit";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Suit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturekertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturegunting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebatu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureutama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureutama;
        private System.Windows.Forms.PictureBox picturebatu;
        private System.Windows.Forms.PictureBox picturegunting;
        private System.Windows.Forms.PictureBox picturekertas;
        private System.Windows.Forms.Label lblsuit;
        private System.Windows.Forms.Button btnmulai;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBatu;
        private System.Windows.Forms.Label lblGunting;
        private System.Windows.Forms.Label lblKertas;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblwin;
        private System.Windows.Forms.Label lbllose;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblD;
    }
}

