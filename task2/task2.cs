using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task2
{
    class task2
    {
        static void Main(string[] args)
        {
            int R;
            WriteLine("Введите число: ");
            String str = ReadLine();
            int num = Int32.Parse(str);
            Write("Длина окружности: ");
            WriteLine(num * 3.14 * 2);
            Write("Площадь круга: ");
            WriteLine(num * num * 3.14);
           ReadLine();
        }
    }
}
