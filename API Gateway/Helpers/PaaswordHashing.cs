using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace API_Gateway.Helpers
{
    public class PasswordHashing
    {
        public string Encrypt(string value)
        {
            byte[] data = Encoding.ASCII.GetBytes("aaaaa" + value);
            data = SHA512.Create().ComputeHash(data);
            var passwd = Convert.ToBase64String(data);
            return passwd;

        }
    }
}
