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
using SPACenter.Entities.Database;
using SPACenter.Entities.Enums;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormSetDatabase : DevExpress.XtraEditors.XtraForm
    {
        public bool Result { get; set; }
        public User User { get;  set; }
        public XtraFormSetDatabase()
        {
            InitializeComponent();
            User = new User();
            userBindingSource.DataSource = User;
        }

        private void comboBoxEditDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEditConnectionString.EditValue = null;

        }

        private void buttonEditConnectionString_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (comboBoxEditDatabase.SelectedIndex == 0)
            {
                XtraFormMssqlConnection xtraFormMsSqlConnection = new XtraFormMssqlConnection();
                xtraFormMsSqlConnection.ShowDialog();
                if (xtraFormMsSqlConnection.Result)
                {
                    buttonEditConnectionString.EditValue = GlobalVariables.MssqlConnectionString;
                }
            }
            else if (comboBoxEditDatabase.SelectedIndex == 1)
            {
                XtraFormMysqlConnection formMySqlConnection = new XtraFormMysqlConnection();
                formMySqlConnection.ShowDialog();
                if (formMySqlConnection.Result)
                {
                    buttonEditConnectionString.EditValue = GlobalVariables.MysqlConnectionString;
                }
            }
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (buttonEditConnectionString.EditValue == null)
            {
                Result = false;
                return;
            }

            DatabaseType databaseType = (DatabaseType)comboBoxEditDatabase.SelectedIndex;
            Properties.Settings.Default.DatabaseType = databaseType;
            Properties.Settings.Default.Save();
            Result = true;
            Close();
        }
    }
}