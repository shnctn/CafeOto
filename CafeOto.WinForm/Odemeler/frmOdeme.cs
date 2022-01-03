using CafeOto.Entities.Models;
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

namespace CafeOto.WinForm.Odemeler
{
    public partial class frmOdeme : DevExpress.XtraEditors.XtraForm
    {
         string _satisKodu;
         string _odemeTuru;
         public OdemeHareketleri odemeHareketleri;
        public bool Kaydedildi;
        public decimal _kalan;
        public frmOdeme(string odemeTuru,string satisKodu,decimal kalan)
        {

            InitializeComponent();
            _odemeTuru=odemeTuru;
            _satisKodu=satisKodu;
            _kalan = kalan;
            if (_odemeTuru=="Nakit")
            {
                lblBaslik.Text="Nakit ödeme";
            }
            else if (_odemeTuru == "Kredi Kartı")
            {
                lblBaslik.Text = "Kredi Kartı ile Ödeme";
            }

        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            odemeHareketleri=new OdemeHareketleri
            {
                SatisKodu=_satisKodu,
                OdemeTuru=_odemeTuru,
                Odenen=calcOdenecek.Value,
                Aciklama=txtAciklama.Text,
                Tarih=Convert.ToDateTime(dateEdit1.Text)
            };
            Kaydedildi=true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btn_Click(object sender, EventArgs e)
        {
            calcOdenecek.Value = _kalan;
        }
    }
}