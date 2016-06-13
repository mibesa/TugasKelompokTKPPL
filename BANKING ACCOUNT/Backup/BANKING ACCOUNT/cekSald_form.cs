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
    public partial class cekSald_form : Form
    {
        public cekSald_form()
        {
            InitializeComponent();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cekSald_form_Load(object sender, EventArgs e)
        {
            txt_norek.Text = Program.Currentaccount.Account_number;
            txt_nama.Text = Program.Currentaccount.Account_nama;
            txt_setoranAwal.Text = Program.Currentaccount.Balance.ToString();
        }

        private void btn_simpan_MouseEnter(object sender, EventArgs e)
        {
            btn_simpan.ForeColor = Color.Green;
        }

        private void btn_simpan_MouseLeave(object sender, EventArgs e)
        {
            btn_simpan.ForeColor = Color.Blue ;
        }
    }
}
