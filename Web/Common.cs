using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;
namespace Web
{
    public class Common
    {
        public static string GetMd5(string str)
        {
            /*给字符串连接上特殊字符,这是为了防止md5被暴力破解所做，也可以用多次md5加密*/
            str += "!@#$ASD";
            /*把字符串转换成字节数组*/
            byte[] buffer = Encoding.Default.GetBytes(str);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            /*md5加密*/
            byte[] cryptBuffer = md5.ComputeHash(buffer);
            string s = "";
            /*把每一个字节0-255，转换成两位16进制数*/
            for (int i=0; i<cryptBuffer.Length; i++)
            {
                s += cryptBuffer[i].ToString("X2");
            }
            return s;
        }
    }
}