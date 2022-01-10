using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using System;
using System.Windows.Forms;
using CafeOto.WinForm.Masalar;

namespace CafeOto.WinForm.Urunler
{
    public partial class frnUrunler : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private UrunDAL urundal = new UrunDAL();

        public frnUrunler()
        {
            InitializeComponent();
            listele();
        }

        private void listele()
        {
            gridControl1.DataSource = urundal.Urunlistele(context);
        }

        private void frnUrunler_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniKaydet_Click(object sender, EventArgs e)
        {
            frmUrunKaydet frm = new frmUrunKaydet(new Urun());
            frm.ShowDialog();
            if (frm.kaydet)
            {
                listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

            int seciliID = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmUrunKaydet frm = new frmUrunKaydet(urundal.GetByFilter(context, u => u.Id == seciliID));
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("ürünü silmek istediğinizden emin misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                urundal.Delete(context, u => u.Id == seciliId);
                urundal.save(context);
                listele();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMasaHareketler_Click(object sender, EventArgs e)
        {
            int _urunid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmMasaHaraketleri frm = new frmMasaHaraketleri(urunId: _urunid);
            frm.ShowDialog();
        }
    }
}