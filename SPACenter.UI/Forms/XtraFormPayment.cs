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
using SPACenter.BLL.Managers;
using SPACenter.Entities.Database;
using SPACenter.UI.Message;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormPayment : DevExpress.XtraEditors.XtraForm
    {
        public PaymentManager paymentManager;
        public XtraFormPayment()
        {
            InitializeComponent();
            GetPayments();

        }

        //Ekle butonuna tıklandıgında:
        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormPaymentDetails paymentDetails = new XtraFormPaymentDetails();
            paymentDetails.ShowDialog();
            if (paymentDetails.Result)
            {
                paymentBindingSource.DataSource = paymentManager.GetAll().OrderByDescending(x=>x.DateTime).ToList();
                //GetPayments();
            }
           
        }

        //Güncelleye tıklandıgında:
        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Payment payment = paymentBindingSource.Current as Payment;
            if (payment == null)
            {
                return;
            }

            XtraFormPaymentDetails paymentDetails = new XtraFormPaymentDetails(payment.Id);
            paymentDetails.ShowDialog();
            if (paymentDetails.Result)
            {
                GetPayments();
            }
        }

        //Ödemeleri gridviewa getir
        private void GetPayments()
        {
            paymentManager = new PaymentManager(GlobalVariables.ConnectInfo);
            paymentBindingSource.DataSource = paymentManager.GetAll().OrderByDescending(x => x.DateTime).ToList();
            //demeleri en son tarihten eskiye dogru getir
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Payment payment = paymentBindingSource.DataSource as Payment;
            if (payment == null)
            {
                return;
            }

            if (MessageBoxes.DeleteConfirmationDialog(name: "Ödeme") != DialogResult.OK)
            {
                return;
            }

            Tuple<bool, List<string>, Payment> delete = paymentManager.Delete(payment.Id);
            MessageBoxes.ShowResult(delete);
            if (delete.Item1)
            {
                GetPayments();
            }
        }
    }
}