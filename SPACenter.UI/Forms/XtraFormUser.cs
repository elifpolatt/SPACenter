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
    public partial class XtraFormUser : DevExpress.XtraEditors.XtraForm
    {
        private UserManager userManager;
        public XtraFormUser()
        {
            InitializeComponent();
            userManager = new UserManager(GlobalVariables.ConnectInfo);
            GetUsers();
        }

        void GetUsers()
        {
            List<User> allUsers = userManager.GetAll();
            userBindingSource.DataSource = allUsers;
        }
        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormUserDetails userDetails = new XtraFormUserDetails();
            userDetails.ShowDialog();
            
        }

        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormUserDetails userDetails = new XtraFormUserDetails();
            userDetails.ShowDialog();
        }
    }
}