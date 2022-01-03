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
    public partial class rptMasaHareketleri : DevExpress.XtraReports.UI.XtraReport
    {
        private CafeContext context = new CafeContext();
        private MasaHareketleriDAL masaHareketleriDal = new MasaHareketleriDAL();
        public rptMasaHareketleri()
        {
            InitializeComponent();
            ObjectDataSource source = new ObjectDataSource();
            source.DataSource = masaHareketleriDal.GetAll(context);
            DataSource = source;
            xrTableId.DataBindings.Add("Text", DataSource, "Id");
            xrTableSatısKodu.DataBindings.Add("Text", DataSource, "SatisKodu");
            xrTableMasaAdi.DataBindings.Add("Text", DataSource, "Masalar.MasaAdi");
            xrTableMenu.DataBindings.Add("Text", DataSource, "Urun.Menu.Adi"); 
            xrTableUrunadi.DataBindings.Add("Text", DataSource, "Urun.UrunAdi");
            xrTableMiktari.DataBindings.Add("Text", DataSource, "Miktari");
            xrTableFiyati.DataBindings.Add("Text", DataSource, "BirimFiyati");
            xrTableIndTutar.DataBindings.Add("Text", DataSource, "indirimTutari");
            xrTableAciklama.DataBindings.Add("Text", DataSource, "Aciklama");
            xrTableTarih.DataBindings.Add("Text", DataSource, "SonIslemTarih");
        }

    }
}
