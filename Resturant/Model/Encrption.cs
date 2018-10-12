using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class Encrption
    {
        public static bool IsValidEmailAddress(string email)
        {
            var regex = new Regex(@"^[a-z0-9][a-z0-9._]+@([-a-z]+\.)+[a-z]{3}$");
            return regex.IsMatch(email);
        }

        public static string UppercaseFirst(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            return char.ToUpper(text[0]) + text.Substring(1);
        }

        public static bool Is_Alphabetic(string input)
        {
            var regex = new Regex("^[a-zA-Z ]*$");
            if (regex.IsMatch(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private String encryptPassword(string password)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }

        public static string trim(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == ' ' || c == '_' || c == '@')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = MD5.Create();  //or use SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
