using CafeOto.WinForm.AnaMenu;
using System;
using System.Linq;
using System.Windows.Forms;
using CafeOto.Entities.Models;

namespace CafeOto.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAnaMenu());
        }
    }
}
