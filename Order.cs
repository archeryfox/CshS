using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tortics
{
    public class Order
    {
        //дефолт конструктор, пока не трогать
        string Form = "";
        int Size = 0;
        string Taste = "";
        int Amount = 1;
        string Glaze = "";
        public Decor Decor;
        static string cur = "(+)";
        public static List<string> Forms = new List<string>() {"Стандарт", ""};
        static public void MenuL0()
        {
            var n = "\n  ";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($" Велком ту Кирби Кафетерий!!" +
                $"\n Выберите компоненты торта:\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 40; i++)
            {
                Console.Write("=");
            }
            Console.SetCursorPosition(2, 4 - 1);
            Console.Write($"Форма" + n +
                $"Размер" + n +
                $"Вкус" + n +
                $"Количество коржиков" + n +
                $"Глазурь" + n +
                $"Декор" + n + 
                $"Я закончил");
        }


        public Order(int amount, string view, string taste, int size)
        {
            Form = view;
            Amount = amount;
            Taste = taste;
            Size = size;
        }
        public Order(Decor decor, int amount, string view, string taste, string color, int size, int DecAmount, string DecColor, string DecForm)
        {
            Amount = amount;
            Form = view;
            Taste = taste;
            Size = size;
            decor = new Decor(DecAmount, DecColor, DecForm);
        }
    }
}

