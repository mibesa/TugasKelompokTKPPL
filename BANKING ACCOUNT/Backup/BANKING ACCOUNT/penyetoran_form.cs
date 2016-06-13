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
    public partial class penyetoran_form : Form
    {
        public penyetoran_form()
        {
            InitializeComponent();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            #region validasi
            int m_nominal = 0;
            if (!int.TryParse(txt_penarikan.Text.Trim(), out m_nominal))
            {
                MessageBox.Show("Inputan Harus Berupa Angka");
                txt_penarikan.ResetText();
                txt_penarikan.Focus();
                return;
            }

            #endregion

            #region proses
            account myaccount = Program.Currentaccount;
            myaccount.Balance = myaccount.deposit (m_nominal);
            Program.Currentaccount = myaccount ;
            this.Close();
            #endregion
        }

        private void btn_simpan_MouseEnter(object sender, EventArgs e)
        {
            btn_simpan.ForeColor = Color.Green ;
        }

        private void btn_simpan_MouseLeave(object sender, EventArgs e)
        {
            btn_simpan.ForeColor = Color.Blue ;
        }

        private void btn_batal_MouseEnter(object sender, EventArgs e)
        {
            btn_batal .ForeColor = Color.Red;
        }

        private void btn_batal_MouseLeave(object sender, EventArgs e)
        {
            btn_batal .ForeColor = Color.Blue ;
        }
    }
}
