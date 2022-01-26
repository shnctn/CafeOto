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

namespace CafeOto.WinForm.Ayarlar
{
    public partial class frmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        public frmAyarlar()
        {
            InitializeComponent();
          
            int i = 0;
            List<Object> obj = new List<object>();
            foreach (var item in typeof(Urun).GetProperties())
            {
                if (item.Name.Contains("BirimFiyat"))
                {
                    obj.Insert(i, item.Name);
                    i++;
                }
               
            }

            lookUpEdit1.Properties.DataSource = obj;
            AyarGetir();
        }

        private void AyarGetir()
        {
            var model = context.ProgramAyarlari.FirstOrDefault(p => p.AyarTanimi == "BirimFiyat");
            if (model != null) lookUpEdit1.EditValue = model.AyarAdi;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var modelprogram = context.ProgramAyarlari.FirstOrDefault(p => p.AyarTanimi == "BirimFiyat");
            if (modelprogram!=null)
            {
                modelprogram.AyarAdi = lookUpEdit1.EditValue.ToString();

            }else if (modelprogram==null)
            {
                ProgramAyarlari entity = new ProgramAyarlari()
                {
                    AyarTanimi = "BirimFiyat",
                    AyarAdi = lookUpEdit1.EditValue.ToString()
                };
                context.ProgramAyarlari.Add(entity);
            }
            AyarGetir();
            MessageBox.Show("Ayarlar Kaydedildi.");
        }
    }
}