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
        public static string desktop = $@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}";
        /// <summary>
        /// Формат файла
        /// </summary>
        public static string format;
        /// <summary>
        /// Имя файла
        /// </summary>
        public static string name;
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
            var a = new Model("Ростик", "кv4", 854386);
            var v = new Model("sd", "бордовый", 12);
            arsd.Add(a);
            arsd.Add(v);
            while (format != "txt" && format != "json" && format != "xml")
            {
                Console.WriteLine("Введите формат.");
                format = Console.ReadLine();
            }
            Console.WriteLine("1 - ser 2.. des");
            if (Console.ReadLine() == "1")
            {
            Serial.Export(arsd);
            }
            else
            {
                if (File.Exists(desktop+$"\\x.{format}"))
                {
                    Deserial.Import();
                }
                else
                {
                    Console.WriteLine($"Файл {desktop + $"\\x.{format}"} не существует!!!");
                }
            }
            format = "";
            arsd.Clear();   
            Main(args);
            
        }

        /// <remarks></remarks>
        public static string InpFormat;
    }
}
