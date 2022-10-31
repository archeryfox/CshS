using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Cakes
{
    public class Order
    {
        //дефолт конструктор, пока не трогать
        static string Form = "";
        static int Size = 0;
        static string Taste = "";
        static int Amount = 1;
        static string Glaze = "";


        public string form = "";
        public int size = 0;
        public string taste = "";
        public int amount = 1;
        public string glaze = "";
        public int Price = 0;
        static string cur = "(+)";
        static public List<string> Forms = new List<string>() 
        {"Стандарт - 100р", "Тыква - 90р", "Квадрат - 200р", "Рыба - 300р" };

        public static List<string> Sizes = new List<string>() 
        {"Кекс - 50р", "Маленький - 70р", "Обычный - 100р", "Рыба - 200р"};

        public static List<string> Tastes = new List<string>() 
        { "Морковный - 60р", "Крем - 70р", "Шоколад - 100", "Клубника - 200р" };

        public static List<string> Amounts = new List<string>()
        {"1 коржик 20р", "2 коржика - 40р", "3 кота 3 хвоста - 50р", "все 4 стихии - 80р"};

        public static List<string> Glazes = new List<string>() 
        {"Розовая - 30р", "Тыква - 20р", "Майнкрафт - 35р", "Рыба - 50р"};
        public static List<Order> Box = new List<Order>{ };
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
                $"Я закончил"+n);
            Console.Write("Ваш заказ:");
            if (Box.Count!=0)
            {
                Console.Write($" {Box[0].form}");

            }
        }

        public Order()
        {
                    
        }
        public Order(int amount = 0, string view ="", string taste="", int size=0, int price = 0)
        {
            form = view;
            this.amount = amount;
            this.taste = taste;
            this.size = size;
            this.Price = price;
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

