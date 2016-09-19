using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5ConsoleW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            int p, o, c = 0; ;
            p = a % 10;
            a /= 10;
            c = a % 10;
            a /= 10;
            o = a % 10;
            Console.Write(c);
            Console.Write(o);
            Console.WriteLine(p);
        }
    }
}
