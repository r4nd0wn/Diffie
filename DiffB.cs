using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me your secret number:");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("At first, give me the g Alice sent to you:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give me the p Alice sent to you:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And now we need the A:");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("let me calculate that shit for you:");
            Console.WriteLine("your B is (send it to Alice):");
            double B = Math.Pow(g, b) % p;
            Console.WriteLine(Convert.ToString(B));
            double K = Math.Pow(A, b) % p;
            Console.WriteLine("Your Key is:");
            Console.WriteLine(Convert.ToString(K));
        }
    }
}
