using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using System;

namespace CafeOto.WinForm.Masalar
{
    public partial class frmMasaKaydet : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDAL masalardal = new MasalarDAL();
        private Entities.Models.Masalar _entity;
        public bool kaydet = false;
        public frmMasaKaydet(Entities.Models.Masalar entity)
        {

            InitializeComponent();
            _entity = entity;
            txtMasaAdi.DataBindings.Add("text", _entity, "MasaAdi");
            memoAciklama.DataBindings.Add("text", _entity, "Aciklama");

        }

        private void btnYeniKaydet_Click(object sender, EventArgs e)
        {
            if (_entity.Id == 0)
            {
                _entity.Durumu = false;
                _entity.RezerveMi = false;
                _entity.EklemeTarih = DateTime.Now;
                _entity.SonIslemTarih = DateTime.Now;
                _entity.Islem = "Yeni Masa Kayıt";
            }
            else if (_entity.Id != 0)
            {
                _entity.SonIslemTarih = DateTime.Now;
                _entity.Islem = "Masa Güncellendi. ";
            }

            if (masalardal.AddOrUpdate(context, _entity))
            {
                masalardal.save(context);
                kaydet = true;
                this.Close();

            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}