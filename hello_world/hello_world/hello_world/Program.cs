using System;

namespace hello_world
{
    class Program
    {

        static void Main(string[] args)
        {
            string userName = CallUserName();
            Console.WriteLine($"Hello {userName}!");
        }

        static string CallUserName()
        {
            Console.WriteLine("Hi, write u name...");
            string name = Console.ReadLine();
            return name;
        }

    }
}
