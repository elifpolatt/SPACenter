using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPACenter.UI.Forms;

namespace SPACenter.UI
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void accordionControlElementCustomers_Click(object sender, EventArgs e)
        {
            Form customerForm = new XtraFormCustomer();
            OpenFormSingle(ref customerForm);
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
        }
    }
}
