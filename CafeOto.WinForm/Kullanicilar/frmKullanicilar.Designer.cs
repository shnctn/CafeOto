
namespace CafeOto.WinForm.Kullanicilar
{
    partial class frmKullanicilar
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnRoller = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParola = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHatirlatmaSorusu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCevap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktifMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciHareketleri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasalar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(1049, 27);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Kullanıcılar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnRoller);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnYeniKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 342);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1049, 79);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.group_32x32;
            this.btnKaydet.Location = new System.Drawing.Point(326, 26);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(89, 48);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(962, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 48);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnRoller
            // 
            this.btnRoller.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.refresh_32x32;
            this.btnRoller.Location = new System.Drawing.Point(219, 26);
            this.btnRoller.Name = "btnRoller";
            this.btnRoller.Size = new System.Drawing.Size(101, 48);
            this.btnRoller.TabIndex = 0;
            this.btnRoller.Text = "Roller";
            this.btnRoller.Click += new System.EventHandler(this.btnRoller_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.pencolor_32x32;
            this.btnGuncelle.Location = new System.Drawing.Point(112, 26);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(101, 48);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYeniKaydet
            // 
            this.btnYeniKaydet.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.add_32x32;
            this.btnYeniKaydet.Location = new System.Drawing.Point(5, 26);
            this.btnYeniKaydet.Name = "btnYeniKaydet";
            this.btnYeniKaydet.Size = new System.Drawing.Size(101, 48);
            this.btnYeniKaydet.TabIndex = 0;
            this.btnYeniKaydet.Text = "Yeni Kayıt";
            this.btnYeniKaydet.Click += new System.EventHandler(this.btnYeniKaydet_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kullanicilarBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1049, 315);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataSource = typeof(CafeOto.Entities.Models.Kullanicilar);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAdSoyad,
            this.colTelefon,
            this.colAdres,
            this.colEmail,
            this.colGorevi,
            this.colKullaniciAdi,
            this.colParola,
            this.colHatirlatmaSorusu,
            this.colCevap,
            this.colAciklama,
            this.colKayitTarihi,
            this.colAktifMi,
            this.colisAdmin,
            this.colKullaniciHareketleri,
            this.colMasalar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 51;
            // 
            // colAdSoyad
            // 
            this.colAdSoyad.FieldName = "AdSoyad";
            this.colAdSoyad.Name = "colAdSoyad";
            this.colAdSoyad.OptionsColumn.AllowEdit = false;
            this.colAdSoyad.Visible = true;
            this.colAdSoyad.VisibleIndex = 1;
            this.colAdSoyad.Width = 66;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 2;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 3;
            this.colAdres.Width = 176;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 164;
            // 
            // colGorevi
            // 
            this.colGorevi.FieldName = "Gorevi";
            this.colGorevi.Name = "colGorevi";
            this.colGorevi.OptionsColumn.AllowEdit = false;
            this.colGorevi.Visible = true;
            this.colGorevi.VisibleIndex = 5;
            this.colGorevi.Width = 133;
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 6;
            this.colKullaniciAdi.Width = 54;
            // 
            // colParola
            // 
            this.colParola.FieldName = "Parola";
            this.colParola.Name = "colParola";
            this.colParola.OptionsColumn.AllowEdit = false;
            this.colParola.Visible = true;
            this.colParola.VisibleIndex = 7;
            this.colParola.Width = 54;
            // 
            // colHatirlatmaSorusu
            // 
            this.colHatirlatmaSorusu.FieldName = "HatirlatmaSorusu";
            this.colHatirlatmaSorusu.Name = "colHatirlatmaSorusu";
            this.colHatirlatmaSorusu.OptionsColumn.AllowEdit = false;
            this.colHatirlatmaSorusu.Width = 74;
            // 
            // colCevap
            // 
            this.colCevap.FieldName = "Cevap";
            this.colCevap.Name = "colCevap";
            this.colCevap.OptionsColumn.AllowEdit = false;
            this.colCevap.Width = 74;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 8;
            this.colAciklama.Width = 78;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 9;
            this.colKayitTarihi.Width = 60;
            // 
            // colAktifMi
            // 
            this.colAktifMi.FieldName = "AktifMi";
            this.colAktifMi.Name = "colAktifMi";
            this.colAktifMi.Visible = true;
            this.colAktifMi.VisibleIndex = 10;
            this.colAktifMi.Width = 39;
            // 
            // colisAdmin
            // 
            this.colisAdmin.Caption = "Admin Mi";
            this.colisAdmin.FieldName = "isAdmin";
            this.colisAdmin.Name = "colisAdmin";
            this.colisAdmin.Visible = true;
            this.colisAdmin.VisibleIndex = 11;
            this.colisAdmin.Width = 74;
            // 
            // colKullaniciHareketleri
            // 
            this.colKullaniciHareketleri.FieldName = "KullaniciHareketleri";
            this.colKullaniciHareketleri.Name = "colKullaniciHareketleri";
            this.colKullaniciHareketleri.OptionsColumn.AllowEdit = false;
            // 
            // colMasalar
            // 
            this.colMasalar.FieldName = "Masalar";
            this.colMasalar.Name = "colMasalar";
            this.colMasalar.OptionsColumn.AllowEdit = false;
            // 
            // frmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 421);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmKullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanicilar Formu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnRoller;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnYeniKaydet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevi;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colParola;
        private DevExpress.XtraGrid.Columns.GridColumn colHatirlatmaSorusu;
        private DevExpress.XtraGrid.Columns.GridColumn colCevap;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAktifMi;
        private DevExpress.XtraGrid.Columns.GridColumn colisAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciHareketleri;
        private DevExpress.XtraGrid.Columns.GridColumn colMasalar;
    }
}