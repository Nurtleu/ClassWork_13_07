using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task7
{
    class Programm
    {
        static void Main(string[] args)
        {
            Write("Введите число: ");
            string num = ReadLine();
            int num1 = Int32.Parse(num);
            WriteLine(num);

            int num2 = num1 / 100;
            int num3 = (num1 - (num2 * 100)) / 10;
            int num4 = num1 - (num2 * 100) - (num3 * 10);

            Write("ответ : ");
            WriteLine((num2 * 100) + (num4 * 10) + num3);

            ReadLine();
        }
    }
}
