using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "String " + "Implementation ";
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("String"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase[2]);
            Console.WriteLine(phrase.IndexOf("Implementation"));
            Console.WriteLine(phrase.IndexOf('z'));
            Console.WriteLine(phrase.Substring(8));
            Console.WriteLine(phrase.Substring(8,3));


            Console.ReadLine();
           
        }
    }
}
