using System;
using System.Linq;
using System.Windows.Forms;
using CafeOto.Entities.Models;
using CafeOto.WinForm.Kullanicilar;
using CafeOto.WinForm.Masalar;
using CafeOto.WinForm.Menuler;
using CafeOto.WinForm.Musteriler;
using CafeOto.WinForm.Odemeler;
using CafeOto.WinForm.RaporDosyalari;
using CafeOto.WinForm.RaporFormlari;
using CafeOto.WinForm.Roles;
using CafeOto.WinForm.Satıslar;
using CafeOto.WinForm.Urunler;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace CafeOto.WinForm.AnaMenu
{
    public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CafeContext context = new CafeContext();
        void FormGetir(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }
        public frmAnaMenu()
        {
            InitializeComponent();

            if (!context.Kullanicilar.Any(k => k.KullaniciAdi == "admin"))
            {

                Entities.Models.Kullanicilar kullanici = new Entities.Models.Kullanicilar
                {
                    AdSoyad = "deneme ad soyad",
                    Telefon = "55555",
                    Adres = "123sdvdf asef",
                    Email = "deneme@mail.com",
                    KullaniciAdi = "admin",
                    Parola = "12345",
                    HatirlatmaSorusu = "1",
                    Cevap = "1",
                    KayitTarihi = DateTime.Now,
                    isAdmin = true
                };
                context.Kullanicilar.Add(kullanici);
                context.SaveChanges();
                foreach (var item in ribbon.Items)
                {
                    if (item is BarButtonItem)
                    {
                        var btn = item as BarButtonItem;
                        if (btn.Caption!="")
                        {
                            Roller roll = new Roller
                            {
                                KullaniciId = 1,
                                FormName = "frmAnaMenu",
                                ControlCaption = btn.Caption,
                                ControlName = btn.Name,
                                Visible = true

                            };
                            context.Roller.Add(roll);
                            context.SaveChanges();
                        }
                    }
                }

            }

            XtraForm frm = new frmKullaniciGiris();
            frm.ShowDialog();
            KullaniciYetki.YetkileriGetir(context,ribbon);
        }

        private void btnUrunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frnUrunler();
            FormGetir(frm);
        }

        private void btnMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMenuler();
            frm.ShowDialog();

        }

        private void btnMasalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMasalar();
            FormGetir(frm);
        }

        private void btnMasaSiparis_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new FormMasaDurumlari();
            FormGetir(frm);
        }

        private void btnMusteriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMusteriler();
            FormGetir(frm);
        }

        private void btnSatislar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmSatislar();
            FormGetir(frm);
        }

        private void btnOdemeHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmOdemeHareketleri();
            FormGetir(frm);

        }

        private void btnMasaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMasaHaraketleri frm = new frmMasaHaraketleri();
            frm.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Paket sipariş işlemini onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                var model = context.SatisKodu.First();
                string satisKodu = model.Tanim + model.Sayi;
                model.Sayi++;
                context.SaveChanges();
                XtraForm frm = new frmMasaSiparisleri(satisKodu: satisKodu,paketSiparis:true);
                FormGetir(frm); 
            }
        }

        private void btnMasaHareketleriRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            rptMasaHareketleri rpt = new rptMasaHareketleri();
            frmMasaHareketleriRaporGor frm = new frmMasaHareketleriRaporGor(rpt);
            frm.ShowDialog();
        }

     

        private void btnOzelRapor_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmOzelRaporOlustur frm = new frmOzelRaporOlustur();
            frm.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmDashport();
            FormGetir(frm);
        }

        private void btnMenuHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}