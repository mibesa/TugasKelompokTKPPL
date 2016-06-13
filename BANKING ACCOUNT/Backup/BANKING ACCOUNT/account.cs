using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BANKING_ACCOUNT
{
    class account
    {
        //attribut
        #region attribut
        private string account_number;
        private string account_nama;   
        private int balance;
        #endregion


        #region prperty
        public string Account_number
        {
            get { return account_number; }
            set { account_number = value; }
        }
        
        public string Account_nama
        {
            get { return account_nama; }
            set { account_nama = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        #endregion

        //operation
        #region deposit
        public int deposit(int m_nominal) {
            return Balance + m_nominal;
        }
        #endregion

        #region withdraw
        public int withdraw(int m_nominal) {
            return Balance - m_nominal;
        }
        #endregion

        #region balance
        public int cekbalance() {
            return Balance;
        }
        #endregion

    }
}
