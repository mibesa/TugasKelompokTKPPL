using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BANKING_ACCOUNT
{
    static class Program
    {
        private static account m_currentaccount;

        internal static account Currentaccount
        {
            get { return Program.m_currentaccount; }
            set { Program.m_currentaccount = value; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main_form());
        }
    }
}
