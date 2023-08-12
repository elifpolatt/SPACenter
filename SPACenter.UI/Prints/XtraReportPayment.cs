using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using SPACenter.BLL.Managers;
using SPACenter.Entities.Database;

namespace SPACenter.UI.Prints
{
    public partial class XtraReportPayment : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportPayment(int paymentId)
        {
            InitializeComponent();

            PaymentManager paymentManager = new PaymentManager(GlobalVariables.ConnectInfo);
            Payment payment = paymentManager.Get(paymentId);

            objectDataSource1.DataSource = payment;
        }

    }
}
