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
using SPACenter.UI.Message;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormCustomer : DevExpress.XtraEditors.XtraForm
    {
        private CustomerManager customerManager;

        //Müşterilere tıklatıldıgında tüm müşteriler listelenecek : getcustomers
        public XtraFormCustomer()
        {
            InitializeComponent();
            customerManager = new CustomerManager(GlobalVariables.ConnectInfo);
            GetCustomers();

           
        }

        //Müşteri ekleye tıklatıldığında müşteri detay formu açılacak. 
        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormCustomerDetails customer = new XtraFormCustomerDetails();
            customer.ShowDialog();
            if (customer.Result)
            {
                GetCustomers();
            }

        }

        //Müşteri güncelleye tıklatıldığında müşteri detay formu açılacak.
        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Customer customer = customerBindingSource.Current as Customer;  //seçtiğim müşteri nesnesini alır
            if (customer == null)
            {
                return;
            }
            XtraFormCustomerDetails customerDetails = new XtraFormCustomerDetails(customer.Id); //seçilen müşterinin idsi alınıyor
            customerDetails.ShowDialog();
            if (customerDetails.Result)
            {
                GetCustomers();
            }
        }
       
        //Müşterileri tabloda listeli şekilde getirilicek
        void GetCustomers()
        {
            List<Customer> allCustomers = customerManager.GetAll();
            customerBindingSource.DataSource = allCustomers;
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Customer customer = customerBindingSource.Current as Customer;

            if (customer == null)
            {
                return;

            }

            if (MessageBoxes.DeleteConfirmationDialog(name: customer.Name) != DialogResult.OK)
            {
                return;
            }

            Tuple<bool, List<string>, Customer> delete = customerManager.Delete(customer.Id);
            MessageBoxes.ShowResult(delete);
            if (delete.Item1)
            {
                GetCustomers();
            }
        }
        }
}