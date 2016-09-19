using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть рік: ");
            int n=int.Parse(Console.ReadLine());
            if (n % 4 == 0 && n % 100 != 0 || n % 400 == 0)
            { Console.WriteLine("Це високосний рік"); }
            else
            { Console.WriteLine("Це не високосний рік"); }
        }
    }
}
