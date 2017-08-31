using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task8
{
    class Programm
    {
        static void Main(string[] args)
        {
            WriteLine("Введите 1-логическое число X: ");
            String strOne = ReadLine();
            bool bool1 = Boolean.Parse(strOne);

            WriteLine("Введите 2-логическое число Y: ");
            String strTwo = ReadLine();
            bool bool2 = Boolean.Parse(strTwo); ;

            Write("!X && !Y = ");
            WriteLine(!bool1 && !bool2);

            Write("X || (!X && Y) =");
            WriteLine(bool1 || (!bool1 && bool2));

            Write("(!X && Y) || Y = ");
            WriteLine((!bool1 && bool2) || bool2);

            ReadLine();

        }
    }
}
