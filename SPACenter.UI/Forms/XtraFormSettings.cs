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
using SPACenter.UI.UserControls;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormSettings : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormSettings()
        {
            InitializeComponent();
            ServerSettingManager serverSettingManager = new ServerSettingManager(GlobalVariables.ConnectInfo);
            List<ServerSetting> serverSettings = serverSettingManager.GetAll(displayOnList: true);

            foreach (ServerSetting serverSetting in serverSettings)
            {
                XtraUserControlServerSettings xtraUserControlServerSettings = new XtraUserControlServerSettings(serverSetting);
                xtraUserControlServerSettings.Dock = DockStyle.Top;
                flowLayoutPanelSettings.Controls.Add(xtraUserControlServerSettings);
            }
        }
    }
}