using CafeOto.WinForm.AnaMenu;
using System;
using System.Windows.Forms;

namespace CafeOto.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAnaMenu());
        }
    }
}
