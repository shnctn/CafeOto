using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace CafeOto.WinForm.Urunler
{
    public partial class frmUrunKaydet : DevExpress.XtraEditors.XtraForm
    {
        private MenuDAL menudal = new MenuDAL();
        private CafeContext context = new CafeContext();
        private UrunDAL urunDal = new UrunDAL();
        private Urun _entity;
        public bool kaydet = false;

        public frmUrunKaydet(Urun entity)
        {
            InitializeComponent();
            _entity = entity;
            LookUpMenu.Properties.DataSource = menudal.GetAll(context);
            LookUpMenu.DataBindings.Add("EditValue", _entity, "MenuId");
            txtUrunKodu.DataBindings.Add("text", _entity, "UrunKodu");
            txtUrunAdi.DataBindings.Add("text", _entity, "UrunAdi");
            calcBirimFiyat1.DataBindings.Add("text", _entity, "BirimFiyat", true);
            calcBirimfiyat2.DataBindings.Add("text", _entity, "BirimFiyat2", true);
            calcBirimFiyat3.DataBindings.Add("text", _entity, "BirimFiyat3", true);
            memoAciklama.DataBindings.Add("text", _entity, "Aciklama");
            dateTarih.DataBindings.Add("text", _entity, "Tarih", true);
            if (_entity.Id != 0)
            {
                if (_entity.Resim != "")
                {
                    pictureEdit1.EditValue = _entity.Resim;
                }
            }

        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.GetLoadedImageLocation() != "")
            {
                string hedefyol = $"{Application.StartupPath}\\Image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
                File.Copy(pictureEdit1.GetLoadedImageLocation(), hedefyol);
                _entity.Resim = $"Image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
            }

            if (urunDal.AddOrUpdate(context, _entity))
            {
                urunDal.save(context);
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