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
using DevExpress.XtraRichEdit.Import.OpenXml;
using SPACenter.BLL.Managers;
using SPACenter.Entities.Database;
using SPACenter.UI.Message;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormAppointment : DevExpress.XtraEditors.XtraForm
    {
        public AppointmentManager appointmentManager;
        public XtraFormAppointment()
        {
            InitializeComponent();
            appointmentManager = new AppointmentManager(GlobalVariables.ConnectInfo);
            GetAppointments();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormAppointmentDetails appointment = new XtraFormAppointmentDetails();
            appointment.ShowDialog();
            if (appointment.Result)
            {
                GetAppointments();
            }
           
        }

        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Appointment appointment = appointmentBindingSource.Current as Appointment;

            if (appointment == null)
            {
                return;
            }


            XtraFormAppointmentDetails appointmentDetails = new XtraFormAppointmentDetails();
            appointmentDetails.ShowDialog();
            if (appointmentDetails.Result)
            {
                GetAppointments();
            }
        }

        
        private void GetAppointments()
        {
            List<Appointment> appointments = appointmentManager.GetAll().OrderBy(x => x.RendevousDate)
                .ThenBy(x => x.RendevousTime.StartTime).ToList();

            appointmentBindingSource.DataSource = appointments;
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Appointment appointment = appointmentBindingSource.Current as Appointment;
            if (appointment == null)
            {
                return;
            }

            if (MessageBoxes.DeleteConfirmationDialog(name: appointment.ToString()) != DialogResult.Yes)
            {
                return;
            }

            Tuple<bool, List<string>, Appointment> delete = appointmentManager.Delete(appointment.Id);
            MessageBoxes.ShowResult(delete);
            if (delete.Item1)
            {
                GetAppointments();
            }
        }

      

        private void barButtonItemCalender_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormRendezvousCalender appointment = new XtraFormRendezvousCalender();
            appointment.ShowDialog();
        }
    }
}