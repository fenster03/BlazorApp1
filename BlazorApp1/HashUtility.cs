using System.Security.Cryptography;
using System.Text;

namespace BlazorApp1
{
    public static class HashUtility
    {
        private static readonly MD5 _md5 = MD5.Create();
        public static string MD5Hash(string value)
        {
            var bytes = ASCIIEncoding.ASCII.GetBytes(value);
            var hash = _md5.ComputeHash(bytes);

            var result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("x2"));
            }

            return result.ToString();
        }
    }
}
