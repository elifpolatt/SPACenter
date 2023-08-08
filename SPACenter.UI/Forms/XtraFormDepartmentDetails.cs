using DevExpress.XtraEditors;
using SPACenter.BLL.Managers;
using SPACenter.Entities.Database;
using SPACenter.UI.Message;
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
    public partial class XtraFormDepartmentDetails : DevExpress.XtraEditors.XtraForm
    {
        //fields
        private DepartmentManager departmentManager;
        public Department Department;
        public bool Result { get; set; }
        public XtraFormDepartmentDetails()
        {
            InitializeComponent();
            departmentManager = new DepartmentManager(GlobalVariables.ConnectInfo);
            Department = new Department();
            departmentBindingSource.DataSource = Department;
        }

        public XtraFormDepartmentDetails(int id)
        {
            InitializeComponent();
            departmentManager = new DepartmentManager(GlobalVariables.ConnectInfo);
            Department = departmentManager.Get(id);
            departmentBindingSource.DataSource = Department;

        }
        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Tuple<bool, List<string>, Department> addResult;
            addResult = departmentManager.Add(Department);
            MessageBoxes.ShowResult(addResult);

            if (addResult.Item1)
            {
                Department = addResult.Item3;
                Result = addResult.Item1;
                Close();
            }
        }
    }
}