using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
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
    public partial class XtraFormMysqlConnection : DevExpress.XtraEditors.XtraForm
    {
        public bool Result { get;  set; }

        public XtraFormMysqlConnection()
        {
            InitializeComponent();
        }

        private void XtraFormMysqlConnection_Load(object sender, EventArgs e)
        {
            string connectionString = GlobalVariables.MysqlConnectionString;
            if (connectionString == null)
            {
                return;
            }
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder(connectionString);

           // textEditServer.Text = mySqlConnectionStringBuilder.Server;
            textEditPort.Text = mySqlConnectionStringBuilder.Port.ToString();
            textEditUser.Text = mySqlConnectionStringBuilder.UserID;
            textEditPassword.Text = mySqlConnectionStringBuilder.Password;
            textEditDatabase.Text = mySqlConnectionStringBuilder.Database;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
            
        }
    }
}