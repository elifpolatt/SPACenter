using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors; //XtraMessageBox kullanmak ıcın eklendı

namespace SPACenter.UI.Message
{
    public static class MessageBoxes
    {
        public static DialogResult ShowResult<T>(Tuple<bool, List<string>, T> result)
        {
            StringBuilder stringBuilder = new StringBuilder();
            result.Item2.ForEach(s => { stringBuilder.AppendLine(s);});  //burada hata mesajlarını StringBuilder'a ekler.
            //StringBuilder, metin icindeki gerçekleştirilen değişiklikleri aynı nesne içinde yönetir.
            //metin parçalarını birleştirmek veya değiştirmek için bellekte daha az kaynak kullanımı sağlar. 
            string message = stringBuilder.ToString();
            string caption = result.Item1 ? "Bilgilendirme" : "Hata"; //sonuc doğruysa bilgilendirme , hatalıysa error
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = result.Item1 ? MessageBoxIcon.Information : MessageBoxIcon.Error;

            DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
            return dialogResult;

        }

        public static DialogResult DeleteConfirmationDialog(string name)
        {
            return XtraMessageBox.Show("{name} silinecek , onaylıyor musunuz?", "uyarı", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
    }
}
