using SPACenter.BLL.Managers;
using SPACenter.Entities.Database;
using SPACenter.Entities.Enums;
using SPACenter.UI.Message;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormPaymentDetails : DevExpress.XtraEditors.XtraForm
    {
        public bool Result { get; set; }
        private PaymentManager paymentManager;
        public Payment Payment { get; set; }
        
        //ekle icin calısacak
        public XtraFormPaymentDetails()
        {
            InitializeComponent();
            paymentManager = new PaymentManager(GlobalVariables.ConnectInfo);
            Payment = new Payment();
            GetValues();
        }

        //güncelleme icin calısacak
        public XtraFormPaymentDetails(int id)
        {
            InitializeComponent();
            paymentManager = new PaymentManager(GlobalVariables.ConnectInfo);
            Payment = paymentManager.Get(id);
            GetValues();

        }

        //kaydet butonuna tıklandıgında 
        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Payment.CustomerId = (gridLookUpEditCustomers.EditValue as Customer)?.Id;  //secilen musterı customerıdye atanacak
            //Customer sınıfına donusum basarısız olursa null dönsün. ve null degilse id'ssine ulassın 
            //
            
            Payment.DepartmentId = (gridLookUpEditDepartment.EditValue as Department)?.Id;
            Payment.DateTime = DateTime.Now;
           //Payment.Amount = textEditAmount.Text;  ??????
           Payment.PaymentType = (PaymentType)comboBoxEditPaymentType.SelectedIndex;


           Tuple<bool, List<string>, Payment> operationResult;
           if (Payment.Id > 0) //eğer bir secim yapılmıssa yani id sıfırdan buyukse 
           {
               operationResult = paymentManager.Update(Payment); //güncelleme işlemi yap 
           }
           else //değilse
           {
               operationResult = paymentManager.Add(Payment); //boşsa ekleme islemi yap
           }

           MessageBoxes.ShowResult(operationResult);
           if (operationResult.Item1) //item1ddeki duruma gore true, false -> ona gore 
           {
                Payment = operationResult.Item3; //nesne alınacak 
                Result = operationResult.Item1;
                Close();
           }

        }

        //gridlookupeditlere musterılerı ve bolumlerı veri tabanından cekıyoruz 
        public void GetValues()
        {
            //musterılerı lıstele
            List<Customer> customer = new CustomerManager(GlobalVariables.ConnectInfo).GetAll();
            customerBindingSource.DataSource = customer;

            //bölümleri listele
            List<Department> department = new DepartmentManager(GlobalVariables.ConnectInfo).GetAll();
            departmentBindingSource.DataSource = department;

            //ödeme nesnesinin id degeri 0dan buyukse yanı onceden kaydedilmis bır odeme tutarı varsa 
            if (Payment.Id > 0)  
            {
                //default olarak son gırılen degerler gelsin dedik
                gridLookUpEditCustomers.EditValue = customer.FirstOrDefault(x => x.Id == Payment.CustomerId);
                gridLookUpEditDepartment.EditValue = department.FirstOrDefault(x => x.Id == Payment.DepartmentId);

                //ödeme türü de aynı sekılde en son secılen türe göre gelsin 
                comboBoxEditPaymentType.SelectedIndex = (int) Payment.PaymentType;
            }
        }

        private void gridLookUpEditDepartment_EditValueChanged(object sender, EventArgs e)
        {
            Department editDepartment = gridLookUpEditDepartment.EditValue as Department;
            if (editDepartment != null)
            {
                textEditAmount.Text = editDepartment.PaymentPerSeance.ToString();
                //ToString("f2") kullanılarak PaymentPerSeance değeri ondalık sayı olarak metin olarak formatlanır ve iki ondalık basamağa sahip bir virgülden sonra kesilir. 
            }
        }

        private void comboBoxEditPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}