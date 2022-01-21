
namespace CafeOto.WinForm.Kullanicilar
{
    partial class frmRoller
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
            this.lblbaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKullaniciKayit = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisible = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbaslik
            // 
            this.lblbaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbaslik.Appearance.Options.UseFont = true;
            this.lblbaslik.Appearance.Options.UseTextOptions = true;
            this.lblbaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblbaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblbaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblbaslik.Location = new System.Drawing.Point(0, 0);
            this.lblbaslik.Name = "lblbaslik";
            this.lblbaslik.Size = new System.Drawing.Size(1027, 35);
            this.lblbaslik.TabIndex = 17;
            this.lblbaslik.Text = "Kullanıcı  Rolleri";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKullaniciKayit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 552);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1027, 79);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(940, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 48);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.Text = "KAPAT";
            // 
            // btnKullaniciKayit
            // 
            this.btnKullaniciKayit.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.save_32x321;
            this.btnKullaniciKayit.Location = new System.Drawing.Point(5, 26);
            this.btnKullaniciKayit.Name = "btnKullaniciKayit";
            this.btnKullaniciKayit.Size = new System.Drawing.Size(101, 48);
            this.btnKullaniciKayit.TabIndex = 12;
            this.btnKullaniciKayit.Text = "Kaydet";
            this.btnKullaniciKayit.Click += new System.EventHandler(this.btnKullaniciKayit_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1027, 517);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKullaniciId,
            this.colFormName,
            this.colControlName,
            this.colControlCaption,
            this.colVisible});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Width = 71;
            // 
            // colKullaniciId
            // 
            this.colKullaniciId.FieldName = "KullaniciId";
            this.colKullaniciId.Name = "colKullaniciId";
            this.colKullaniciId.OptionsColumn.AllowEdit = false;
            this.colKullaniciId.Visible = true;
            this.colKullaniciId.VisibleIndex = 0;
            this.colKullaniciId.Width = 186;
            // 
            // colFormName
            // 
            this.colFormName.FieldName = "FormName";
            this.colFormName.Name = "colFormName";
            this.colFormName.OptionsColumn.AllowEdit = false;
            this.colFormName.Visible = true;
            this.colFormName.VisibleIndex = 1;
            this.colFormName.Width = 156;
            // 
            // colControlName
            // 
            this.colControlName.FieldName = "ControlName";
            this.colControlName.Name = "colControlName";
            this.colControlName.OptionsColumn.AllowEdit = false;
            this.colControlName.Visible = true;
            this.colControlName.VisibleIndex = 2;
            this.colControlName.Width = 195;
            // 
            // colControlCaption
            // 
            this.colControlCaption.FieldName = "ControlCaption";
            this.colControlCaption.Name = "colControlCaption";
            this.colControlCaption.OptionsColumn.AllowEdit = false;
            this.colControlCaption.Visible = true;
            this.colControlCaption.VisibleIndex = 3;
            this.colControlCaption.Width = 195;
            // 
            // colVisible
            // 
            this.colVisible.Caption = "Yetkili Mi";
            this.colVisible.FieldName = "Visible";
            this.colVisible.Name = "colVisible";
            this.colVisible.Visible = true;
            this.colVisible.VisibleIndex = 4;
            this.colVisible.Width = 199;
            // 
            // frmRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 631);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblbaslik);
            this.Name = "frmRoller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Rolleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblbaslik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciKayit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciId;
        private DevExpress.XtraGrid.Columns.GridColumn colFormName;
        private DevExpress.XtraGrid.Columns.GridColumn colControlName;
        private DevExpress.XtraGrid.Columns.GridColumn colControlCaption;
        private DevExpress.XtraGrid.Columns.GridColumn colVisible;
    }
}