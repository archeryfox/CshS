using System;
namespace Tortics
{
    public class Order
    {
        //дефолт конструктор, пока не трогать
        public string Form = "";
        public int Size = 0;
        public string Taste = "";
        public int Amount = 1;
        public string Glaze = "";
        public Decor Decor;

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

        public Order(int i)
        {
            Amount = i;
        }
        public Order(Decor decor, int amount, string view, string color, int size)
        {
            Decor = new Decor(amount, view, color, size);
        }
    }
}

