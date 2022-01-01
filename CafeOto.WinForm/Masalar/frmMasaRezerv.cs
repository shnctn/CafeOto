using CafeOto.Entities.DAL;
using CafeOto.Entities.Models;
using CafeOto.WinForm.WinTools;
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

namespace CafeOto.WinForm.Masalar
{
    public partial class frmMasaRezerv : DevExpress.XtraEditors.XtraForm
    {
        int _masaId;
       public bool islemyapildi;
       Entities.Models.Masalar masalar;
        MasalarDAL masalarDal=new MasalarDAL();
        CafeContext context=new CafeContext();
        public frmMasaRezerv(int masaId)
        {
            _masaId=masaId;
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            masalar=masalarDal.GetByFilter(context,m=>m.Id==_masaId);
            masalar.Islem=txtIslem.Text;
            masalar.SonIslemTarih=Convert.ToDateTime(dateEdit1.EditValue);
            masalar.KullaniciId=KullaniciAyarlari.KullaniciId;
            masalar.RezerveMi=true;
            masalarDal.save(context);
            islemyapildi=true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}