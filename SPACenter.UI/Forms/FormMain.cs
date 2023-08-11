using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPACenter.Entities.Database;
using SPACenter.UI.Forms;
using SPACenter.UI.Wait_Forms;

namespace SPACenter.UI
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void OpenFormSingle(ref Form form)
        {

            Form formOpen = form;
            Form control = this.MdiChildren.FirstOrDefault(x => x.Name == formOpen.Name);
            //form altındakı tek bır form getırılecek ve bır tane acılacak.
            if (control != null)
            {
                control.BringToFront();
                //en son acılan form on planda olcak.
            }
            else
            {//form acık degılse ana formun cocugu formopena attıgımız Form, ana formun cocugu olacak
                formOpen.MdiParent = this;
                formOpen.Show();
            }
            WaitForm.ShowWaitForm(false);
        }
        private void accordionControlElementCustomers_Click(object sender, EventArgs e)
        {
            WaitForm.ShowWaitForm();
            Form customerForm = new XtraFormCustomer();
            OpenFormSingle(ref customerForm);
        }
        private void accordionControlElementAppointments_Click(object sender, EventArgs e)
        {
            WaitForm.ShowWaitForm();
            Form appointmentForm = new XtraFormAppointment();
            OpenFormSingle(ref appointmentForm);
        }

        private void accordionControlElementPayments_Click(object sender, EventArgs e)
        {
            WaitForm.ShowWaitForm();
            Form paymentForm = new XtraFormPayment();
            OpenFormSingle(ref paymentForm);
        }

        private void accordionControlElementDepartments_Click(object sender, EventArgs e)
        {
            WaitForm.ShowWaitForm();
            Form deparmentForm = new XtraFormDepartment();
            OpenFormSingle(ref deparmentForm);
        }

        private void accordionControlElementUsers_Click(object sender, EventArgs e)
        {
            WaitForm.ShowWaitForm();
            Form userForm = new XtraFormUser();
            OpenFormSingle(ref userForm);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }
    }
}
