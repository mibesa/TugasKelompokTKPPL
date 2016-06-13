using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BANKING_ACCOUNT
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

       

        private void btn_penarikan_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_penyetoran_Click(object sender, EventArgs e)
        {
            
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            pictureBox2 .Enabled = false;
            pictureBox3 .Enabled = false;
            pictureBox4 .Enabled = false;
        }

        //private void btn_daftar_MouseEnter(object sender, EventArgs e)
        //{
        //    btn_daftar.BackColor = Color.Blue;
        //}

        //private void btn_daftar_MouseLeave(object sender, EventArgs e)
        //{
        //    btn_daftar.BackColor = Color.Transparent;
        //}

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Lime ;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addNewAccount ad = new addNewAccount();
            ad.ShowDialog();
            pictureBox2 .Enabled = true;
           pictureBox3 .Enabled = true;
            pictureBox4 .Enabled = true;
            pictureBox1.Enabled = false ;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            penarikan_form tr = new penarikan_form();
            tr.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            penyetoran_form set = new penyetoran_form();
            set.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cekSald_form cek = new cekSald_form();
            cek.ShowDialog();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Lime;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent ;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Lime;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Lime;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }
    }
}
