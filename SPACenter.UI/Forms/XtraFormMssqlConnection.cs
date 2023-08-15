using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPACenter.UI.Forms
{
    public partial class XtraFormMssqlConnection : DevExpress.XtraEditors.XtraForm
    {
        public bool Result { get; set; }
        public XtraFormMssqlConnection()
        {
            InitializeComponent();
        }

        private void XtraFormMssqlConnection_Load(object sender, EventArgs e)
        {
            string connectionString = GlobalVariables.MssqlConnectionString;
            if (connectionString == null)
            {
                return;
            }
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);

            if (sqlConnectionStringBuilder.IntegratedSecurity)
            {
                comboBoxEditAuth.SelectedIndex = 0;
            }
            else
            {
                comboBoxEditAuth.SelectedIndex = 1;
            }
           // textEditServer.Text = sqlConnectionStringBuilder.DataSource;
            textEditDatabase.Text = sqlConnectionStringBuilder.InitialCatalog;
      
            if (!sqlConnectionStringBuilder.IntegratedSecurity)
            {
                textEditUser.Text = sqlConnectionStringBuilder.UserID;
                textEditPassword.Text = sqlConnectionStringBuilder.Password;
            }
        }

        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItemTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void comboBoxEditAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            textEditUser.Enabled =
                textEditPassword.Enabled = comboBoxEditAuth.SelectedIndex > 0;

        }
    }
}