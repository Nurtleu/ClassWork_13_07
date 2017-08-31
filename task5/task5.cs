using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task5
{
    class Programm
    {
        /*5.	Дано двузначное число. Найти:
            a.	число десятков в нем;
            b.	число единиц в нем;
            c.	сумму его цифр;
            d.	произведение его цифр;
        */
        static void Main(string[] args)
        {
            int num = 10;
            WriteLine("Введите двузначный номер: ");
            string str = ReadLine();
            int abs = Int32.Parse(str);

            WriteLine("Число десятков в нем: " + (abs / num));
            WriteLine("Количество единиц в нем: " + (abs % num));
            WriteLine("Сумма его цифр: " + (abs / num) + (abs % num));
            WriteLine("Произведение его цифр:" + (abs * num));
            ReadLine();
        }
    }
}
