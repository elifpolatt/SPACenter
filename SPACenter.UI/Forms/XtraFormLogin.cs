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
    public partial class XtraFormLogin : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormLogin()
        {
            InitializeComponent();
            UserManager userManager = new UserManager(GlobalVariables.ConnectInfo);
            List<User> users = userManager.GetAll();
            userBindingSource.DataSource = users;
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            User user = gridLookUpEdit1.EditValue as User;

            //user null değilse ve girilen şifre ile kullanıcının geçici şifresi karsılastırılıyor şifreler aynı değilse veya boşsa hata mesajı alacagız.
            //StringComparison.Ordinal, dil veya kültüre bağlı olmayan sıralama yapmak için kullanılır ve genellikle metinleri karşılaştırmak için güvenli bir seçenektir.
            if (user == null || String.Compare(user.PasswordTemp, textEditPassword.Text, StringComparison.Ordinal) != 0)
            {
                XtraMessageBox.Show("Kullanıcı seçilmedi veya şifre hatalı girildi. Yeniden deneyiniz.","Hata" , MessageBoxButtons.OK , MessageBoxIcon.Stop);
                return;
            }

            GlobalVariables.User = user;
                Close();
        }
    }
}