using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using CafeOto.WinForm.WinTools;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CafeOto.WinForm.Kullanicilar
{
    public partial class frmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        private bool giris;
        private CafeContext context = new CafeContext();
        KullaniciHareketleriDAL KullaniciHareketleriDAL = new KullaniciHareketleriDAL();
        KullaniciHareketleri entity = new KullaniciHareketleri();
        public frmKullaniciGiris()
        {
            InitializeComponent();
            BilgileriGetir();
        }

        void BilgileriGetir()
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                txtParola.Text = Properties.Settings.Default.Parola;
                chkBeniHatirla.Checked = true;
            }
            else
            {
                txtKullaniciAdi.Text = null;
                txtParola.Text = null;
                chkBeniHatirla.Checked = false;
            }
        }

        void BilgileriKaydet()
        {
            if (chkBeniHatirla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text;
                Properties.Settings.Default.Parola = txtParola.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Parola = null;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();

            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void frmKullaniciGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var model = context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Parola == txtParola.Text);
            if (model != null)
            {
                giris = true;
                BilgileriKaydet();
                KullaniciAyarlari.KullaniciId=model.Id;
                //entity.KullaniciId=model.Id;
                //string Aciklama=model.KullaniciAdi+" adlı kullanıcı sisteme giriş yaptı.  ";
                //KullaniciHareketleriDAL.kullaniciHareketleriEkle(context,entity,Aciklama);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifreniz Hatalıdır.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void hypkaydol_Click(object sender, EventArgs e)
        {
            frmKaydol frm = new frmKaydol(new Entities.Models.Kullanicilar());
            frm.ShowDialog();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            frmSifremiUnuttum frm = new frmSifremiUnuttum();
            frm.ShowDialog();
        }
    }
}