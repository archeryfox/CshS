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
        public static string way = $@"";
        public static string format;
        /// <summary>
        /// Имя файла
        /// </summary>
        public static string name = "";

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
            c();
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Нажмите F1 - сохранить файл, F2 - Загрузить файл");
            ConsoleKey consoleKey = Console.ReadKey(true).Key;
            if (consoleKey == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else if (consoleKey == ConsoleKey.F1)
            {
                if (Model.somelist.Count == 0)
                {
                    Console.WriteLine("Нет загруженного шаблона, загрузите какой либо шаблон чтобы его скопировать!");
                    Console.WriteLine("Всё равно экспортировать пустой файл?(Y/N)");    
                    ConsoleKey consoleKey1 = Console.ReadKey(true).Key;
                    if (consoleKey1 == ConsoleKey.Y)
                    {
                        Serial.Export(Model.somelist);
                    }
                    else if (consoleKey1 == ConsoleKey.N)
                    {
                        Main(args);
                    }
                }
                else
                {
                    Serial.Export(Model.somelist);
                }

            }
            else if (consoleKey == ConsoleKey.F2)
            {
                Console.WriteLine("Перетащите файл или Введите путь до файла:");
                try
                {
                    do
                    {
                        Program.way = $@"{Console.ReadLine().Replace("\"", "")}";
                        if (!Program.way.Contains("."))
                        {
                            Console.WriteLine("Вы не можете десериализовать папку! Укажите файл");
                        }
                    } while (!Program.way.Contains("."));
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Повторите ввод пути, путь некоректен");
                    Console.ForegroundColor = ConsoleColor.White;
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
            else
            {
                c();
            }
            format = "";
            Main(args);
        }
    }
}
