using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace GtaBackground.BLL
{
    public static class ContractHelper
    {
        private const string AppSecret = "9xkmR1lAMfGMmxZytjhsssDgtp8IQ0rWadgKZu1Dm21Wh6GqXPYoEoWHj3sctTkM";

        public static string GetPassWord(string val)
        {
            return MD5(val);
        }

        public static string Serialize<T>(T value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public static T Deserialize<T>(string jsonString)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            catch
            {
                throw new Exception("数据格式不正确");
            }
        }
        public static string MD5(string val)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(val));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static bool Contains<T>(this IEnumerable<T> items, Predicate<T> predicate)
        {
            if (items == null)
                throw new ArgumentNullException("items");
            if (predicate == null)
                throw new ArgumentNullException("predicate");

            foreach (var item in items)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}