using System;

namespace PW2_3in1
{
    internal class Program
    {
        static int YourNum;
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t▒▓▒▓▒▓▒▓▒▓▒▓─▄▀▀▀▄\r\n\t─██▀████▀██──▀▄▀──█\r\n\tO▀████████▀O─────█\r\n\t───▀█▄▄█▀────────█\r\n\t──▓▒▓▒▓▒▓▒───────█\r\n");
            Console.WriteLine("\tПрограмка 3 в 1\n  " +
                "  1. Игра \"Угадай число\"\r\n  " +
                "  2. Таблица умножения\r\n  " +
                "  3. Вывод делителей числа\n" +
                "    4. Выйти");
            int act;
            do
            {
            Console.Write("\n\tВыбери действие - ");
                while (!int.TryParse(Console.ReadLine(), out act))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Введено не число! Повторите ввод ");
                    Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                while (act < 0 || act > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Введено число меньше 0 или больше 4! Повторите ввод");
                    Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                    int.TryParse(Console.ReadLine(), out act);
                }
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
                }
            } while (act > 0 && act < 4);

        }
        
        static void WhatANum()
        {
            Console.Write(" Отгадайте число от 1 до 100(включительно): ");
            
            Random ElRandom = new Random();
            var RandomNum = ElRandom.Next(1, 101);
            while (!int.TryParse(Console.ReadLine(), out YourNum))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Введено не число! Повторите ввод ");
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            while (YourNum < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Введено число меньше 0! Повторите ввод");
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.White;
                int.TryParse(Console.ReadLine(), out YourNum);
            }
            while (YourNum > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Введено число больше 100! Повторите ввод");
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.White;
                int.TryParse(Console.ReadLine(), out YourNum);
            }
            while (YourNum != RandomNum)
            {

                if (YourNum > RandomNum)
                {
                   
                    Console.WriteLine($" {YourNum} гораздо больше чем загаданное число." +
                        "\n Повторите ввод!");
                    Console.Write(" ");
                    int.TryParse(Console.ReadLine(), out YourNum);
                }
                else if (YourNum < RandomNum)
                {
                   
                    Console.WriteLine($" {YourNum} гораздо меньше чем загаданное число." +
                        $"\n Повторите ввод!");
                    Console.Write(" ");
                    int.TryParse(Console.ReadLine(), out YourNum);
                }
            }
            if (YourNum == RandomNum)
            {
                Console.WriteLine(" Вы угадали!\n");
            return;
            }
        }
        static void MultiplationTable()
        {
            int[,] Table = new int[10,10];

        }
        static void Divider()
        {

        }
    }
}
