using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPACenter.Entities.Messages
{
    public class StaticMessages
    {
        public static List<string> GetResultMessage(bool result)
        {
            List<string> messages = new List<string>();
            string successMessage = result ? "başarılı" : "başarısız";  //result doğruysa basarılı hatalıysa basarısız
            messages.Add($"İşlem {successMessage} oldu."); // duruma gore mesajı aldık
            return messages;


            // List<string> list = new List<string>();
            //list.Add($"İşlem başarı{(result ? "lı" : "sız")} oldu");  //trueysa lı false ise sız alacak
            //return list;
        }
    }
}
