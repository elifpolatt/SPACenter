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
using SPACenter.UI.Message;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormAppointmentDetails : DevExpress.XtraEditors.XtraForm
    {
        public bool Result { get; set; }
        public Appointment Appointment { get; set; }

        private int CustomerId { get; set; }
        private int DepartmentId { get; set; }
        private int RendezvousTimeId { get; set; }
        private CustomerManager customerManager;
        private DepartmentManager departmentManager;
        private RendezvousTimeManager rendezvousTimeManager;

        private List<RendezvousTime> rendezvousTimes;
        private List<Customer> customers;
        private List<Department> departments;
        public XtraFormAppointmentDetails(Appointment appointment)
        {
            InitializeComponent();
            Appointment = appointment;
            DepartmentId = Appointment.DepartmentId;
            RendezvousTimeId = Appointment.RendezvousTimeId;
            CustomerId = Appointment.CustomerId;
            dateEditDate.DateTime = Appointment.RendevousDate;

            gridLookUpEditCustomer.ReadOnly = true;
            GetValues();
        }

        public XtraFormAppointmentDetails(int customerId)
        {
            InitializeComponent();
            CustomerId = customerId;
            Appointment = new Appointment();
            dateEditDate.DateTime = DateTime.Today;
           
            gridLookUpEditCustomer.ReadOnly = true;
            GetValues();
        }

        public XtraFormAppointmentDetails()
        {
            InitializeComponent();
            Appointment = new Appointment();
            dateEditDate.DateTime = DateTime.Today;
            GetValues();

        }
        private void GetValues()
        {
            customerManager = new CustomerManager(GlobalVariables.ConnectInfo);
            departmentManager = new DepartmentManager(GlobalVariables.ConnectInfo);
            rendezvousTimeManager = new RendezvousTimeManager(GlobalVariables.ConnectInfo);

            //tum randevu bılgılerını al. baslangıc saatıne gore sırala
            rendezvousTimes = rendezvousTimeManager.GetAll().OrderBy(x => x.StartTime).ToList();
            customers = customerManager.GetAll().OrderBy(x => x.FullName).ToList();
            departments = departmentManager.GetAll().OrderBy(x => x.Name).ToList();

            customerBindingSource.DataSource = customers;

            Customer customer = customers.FirstOrDefault(x => x.Id == CustomerId);
            gridLookUpEditCustomer.EditValue = customer;

            departmentBindingSource.DataSource = departments;

            Department department = departments.FirstOrDefault(x => x.Id == DepartmentId);
            gridLookUpEditDepartment.EditValue = department;

            if (department != null)
            {
                rendezvousTimeBindingSource.DataSource = rendezvousTimes.Where(x => x.DepartmentId == department.Id).ToList();
                
            }

            RendezvousTime rendezvousTime = rendezvousTimes.FirstOrDefault(x => x.Id == RendezvousTimeId);
            gridLookUpEditSeances.EditValue = rendezvousTime;
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppointmentManager appointmentManager = new AppointmentManager(GlobalVariables.ConnectInfo);
            if (gridLookUpEditCustomer.EditValue == null)
            {
                XtraMessageBox.Show("Müşteri boş geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Appointment.CustomerId = (gridLookUpEditCustomer.EditValue as Customer).Id;
            Appointment.DepartmentId = (gridLookUpEditDepartment.EditValue as Department).Id;
            //Department department = gridLookUpEditDepartments.EditValue as Department;
            //Appointment.DepartmentId = department.Id;
            Appointment.RendezvousTimeId = (gridLookUpEditSeances.EditValue as  RendezvousTime).Id;
            Appointment.RendevousDate = dateEditDate.DateTime.Date;

            if (gridLookUpEditDepartment.EditValue == null)
            {
                XtraMessageBox.Show("Bölüm boş geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            if (gridLookUpEditSeances.EditValue == null)
            {
                XtraMessageBox.Show("Seans saatleri boş geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            Tuple<bool, List<string>, Appointment> tuple;
            if (Appointment.Id > 0)
            {
                tuple = appointmentManager.Update(Appointment);
            }
            else
            {
                tuple = appointmentManager.Add(Appointment);
            }

            MessageBoxes.ShowResult(tuple);

            Result = tuple.Item1;
            Appointment = tuple.Item3;
            if (Result)
            {
                Close();
            }
        }

        private void gridLookUpEditDepartment_EditValueChanged(object sender, EventArgs e)
        {
            Department editValue = gridLookUpEditDepartment.EditValue as Department;
            if (editValue == null)
            {
                return;
            }

            rendezvousTimeBindingSource.DataSource =
                rendezvousTimes.Where(x => x.DepartmentId == editValue.Id).ToList();
        }
    }
}