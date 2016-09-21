using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x, v, p;
            x = Double.Parse(Console.ReadLine());
            v = 1 - (2 * x) / 3;
            for (int i =3; i <= 10; i+=2)
            {
                p = i * Math.Pow(x, i - 1) / (i+1);
                p-= (i+1)*Math.Pow(x,i)/(i+2);
                v += p;
            }
            Console.WriteLine(v);
        }
    }
}
