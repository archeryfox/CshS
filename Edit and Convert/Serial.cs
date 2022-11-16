using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Edit_and_Convert
{
    /// <summary>
    /// Класс, отвечающиий за сериализацию данных. ДАННЫЕ В ТЕКСТ
    /// </summary>
    public static class Serial
    {
        private static void TXTer(List<Model> sender)
        {
            var i = 0;
            foreach (var item in sender)
            {
                if (i == 0)
                {
                    File.WriteAllText(Program.way + $"\\{Program.name}.txt", $"{item.Name}\n{item.Description}\n{item.Field}");
                }
                else
                {
                    File.AppendAllText(Program.way + $"\\{Program.name}.txt", $"\n{item.Name}\n{item.Description}\n{item.Field}");
                }
                i++;
            }
        }
        private static void JSONer(List<Model> sender)
        {
            File.WriteAllText(Program.way + $"\\{Program.name}.json", JsonConvert.SerializeObject(sender));
        }
        private static void XMLer(List<Model> sender)
        {
            File.WriteAllText(Program.way + $"\\{Program.name}.xml", "");
            using (var f = new FileStream(Program.way + $"\\{Program.name}.xml", FileMode.OpenOrCreate))
            {
                new XmlSerializer(typeof(List<Model>)).Serialize(f, sender);
            }
        }
        public static void Export(List<Model> sender)
        {
            Console.WriteLine("Введите путь папки, в которой будет лежать файл:");
            try
            {
                Program.way = $@"{Console.ReadLine()}";
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Повторите ввод пути, путь некоректен");
                Console.ReadKey();
            }
            Console.Write("Введите имя файла: ");
            Program.name = Console.ReadLine();
            var format = Program.format;
            while (format != "txt" && format != "json" && format != "xml")
            {
                Console.WriteLine("Введите формат.");
                format = Console.ReadLine();
            }
            switch (format.ToLower()
                .Replace(" ", "")
                .Replace(".", ""))
            {
                case "txt":
                    TXTer(sender);
                    break;
                case "json":
                    JSONer(sender);
                    break;
                case "xml":
                    XMLer(sender);
                    break;
            }
            Console.WriteLine($"Ваш файл успешно сохранён в {Program.way}{Program.name}" +
                $".{format.ToLower().Replace(" ", "").Replace(".", "")}!");
        }
    }
}
