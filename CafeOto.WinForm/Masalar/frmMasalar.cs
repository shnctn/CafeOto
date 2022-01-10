using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using System;
using System.Windows.Forms;

namespace CafeOto.WinForm.Masalar
{
    public partial class frmMasalar : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDAL masalardal = new MasalarDAL();
      
        public frmMasalar()
        {
            InitializeComponent();
            listele();
        }

        private void listele()
        {
            btnMasaHareketleri.DataSource = masalardal.MasalariListele(context);
        }

        private void btnYeniKaydet_Click(object sender, EventArgs e)
        {


            frmMasaKaydet frm = new frmMasaKaydet(new Entities.Models.Masalar());
            frm.ShowDialog();
            if (frm.kaydet)
            {
                listele();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var masalar = masalardal.GetByFilter(context, p => p.Id == seciliid);
            frmMasaKaydet frm = new frmMasaKaydet(masalar);
            frm.ShowDialog();
            if (frm.kaydet)
            {
                listele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("MAsayı silmek istediğinizden emin misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                masalardal.Delete(context, u => u.Id == seciliId);
                masalardal.save(context);
                listele();
            }
        }

        private void btndurumdegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masalar = masalardal.GetByFilter(context, m => m.Id == seciliid);
                if (masalar.Durumu)
                {
                    masalar.Durumu = false;
                }
                else if (!masalar.Durumu)
                {
                    masalar.Durumu = true;
                }
                masalardal.save(context);
                listele();
            }
        }

        private void btnRezerveDegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masalar = masalardal.GetByFilter(context, m => m.Id == seciliid);
                if (masalar.RezerveMi)
                {
                    masalar.RezerveMi = false;
                }
                else if (!masalar.RezerveMi)
                {
                    masalar.RezerveMi = true;
                }
                masalardal.save(context);
                listele();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMasaHareketler_Click(object sender, EventArgs e)
        {
            int _masaid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmMasaHaraketleri frm = new frmMasaHaraketleri(masaId: _masaid);
            frm.ShowDialog();
        }
    }
}