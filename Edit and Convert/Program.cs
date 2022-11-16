using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Resolvers;
using Newtonsoft.Json;

namespace Edit_and_Convert
{
    internal class Program
    {
        /// <summary>
        /// Дефолтный путь
        /// </summary>
        public static string way = $@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}";
        /// <summary>
        /// Формат файла
        /// </summary>
        public static string format;
        /// <summary>
        /// Имя файла
        /// </summary>
        public static string name = "";
        static List<Model> arsd = Model.somelist;

        delegate void del();

        /// <summary>
        /// Пустая строка
        /// </summary>
        static del e = Console.WriteLine;

        /// <summary>
        /// Очистка
        /// </summary>
        static del c = Console.Clear;

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            var a = new Model("Ростик", "лиса", 854386);
            var v = new Model("Имя", "Описание", 12);
            arsd.Add(a);
            arsd.Add(v);
            
            Console.WriteLine("1 - ser 2.. des");
            ConsoleKey consoleKey = Console.ReadKey(true).Key;
            if (consoleKey == ConsoleKey.D1)
            {
                Serial.Export(arsd);
            }
            else if (consoleKey == ConsoleKey.D2)
            {
                way = Console.ReadLine().Replace("\"", "");
                if (File.Exists(way))
                {
                    Deserial.Import();
                }
                else
                {
                    Console.WriteLine($"Файл {way} не существует!!!");
                }
            }
            format = "";
            arsd.Clear();
            Main(args);

        }
    }
}
