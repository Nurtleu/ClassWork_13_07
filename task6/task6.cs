using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task6
{
    class Programm
    {
        static void Main(string[] args)
        {
            int num = 9999;
            WriteLine("Введите четырехзначный номер:");
            string  str = ReadLine();
            int abs = Int32.Parse(str);

            WriteLine("\nСумма его цифр: " + (abs / num) + (abs % num));
            WriteLine("Произведение его цифр:" + (abs * num));
            ReadLine();
        }
    }
}
