using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 + 8);
            Console.WriteLine(5 - 8);
            Console.WriteLine(5 * 8);
            Console.WriteLine(5 / 8);
            Console.WriteLine(5 % 2); 
            Console.WriteLine(4 + 2 * 3);

            int num = 2;
            num++;
            Console.WriteLine(num);

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3.8,2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 80));
            Console.WriteLine(Math.Round(4.6));

            Console.ReadLine();  
        }
    }
}
