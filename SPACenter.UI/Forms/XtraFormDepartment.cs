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
using SPACenter.UI.Message;

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
            Department department = departmentBindingSource.Current as Department;

            if (department == null)
            {
                return;
            }
            XtraFormDepartmentDetails departmentDetails = new XtraFormDepartmentDetails(department.Id);
            departmentDetails.ShowDialog();
            GetDepartments();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Department department = departmentBindingSource.Current as Department;
            if (department == null)
            {
                return;
            }

            if (MessageBoxes.DeleteConfirmationDialog(name: department.Name) != DialogResult.Yes)
            {
                return;
            }

           
            Tuple<bool, List<string>, Department> delete = departmentManager.Delete(department.Id);
            MessageBoxes.ShowResult(delete);
            if (delete.Item1)
            {
                GetDepartments();
            }
        }
    }
}