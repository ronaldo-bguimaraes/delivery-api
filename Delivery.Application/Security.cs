using System.Security.Cryptography;
using System.Text;

namespace Delivery.Application
{
  public class Security
  {
    public static string CreateMD5Hash(string text)
    {
      MD5 md5 = MD5.Create();
      byte[] inputBytes = Encoding.ASCII.GetBytes(text);
      byte[] hashBytes = md5.ComputeHash(inputBytes);

      StringBuilder builder = new StringBuilder();

      for (int i = 0; i < hashBytes.Length; i++)
      {
        builder.Append(hashBytes[i].ToString("X2"));
      }
      return builder.ToString();
    }
  }
}