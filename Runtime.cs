using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cakes
{
    internal class Terminal
    {
        delegate void del();
        static del c = Console.Clear;

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

        static public int y = 3;
        static void Main()
        {
            Console.Title = "Кафешка";
            c();
            Console.CursorVisible = false;
            Order.MenuL0();
            Console.SetCursorPosition(0, y);
            Console.Write(">");
            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                Cursor(key);
            }

        }

        private static void Cursor(ConsoleKey key)
        {
            bool inSubMenu = false;
            if (y == 2 && key == ConsoleKey.UpArrow && !inSubMenu)
            {
                y++;
            }
            switch (key, y, inSubMenu)
            {
                case (ConsoleKey.Escape, not 99, false):
                    c();
                    System.Environment.Exit(0);
                    break;
                case (ConsoleKey.UpArrow, not 3, false):
                    int yb = y;
                    y--;
                    Console.SetCursorPosition(0, yb);
                    Console.Write("  ");
                    break;
                case (ConsoleKey.DownArrow, < 8, false):
                    int yb1 = y;
                    y++;
                    Console.SetCursorPosition(0, yb1);
                    Console.Write("  ");
                    break;
                case (ConsoleKey.Enter, 3, false):
                    int yL0 = y;
                    inSubMenu = true;
                    c();

                    Console.WriteLine("Выбор Формы");
                    foreach (var punkt in Order.Forms)
                    {
                        Console.SetCursorPosition(2, Order.Forms.IndexOf(punkt) + 1);
                        Console.WriteLine(punkt);
                    }
                    y = 1;
                    Console.SetCursorPosition(Order.Forms[y - 1].Length + 2, y);
                    Console.Write(" <" + y);
                    while (inSubMenu)
                    {
                        int x = Order.Forms[y - 1].Length + 2;
                        key = Console.ReadKey(true).Key;
                        switch (key, y)
                        {
                            case (ConsoleKey.UpArrow, not 1):
                                int yb11 = y;
                                y--;
                                Console.SetCursorPosition(x, yb11);
                                Console.Write("     ");
                                break;
                            case (ConsoleKey.DownArrow, < 4):
                                int yb111 = y;
                                y++;
                                Console.SetCursorPosition(x, yb111);
                                Console.Write("    ");
                                break;
                            case (ConsoleKey.Escape, not 999):
                                y = 3;
                                Main();
                                break;
                            case (ConsoleKey.Enter, not 999):
                                if (Order.Box.Count == 0)
                                {

                                    Order.Box.Add(new Order(
                                        view: new Components(Order.Forms[y - 1]).Detail,
                                        price: new Components(Order.Forms[y - 1]).Price)
                                        );
                                }
                                else
                                {
                                    Order.Box[0].form = new Components(Order.Forms[y - 1]).Detail;
                                    Order.Box[0].Price += new Components(Order.Forms[y - 1]).Price;
                                }
                                inSubMenu = false;
                                y = yL0;
                                Main();
                                break;
                        }

                        Console.SetCursorPosition(Order.Forms[y - 1].Length + 2, y);
                        Console.Write(" <" + y);
                    }
                    break;
                case (ConsoleKey.Enter, 4, false):
                    inSubMenu = true;
                    c();
                    Console.WriteLine("Выбор Размера");
                    foreach (var punkt in Order.Sizes)
                    {
                        Console.SetCursorPosition(2, Order.Sizes.IndexOf(punkt) + 1);
                        Console.WriteLine(punkt);
                    }
                    y = 1;
                    while (inSubMenu)
                    {
                        int x = Order.Sizes[y - 1].Length + 2;
                        key = Console.ReadKey(true).Key;
                        switch (key, y)
                        {
                            case (ConsoleKey.UpArrow, not 1):
                                int yb11 = y;
                                y--;
                                Console.SetCursorPosition(x, yb11);
                                Console.Write("     ");
                                break;
                            case (ConsoleKey.DownArrow, < 4):
                                int yb111 = y;
                                y++;
                                Console.SetCursorPosition(x, yb111);
                                Console.Write("    ");
                                break;
                            case (ConsoleKey.Escape, not 999):
                                y = 3;
                                Main();
                                break;
                            case (ConsoleKey.Enter, not 999):
                                if (Order.Box.Count == 0)
                                {

                                    Order.Box.Add(new Order(
                                        size: new Components(Order.Sizes[y - 1]).Detail,
                                        price: new Components(Order.Sizes[y - 1]).Price)
                                        );
                                }
                                else
                                {
                                    Order.Box[0].size = new Components(Order.Sizes[y - 1]).Detail;
                                    Order.Box[0].Price += new Components(Order.Sizes[y - 1]).Price;
                                }
                                inSubMenu = false;
                                y = 3;
                                Main();
                                break;
                        }

                        Console.SetCursorPosition(Order.Sizes[y - 1].Length + 2, y);
                        Console.Write(" <" + y);
                    }
                    break;
                case (ConsoleKey.Enter, 5, false):
                    inSubMenu = true;
                    c();
                    Console.WriteLine("Выбор Вкусов");
                    foreach (var punkt in Order.Tastes)
                    {
                        Console.SetCursorPosition(2, Order.Tastes.IndexOf(punkt) + 1);
                        Console.WriteLine(punkt);
                    }
                    y = 1;
                    while (inSubMenu)
                    {
                        int x = Order.Tastes[y - 1].Length + 2;
                        key = Console.ReadKey(true).Key;
                        switch (key, y)
                        {
                            case (ConsoleKey.UpArrow, not 1):
                                int yb11 = y;
                                y--;
                                Console.SetCursorPosition(x, yb11);
                                Console.Write("     ");
                                break;
                            case (ConsoleKey.DownArrow, < 4):
                                int yb111 = y;
                                y++;
                                Console.SetCursorPosition(x, yb111);
                                Console.Write("    ");
                                break;
                            case (ConsoleKey.Escape, not 999):
                                Main();
                                break;
                            case (ConsoleKey.Enter, not 999):
                                if (Order.Box.Count == 0)
                                {

                                    Order.Box.Add(new Order(
                                        taste: new Components(Order.Tastes[y - 1]).Detail,
                                        price: new Components(Order.Tastes[y - 1]).Price)
                                        );
                                }
                                else
                                {
                                    Order.Box[0].taste = new Components(Order.Tastes[y - 1]).Detail;
                                    Order.Box[0].Price += new Components(Order.Tastes[y - 1]).Price;
                                }
                                inSubMenu = false;
                                y = 3;
                                Main();
                                break;
                        }

                        Console.SetCursorPosition(Order.Tastes[y - 1].Length + 2, y);
                        Console.Write(" <" + y);
                    }
                    break;
                case (ConsoleKey.Enter, 6, false):
                    inSubMenu = true;
                    c();
                    Console.WriteLine("Выбор количества коржей");
                    foreach (var punkt in Order.Amounts)
                    {
                        Console.SetCursorPosition(2, Order.Amounts.IndexOf(punkt) + 1);
                        Console.WriteLine(punkt);
                    }
                    y = 1;
                    while (inSubMenu)
                    {
                        int x = Order.Amounts[y - 1].Length + 2;
                        key = Console.ReadKey(true).Key;
                        switch (key, y)
                        {
                            case (ConsoleKey.UpArrow, not 1):
                                int yb11 = y;
                                y--;
                                Console.SetCursorPosition(x, yb11);
                                Console.Write("     ");
                                break;
                            case (ConsoleKey.DownArrow, < 4):
                                int yb111 = y;
                                y++;
                                Console.SetCursorPosition(x, yb111);
                                Console.Write("    ");
                                break;
                            case (ConsoleKey.Escape, not 999):
                                y = 3;
                                Main();
                                break;
                            case (ConsoleKey.Enter, not 999):
                                if (Order.Box.Count == 0)
                                {

                                    Order.Box.Add(new Order(
                                        taste: new Components(Order.Amounts[y - 1]).Detail,
                                        price: new Components(Order.Amounts[y - 1]).Price)
                                        );
                                }
                                else
                                {
                                    Order.Box[0].amount = new Components(Order.Amounts[y - 1]).Detail;
                                    Order.Box[0].Price += new Components(Order.Amounts[y - 1]).Price;
                                }
                                inSubMenu = false;
                                y = 3;
                                Main();
                                break;
                        }

                        Console.SetCursorPosition(Order.Amounts[y - 1].Length + 2, y);
                        Console.Write(" <" + y);
                    }
                    break;
                case (ConsoleKey.Enter, 7, false):
                    inSubMenu = true;
                    c();
                    Console.WriteLine("Выбор Глазури");
                    foreach (var punkt in Order.Glazes)
                    {
                        Console.SetCursorPosition(2, Order.Glazes.IndexOf(punkt) + 1);
                        Console.WriteLine(punkt);
                    }
                    y = 1;
                    while (inSubMenu)
                    {
                        int x = Order.Glazes[y - 1].Length + 2;
                        key = Console.ReadKey(true).Key;
                        switch (key, y)
                        {
                            case (ConsoleKey.UpArrow, not 1):
                                int yb11 = y;
                                y--;
                                Console.SetCursorPosition(x, yb11);
                                Console.Write("     ");
                                break;
                            case (ConsoleKey.DownArrow, < 4):
                                int yb111 = y;
                                y++;
                                Console.SetCursorPosition(x, yb111);
                                Console.Write("    ");
                                break;
                            case (ConsoleKey.Escape, not 999):
                                y = 3;
                                Main();
                                break;
                            case (ConsoleKey.Enter, not 999):
                                if (Order.Box.Count == 0)
                                {

                                    Order.Box.Add(new Order(
                                        glaze: new Components(Order.Glazes[y - 1]).Detail,
                                        price: new Components(Order.Glazes[y - 1]).Price)
                                        );
                                }
                                else
                                {
                                    Order.Box[0].glaze = new Components(Order.Glazes[y - 1]).Detail;
                                    Order.Box[0].Price += new Components(Order.Glazes[y - 1]).Price;
                                }
                                inSubMenu = false;
                                y = 3;
                                Main();
                                break;
                        }

                        Console.SetCursorPosition(Order.Glazes[y - 1].Length + 2, y);
                        Console.Write(" <");
                    }
                    break;
                case (ConsoleKey.Enter, 8, false):
                    Order.RenderCheck();
                    break;
            }
            if (y != 2 && key != ConsoleKey.Enter && !inSubMenu)
            {
                Console.SetCursorPosition(0, y);
                Console.Write(">");

            }

        }
    }
}