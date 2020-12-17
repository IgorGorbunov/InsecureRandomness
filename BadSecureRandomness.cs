using System;
using System.Collections.Generic;
using System.Text;

namespace InsecureRandomness
{
    /// <summary>
    /// Класс, содержащий небезопасный метод ГПСЧ.
    /// </summary>
    public static class BadSecureRandomness
    {
        /// <summary>
        /// Метод возвращает случайно сгенерироавнный токен.
        /// </summary>
        /// <returns></returns>
        public static string GetSecureString()
        {
            Random gen = new Random();
            return gen.Next().ToString();
        }
    }
}
