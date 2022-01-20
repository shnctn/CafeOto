
namespace CafeOto.WinForm.Masalar
{
    partial class FormMasaDurumlari
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
            this.btnRezerve = new DevExpress.XtraEditors.SimpleButton();
            this.btnMasaAc = new DevExpress.XtraEditors.SimpleButton();
            this.btnSiparisEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenileme = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnRezerve);
            this.groupControl1.Controls.Add(this.btnMasaAc);
            this.groupControl1.Controls.Add(this.btnSiparisEkle);
            this.groupControl1.Controls.Add(this.btnYenileme);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 382);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(920, 79);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(833, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 48);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnRezerve
            // 
            this.btnRezerve.Enabled = false;
            this.btnRezerve.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.converttorange_32x321;
            this.btnRezerve.Location = new System.Drawing.Point(226, 26);
            this.btnRezerve.Name = "btnRezerve";
            this.btnRezerve.Size = new System.Drawing.Size(101, 48);
            this.btnRezerve.TabIndex = 0;
            this.btnRezerve.Text = "Rezerve Et";
            this.btnRezerve.Click += new System.EventHandler(this.btnRezerve_Click);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.Enabled = false;
            this.btnMasaAc.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.inserttablecells_32x32;
            this.btnMasaAc.Location = new System.Drawing.Point(116, 26);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(101, 48);
            this.btnMasaAc.TabIndex = 0;
            this.btnMasaAc.Text = "Masa Aç";
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Enabled = false;
            this.btnSiparisEkle.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.add_32x321;
            this.btnSiparisEkle.Location = new System.Drawing.Point(9, 26);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(101, 48);
            this.btnSiparisEkle.TabIndex = 0;
            this.btnSiparisEkle.Text = "Siparişler";
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // btnYenileme
            // 
            this.btnYenileme.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.refresh_32x322;
            this.btnYenileme.Location = new System.Drawing.Point(333, 26);
            this.btnYenileme.Name = "btnYenileme";
            this.btnYenileme.Size = new System.Drawing.Size(101, 48);
            this.btnYenileme.TabIndex = 0;
            this.btnYenileme.Text = "Yenile-Listele";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(920, 345);
            this.flowLayoutPanel1.TabIndex = 3;
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
            this.labelControl1.Size = new System.Drawing.Size(920, 37);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Masa Durumları";
            // 
            // FormMasaDurumlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 461);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FormMasaDurumlari";
            this.Text = "Masa Durumlari";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnRezerve;
        private DevExpress.XtraEditors.SimpleButton btnMasaAc;
        private DevExpress.XtraEditors.SimpleButton btnSiparisEkle;
        private DevExpress.XtraEditors.SimpleButton btnYenileme;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}