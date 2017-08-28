using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task3
{
    class task3
    {
        static void Main(string[] args)
        {
            WriteLine("Введите число в сантиметрах:");
            string str = ReadLine();
            int sm = Int32.Parse(str);

            Write("\nВ" + str + "сантиметрах" + sm / 100 + "метров");
            ReadLine();
        }
    }
}
