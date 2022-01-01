using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
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

namespace CafeOto.WinForm.Urunler
{
    public partial class frmUrunSec : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        UrunDAL urunDal = new UrunDAL();
        public Urun urunModel;
        public bool secildi;
        public frmUrunSec()
        {
            InitializeComponent();
            gridControl1.DataSource = urunDal.GetAll(context);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                int urunId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                urunModel = urunDal.GetByFilter(context, u => u.Id == urunId);
                secildi=true;
                this.Close();
            }
            

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}