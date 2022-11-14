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
        public static string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}";
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
            var v = new Model("Влад", "бордовый", 12);
            arsd.Add(a);
            arsd.Add(v);
            Serial.XMLer(arsd);
            Serial.JSONer(arsd);
            Serial.TXTer(arsd);
            Console.WriteLine(path);
            Deserial.TXTer();
        }

    }
}
