using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MumtaazHerbal
{


    static class Program
    {
        /// <summary>644f6
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var main = new frmMain();
            //main.Show();

            //var cn = new connection();
            //cn.ShowDialog();

            Application.Run(new frmMain());
            //Application.Run(new frmMain());
        }
    }
}
