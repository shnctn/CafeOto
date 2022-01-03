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

namespace CafeOto.WinForm.Odemeler
{
    public partial class frmOdemeHareketleri : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private OdemeHareketleriDAL odemeHarekerleriDal = new OdemeHareketleriDAL();
        public frmOdemeHareketleri(string satisKodu=null)
        {
            InitializeComponent();
            if (satisKodu==null)
            {
                gridControl1.DataSource = odemeHarekerleriDal.GetAll(context);
            }
            else if (satisKodu != null)
            {
                gridControl1.DataSource = odemeHarekerleriDal.GetAll(context,o=>o.SatisKodu==satisKodu);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            gridControl1.Refresh();
        }
    }
}