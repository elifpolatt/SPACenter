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
    public partial class XtraFormPayment : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormPayment()
        {
            InitializeComponent();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormPaymentDetails paymentDetails = new XtraFormPaymentDetails();
            paymentDetails.ShowDialog();
        }
    }
}