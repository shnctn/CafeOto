
namespace CafeOto.WinForm.Kullanicilar
{
    partial class frmKullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGiris));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSifremiUnuttum = new DevExpress.XtraEditors.SimpleButton();
            this.btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.hypkaydol = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.chkBeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBeniHatirla.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(418, 43);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Kullanıcı Giriş";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnSifremiUnuttum);
            this.groupControl1.Controls.Add(this.btnGirisYap);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(118, 126);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(300, 79);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.close_32x32;
            this.btnKapat.Location = new System.Drawing.Point(218, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 48);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.tag_32x32;
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(95, 26);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(117, 48);
            this.btnSifremiUnuttum.TabIndex = 6;
            this.btnSifremiUnuttum.Text = "Sifremi Unuttum";
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.ImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.bocustomer_32x32;
            this.btnGirisYap.Location = new System.Drawing.Point(5, 26);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(84, 48);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            this.btnGirisYap.Enter += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(127, 75);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.ContextImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.bopermission_16x16;
            this.txtParola.Properties.NullText = "Şifre Giriniz";
            this.txtParola.Properties.NullValuePrompt = "Şifre Giriniz";
            this.txtParola.Properties.UseSystemPasswordChar = true;
            this.txtParola.Size = new System.Drawing.Size(284, 20);
            this.txtParola.TabIndex = 2;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(124, 49);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.ContextImageOptions.Image = global::CafeOto.WinForm.Properties.Resources.usergroup_16x161;
            this.txtKullaniciAdi.Properties.NullText = "Kullanıcı Adınızı Giriniz";
            this.txtKullaniciAdi.Properties.NullValuePrompt = "Kullanıcı Adınızı Giriniz";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(287, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 43);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(118, 162);
            this.pictureEdit1.TabIndex = 6;
            // 
            // hypkaydol
            // 
            this.hypkaydol.Location = new System.Drawing.Point(379, 102);
            this.hypkaydol.Name = "hypkaydol";
            this.hypkaydol.Size = new System.Drawing.Size(32, 13);
            this.hypkaydol.TabIndex = 4;
            this.hypkaydol.Text = "Kaydol";
            this.hypkaydol.Click += new System.EventHandler(this.hypkaydol_Click);
            // 
            // chkBeniHatirla
            // 
            this.chkBeniHatirla.Location = new System.Drawing.Point(127, 101);
            this.chkBeniHatirla.Name = "chkBeniHatirla";
            this.chkBeniHatirla.Properties.Caption = "Beni Hatırla";
            this.chkBeniHatirla.Size = new System.Drawing.Size(97, 20);
            this.chkBeniHatirla.TabIndex = 3;
            // 
            // frmKullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 205);
            this.Controls.Add(this.chkBeniHatirla);
            this.Controls.Add(this.hypkaydol);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKullaniciGiris_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBeniHatirla.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSifremiUnuttum;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.HyperlinkLabelControl hypkaydol;
        private DevExpress.XtraEditors.CheckEdit chkBeniHatirla;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
    }
}