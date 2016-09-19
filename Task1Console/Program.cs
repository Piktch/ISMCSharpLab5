using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x, y,zn,z,zn2,q;
            Console.Write("Enther x:");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Enther y:");
            y = Double.Parse(Console.ReadLine());
            zn=x+(2+y)/(x*x);
            zn2=y+(1/Math.Sqrt(x*x+10));    
            q=2.8*Math.Sin(x)+Math.Abs(y);
            Console.WriteLine("Z="+(zn/zn2)+"\nQ="+q);

        }
    }
}
