using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace ShopApp.UI.Helpers
{
    public static class StringHelper
    {
        public static string CreateRandomPassword(int length = 7)
        {

            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%?_-";
            Random random = new Random();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
        public static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);


                var sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }
        public static string ToSeoUrl(this string url)
        {
            string encodeURL = (url ?? "").ToLower();
            encodeURL = encodeURL.Replace("ç", "c")
                .Replace("ı", "i")
                .Replace("ş", "s")
                .Replace("ğ", "g")
                .Replace("ü", "u")
                .Replace("ö", "o")
                .Replace("+", "plus")
                .Replace("#", "sharp");
            encodeURL = Regex.Replace(encodeURL, @"\&+", "and");
            encodeURL = encodeURL.Replace("'", "");
            encodeURL = Regex.Replace(encodeURL, @"[^a-z0-9]", "-");
            encodeURL = Regex.Replace(encodeURL, @"-+", "-");
            encodeURL = encodeURL.Trim('-');
            return encodeURL;

        }
    }
}