using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suit
{
    public partial class Suit : Form
    {
        int nilai = 0, win = 0, lose = 0, draw = 0;
        public Suit()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (btnmulai.Enabled == false)
            {
                timer1.Stop();
                if (nilai == 1)
                {

                    lblsuit.Text = "DRAW";
                    draw++;
                }
                else if (nilai == 2)
                {

                    lblsuit.Text = "WIN";
                    win++;
                }
                else
                {
                    lblsuit.Text = "LOSE";
                    lose++;
                }
                btnmulai.Enabled = true;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (btnmulai.Enabled == false)
            {
                timer1.Stop();
                if (nilai == 1)
                {
                    lblsuit.Text = "LOSE";
                    lose++;
                }
                else if (nilai == 2)
                {
                    lblsuit.Text = "DRAW";
                    draw++;
                }
                else
                {
                    lblsuit.Text = "WIN";
                    win++;
                }
                btnmulai.Enabled = true;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (btnmulai.Enabled == false)
            {
                timer1.Stop();
                if (nilai == 1)
                {
                    lblsuit.Text = "WIN";
                    win++;
                }
                else if (nilai == 2)
                {
                    lblsuit.Text = "LOSE";
                    lose++;
                }
                else
                {
                    lblsuit.Text = "DRAW";
                    draw++;
                }
                btnmulai.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                lblsuit.Text = "";
                timer1.Start();
                btnmulai.Enabled = false;       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                if (nilai == 0) 
                    pictureutama.Image = Properties.Resources.tes;

                else if (nilai == 1) 
                    pictureutama.Image = Properties.Resources.gunting;
                else 
                    pictureutama.Image = Properties.Resources.kertas;
                    nilai++;
                if (nilai >= 3)
                    nilai = 0;

        }

        private void lblGunting_Click(object sender, EventArgs e)
        {

        }

        private void lblW_Click(object sender, EventArgs e)
        {
            this.lblW.Text = string.Concat(win, "2");
        }

        private void lblL_Click(object sender, EventArgs e)
        {
            this.lblL.Text = string.Concat(lose, "1");
        }

        private void Suit_Load(object sender, EventArgs e)
        {

        }

        private void lblD_Click(object sender, EventArgs e)
        {
            this.lblD.Text = string.Concat(draw, "3");
        }

    }
}


