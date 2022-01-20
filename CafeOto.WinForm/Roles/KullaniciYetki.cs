using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOto.Entities.Models;
using CafeOto.WinForm.WinTools;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace CafeOto.WinForm.Roles
{
    public class KullaniciYetki
    {
        public static void YetkileriGetir(CafeContext context, RibbonControl ribbon)
        {
            foreach (var item in ribbon.Items)
            {
                foreach (var roller in context.Roller.Where(r=>r.KullaniciId==KullaniciAyarlari.KullaniciId).ToList())
                {
                    if (item is BarButtonItem)
                    {
                        var btn = item as BarButtonItem;
                        if (btn.Name==roller.ControlName&&roller.Visible)
                        {
                            btn.Enabled = true;
                        }
                        if (btn.Name == roller.ControlName && !roller.Visible)
                        {
                            btn.Enabled = false;
                        }
                    }
                }

            }
        }

        public static void AdminMi(CafeContext context, dynamic obj)
        {
            var adminControl = context.Kullanicilar.FirstOrDefault(k => k.Id == KullaniciAyarlari.KullaniciId);
            if (adminControl.isAdmin)
            {
                obj.Enabled = true;
            }
            else if (!adminControl.isAdmin)
            {
                obj.Enabled = false;
            }
        }
    }
}
