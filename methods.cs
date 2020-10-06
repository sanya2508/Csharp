using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods or Functions
            SayHi("Sanya", 20);
            SayHi("Abc", 18);
            SayHi("Okay", 16);
            Console.WriteLine();

            Console.WriteLine(Cube(5));

            Console.ReadLine();  
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Helloooo " + name + ", you are " + age);
        }

        //using return statement in methods
        static int Cube(int num)
        {
            int result= num * num * num;
            return result;
        }
    }
}
