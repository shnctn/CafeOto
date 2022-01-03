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
using DevExpress.XtraReports.UI;

namespace CafeOto.WinForm.RaporFormlari
{
    public partial class frmRaporGor : DevExpress.XtraEditors.XtraForm
    {
        public frmRaporGor(XtraReport report)
        {
            InitializeComponent();
            documentViewer1.DocumentSource = report;
        }
    }
}