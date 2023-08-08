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
using SPACenter.BLL.Managers;
using SPACenter.Entities.Database;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormDepartment : DevExpress.XtraEditors.XtraForm
    {
        //Fields
        public DepartmentManager departmentManager;


        //Constructor
        public XtraFormDepartment()
        {
            InitializeComponent();
            departmentManager = new DepartmentManager(GlobalVariables.ConnectInfo);
            GetDepartments();
        }

        //Methods
        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormDepartmentDetails department = new XtraFormDepartmentDetails();
            department.ShowDialog();
            GetDepartments();
        }

        public void GetDepartments()
        {
            List<Department> departments = departmentManager.GetAll();
            departmentBindingSource.DataSource = departments;
        }

        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormDepartmentDetails department = new XtraFormDepartmentDetails();
            department.ShowDialog();
            GetDepartments();
        }
    }
}