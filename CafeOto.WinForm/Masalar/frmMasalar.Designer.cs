
namespace CafeOto.WinForm.Masalar
{
    partial class frmMasalar
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btndurumdegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnRezerveDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnMasaHareketler = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnMasaHareketleri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRezerveMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEklemeTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonIslemTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaHareketleri = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMasaHareketleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1156, 43);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "MASALAR";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btndurumdegistir);
            this.groupControl1.Controls.Add(this.btnRezerveDegistir);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnMasaHareketler);
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Controls.Add(this.btnYeniKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 430);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1156, 79);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(1069, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 48);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btndurumdegistir
            // 
            this.btndurumdegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndurumdegistir.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.refresh_32x321;
            this.btndurumdegistir.Location = new System.Drawing.Point(728, 26);
            this.btndurumdegistir.Name = "btndurumdegistir";
            this.btndurumdegistir.Size = new System.Drawing.Size(119, 48);
            this.btndurumdegistir.TabIndex = 0;
            this.btndurumdegistir.Text = "Durum Değiştir";
            this.btndurumdegistir.Click += new System.EventHandler(this.btndurumdegistir_Click);
            // 
            // btnRezerveDegistir
            // 
            this.btnRezerveDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRezerveDegistir.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.convert_32x32;
            this.btnRezerveDegistir.Location = new System.Drawing.Point(853, 26);
            this.btnRezerveDegistir.Name = "btnRezerveDegistir";
            this.btnRezerveDegistir.Size = new System.Drawing.Size(122, 48);
            this.btnRezerveDegistir.TabIndex = 0;
            this.btnRezerveDegistir.Text = "Rezerve Değiştir";
            this.btnRezerveDegistir.Click += new System.EventHandler(this.btnRezerveDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.clearall_32x32;
            this.btnSil.Location = new System.Drawing.Point(981, 26);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 48);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnMasaHareketler
            // 
            this.btnMasaHareketler.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.group_32x32;
            this.btnMasaHareketler.Location = new System.Drawing.Point(326, 26);
            this.btnMasaHareketler.Name = "btnMasaHareketler";
            this.btnMasaHareketler.Size = new System.Drawing.Size(155, 48);
            this.btnMasaHareketler.TabIndex = 0;
            this.btnMasaHareketler.Text = "MASA HAREKETLER";
            this.btnMasaHareketler.Click += new System.EventHandler(this.btnMasaHareketler_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.refresh_32x32;
            this.btnYenile.Location = new System.Drawing.Point(219, 26);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(101, 48);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.pencolor_32x32;
            this.btnDuzenle.Location = new System.Drawing.Point(112, 26);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(101, 48);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniKaydet
            // 
            this.btnYeniKaydet.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.add_32x32;
            this.btnYeniKaydet.Location = new System.Drawing.Point(5, 26);
            this.btnYeniKaydet.Name = "btnYeniKaydet";
            this.btnYeniKaydet.Size = new System.Drawing.Size(101, 48);
            this.btnYeniKaydet.TabIndex = 0;
            this.btnYeniKaydet.Text = "YENİ KAYIT";
            this.btnYeniKaydet.Click += new System.EventHandler(this.btnYeniKaydet_Click);
            // 
            // btnMasaHareketleri
            // 
            this.btnMasaHareketleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMasaHareketleri.Location = new System.Drawing.Point(0, 43);
            this.btnMasaHareketleri.MainView = this.gridView1;
            this.btnMasaHareketleri.Name = "btnMasaHareketleri";
            this.btnMasaHareketleri.Size = new System.Drawing.Size(1156, 387);
            this.btnMasaHareketleri.TabIndex = 1;
            this.btnMasaHareketleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMasaAdi,
            this.colAciklama,
            this.colDurumu,
            this.colRezerveMi,
            this.colEklemeTarih,
            this.colSonIslemTarih,
            this.colIslem,
            this.colKullaniciId,
            this.colMasaHareketleri});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(832, 382, 252, 266);
            this.gridView1.GridControl = this.btnMasaHareketleri;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 90;
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.FieldName = "MasaAdi";
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 1;
            this.colMasaAdi.Width = 90;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Acıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 192;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 3;
            this.colDurumu.Width = 62;
            // 
            // colRezerveMi
            // 
            this.colRezerveMi.FieldName = "RezerveMi";
            this.colRezerveMi.Name = "colRezerveMi";
            this.colRezerveMi.Visible = true;
            this.colRezerveMi.VisibleIndex = 4;
            this.colRezerveMi.Width = 72;
            // 
            // colEklemeTarih
            // 
            this.colEklemeTarih.FieldName = "EklemeTarih";
            this.colEklemeTarih.Name = "colEklemeTarih";
            this.colEklemeTarih.Visible = true;
            this.colEklemeTarih.VisibleIndex = 5;
            this.colEklemeTarih.Width = 72;
            // 
            // colSonIslemTarih
            // 
            this.colSonIslemTarih.FieldName = "SonIslemTarih";
            this.colSonIslemTarih.Name = "colSonIslemTarih";
            this.colSonIslemTarih.Visible = true;
            this.colSonIslemTarih.VisibleIndex = 6;
            this.colSonIslemTarih.Width = 72;
            // 
            // colIslem
            // 
            this.colIslem.FieldName = "Islem";
            this.colIslem.Name = "colIslem";
            this.colIslem.Visible = true;
            this.colIslem.VisibleIndex = 8;
            this.colIslem.Width = 93;
            // 
            // colKullaniciId
            // 
            this.colKullaniciId.Caption = "Kullanıcı";
            this.colKullaniciId.FieldName = "Kullanici";
            this.colKullaniciId.Name = "colKullaniciId";
            this.colKullaniciId.Visible = true;
            this.colKullaniciId.VisibleIndex = 7;
            this.colKullaniciId.Width = 72;
            // 
            // colMasaHareketleri
            // 
            this.colMasaHareketleri.FieldName = "MasaHareketleri";
            this.colMasaHareketleri.Name = "colMasaHareketleri";
            // 
            // frmMasalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 509);
            this.Controls.Add(this.btnMasaHareketleri);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmMasalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASALAR";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMasaHareketleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnYeniKaydet;
        private DevExpress.XtraGrid.GridControl btnMasaHareketleri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colRezerveMi;
        private DevExpress.XtraGrid.Columns.GridColumn colEklemeTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSonIslemTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colIslem;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciId;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaHareketleri;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.SimpleButton btndurumdegistir;
        private DevExpress.XtraEditors.SimpleButton btnRezerveDegistir;
        private DevExpress.XtraEditors.SimpleButton btnMasaHareketler;
    }
}