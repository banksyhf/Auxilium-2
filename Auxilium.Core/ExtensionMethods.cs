using System;
using System.Security.Cryptography;
using System.Text;

namespace Auxilium.Core
{
    internal static class ExtensionMethods
    {
        public static string Hash(this string input, HashAlgorithm algo)
        {
            string salt = input[input[0] % input.Length] + "B4TH5ALTS" + input.Length;

            byte[] inputBytes = Encoding.UTF8.GetBytes(input + salt);
            byte[] hashedBytes = algo.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes).Replace("-", "");
        }
    }
}