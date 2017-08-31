using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practica
{
    class Programm
    {
        static void Main(string[] args)
        {
            int x;
            //int y;
            Console.WriteLine("vvedite,x:");
            string number = ReadLine();
            int numX = Int32.Parse(number);
            int y = 7 * numX * numX - 3 * numX + 4;
            WriteLine("y=7x^2-3x+4 = " + y);
            ReadLine();
        }
    }
}
