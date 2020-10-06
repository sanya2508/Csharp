using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // writeline goes to new line while write stays in the same line
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.ReadLine();  
        }
    }
}
