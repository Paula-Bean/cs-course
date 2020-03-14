using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, what's your name? "); // test
            dynamic name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.ReadKey();
        }
    }
}
