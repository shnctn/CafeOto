﻿using CafeOto.Entities.Models;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace CafeOto.WinForm.Menuler
{
    public partial class frmMenuler : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();

        public frmMenuler()
        {
            InitializeComponent();
            context.Menu.Load();
            gridControl1.DataSource = context.Menu.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gridView1.RefreshData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçilem menu silinsin mi", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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