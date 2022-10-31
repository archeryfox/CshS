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

        static public int y = 2;
        static void Main()
        {
            c();
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
            bool inSubMenu = false;
            switch (key, y, inSubMenu)
            {
                case (ConsoleKey.Escape, not 99, false):
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
                case (ConsoleKey.Enter, 3,false):
                    inSubMenu = true;
                    c();
                    Console.WriteLine("Выбор Формы");
                    foreach (var punkt in Order.Forms)
                    {
                        Console.SetCursorPosition(2, Order.Forms.IndexOf(punkt) + 1);
                        Console.WriteLine(punkt);
                    }
                    while(inSubMenu)
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
                                Cursor(key);
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
                                Main();
                                break;
                        }

                        Console.SetCursorPosition(Order.Forms[y-1].Length+2, y);
                        Console.Write(" <" + y);
                    }

                    break;
            }
            Console.SetCursorPosition(0, y);
            Console.Write(">"+ y);

        }
    }
}