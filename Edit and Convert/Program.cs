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
using System.Threading;

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
            Console.WriteLine("Нажмите F1 - сохранить файл, F2 - Загрузить файл (L),\nF3 - Запустить конструктор модели, Q - Как создать файл шаблона?");
            ConsoleKey consoleKey = Console.ReadKey(true).Key;
            if (consoleKey == ConsoleKey.L)
            {
                Model.somelist = new List<Model>() { new Model("Test name", "test descr", "firld troololo"),
                    new Model("2Test name2", "test desc2r2", "2firld troololo2") };
                Console.WriteLine("Стандарт загружен");
                Thread.Sleep(1000);
            }
            if (consoleKey == ConsoleKey.Q)
            {
                Console.WriteLine(" 1. Создать файл `имя_файла.txt`" +
                                  "\n 2. Чтобы создать объект надо заполнить три строчки по следующему образцу:" +
                                  "\n  Имя модели" +
                                  "\n  Описание" +
                                  "\n  Свойство" +
                                  "\n Чтобы создать список из объектов, оформляйте так:" +
                                  "\n  Имя модели1" +
                                  "\n  Описание1" +
                                  "\n  Свойство1" +
                                  "\n  Имя модели2" +
                                  "\n  Описание2" +
                                  "\n  Свойство2" +
                                  "\n Либо воспользуетесь конструктором модели");
                Console.ReadKey();
            }
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
                Console.WriteLine("Перетащите ФАЙЛ или Введите путь до ФАЙЛА:");
                try
                {
                    do
                    {
                        Program.way = $@"{Console.ReadLine().Replace("\"", "")}";
                        if (!Program.way.Contains("."))
                        {
                            Console.WriteLine("Вы не можете десериализовать папку! Укажите ФАЙЛ");
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
            else if (consoleKey == ConsoleKey.F3)
            {
                Editor.ObjectEditor(Model.somelist);
            }
            format = "";
            Main(args);
        }
    }
}
