using CafeOto.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CafeOto.WinForm.Masalar
{
    public partial class FormMasaDurumlari : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        CheckButton btnsender;
        SatisKodu modelSatisKodu;
        string _satisKodu;
        int _masaId;
        Entities.Models.Masalar masalar;
        Entities.DAL.MasalarDAL masalarDal = new Entities.DAL.MasalarDAL();

        public FormMasaDurumlari()
        {
            InitializeComponent();
            modelSatisKodu = context.SatisKodu.First();
            masalariGetir();


        }
        public void DurumYenile()
        {
            btnSiparisEkle.Enabled = false;
            btnMasaAc.Enabled = false;
            btnRezerve.Enabled = false;
        }
        public void masalariGetir()
        {
            flowLayoutPanel1.Controls.Clear();
            context = new CafeContext();
            var model = context.Masalar.ToList();
            for (int i = 0; i < model.Count; i++)
            {
                var btn = new CheckButton();
                btn.Text = model[i].MasaAdi;
                btn.Name = model[i].Id.ToString();
                btn.Tag = model[i].SatisKodu;
                btn.Height = 100;
                btn.Width = 80;
                flowLayoutPanel1.Controls.Add(btn);
                if (!model[i].RezerveMi && !model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.Green;
                }
                else if (model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.Red;
                }
                else if (!model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.Yellow;
                }
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            btnsender = sender as CheckButton;
            _masaId = Convert.ToInt32(btnsender.Name);

            DurumYenile();
            if (btnsender.Appearance.BackColor == Color.Yellow)
            {
                btnMasaAc.Enabled = true;
            }
            else if (btnsender.Appearance.BackColor == Color.Green)
            {
                btnMasaAc.Enabled = true;
                btnRezerve.Enabled = true;
            }
            else if (btnsender.Appearance.BackColor == Color.Red)
            {
                btnSiparisEkle.Enabled = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            _satisKodu = btnsender.Tag.ToString();
            frmMasaSiparisleri frm = new frmMasaSiparisleri(masaId: _masaId, masaAdi: btnsender.Text, satisKodu: _satisKodu);
            frm.ShowDialog();
            btnsender = null;
            DurumYenile();
            masalariGetir();
        }

        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(btnsender.Text + " Açılsın Mı? ", " CAFE OTOMASYONU ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
                masalar.SatisKodu = modelSatisKodu.Tanim + modelSatisKodu.Sayi;
                masalar.Durumu = true;
                masalar.RezerveMi = false;
                var sayiarttir = context.SatisKodu.First();
                sayiarttir.Sayi++;

                masalarDal.save(context);
                btnsender = null; 
                DurumYenile();
                masalariGetir();
                modelSatisKodu = context.SatisKodu.First();
            }

        }

        private void btnRezerve_Click(object sender, EventArgs e)
        {
            frmMasaRezerv frm = new frmMasaRezerv(_masaId);
            frm.ShowDialog();
            if (frm.islemyapildi)
            {
                DurumYenile();
                masalariGetir();

            }
            btnsender = null;
        }
    }
}