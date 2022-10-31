using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tortics;

namespace Cakes
{
    internal class Terminal
    {

        /// <summary>
        /// Более комфортный путь создания торта через конструктор
        /// </summary>
        /// <param name="amount">Количество деталек декора</param>
        /// <param name="view">Вид деталей</param>
        /// <param name="color">Цвет деталей</param>
        /// <param name="size">Введите размер деталек декора</param>
        /// <returns>Объект сразу с декором</returns>
        static Order OrderDecor(int DecAmount, string DecColor, string taste, string DecForm, int amount = 0, string view = "", string color = "", int size = 0)
        {
            return new Order(new Decor(), amount, view, taste, color, size, DecAmount, DecColor, DecForm);
        }

        static public int y = 2;
        static void Main()
        {
            Console.CursorVisible = false;
            Order.MenuL0();
            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                Cursor(key);
            }

        }

        private static void Cursor(ConsoleKey key)
        {
            switch (key, y)
            {
                case (ConsoleKey.Escape, not 99):
                    System.Environment.Exit(0);
                    break;
                case (ConsoleKey.UpArrow, not 3):
                    int yb = y;
                    y--;
                    Console.SetCursorPosition(0, yb);
                    Console.Write("  ");
                    break;
                case (ConsoleKey.DownArrow, < 8):
                    int yb1 = y;
                    y++;
                    Console.SetCursorPosition(0, yb1);
                    Console.Write("  ");
                    break;
            }
            Console.SetCursorPosition(0, y);
            Console.Write(">");

        }
    }
}