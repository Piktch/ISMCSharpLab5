using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a,a4,a6,a7,a8,a9,a10,a13,a15,a21,a28,a64;
            Console.Write("Enther a:");
            a = Double.Parse(Console.ReadLine());
            a4 = a * a;
            a4 *= a4;
            //-----------------------
            a6 = a * a * a;
            a6 *= a6;
            //------------------------
            a7 =a6 * a;
            //--------------------------
            a8 = a4 * a4;
            //--------------------
            a9 = a8 * a;
            //-------------------------
            a10 = a4 * a6;
            //---------------------------
            a13 = a10 * a * a * a; 
            //--------------------------
            a15 = a * a; a15 = a15 * a15 * a15; a15 *= a15; a15 /= a;
            //------------------------
            a21 = a * a; a21 = a21 * a21 * a21; a21 /= a; a21 = a21 * a21 * a21;
            //---------------------------------------
            a28 = a * a; a28 = a28 * a28 * a28 * a; a28 *= a28; a28 *= a28;
            //--------------------------------------
            a64 = a * a; a64 *= a64; a64 *= a64; a64 *= a64; a64 *= a64; a64 *= a64;
            Console.WriteLine("\na^4="+ a4 +"\na^6="+ a6 +"\na^7="+ a7 +"\na^8="+ a8 +"\na^9="+ a9 +"\na^10="+ a10);
            Console.WriteLine("\na^13=" + a13 + "\na^15=" + a15 + "\na^21=" + a21 + "\na^28=" + a28 + "\na^64=" + a64);
        }
    }
}
