using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinOwl
{
    class Creditional
    {
        private static string keys = "smit1234";
        public static string sam1 = @"C:\Users\vishal\Desktop\sam1.txt";
        public static string temp = @"C:\Users\vishal\Desktop\temp.txt";
        public static string sam2 = @"C:\Users\vishal\Desktop\sam2.txt";

        public void Savefile(string username, string password)
        {
            File.WriteAllBytes(temp,Encoding.ASCII.GetBytes(username));
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(@keys);

            FileStream fsCrypt = new FileStream(sam1, FileMode.Create);

            RijndaelManaged RMCrypto = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateEncryptor(key, key),
                CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(temp, FileMode.Open);

            int data;
            while ((data = fsIn.ReadByte()) != -1)
                cs.WriteByte((byte)data);

            fsIn.Close();
            cs.Close();
            fsCrypt.Close();
            File.Delete(temp);


            File.WriteAllBytes(temp, Encoding.ASCII.GetBytes(password));
            UnicodeEncoding UE2 = new UnicodeEncoding();
            byte[] key2 = UE2.GetBytes(@keys);

            FileStream fsCrypt2 = new FileStream(sam2, FileMode.Create);

            RijndaelManaged RMCrypto2 = new RijndaelManaged();

            CryptoStream cs2 = new CryptoStream(fsCrypt2,
                RMCrypto2.CreateEncryptor(key2, key2),
                CryptoStreamMode.Write);

            FileStream fsIn2 = new FileStream(temp, FileMode.Open);

            int data2;
            while ((data2 = fsIn2.ReadByte()) != -1)
                cs2.WriteByte((byte)data2);

            fsIn2.Close();
            cs2.Close();
            fsCrypt2.Close();
            File.Delete(temp);
        }
        public string Readuser()
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(keys);

            FileStream fsCrypt = new FileStream(sam1, FileMode.Open);

            RijndaelManaged RMCrypto = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateDecryptor(key, key),
                CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(temp, FileMode.Create);

            int data;
            while ((data = cs.ReadByte()) != -1)
                fsOut.WriteByte((byte)data);
            fsOut.Close();
            byte[] b = File.ReadAllBytes(temp);
            fsOut.Close();
            cs.Close();
            fsCrypt.Close();
            File.Delete(temp);
             string s = Encoding.ASCII.GetString(b);
            return s;
        }
        public string Readpass()
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(keys);

            FileStream fsCrypt = new FileStream(sam2, FileMode.Open);

            RijndaelManaged RMCrypto = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateDecryptor(key, key),
                CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(temp, FileMode.Create);

            int data;
            while ((data = cs.ReadByte()) != -1)
                fsOut.WriteByte((byte)data);
            fsOut.Close();
            byte[] b = File.ReadAllBytes(temp);
            fsOut.Close();
            cs.Close();
            fsCrypt.Close();
            File.Delete(temp);
            string s = Encoding.ASCII.GetString(b);
            return s;


        }
    }
}
