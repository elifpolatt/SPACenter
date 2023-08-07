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
using DevExpress.Xpo.Helpers;
using SPACenter.BLL.Managers;
using SPACenter.Entities.Database;
using SPACenter.DAL.Abstracts;
using SPACenter.UI.Message;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormCustomerDetails : DevExpress.XtraEditors.XtraForm
    {
        private CustomerManager customerManager;
        public bool Result { get; set; }
        public Customer Customer { get; set; }

        public XtraFormCustomerDetails()
        {
            //müşteri eklemek istediğimde calısacak olan ctor
            InitializeComponent();
            customerManager = new CustomerManager(GlobalVariables.ConnectInfo);
            Customer = new Customer(); //yeni bir Customer nesnesi olusturup bunu customerBindingSource'a atıyoruz.
            customerBindingSource.DataSource = Customer; //değişiklikler gride ve verı tabanına yansır

        }
        public XtraFormCustomerDetails(int id)
        {
            //müşteri güncellemek istediğimde calısacak olan ctor
            InitializeComponent();
            customerManager = new CustomerManager(GlobalVariables.ConnectInfo);
            Customer = customerManager.Get(id);   //veri tabanından idyi alarak Customera iletir ve customerBindingSource'a atanır
            customerBindingSource.DataSource = Customer;//değişiklikler gride ve verı tabanına yansır


        }
        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tuple<bool, List<string>, Customer> updateResult;
             
            if (Customer.Id > 0)  //id sıfırdan buyukse yanı bır secim yapıldıysa save butonunda guncelleme islemi yap
            {
                updateResult = customerManager.Update(Customer);
            }
            else // yoksa ekleme işlemi yap 
            {
                updateResult = customerManager.Add(Customer);
            }

            MessageBoxes.ShowResult(updateResult);  //kullanıcıya sonucu messageboxesdan goster 

            if (updateResult.Item1)  //bool = true ise işlem basarılıysa: 
            {
                Customer = updateResult.Item3;  //eklenmiş veya güncellenmiş olan müsteri bilgisini güncelle
                Result = updateResult.Item1; //sonucu true olarak ayarla ve kaapt
                Close();
            }
        }

        //private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //string name = textEditName.Text;
        //string surname = textEditSurname.Text;
        //string mail = textEditMail.Text;
        //string telefon = textEditTel.Text;

        //Customer newCustomer= new Customer
        //{
        //    Name = name,
        //    Surname = surname,
        //    Mail = mail,
        //    PhoneNumber = telefon
        //};
        //bunun yerine bindingsource eklenecek

        //Customer customerToAdd = (Customer)bindingSourceCustomer.DataSource;


        //var result = customerManager.Add(Customer);
        //if (Customer != null)
        //{
        //    //var result = customerManager.Add(customer);

        //    MessageBox.Show("başarılı", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    this.Close();

        //}
        //else
        //{
        //    MessageBox.Show("müşteri adı ve soyadı boş bırakılamaz", "hata", MessageBoxButtons.OK,
        //        MessageBoxIcon.Error);
        //}
        //}


    }

}
