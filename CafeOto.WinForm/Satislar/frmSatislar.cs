using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using CafeOto.WinForm.Masalar;
using CafeOto.WinForm.Odemeler;

namespace CafeOto.WinForm.Satıslar
{
    public partial class frmSatislar : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private SatislarDAL satislarDal = new SatislarDAL();
        public frmSatislar()
        {
            InitializeComponent();
            gridControl1.DataSource = satislarDal.GetAll(context);
        }

        

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiparisDetaylari_Click(object sender, EventArgs e)
        {
            string satisKodu = gridView1.GetFocusedRowCellValue(colSatisKodu).ToString();
            bool paketSipari =Convert.ToBoolean(gridView1.GetFocusedRowCellValue(colPaketsiparisMi));

            frmMasaSiparisleri frm = new frmMasaSiparisleri(satisKodu:satisKodu, paketSiparis:paketSipari);
            frm.ShowDialog();
        }

        private void btnOdemeHareketleri_Click(object sender, EventArgs e)
        {
            string satisKodu = gridView1.GetFocusedRowCellValue(colSatisKodu).ToString();
            frmOdemeHareketleri frm = new frmOdemeHareketleri(satisKodu: satisKodu);
            frm.ShowDialog();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            gridControl1.Refresh();
        }

        private void Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = e.Item.Tag.ToString();
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                if (e.Item==btnExcelExport)
                {
                    gridView1.ExportToXlsx(dialog.FileName);
                }
                else if (e.Item==btnWordExport)
                {
                    gridView1.ExportToDocx(dialog.FileName);
                }
                else if (e.Item == btnPdf)
                {
                    gridView1.ExportToPdf(dialog.FileName);
                }
            }
        }
    }
}