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
using CafeOto.Entities.Models;
using CafeOto.Entities.DAL;
using CafeOto.WinForm.Roles;

namespace CafeOto.WinForm.Kullanicilar
{
    public partial class frmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private KulanicilarDAL kullaniciDal = new KulanicilarDAL();
        public frmKullanicilar()
        {
            InitializeComponent();
            listele();
            KullaniciYetki.AdminMi(context,btnKaydet,btnGuncelle,btnRoller,btnYeniKaydet);
        }

        private void listele()
        {
            gridControl1.DataSource = kullaniciDal.GetAll(context);
        }

        private void btnYeniKaydet_Click(object sender, EventArgs e)
        {
            frmKullaniciKayit frm = new frmKullaniciKayit(new Entities.Models.Kullanicilar());
            frm.ShowDialog();
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges(); listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var model = kullaniciDal.GetByFilter(context, k => k.Id == id);
            frmKullaniciKayit frm = new frmKullaniciKayit(model);
            frm.ShowDialog();
            listele();
        }

        private void btnRoller_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmRoller frm = new frmRoller(id);
            frm.ShowDialog();
        }
    }
}