using System;

namespace InsecureRandomness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(GoodSecureRandomness.GetSecureString());

        }
    }
}
