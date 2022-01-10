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

namespace CafeOto.WinForm.Masalar
{
    public partial class frmMasaHaraketleri : DevExpress.XtraEditors.XtraForm
    {
        private int? _masaID;
        private int? _menuID;
        private int? _urunID;
        private CafeContext context = new CafeContext();
        private MasaHareketleriDAL masaHareketleriDal = new MasaHareketleriDAL();
        public frmMasaHaraketleri(int? masaId = null, int? menuId=null, int? urunId=null)
        {
            _masaID = masaId;
            _menuID = menuId;
            _urunID = urunId;
            if (_masaID != null)
            {
                gridControl1.DataSource = masaHareketleriDal.GetAll(context, c => c.MasaId == _masaID);
                return;
            }
            else if(_menuID != null)
            {
                gridControl1.DataSource = masaHareketleriDal.GetAll(context, c => c.Urun.MenuId == _menuID);
                return;
            }
            else if (_urunID != null)
            {
                gridControl1.DataSource = masaHareketleriDal.GetAll(context, c => c.UrunId == _urunID);
                return;
            }
            InitializeComponent();
            gridControl1.DataSource = masaHareketleriDal.GetAll(context);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            gridControl1.Refresh();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}