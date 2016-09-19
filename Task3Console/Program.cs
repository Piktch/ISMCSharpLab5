using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            int o = 0, d = 0, sc = 0, dob = 1;
            while (a > 0)
            {
                d++;
                sc += a % 10;
                dob *= a % 10;
                if (a % 10 == 1)
                    o++;
                a /= 10;
            }
            Console.WriteLine("Число одиниць: "+o+"\nЧисло десятків: "+d+"\nСума цифр: "+sc+"\nДобуток: "+dob);
        }
    }
}
