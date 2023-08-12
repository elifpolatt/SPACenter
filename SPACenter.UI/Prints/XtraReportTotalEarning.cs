using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using SPACenter.BLL.Managers;
using SPACenter.Entities.Database;

namespace SPACenter.UI.Prints
{
    public partial class XtraReportTotalEarning : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportTotalEarning()
        {
            InitializeComponent();

            PaymentManager paymentManager = new PaymentManager(GlobalVariables.ConnectInfo);
            List<Payment> paymentList = paymentManager.GetAll();
            objectDataSource1.DataSource = paymentList;
        }

    }
}
