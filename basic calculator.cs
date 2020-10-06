using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // concat
            Console.WriteLine("430" + "56");

            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 56);

            // basic calculator
            Console.Write("Enter a number: ");
            doouble num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);


            Console.ReadLine();  
        }
    }
}
