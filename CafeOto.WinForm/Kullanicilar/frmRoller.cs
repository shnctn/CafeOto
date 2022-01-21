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

namespace CafeOto.WinForm.Kullanicilar
{
    public partial class frmRoller : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private RollerDAL rollerDal = new RollerDAL();
        private int _Kullanicid;
        public frmRoller(int id)
        {
            _Kullanicid = id;
            InitializeComponent();
            gridControl1.DataSource = rollerDal.GetAll(context,r=>r.KullaniciId== _Kullanicid);

        }

        private void btnKullaniciKayit_Click(object sender, EventArgs e)
        {
            rollerDal.save(context);
            gridView1.RefreshData();
        }
    }
}