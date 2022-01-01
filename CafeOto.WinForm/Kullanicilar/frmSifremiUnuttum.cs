using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using System;
using System.Windows.Forms;

namespace CafeOto.WinForm.Kullanicilar
{
    public partial class frmSifremiUnuttum : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        KulanicilarDAL kulanicilardal = new KulanicilarDAL();
        KullaniciHareketleriDAL KullaniciHareketleriDAL = new KullaniciHareketleriDAL();
        KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();

        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var entity = kulanicilardal.GetByFilter(context, k => k.KullaniciAdi == txtKullaniciAdi.Text || k.Email == txtKullaniciAdi.Text);
            if (entity != null)
            {
                if (entity.HatirlatmaSorusu == txtHatırlatmaSoru.Text && entity.Cevap == txtCevap.Text)
                {
                    if (txtSifre.Text == txtSifreTekrar.Text)
                    {
                        entity.Parola = txtSifre.Text;
                        kulanicilardal.save(context);
                        kullaniciHareketleri.KullaniciId = entity.Id;
                        string Aciklama = entity.KullaniciAdi + " adlı kullanıcı parolası yenilendi.  ";
                        KullaniciHareketleriDAL.kullaniciHareketleriEkle(context, kullaniciHareketleri, Aciklama);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Parolalar uyuşmuyor.");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen soru ve cevap yanlış");
                }
            }
            else
            {
                MessageBox.Show("Boyle bir kullanıcı bulunamadı.");
            }
        }
    }
}