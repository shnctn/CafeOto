
namespace CafeOto.WinForm.Satıslar
{
    partial class frmSatislar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnExport = new DevExpress.XtraEditors.DropDownButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeHareketleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnSiparisDetaylari = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.satislarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindirimToplami = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKalan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonIslemTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaketsiparisMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnExcelExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnWordExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdf = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1274, 43);
            this.lblBaslik.TabIndex = 9;
            this.lblBaslik.Text = "Satışlar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnExport);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.btnOdemeHareketleri);
            this.groupControl1.Controls.Add(this.btnSiparisDetaylari);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 536);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1274, 79);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.DropDownControl = this.popupMenu1;
            this.btnExport.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.textthatcontains_32x32;
            this.btnExport.Location = new System.Drawing.Point(1053, 26);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 48);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(1168, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(94, 48);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.refresh_32x323;
            this.btnYenile.Location = new System.Drawing.Point(258, 26);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(141, 48);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "Yenile - Listele";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnOdemeHareketleri
            // 
            this.btnOdemeHareketleri.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.download_32x32;
            this.btnOdemeHareketleri.Location = new System.Drawing.Point(135, 26);
            this.btnOdemeHareketleri.Name = "btnOdemeHareketleri";
            this.btnOdemeHareketleri.Size = new System.Drawing.Size(117, 48);
            this.btnOdemeHareketleri.TabIndex = 0;
            this.btnOdemeHareketleri.Text = "Ödeme \r\nHareketleri";
            this.btnOdemeHareketleri.Click += new System.EventHandler(this.btnOdemeHareketleri_Click);
            // 
            // btnSiparisDetaylari
            // 
            this.btnSiparisDetaylari.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.boorder_32x32;
            this.btnSiparisDetaylari.Location = new System.Drawing.Point(5, 26);
            this.btnSiparisDetaylari.Name = "btnSiparisDetaylari";
            this.btnSiparisDetaylari.Size = new System.Drawing.Size(124, 48);
            this.btnSiparisDetaylari.TabIndex = 0;
            this.btnSiparisDetaylari.Text = "Sipariş \r\nDetayları";
            this.btnSiparisDetaylari.Click += new System.EventHandler(this.btnSiparisDetaylari_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.satislarBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1274, 493);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // satislarBindingSource
            // 
            this.satislarBindingSource.DataSource = typeof(CafeOto.Entities.Models.Satislar);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSatisKodu,
            this.gridAdSoyad,
            this.colMusteriId,
            this.colTutar,
            this.colindirimToplami,
            this.colOdenen,
            this.colKalan,
            this.colAciklama,
            this.colSonIslemTarih,
            this.colMusteriler,
            this.colPaketsiparisMi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 67;
            // 
            // colSatisKodu
            // 
            this.colSatisKodu.FieldName = "SatisKodu";
            this.colSatisKodu.Name = "colSatisKodu";
            this.colSatisKodu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SatisKodu", "Kayıt Sayısı:{0}")});
            this.colSatisKodu.Visible = true;
            this.colSatisKodu.VisibleIndex = 1;
            this.colSatisKodu.Width = 81;
            // 
            // gridAdSoyad
            // 
            this.gridAdSoyad.Caption = "Müşteri Adı Soyadı";
            this.gridAdSoyad.FieldName = "Musteriler.AdSoyad";
            this.gridAdSoyad.Name = "gridAdSoyad";
            this.gridAdSoyad.Visible = true;
            this.gridAdSoyad.VisibleIndex = 2;
            this.gridAdSoyad.Width = 134;
            // 
            // colMusteriId
            // 
            this.colMusteriId.FieldName = "MusteriId";
            this.colMusteriId.Name = "colMusteriId";
            this.colMusteriId.Width = 79;
            // 
            // colTutar
            // 
            this.colTutar.DisplayFormat.FormatString = "c2";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "Tutar={0:c2}")});
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 3;
            this.colTutar.Width = 116;
            // 
            // colindirimToplami
            // 
            this.colindirimToplami.DisplayFormat.FormatString = "c2";
            this.colindirimToplami.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colindirimToplami.FieldName = "indirimToplami";
            this.colindirimToplami.Name = "colindirimToplami";
            this.colindirimToplami.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "indirimToplami", "İndirim Toplamı={0:c2}")});
            this.colindirimToplami.Visible = true;
            this.colindirimToplami.VisibleIndex = 4;
            this.colindirimToplami.Width = 140;
            // 
            // colOdenen
            // 
            this.colOdenen.DisplayFormat.FormatString = "c2";
            this.colOdenen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOdenen.FieldName = "Odenen";
            this.colOdenen.Name = "colOdenen";
            this.colOdenen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Odenen", "Odenen={0:c2}")});
            this.colOdenen.Visible = true;
            this.colOdenen.VisibleIndex = 5;
            this.colOdenen.Width = 99;
            // 
            // colKalan
            // 
            this.colKalan.DisplayFormat.FormatString = "c2";
            this.colKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKalan.FieldName = "Kalan";
            this.colKalan.Name = "colKalan";
            this.colKalan.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Kalan", "Kalan={0:c2}")});
            this.colKalan.Visible = true;
            this.colKalan.VisibleIndex = 6;
            this.colKalan.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 381;
            // 
            // colSonIslemTarih
            // 
            this.colSonIslemTarih.FieldName = "SonIslemTarih";
            this.colSonIslemTarih.Name = "colSonIslemTarih";
            this.colSonIslemTarih.Visible = true;
            this.colSonIslemTarih.VisibleIndex = 8;
            this.colSonIslemTarih.Width = 137;
            // 
            // colMusteriler
            // 
            this.colMusteriler.FieldName = "Musteriler";
            this.colMusteriler.Name = "colMusteriler";
            this.colMusteriler.Width = 106;
            // 
            // colPaketsiparisMi
            // 
            this.colPaketsiparisMi.Caption = "Paket Sipariş Mi";
            this.colPaketsiparisMi.FieldName = "PaketSiparisMi";
            this.colPaketsiparisMi.Name = "colPaketsiparisMi";
            this.colPaketsiparisMi.Visible = true;
            this.colPaketsiparisMi.VisibleIndex = 9;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWordExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdf)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Caption = "Excel Dosyalar(*.xlsx)";
            this.btnExcelExport.Id = 0;
            this.btnExcelExport.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.exporttoxlsx_16x16;
            this.btnExcelExport.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.exporttoxlsx_32x32;
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Tag = "Excel Dosyalar(*.xlsx)|*.xlsx";
            this.btnExcelExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // btnWordExport
            // 
            this.btnWordExport.Caption = "Word Dosyaları(* .Docx)";
            this.btnWordExport.Id = 1;
            this.btnWordExport.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.exporttodoc_16x16;
            this.btnWordExport.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.exporttodoc_32x32;
            this.btnWordExport.Name = "btnWordExport";
            this.btnWordExport.Tag = "Word Dosyaları(* .Docx)|*.docx";
            this.btnWordExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // btnPdf
            // 
            this.btnPdf.Caption = "Pdf Dosyaları(* .pdf)";
            this.btnPdf.Id = 2;
            this.btnPdf.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.exporttopdf_16x16;
            this.btnPdf.ImageOptions.LargeImage = global::CafeOto.WinForm.Properties.Resources.exporttopdf_32x32;
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Tag = "Pdf Dosyaları(* .pdf)|*.pdf";
            this.btnPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnExcelExport,
            this.btnWordExport,
            this.btnPdf});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1274, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 615);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1274, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 615);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1274, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 615);
            // 
            // frmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 615);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satişlar";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnOdemeHareketleri;
        private DevExpress.XtraEditors.SimpleButton btnSiparisDetaylari;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource satislarBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn gridAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriId;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colindirimToplami;
        private DevExpress.XtraGrid.Columns.GridColumn colOdenen;
        private DevExpress.XtraGrid.Columns.GridColumn colKalan;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colSonIslemTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriler;
        private DevExpress.XtraGrid.Columns.GridColumn colPaketsiparisMi;
        private DevExpress.XtraEditors.DropDownButton btnExport;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnExcelExport;
        private DevExpress.XtraBars.BarButtonItem btnWordExport;
        private DevExpress.XtraBars.BarButtonItem btnPdf;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}