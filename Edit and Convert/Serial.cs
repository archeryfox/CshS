using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Edit_and_Convert
{
    /// <summary>
    /// Класс, отвечающиий за сериализацию данных. ДАННЫЕ В ТЕКСТ
    /// </summary>
    public static class Serial
    {
        /// <summary>
        /// Сериализация одного 
        /// </summary>
        /// <param name="sender"></param>
        private static void TXTer(Model sender)
        {
            string _r = File.ReadAllText(Program.desktop + "\\x.txt");
            if (_r[0] != ' ')
            {
                File.WriteAllText(Program.desktop + "\\x.txt", $"{sender.Name}\n{sender.Description}\n{sender.Field}");
            }
            else
            {
                File.AppendAllText(Program.desktop + "\\x.txt", $"\n{sender.Name}\n{sender.Description}\n{sender.Field}");
            }
        }
        private static void TXTer(List<Model> sender)
        {
            var i = 0;
            foreach (var item in sender)
            {
                if (i == 0)
                {
                    File.WriteAllText(Program.desktop + "\\x.txt", $"{item.Name}\n{item.Description}\n{item.Field}");
                }
                else 
                {
                    File.AppendAllText(Program.desktop + "\\x.txt", $"\n{item.Name}\n{item.Description}\n{item.Field }");
                }
                i++;
            }

        }
        private static void JSONer(Model sender)
        {
           File.AppendAllText(Program.desktop + "\\x.json", JsonConvert.SerializeObject(sender));
        }
        private static void JSONer(List<Model> sender)
        {
            File.WriteAllText(Program.desktop + "\\x.json", JsonConvert.SerializeObject(sender));
        }
        private static void XMLer(List<Model> sender)
        {
            File.WriteAllText(Program.desktop + "\\x.xml", "");
            using (var f = new FileStream(Program.desktop + "\\x.xml", FileMode.OpenOrCreate))
            {
               new XmlSerializer(typeof(List<Model>)).Serialize(f, sender);
            }
        }
        public static void XMLer(Model sender)
        {
            using (var f = new FileStream(Program.desktop + "\\x.xml", FileMode.OpenOrCreate))
            {
                new XmlSerializer(typeof(Model)).Serialize(f, sender);
            }
        }
        public static void Export(List<Model> sender)
        {
            switch (Program.format.ToLower()
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
        }
    }
}
