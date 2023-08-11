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

namespace SPACenter.UI.Forms
{
    public partial class XtraFormRendezvousTime : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormRendezvousTime()
        {
            InitializeComponent();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormRendezvousTimeDetails rendezvousTimeDetails = new XtraFormRendezvousTimeDetails();
            rendezvousTimeDetails.ShowDialog();
            
        }
    }
}