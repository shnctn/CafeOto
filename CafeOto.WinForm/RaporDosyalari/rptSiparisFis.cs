using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using DevExpress.DataAccess.ObjectBinding;

namespace CafeOto.WinForm.RaporDosyalari
{
    public partial class rptSiparisFis : DevExpress.XtraReports.UI.XtraReport
    {
        private CafeContext context = new CafeContext();
        private MasaHareketleriDAL masaHareketleriDal = new MasaHareketleriDAL();
        ObjectDataSource source = new ObjectDataSource();

        public rptSiparisFis()
        {
            
        }
        public rptSiparisFis(string satisKodu, string bilgi, Satislar satislar = null)
        {
            InitializeComponent();

            xrLabelBilgi.Text = bilgi;
            source.DataSource = masaHareketleriDal.GetAll(context, m => m.SatisKodu == satisKodu);
            this.DataSource = source;
            xrTableUrunAdi.DataBindings.Add("Text", DataSource, "Urun.UrunAdi");
            xrTableMiktar.DataBindings.Add("Text", DataSource, "Miktari");
            xrTableİndirim.DataBindings.Add("Text", DataSource, "indirimTutari");
            xrTableFiyati.DataBindings.Add("Text", DataSource, "BirimFiyati");
            xrLabelKalan1.Text = satislar.Kalan.ToString("C2");
            xrLabelOdenen1.Text = satislar.Odenen.ToString("C2");
        }

    }
}
