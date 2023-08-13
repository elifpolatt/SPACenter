using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SPACenter.BLL.Security
{
    public class Cryptography
    {
        //burası şifrelemeyle ilgili hazır bir kod blogu. Veri tabanında asıl sifreden bagımsız rastgele seylerle tutulması ıcın yapılıyor.
        public static string DefaultKey { get { return "857a6030127e4f2f910fb6f7302dfbf9"; } }

        private byte[] Coding(byte[] sifresizVeri, byte[] key, byte[] iv)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();

            alg.Key = key;
            alg.IV = iv;

            CryptoStream cs = new CryptoStream(ms,

            alg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(sifresizVeri, 0, sifresizVeri.Length);
            cs.Close();

            byte[] sifrelenmisVeri = ms.ToArray();
            return sifrelenmisVeri;
        }

        private Tuple<bool, byte[]> EnCoding(byte[] sifreliVeri, byte[] key, byte[] iv)
        {
            Tuple<bool, byte[]> tuple = new Tuple<bool, byte[]>(false, null);
            try
            {
                MemoryStream ms = new MemoryStream();
                Rijndael alg = Rijndael.Create();

                alg.Key = key;
                alg.IV = iv;

                CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);

                cs.Write(sifreliVeri, 0, sifreliVeri.Length);
                cs.Close();

                byte[] sifresiCozulmusVeri = ms.ToArray();
                return new Tuple<bool, byte[]>(true, sifresiCozulmusVeri);
            }
            catch (Exception e)
            {
                return new Tuple<bool, byte[]>(false, null);
            }
        }

        public string TextCoding(string sifrelenecekMetin)
        {
            byte[] sifrelenecekByteDizisi = System.Text.Encoding.Unicode.GetBytes(sifrelenecekMetin);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(DefaultKey, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,

            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            byte[] sifrelenmisVeri = Coding(sifrelenecekByteDizisi,

                 pdb.GetBytes(32), pdb.GetBytes(16));

            return Convert.ToBase64String(sifrelenmisVeri);
        }

        public string TextEnCoding(string text)
        {
            byte[] sifrelenmisByteDizisi = Convert.FromBase64String(text);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(DefaultKey,

                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65,

            0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            Tuple<bool, byte[]> enCoding = EnCoding(sifrelenmisByteDizisi,

                pdb.GetBytes(32), pdb.GetBytes(16));
            string result;
            try
            {
                result = enCoding.Item1 ? Encoding.Unicode.GetString(enCoding.Item2) : String.Empty;
            }
            catch (Exception e)
            {
                result = null;
            }
            return result;
        }
    }
}
