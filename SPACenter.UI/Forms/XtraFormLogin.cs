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
using SPACenter.BLL.Security;

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
            //User user = gridLookUpEditCustomer.EditValue as User;

            ////user null değilse ve girilen şifre ile kullanıcının geçici şifresi karsılastırılıyor şifreler aynı değilse veya boşsa hata mesajı alacagız.
            ////StringComparison.Ordinal, dil veya kültüre bağlı olmayan sıralama yapmak için kullanılır ve genellikle metinleri karşılaştırmak için güvenli bir seçenektir.
            //if (user == null || String.Compare(user.PasswordTemp, textEditPassword.Text, StringComparison.Ordinal) != 0)
            //{
            //    XtraMessageBox.Show("Kullanıcı seçilmedi veya şifre hatalı girildi. Yeniden deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}

            //GlobalVariables.User = user;
            //Close();


            //int userId = (int)gridLookUpEditUser.EditValue; // Burada gridLookUpEdit'ten seçilen kullanıcı ID'sini alıyoruz
            //UserManager userManager = new UserManager(GlobalVariables.ConnectInfo);
            //User user = userManager.LoginUser(userId);
            //string enterPassword = textEditPassword.Text;

            //if (user == null || user.PasswordTemp != enterPassword)
            //{
            //    XtraMessageBox.Show("Kullanıcı seçilmedi veya şifre hatalı girildi. Yeniden deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
            //else
            //{
            //    GlobalVariables.User = user;
            //    Close();
            //}
           
            int userId = (int)gridLookUpEditUser.EditValue; // Burada gridLookUpEdit'ten seçilen kullanıcı ID'sini alıyoruz

            UserManager userManager = new UserManager(GlobalVariables.ConnectInfo);
            User user = userManager.Get(userId); // Kullanıcıyı direkt olarak Get metodundan alıyoruz
            string enterPassword = textEditPassword.Text;
            if (user == null || user.PasswordTemp != enterPassword)
            {
                XtraMessageBox.Show("Kullanıcı seçilmedi veya şifre hatalı girildi. Yeniden deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            else
            {
                GlobalVariables.User = user;
                Close();
            }


        }

        private void XtraFormLogin_Load(object sender, EventArgs e)
        {
            //login formunda gridlookupeditcustomer editvalue is null gelmesin diye bunu yaptım
            gridLookUpEditUser.Properties.NullText = " ";
            textEditPassword.Text = "";
            textEditPassword.Properties.PasswordChar = '*';

        }
    }
}