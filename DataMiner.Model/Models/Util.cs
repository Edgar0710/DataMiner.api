using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace dataMiner.Data.helpers
{
    public class Utils
    {
        private TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider(); // Algoritmo de encriptacion TripleDES (Data Encryption Standard (DES))
        private MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider(); // Objeto MD5
        private string myKey = "PrivateKey2020"; // Clave secreta(puede cambiarse)

        public string Encriptar(string texto)
        {
            if (texto == "") return "";
            else
            {
                des.Key = hashmd5.ComputeHash((new UnicodeEncoding()).GetBytes(myKey));
                des.Mode = CipherMode.ECB;
                ICryptoTransform encrypt = des.CreateEncryptor();
                byte[] buff = UnicodeEncoding.ASCII.GetBytes(texto);
                return Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length));
            }
        }

        public string Desencriptar(string texto)
        {
            if (texto == "") return "";
            else
            {
                des.Key = hashmd5.ComputeHash((new UnicodeEncoding()).GetBytes(myKey));
                des.Mode = CipherMode.ECB;
                ICryptoTransform desencrypta = des.CreateDecryptor();
                byte[] buff = Convert.FromBase64String(texto);
                return UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length));
            }
        }

        public string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public string Base64_Encode(string str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }

        //Decodificar base64
        public string Base64_Decode(string str)
        {
            try
            {
                byte[] decbuff = Convert.FromBase64String(str);
                return System.Text.Encoding.UTF8.GetString(decbuff);
            }
            catch
            {
                //si se envia una cadena si codificación base64, mandamos vacio
                return "";
            }
        }
    }
}
