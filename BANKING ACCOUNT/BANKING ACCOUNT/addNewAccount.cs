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
    public partial class addNewAccount : Form
    {
        public addNewAccount()
        {
            InitializeComponent();
        }

        private void btn_ulang_Click(object sender, EventArgs e)
        {
            txt_norek.ResetText();
            txt_nama.ResetText();
            txt_setoranAwal.ResetText();
            txt_norek.Focus();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            #region validasi
            if (txt_norek.Text == "") {
                MessageBox.Show("No Rekening Harus di Isi");
                txt_norek.Focus();
                return;
            }
            if(txt_nama .Text ==""){
                MessageBox.Show("Nama Harus di Isi");
                txt_nama.Focus();
                return;
            }
            if(txt_setoranAwal .Text ==""){
                MessageBox.Show("Nominal Setoran Harus di Isi");
                txt_setoranAwal .Focus();
                return;
            }

            int m_nominal=0;
            if(!int .TryParse (txt_setoranAwal .Text .Trim (),out m_nominal  )){
                MessageBox.Show("Inputan Harus Berupa Angka");
                txt_setoranAwal.ResetText();
                txt_setoranAwal.Focus();
                return;
            }
            #endregion

            #region proses
            account myaccount = new account();
            myaccount.Account_number = txt_norek.Text.Trim();
            myaccount.Account_nama = txt_nama.Text.Trim();
            myaccount.Balance = m_nominal;
            Program.Currentaccount = myaccount;
            this.Close();
            #endregion

           
        }

        private void btn_simpan_MouseEnter(object sender, EventArgs e)
        {
            btn_simpan.ForeColor = Color.Green;
        }

        private void btn_simpan_MouseLeave(object sender, EventArgs e)
        {
            btn_simpan.ForeColor = Color.Blue;
        }

        private void btn_ulang_MouseEnter(object sender, EventArgs e)
        {
            btn_ulang .ForeColor = Color.Yellow ;
        }

        private void btn_ulang_MouseLeave(object sender, EventArgs e)
        {
            btn_ulang .ForeColor = Color.Blue ;
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
