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
using Org.BouncyCastle.Bcpg;
using SPACenter.BLL.Managers;
using SPACenter.Entities.Database;
using SPACenter.UI.Message;

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
            if (userDetails.Result)
            {
                GetUsers();
            }
            
        }

        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            User user = userBindingSource.Current as User;
            if (user == null)
            {
                return;
            }
            XtraFormUserDetails userDetails = new XtraFormUserDetails(/*user.Id*/);

            userDetails.ShowDialog();
            if (userDetails.Result)
            {
                GetUsers();
            }
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            User user = userBindingSource.Current as User;
            if (user == null)
            {
                return;
            }

            if (MessageBoxes.DeleteConfirmationDialog(name: user.Name) != DialogResult.Yes)
            {
                return;
            }

            Tuple<bool, List<string>, User> delete = userManager.Delete(user.Id);
            MessageBoxes.ShowResult(delete);
            if (delete.Item1)
            {
                GetUsers();
            }
        }
    }
}