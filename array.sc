using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] states = { "animal", "vegetal", "mineral" };
            Console.WriteLine(states.Length);
            Console.WriteLine(string.Join(", ", states));

            int[] d = new int[] { -88, 14, -16 };
            Console.WriteLine(d.Length);
            Console.WriteLine(string.Join(", ", d));

            List<int> b = new List<int>();
            b.Add(12);
            b.Add(9);
            Console.WriteLine(b.Count);
            Console.WriteLine(string.Join(", ", b));

            int[] c = b.ToArray();
            Console.WriteLine(c.Length);
            Console.WriteLine(string.Join(", ", c));

            Console.ReadKey();
        }
    }
}
