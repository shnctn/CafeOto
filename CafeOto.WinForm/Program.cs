using CafeOto.WinForm.AnaMenu;
using System;
using System.Linq;
using System.Windows.Forms;
using CafeOto.Entities.Models;
using CafeOto.Entities.Tools;

namespace CafeOto.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            ConnectionTools.baglantiControl();// otomatik  veri tabanı  oluşturma işlemi
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAnaMenu());
        }
    }
}
