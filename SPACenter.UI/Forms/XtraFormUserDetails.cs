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
using DevExpress.XtraScheduler.UI;
using SPACenter.BLL.Managers;
using SPACenter.Entities.Database;
using SPACenter.UI.Message;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormUserDetails : DevExpress.XtraEditors.XtraForm
    {
        public bool Result { get; set; }
        private UserManager userManager;
        public User User { get; set; }
        public XtraFormUserDetails()
        {
            InitializeComponent();
            userManager = new UserManager(GlobalVariables.ConnectInfo);
            User = new User();
            userBindingSource.DataSource = User;
        }

        public XtraFormUserDetails(int id)
        {
            InitializeComponent();
            userManager = new UserManager(GlobalVariables.ConnectInfo);
            User = userManager.Get(id);
            userBindingSource.DataSource = User;
        }
        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tuple<bool, List<string>, User> operationResult;

            if (User.Id > 0) //bir seçim yapıldıysa id sıfırdan buyukse:
            {
                operationResult = userManager.Update(User);
            }
            else
            {
                operationResult = userManager.Add(User);
            }

            MessageBoxes.ShowResult(operationResult);
            if (operationResult.Item1)
            {
                User = operationResult.Item3;
                Result = operationResult.Item1;
                Close();

            }
        }

      
    }
}