using DevExpress.XtraEditors;
using SPACenter.Entities.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPACenter.BLL.Managers;
using SPACenter.DAL.Abstracts;
using SPACenter.DAL.Concrete.Mssql;
using System.Configuration;
using System.Configuration.Provider;
using System.Runtime.Remoting;
using System.Xml.Linq;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormCustomer : DevExpress.XtraEditors.XtraForm
    {
        private CustomerManager customerManager;

        public XtraFormCustomer()
        {
            InitializeComponent();
            customerManager = new CustomerManager(GlobalVariables.ConnectInfo);
            GetCustomers();

           
        }

       private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormCustomerDetails customer = new XtraFormCustomerDetails();
            customer.ShowDialog();
            GetCustomers();
        }
        void GetCustomers()
        {
            List<Customer> allCustomers = customerManager.GetAllCustomers();
            gridControlCustomer.DataSource = allCustomers;
        }
        

    }
}