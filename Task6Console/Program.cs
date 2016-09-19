using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, d;
            Console.Write("Введите масть: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Введите достоинство: ");
            d = int.Parse(Console.ReadLine());
            if(d>10 && d< 15)
            switch (d)
            {
                case 11:
                    Console.Write("Валет ");
                    break;
                case 12:
                    Console.Write("Дама ");
                    break;
                case 13:
                    Console.Write("Король ");
                    break;
                case 14:
                    Console.Write("Туз ");
                    break;
                default:
                    Console.Write("Не коректные данные ");
                    break;
            }
            else
                Console.Write(d+ " ");
            switch (m)
            { 
                case 1:
                    Console.Write("Пики ");
                    break;
                case 2:
                    Console.Write("Трефы ");
                    break;
                case 3:
                    Console.Write("Бубны ");
                    break;
                case 4:
                    Console.Write("Червы ");
                    break;
                default:
                    Console.Write("Не коректные данные ");
                    break;
            }
        }
    }
}
