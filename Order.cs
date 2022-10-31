using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
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
        public string size = "";
        public string taste = "";
        public string amount = "";
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
        public static List<Order> Box = new List<Order> { };
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
                $"Я закончил" + n);
            if (Box.Count != 0)
            {
            Console.WriteLine($"С вас: {Box[0].Price}");
                Console.Write("Ваш заказ:");
                string order = $" {Box[0].form}{Box[0].size}{Box[0].taste}{Box[0].amount}{Box[0].glaze}";
                Console.Write(order);
                Console.SetCursorPosition(order.Length + "Ваш заказ:".Length-2, 10);
                Console.Write("  ");
                
            }
        }

        public static void RenderCheck()
        {
            if (Box.Count != 0 )
            {
                string order = $" {Box[0].form}{Box[0].size}{Box[0].taste}{Box[0].amount}{Box[0].glaze}";
                if (Box[0].form != "" && Box[0].size != "" && Box[0].taste != "" && Box[0].amount != "" && Box[0].glaze != "")
                {
                    File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\заказ.txt", $"Заказ от {DateTime.Now}\r\n\tЗаказ: {order}\r\n\tЦена: {Box[0].Price} руб");
                }

            }
        }

        public Order()
        {

        }
        public Order(string amount = "", string view = "", string taste = "", string size = "", int price = 0, string glaze = "")
        {
            form = view;
            this.amount = amount;
            this.taste = taste;
            this.size = size;
            this.Price = price;
            this.glaze = glaze;
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

