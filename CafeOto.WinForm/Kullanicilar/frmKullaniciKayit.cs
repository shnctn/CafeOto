using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using CafeOto.WinForm.AnaMenu;
using CafeOto.WinForm.WinTools;
using DevExpress.XtraBars;

namespace CafeOto.WinForm.Kullanicilar
{
    public partial class frmKullaniciKayit : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext(); 
        private KulanicilarDAL kullanicilarDal = new KulanicilarDAL();
        private Entities.Models.Kullanicilar _kullanicilar;
        
        private KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();
        private KullaniciHareketleriDAL kullaniciHareketleriDal = new KullaniciHareketleriDAL();
        private string _girisyapankullanici;
        public frmKullaniciKayit(Entities.Models.Kullanicilar kullanicilar,string girisyapankullanici=null)
        {

            InitializeComponent();
            _girisyapankullanici = girisyapankullanici;
            _kullanicilar = kullanicilar;
            togAktifmi.DataBindings.Add("EditValue", _kullanicilar, "AktifMi" );
            txtAdSoyad.DataBindings.Add("text", _kullanicilar, "Adsoyad");
            txtTelefon.DataBindings.Add("text", _kullanicilar, "Telefon");
            txtAdres.DataBindings.Add("text", _kullanicilar, "Adres");
            txtEmail.DataBindings.Add("text", _kullanicilar, "Email");
            txtgörev.DataBindings.Add("text", _kullanicilar, "Gorevi");
            txtKullaniciAdi.DataBindings.Add("text", _kullanicilar, "KullaniciAdi");
            txtSifre.DataBindings.Add("text", _kullanicilar, "Parola");
            txtHatırlatmaSoru.DataBindings.Add("text", _kullanicilar, "HatirlatmaSorusu");
            txtCevap.DataBindings.Add("text", _kullanicilar, "Cevap");
            txtAciklama.DataBindings.Add("text", _kullanicilar, "Aciklama");
            if (_kullanicilar.Id==0)
            {
                lblbas.Text = "Yeni kullanıcı ekleme Sayfası";
            }
            else if (_kullanicilar.Id !=0)
            {
                lblbas.Text = _kullanicilar.KullaniciAdi + "bilgileri sayfası";

            }    

        }

        private void btnKullaniciKayit_Click(object sender, EventArgs e)
        {
            if (lblbas.Text == "Yeni kullanıcı ekleme Sayfası")
            {
                _kullanicilar.KayitTarihi = DateTime.Now;
                if (kullanicilarDal.AddOrUpdate(context, _kullanicilar))
                {
                    kullanicilarDal.save(context);
                    var model = context.Kullanicilar.Max(k => k.Id);
                    kullaniciHareketleri.KullaniciId = model;
                    string aciklama = "Yönetici tarafından yeni kullanıcı luşturuldu.";
                    kullaniciHareketleriDal.kullaniciHareketleriEkle(context, kullaniciHareketleri, aciklama);
                    frmAnaMenu frm = new frmAnaMenu();
                    foreach (var item in frm.ribbon.Items)
                        if (item is BarButtonItem)
                        {
                            var btn = item as BarButtonItem;
                            if (btn.Caption != "")
                            {
                                Roller roll = new Roller
                                {
                                    KullaniciId = context.Kullanicilar.Max(k => k.Id),
                                    FormName = "frmAnaMenu",
                                    ControlCaption = btn.Caption,
                                    ControlName = btn.Name,
                                    Visible = false

                                };
                                context.Roller.Add(roll);
                                context.SaveChanges();
                            }
                        }

                    this.Close();

                }

            }
            else
            {
                if (kullanicilarDal.AddOrUpdate(context, _kullanicilar))
                {
                    kullanicilarDal.save(context);
                    var id = _kullanicilar.Id;
                    kullaniciHareketleri.KullaniciId = id;
                    string aciklama;
                    if (_girisyapankullanici!=null)
                    {
                        
                        aciklama = _kullanicilar.KullaniciAdi + "bilgilerini geğiştirdi";
                    }
                    else
                    {
                        aciklama = "Yönetici tarafından " + _kullanicilar.AdSoyad + "'nın bilgileri güncellendi.";
                    }
                    
                    kullaniciHareketleriDal.kullaniciHareketleriEkle(context, kullaniciHareketleri, aciklama);
                    this.Close();
                }
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}