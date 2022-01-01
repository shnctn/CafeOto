using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using CafeOto.WinForm.Odemeler;
using CafeOto.WinForm.Urunler;
using DevExpress.XtraEditors;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CafeOto.WinForm.Masalar
{
    public partial class frmMasaSiparisleri : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        MusterilerDAL musterilerDal = new MusterilerDAL();
        MasaHareketleriDAL masaHaraketleriDal = new MasaHareketleriDAL();
        OdemeHareketleriDAL odemeHareketleriDal=new OdemeHareketleriDAL();
        int? _masaId = null;
        string _satisKodu = null;
        Satislar satislar;
        SatislarDAL satislarDal=new SatislarDAL();
        public frmMasaSiparisleri(int? masaId = null, string masaAdi = null, string satisKodu = null)
        {
            InitializeComponent();
            _masaId = masaId;
            _satisKodu = satisKodu;
            context.MasaHareketleri.Where(m => m.SatisKodu == _satisKodu).Load();
            context.OdemeHareketleri.Where(o => o.SatisKodu == _satisKodu).Load();
            gridControlSiparisler.DataSource = context.MasaHareketleri.Local.ToBindingList();
            gridControlOdemeler.DataSource = context.OdemeHareketleri.Local.ToBindingList();
            context.Urun.Load();
            lookUpMusteri.Properties.DataSource = musterilerDal.GetAll(context);
            if (_masaId != null)
            {
                lblBaslik.Text = masaAdi + "Siparişleri";
            }
            satislar=satislarDal.GetByFilter(context,s=>s.SatisKodu==_satisKodu);
            if (satislar!=null)
            {
                lookUpMusteri.EditValue=satislar.MusteriId;
                txtAciklama.Text=satislar.Aciklama;
                dateEdit1.Text=satislar.SonIslemTarih.ToString("dd.MM.yyyy");
            }
        }

        void Hesapla()
        {
            calcİndirimToplami.Value = Convert.ToInt32(colIndirimTutari.SummaryItem.SummaryValue);
            calcIndirimliToplam.Value = Convert.ToInt32(colTutar.SummaryItem.SummaryValue);
            calcOdenen.Value = Convert.ToInt32(colOdenen.SummaryItem.SummaryValue);
            calcToplam.Value = calcİndirimToplami.Value + calcIndirimliToplam.Value;
            calcKalan.Value = calcIndirimliToplam.Value - calcOdenen.Value;

            ////////////////////////////////////////
            //// indirim oranı hesplama
            ///
            if (calcToplam.Value != 0)
            {
                calcIndirimOrani.Value = 100 * Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue) /
                    (Convert.ToDecimal(colTutar.SummaryItem.SummaryValue) +
                    Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue));

            }
            else if (calcToplam.Value != 0)
            {
                calcIndirimOrani.Value = 0;
            }



        }
        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            lookUpMusteri.EditValue = null;
        }

        private void repositorySipariSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili siparisin silinmesini onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                gridViewSiparis.DeleteSelectedRows();
                Hesapla();
            }
        }

        private void repositoryOdemeSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Ödemenin silinmesini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewOdeme.DeleteSelectedRows();
                Hesapla();
            }
        }



        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            frmUrunSec frm = new frmUrunSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                MasaHareketleri entity = new MasaHareketleri
                {
                    SatisKodu = _satisKodu,
                    MasaId = Convert.ToInt32(_masaId),
                    UrunId = frm.urunModel.Id,
                    Miktari = 1,
                    BirimFiyati = frm.urunModel.BirimFiyat,
                    IndirimTutari = 0,
                    Aciklama = " ",
                    SonIslemTarih = DateTime.Now


                };
                if (masaHaraketleriDal.AddOrUpdate(context, entity))
                {

                }
            }
        }

       
        private void gridViewSiparis_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (satislar==null)
            {
                satislar=new Satislar();
                satislar.SatisKodu=_satisKodu;
            }
            satislar.MusteriId=(int?)lookUpMusteri.EditValue;
            satislar.Aciklama=txtAciklama.Text;
            satislar.SonIslemTarih=Convert.ToDateTime(dateEdit1.EditValue);
            satislar.Kalan=calcKalan.Value;
            satislar.Odenen=calcOdenen.Value;
            satislar.Tutar=calcToplam.Value;
            satislar.indirimToplami=calcİndirimToplami.Value;
            satislarDal.AddOrUpdate(context,satislar);
            context.SaveChanges();
        }

       

        private void Odemeler_Click(object sender, EventArgs e)
        {
            var btn=sender as SimpleButton;
            frmOdeme frm = new frmOdeme(btn.Text, _satisKodu);
            frm.ShowDialog();
            if (frm.Kaydedildi)
            {
                if (odemeHareketleriDal.AddOrUpdate(context,frm.odemeHareketleri))
                {
                    gridViewOdeme.RefreshData();
                    Hesapla();
                }
            }
        }

        private void gridViewOdeme_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Hesapla();
        }
    }
}