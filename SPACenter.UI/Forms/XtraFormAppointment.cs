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

namespace SPACenter.UI.Forms
{
    public partial class XtraFormAppointment : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormAppointment()
        {
            InitializeComponent();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormAppointmentDetails appointment = new XtraFormAppointmentDetails();
            appointment.ShowDialog();
           
        }

        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormAppointmentDetails appointment = new XtraFormAppointmentDetails();
            appointment.ShowDialog();
        }
    }
}