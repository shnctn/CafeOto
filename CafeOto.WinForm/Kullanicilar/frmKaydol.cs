using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using CafeOto.WinForm.AnaMenu;
using DevExpress.XtraBars;

namespace CafeOto.WinForm.Kullanicilar
{
    public partial class frmKaydol : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private KulanicilarDAL kulanicilarDal = new KulanicilarDAL();
        KullaniciHareketleriDAL KullaniciHareketleriDAL = new KullaniciHareketleriDAL();
        KullaniciHareketleri KullaniciHareketleri = new KullaniciHareketleri();
        private Entities.Models.Kullanicilar _entity;


        public frmKaydol(Entities.Models.Kullanicilar entity)
        {
            InitializeComponent();
            _entity = entity;
            togAktifmi.DataBindings.Add("EditValue", _entity, "AktifMi");
            txtAdSoyad.DataBindings.Add("text", _entity, "Adsoyad");
            txtTelefon.DataBindings.Add("text", _entity, "Telefon");
            txtAdres.DataBindings.Add("text", _entity, "Adres");
            txtEmail.DataBindings.Add("text", _entity, "Email");
            txtgörev.DataBindings.Add("text", _entity, "Gorevi");
            txtKullaniciAdi.DataBindings.Add("text", _entity, "KullaniciAdi");
            txtSifre.DataBindings.Add("text", _entity, "Parola");
            //txtSifreTekrar.DataBindings.Add("text", _entity, "ParolaTekrar");
            txtHatırlatmaSoru.DataBindings.Add("text", _entity, "HatirlatmaSorusu");
            txtCevap.DataBindings.Add("text", _entity, "Cevap");
            txtAciklama.DataBindings.Add("text", _entity, "Aciklama");

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                _entity.KayitTarihi = DateTime.Now;
                if (kulanicilarDal.AddOrUpdate(context, _entity))
                {
                    kulanicilarDal.save(context);
                    var model = context.Kullanicilar.Max(k => k.Id);
                    KullaniciHareketleri.KullaniciId = model;
                    string aciklama = "Yeni kullanıcı Oluşturuldu.";
                    KullaniciHareketleriDAL.kullaniciHareketleriEkle(context, KullaniciHareketleri, aciklama);
                    frmAnaMenu frm = new frmAnaMenu();
                    foreach (var item in frm.ribbon.Items)
                        if (item is BarButtonItem)
                        {
                            var btn = item as BarButtonItem;
                            if (btn.Caption != "")
                            {
                                Roller roll = new Roller
                                {
                                    KullaniciId = context.Kullanicilar.Max(k=>k.Id),
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
                MessageBox.Show("Şifreler aynı değildir. ");
            }
           
        }

        private void frmKaydol_Load(object sender, EventArgs e)
        {

        }
    }
}