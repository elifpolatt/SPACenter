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
using SPACenter.BLL.Managers;
using SPACenter.Entities.Database;
using SPACenter.UI.Message;
using SPACenter.UI.Prints;

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
                XtraReportPayment xtraReportPayment = new XtraReportPayment(paymentDetails.Payment.Id);
                xtraReportPayment.ShowPreview();
                paymentBindingSource.DataSource = paymentManager.GetAll().OrderByDescending(x=>x.DateTime).ToList();
                //En yakın tarihten en uzak tarihe doğru sıralayarak gridviewa getir.
                //GetPayments();
            }
           
        }

        //Güncelleye tıklandıgında:
        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Payment payment = paymentBindingSource.Current as Payment; //seçilen değeri paymenta attık 
            if (payment == null)
            {
                return;
            }

            XtraFormPaymentDetails paymentDetails = new XtraFormPaymentDetails(payment.Id); //paymentla da seçilenin idsi alındı 
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

            //messageboxtaki {name} silinecek onaylıyor musunuz mesajını alıyoruz. Ödeme silinecek onaylıyor musunuz seklinde popup cıkacak
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

        private void barButtonItemTotalEarn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            
            double totalEarnings = paymentManager.GetAll().Sum(payment => payment.Amount);

            XtraReportTotalEarning xtraReportTotalEarning = new XtraReportTotalEarning();
            //xtraReportTotalEarning.Parameters["TotalAmount"].Value = totalEarnings;
            xtraReportTotalEarning.ShowPreview();


        }
    }
}