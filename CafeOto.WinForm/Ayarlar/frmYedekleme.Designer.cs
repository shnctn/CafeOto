
namespace CafeOto.WinForm.Ayarlar
{
    partial class frmYedekleme
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblYuzde = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblDurum = new DevExpress.XtraEditors.LabelControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.cmbveritabani = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtKayityolu = new DevExpress.XtraEditors.TextEdit();
            this.txtSunucu = new DevExpress.XtraEditors.TextEdit();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbveritabani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKayityolu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSunucu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sunucu :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Veritabanı :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Kayıt Yeri :";
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(293, 106);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(41, 23);
            this.btnSec.TabIndex = 4;
            this.btnSec.Text = "...";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(268, 135);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(66, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Yedek Al";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblYuzde
            // 
            this.lblYuzde.Location = new System.Drawing.Point(268, 165);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(17, 13);
            this.lblYuzde.TabIndex = 6;
            this.lblYuzde.Text = "0%";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 165);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Durum";
            // 
            // lblDurum
            // 
            this.lblDurum.Location = new System.Drawing.Point(89, 166);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(37, 13);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.Text = "Durumu";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(1, 185);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(347, 18);
            this.progressBarControl1.TabIndex = 5;
            // 
            // cmbveritabani
            // 
            this.cmbveritabani.Location = new System.Drawing.Point(89, 64);
            this.cmbveritabani.Name = "cmbveritabani";
            this.cmbveritabani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbveritabani.Size = new System.Drawing.Size(245, 20);
            this.cmbveritabani.TabIndex = 3;
            // 
            // txtKayityolu
            // 
            this.txtKayityolu.Location = new System.Drawing.Point(89, 108);
            this.txtKayityolu.Name = "txtKayityolu";
            this.txtKayityolu.Size = new System.Drawing.Size(197, 20);
            this.txtKayityolu.TabIndex = 2;
            // 
            // txtSunucu
            // 
            this.txtSunucu.Location = new System.Drawing.Point(89, 23);
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Size = new System.Drawing.Size(245, 20);
            this.txtSunucu.TabIndex = 2;
            // 
            // xtraSaveFileDialog1
            // 
            this.xtraSaveFileDialog1.FileName = "xtraSaveFileDialog1";
            // 
            // frmYedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 204);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblYuzde);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.cmbveritabani);
            this.Controls.Add(this.txtKayityolu);
            this.Controls.Add(this.txtSunucu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmYedekleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedekleme";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbveritabani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKayityolu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSunucu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSunucu;
        private DevExpress.XtraEditors.ComboBoxEdit cmbveritabani;
        private DevExpress.XtraEditors.TextEdit txtKayityolu;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lblYuzde;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblDurum;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
    }
}