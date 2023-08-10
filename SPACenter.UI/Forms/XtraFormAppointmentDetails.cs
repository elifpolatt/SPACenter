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

namespace SPACenter.UI.Forms
{
    public partial class XtraFormAppointmentDetails : DevExpress.XtraEditors.XtraForm
    {
        public bool Result { get; set; }
        private AppointmentManager appointmentManager;
        public Appointment Appointment { get; set; }
        public XtraFormAppointmentDetails()
        {
            InitializeComponent();
        }

     
    }
}