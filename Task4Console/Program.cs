using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Console
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
            while (a > 9)
            {
                c += a % 10;
                c *= 10;
                a /= 10;
            }
            c /= 10;
            Console.Write(p);
            Console.Write(c);
            Console.WriteLine(a);
        }
    }
}
