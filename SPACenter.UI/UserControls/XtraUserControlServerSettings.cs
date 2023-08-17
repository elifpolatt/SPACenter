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

namespace SPACenter.UI.UserControls
{
    public partial class XtraUserControlServerSettings : DevExpress.XtraEditors.XtraUserControl
    {
        public ServerSetting ServerSetting { get; private set; }

        public XtraUserControlServerSettings(ServerSetting serverSetting)
        {
            InitializeComponent();
            ServerSetting = serverSetting;
            serverSettingBindingSource.DataSource = ServerSetting;

        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            ServerSettingManager serverSettingManager = new ServerSettingManager(GlobalVariables.ConnectInfo);
            ServerSetting serverSetting = serverSettingManager.Update(ServerSetting);
            if (serverSetting != null)
            {
                XtraMessageBox.Show("Ayar kaydedildi.", "Bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Ayar kaydedilemedi.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
