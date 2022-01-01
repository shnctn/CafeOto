using CafeOto.Entities.Models;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace CafeOto.WinForm.Musteriler
{
    public partial class frmMusteriler : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        public frmMusteriler()
        {
            InitializeComponent();
            context.Musteriler.Load();
            gridControl1.DataSource = context.Musteriler.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gridView1.RefreshData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçilen müşteri silinsin mi", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                context.SaveChanges();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}