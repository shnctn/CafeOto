using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using CafeOto.WinForm.Odemeler;
using CafeOto.WinForm.Urunler;
using DevExpress.XtraEditors;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CafeOto.WinForm.RaporDosyalari;
using CafeOto.WinForm.RaporFormlari;

namespace CafeOto.WinForm.Masalar
{
    public partial class frmMasaSiparisleri : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        MusterilerDAL musterilerDal = new MusterilerDAL();
        MasaHareketleriDAL masaHaraketleriDal = new MasaHareketleriDAL();
        OdemeHareketleriDAL odemeHareketleriDal = new OdemeHareketleriDAL();
        int? _masaId = null;
        string _satisKodu = null;
        Satislar satislar;
        SatislarDAL satislarDal = new SatislarDAL();
        private Entities.Models.Masalar masalar;
        private MasalarDAL masalarDal = new MasalarDAL();
        private UrunDAL urunDal = new UrunDAL();
        private bool _paketSiparis;
        private bool yazdir;
        frmUrunSec frm = new frmUrunSec();



        public frmMasaSiparisleri(int? masaId = null, string masaAdi = null, string satisKodu = null, bool paketSiparis = false)
        {
            InitializeComponent();
            _masaId = masaId;
            _satisKodu = satisKodu;
            _paketSiparis = paketSiparis;
            context.MasaHareketleri.Where(m => m.SatisKodu == _satisKodu).Load();
            context.OdemeHareketleri.Where(o => o.SatisKodu == _satisKodu).Load();
            gridControlSiparisler.DataSource = context.MasaHareketleri.Local.ToBindingList();
            gridControlOdemeler.DataSource = context.OdemeHareketleri.Local.ToBindingList();
            context.Urun.Load();
            lookUpMusteri.Properties.DataSource = musterilerDal.GetAll(context);
            if (_masaId != null)
            {
                lblBaslik.Text = masaAdi + "Siparişleri";
                masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
            }
            else if (_masaId == null)
            {
                lblBaslik.Text = "Paket Siparisi veya Veresiye İşlemleri";
            }
            satislar = satislarDal.GetByFilter(context, s => s.SatisKodu == _satisKodu);
            if (satislar != null)
            {
                lookUpMusteri.EditValue = satislar.MusteriId;
                txtAciklama.Text = satislar.Aciklama;
                dateEditTarih.Text = satislar.SonIslemTarih.ToString("dd.MM.yyyy");
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
            /// f
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
            if (MessageBox.Show("Seçili siparisin silinmesini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        decimal fiyat()
        {
            decimal birimfiyat = frm.urunModel.BirimFiyat;
            var modelprogram = context.ProgramAyarlari.FirstOrDefault(p => p.AyarTanimi == "BirimFiyat");
            if (modelprogram!=null)
            {
                switch (modelprogram.AyarAdi)
                {
                    case "BirimFiyat":
                        birimfiyat = frm.urunModel.BirimFiyat;
                        break;
                    case "BirimFiyat2":
                        birimfiyat = frm.urunModel.BirimFiyat2;
                        break;
                    case "BirimFiyat3":
                        birimfiyat = frm.urunModel.BirimFiyat3;
                        break;
                  
                }
            }

            return birimfiyat;
        }


        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            
            frm.ShowDialog();
            if (frm.secildi)
            {
                MasaHareketleri entity = new MasaHareketleri
                {
                    SatisKodu = _satisKodu,
                    MasaId = _masaId,
                    UrunId = frm.urunModel.Id,
                    Miktari = 1,
                    BirimFiyati = fiyat(),
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
            if (gridViewSiparis.RowCount > 0)
            {
                if (dateEditTarih.EditValue != null)
                {
                    if (satislar == null)
                    {
                        satislar = new Satislar();
                        satislar.SatisKodu = _satisKodu;
                    }
                    satislar.MusteriId = (int?)lookUpMusteri.EditValue;
                    satislar.Aciklama = txtAciklama.Text;
                    satislar.SonIslemTarih = Convert.ToDateTime(dateEditTarih.EditValue);
                    satislar.Kalan = calcKalan.Value;
                    satislar.Odenen = calcOdenen.Value;
                    satislar.Tutar = calcToplam.Value;
                    satislar.indirimToplami = calcİndirimToplami.Value;
                    satislar.PaketSiparisMi = _paketSiparis;
                    satislarDal.AddOrUpdate(context, satislar);
                    context.SaveChanges();
                    yazdir = true;

                }
                else
                {
                    MessageBox.Show("Tarih giriniz", "Bilgi");
                }
            }
            else
            {
                MessageBox.Show("Herhangi bir kayıt bulunamadı", "Bilgi");

            }
        }



        private void Odemeler_Click(object sender, EventArgs e)
        {
            if (gridViewSiparis.RowCount > 0)
            {
                var btn = sender as SimpleButton;
                frmOdeme frm = new frmOdeme(btn.Text, _satisKodu, calcKalan.Value);
                frm.ShowDialog();
                if (frm.Kaydedildi)
                {
                    if (odemeHareketleriDal.AddOrUpdate(context, frm.odemeHareketleri))
                    {
                        gridViewOdeme.RefreshData();
                        Hesapla();
                    }
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

        private void btnSonuclandir_Click(object sender, EventArgs e)
        {
            if (gridViewSiparis.RowCount > 0)
            {
                if (_masaId != null)
                {
                    if (calcKalan.Value > 0)
                    {
                        if (MessageBox.Show("Bu işlemi onaylarsanız müşteriye borc kaydedilecektir.", "bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            if (satislar != null)
                            {
                                if (satislar.MusteriId == null)
                                {
                                    MessageBox.Show("Lütfen müşteri seçiniz.", "Bilgi");
                                }
                                else
                                {
                                    Sonuclandir();
                                    this.Close();
                                }
                            }
                        }

                    }
                    else if (calcKalan.Value == 0)
                    {
                        Sonuclandir();
                        this.Close();
                    }
                }
            }
        }

        private void Sonuclandir()
        {
            masalar.SatisKodu = null;
            masalar.Durumu = false;
            masalar.Islem = null;
            masalar.KullaniciId = null;
            masalarDal.AddOrUpdate(context, masalar);
            masalarDal.save(context);
        }

        private void repositoryFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int urunId = Convert.ToInt32(gridViewSiparis.GetFocusedRowCellValue(colId));
            var model = urunDal.GetByFilter(context, u => u.Id == urunId);
            barFiyat1.Caption = model.BirimFiyat.ToString();
            barFiyat2.Caption = model.BirimFiyat2.ToString();
            barFiyat3.Caption = model.BirimFiyat3.ToString();
            radialMenu1.ShowPopup(MousePosition);
        }


        private void Fiyatlar(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewSiparis.SetFocusedRowCellValue(colBirimFiyati, e.Item.Caption);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnYazdir_Click(object sender, EventArgs e)
        {
            btnKaydet.PerformClick();
            if (yazdir)
            {
                if (_masaId!=null)
                {
                    rptSiparisFis rpt = new rptSiparisFis(_satisKodu, masalar.MasaAdi, satislar);
                    frmRaporGoruntuleme frm = new frmRaporGoruntuleme(rpt);
                    frm.ShowDialog();  
                }
                else if (_masaId==null)
                {
                    if (satislar.MusteriId==null)
                    {
                        rptSiparisFis rpt = new rptSiparisFis(_satisKodu, _satisKodu, satislar);
                        frmRaporGoruntuleme frm = new frmRaporGoruntuleme(rpt);
                        frm.ShowDialog();

                    }
                    else if (satislar.MusteriId != null)
                    {
                        rptSiparisFis rpt = new rptSiparisFis(_satisKodu, _satisKodu + " "+ satislar.Musteriler.AdSoyad , satislar);
                        frmRaporGoruntuleme frm = new frmRaporGoruntuleme(rpt);
                        frm.ShowDialog();
                    }
                   
                }
            }
        }
    }
}