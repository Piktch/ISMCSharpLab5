using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a = Math.Sqrt(50),d;
            for (int i = 49; i > 0; i--)
            {
                d = i + a;
                a = Math.Sqrt(a);
            }
            Console.WriteLine(a);
        }
    }
}
