using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOto.Entities.Models;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace CafeOto.WinForm.Ayarlar
{
    public partial class frmYedekleme : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        public frmYedekleme()
        {
            InitializeComponent();
            Server sunucu = new Server();
            var model = context.Database.SqlQuery<Database>("select * from sys.databases").ToList();
            foreach (var item in model)
            {
                cmbveritabani.Properties.Items.Add(item.Name);
            }

            cmbveritabani.EditValue = "Cafe2";
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            xtraSaveFileDialog1.Filter = "Backup(yedekleme) Dosyalrı(*.bak)|*.bak";
            xtraSaveFileDialog1.Title = "yedeklenecek dosyalar";
            if (xtraSaveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtKayityolu.Text = xtraSaveFileDialog1.FileName;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            progressBarControl1.EditValue = 0;
            try
            {
                if (System.IO.File.Exists(txtKayityolu.Text))
                {
                    File.Delete(txtKayityolu.Text);
                }

                Server dbserver = new Server(new ServerConnection(txtSunucu.Text));
                    Backup dBackup = new Backup();
                    dBackup.Action = BackupActionType.Database;
                    dBackup.Database = cmbveritabani.Text;
                    dBackup.Devices.AddDevice(txtKayityolu.Text,DeviceType.File);
                    dBackup.Initialize = false;
                dBackup.PercentComplete += DBackup_PercentComplete;
                dBackup.Complete += DBackup_Complete;
                    dBackup.SqlBackup(dbserver); 

            } 
            catch(Exception ex)
            {
                MessageBox.Show("Hata = " + ex.Message);
            }
        }

        private void DBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            MessageBox.Show("Yedekleme işlemi başarıyla gerçekleşti.");
        }

        private void DBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBarControl1.EditValue = e.Percent;
            progressBarControl1.Update();
            lblYuzde.Text = $"{e.Percent}%";
            lblDurum.Text="İşlem Başarıyla gerçekleşti.";
        }
    }
}