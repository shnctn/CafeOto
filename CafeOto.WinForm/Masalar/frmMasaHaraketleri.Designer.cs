
using DevExpress.XtraEditors;

namespace CafeOto.WinForm.Masalar
{
    partial class frmMasaHaraketleri
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonIslemTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasalar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrun = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 400);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(968, 79);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(881, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 48);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.refresh_32x32;
            this.btnYenile.Location = new System.Drawing.Point(5, 26);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(101, 48);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
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
            this.labelControl1.Size = new System.Drawing.Size(968, 43);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "MASALAR";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(968, 357);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSatisKodu,
            this.colUrunAdi,
            this.colMenuAdi,
            this.colMasaAdi,
            this.colMasaId,
            this.colUrunId,
            this.colMiktari,
            this.colBirimFiyati,
            this.colIndirimTutari,
            this.colAciklama,
            this.colSonIslemTarih,
            this.colMasalar,
            this.colUrun});
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
            // 
            // colSatisKodu
            // 
            this.colSatisKodu.FieldName = "SatisKodu";
            this.colSatisKodu.Name = "colSatisKodu";
            this.colSatisKodu.Visible = true;
            this.colSatisKodu.VisibleIndex = 1;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürünler";
            this.colUrunAdi.FieldName = "Urun.UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 4;
            // 
            // colMenuAdi
            // 
            this.colMenuAdi.Caption = "Menüler";
            this.colMenuAdi.FieldName = "Urun.Menu.Adi";
            this.colMenuAdi.Name = "colMenuAdi";
            this.colMenuAdi.Visible = true;
            this.colMenuAdi.VisibleIndex = 3;
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.Caption = "Masalar";
            this.colMasaAdi.FieldName = "Masalar.MasaAdi";
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 2;
            // 
            // colMasaId
            // 
            this.colMasaId.FieldName = "MasaId";
            this.colMasaId.Name = "colMasaId";
            // 
            // colUrunId
            // 
            this.colUrunId.FieldName = "UrunId";
            this.colUrunId.Name = "colUrunId";
            // 
            // colMiktari
            // 
            this.colMiktari.FieldName = "Miktari";
            this.colMiktari.Name = "colMiktari";
            this.colMiktari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktari", "SUM={0:0.##}")});
            this.colMiktari.Visible = true;
            this.colMiktari.VisibleIndex = 5;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 6;
            // 
            // colIndirimTutari
            // 
            this.colIndirimTutari.FieldName = "IndirimTutari";
            this.colIndirimTutari.Name = "colIndirimTutari";
            this.colIndirimTutari.Visible = true;
            this.colIndirimTutari.VisibleIndex = 7;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 8;
            // 
            // colSonIslemTarih
            // 
            this.colSonIslemTarih.FieldName = "SonIslemTarih";
            this.colSonIslemTarih.Name = "colSonIslemTarih";
            this.colSonIslemTarih.Visible = true;
            this.colSonIslemTarih.VisibleIndex = 9;
            // 
            // colMasalar
            // 
            this.colMasalar.FieldName = "Masalar";
            this.colMasalar.Name = "colMasalar";
            // 
            // colUrun
            // 
            this.colUrun.FieldName = "Urun";
            this.colUrun.Name = "colUrun";
            // 
            // frmMasaHaraketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 479);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmMasaHaraketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMasaHaraketleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupControl1;
        private SimpleButton btnKapat;
        private SimpleButton btnYenile;
        private LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunId;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colSonIslemTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colMasalar;
        private DevExpress.XtraGrid.Columns.GridColumn colUrun;
    }
}