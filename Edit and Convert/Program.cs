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
            Console.WriteLine("Нажмите F1 - сохранить файл, F2 - Загрузить файл");
            ConsoleKey consoleKey = Console.ReadKey(true).Key;
            if (consoleKey == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            if (consoleKey == ConsoleKey.F1)
            {
                Serial.Export(arsd);
            }
            if (consoleKey == ConsoleKey.F2)
            {
                Console.WriteLine("Введите путь до файла:");
                try
                {
                    way = Console.ReadLine().Replace("\"", "");
                }
                catch (Exception)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Повторите ввод пути, путь некоректен");
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.ReadKey();
                }
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
            Main(args);
        }
    }
}
