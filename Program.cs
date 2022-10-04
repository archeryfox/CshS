using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW2_3in1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t▒▓▒▓▒▓▒▓▒▓▒▓─▄▀▀▀▄\r\n\t─██▀████▀██──▀▄▀──█\r\n\tO▀████████▀O─────█\r\n\t───▀█▄▄█▀────────█\r\n\t──▓▒▓▒▓▒▓▒───────█\r\n");
            Console.WriteLine("\tПрограмка 3 в 1\n    1. Игра \"Угадай число\"\r\n  " +
                "  2. Таблица умножения\r\n  " +
                "  3. Вывод делителей числа");
            Console.Write("\n\tВыбери действие - ");
            int act;
            do
            {
             act = int.Parse(Console.ReadLine());
                switch (act)
                {
                    case 1:
                        WhatANum();
                        break;
                    case 2:
                        MultiplationTable();
                        break;
                    case 3:
                        Divider();
                        break;
                    case 4:
                        break;
                }                               
            } while (act>0 && act<=4);
        }
        static void WhatANum()
        {
            Console.WriteLine(" ???");
            return;
        }
        static void MultiplationTable()
        {

        }
        static void Divider()
        {

        }
    }
}
