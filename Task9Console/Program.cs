using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a,n;
            Double x = 2;
            Double vidst=0,zah=0;
            n = Double.Parse(Console.ReadLine());

            for (Double i = 2; i < n; i+=2)
            {
                vidst += (1.0 / i)-(1.0/(i+1));
                zah += (1.0 / i) + (1.0 / (i + 1));
            }
            Console.WriteLine("Vidtan do domu=" + vidst);
            Console.WriteLine("Zahalna Vidtan=" + zah);
        }
    }
}
