using System;
using System.Security.Cryptography;
using System.Text;

namespace OnlineMusicStore.UI.Helper
{
	public class PasswordHelper
	{
		public static string GenerateSalt()
		{
			byte[] saltBytes = new byte[16];
			var crypto = new RNGCryptoServiceProvider();
			crypto.GetBytes(saltBytes);
			return Convert.ToBase64String(saltBytes);
		}

		public static string GenerateHash(string password, string salt)
		{
			byte[] passwordBytes = Encoding.Unicode.GetBytes(password);
			byte[] saltBytes = Convert.FromBase64String(salt);
			byte[] hashingBytes = new byte[passwordBytes.Length + saltBytes.Length];


			Buffer.BlockCopy(passwordBytes, 0, hashingBytes, 0, passwordBytes.Length);
			Buffer.BlockCopy(saltBytes, 0, hashingBytes, passwordBytes.Length, saltBytes.Length);

			var algorithm = HashAlgorithm.Create("SHA1");
			return Convert.ToBase64String(algorithm.ComputeHash(hashingBytes));
		}
	}
}
