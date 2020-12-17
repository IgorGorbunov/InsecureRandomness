using System;


namespace InsecureRandomness
{
    /// <summary>
    /// Класс, содержащий плохо исправленный небезопасный метод ГПСЧ.
    /// </summary>
    public static class NotGoodSecureRandomness
    {
        /// <summary>
        /// Метод возвращает случайно сгенерироавнный токен.
        /// </summary>
        /// <returns></returns>
        public static string GetSecureString()
        {
            Random gen1 = new Random(Environment.TickCount);
            Random gen2 = new Random(gen1.Next());
            return gen2.Next().ToString();
        }
    }
}
