using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace InsecureRandomness
{
    /// <summary>
    /// Класс, содержащий правильно исправленный безопасный метод ГПСЧ.
    /// </summary>
    public static class GoodSecureRandomness
    {

        /// <summary>
        /// Метод возвращает случайно сгенерироавнный токен.
        /// </summary>
        /// <returns></returns>
        public static string GetSecureString()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[4];

            rng.GetBytes(buffer);
            int result = BitConverter.ToInt32(buffer, 0);
            
            return new Random(result).Next().ToString();
        }
    }
}
