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
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CafeContext context = new CafeContext();
            if (!context.Kullanicilar.Any(k=>k.KullaniciAdi=="admin"))
            {
                Entities.Models.Kullanicilar model = new Entities.Models.Kullanicilar
                {
                    AdSoyad = "deneme ad soyad",
                    Telefon = "5388478775"

                };
                context.Kullanicilar.Add(model);
                context.SaveChanges();  
            }
            Application.Run(new frmAnaMenu());
        }
    }
}
