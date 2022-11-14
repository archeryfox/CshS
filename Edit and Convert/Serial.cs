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
    /// Класс, отвечающиий за сериализацию данных
    /// </summary>
    public static class Serial
    {
        public static void TXTer(Model sender)
        {
            string _r = File.ReadAllText(Program.path + "\\x.txt");
            if (_r[0] != ' ')
            {
                File.WriteAllText(Program.path + "\\x.txt", $"{sender.Name}\n{sender.Description}\n{sender.Field1}");
            }
            else
            {
                File.AppendAllText(Program.path + "\\x.txt", $"\n{sender.Name}\n{sender.Description}\n{sender.Field1}");
            }
        }
        public static void TXTer(List<Model> sender)
        {
            var i = 0;
            foreach (var item in sender)
            {
                if (i == 0)
                {
                    File.WriteAllText(Program.path + "\\x.txt", $"{item.Name}\n{item.Description}\n{item.Field1}");
                }
                else 
                {
                    File.AppendAllText(Program.path + "\\x.txt", $"\n{item.Name}\n{item.Description}\n{item.Field1}");
                }
                i++;
            }

        }
        public static void JSONer(Model sender)
        {
           File.AppendAllText(Program.path + "\\x.json", JsonConvert.SerializeObject(sender));
        }
        public static void JSONer(List<Model> sender)
        {
            File.WriteAllText(Program.path + "\\x.json", JsonConvert.SerializeObject(sender));
        }
        public static void XMLer(List<Model> sender)
        {
            using (var f = new FileStream(Program.path + "\\x.xml", FileMode.OpenOrCreate))
            {
               new XmlSerializer(typeof(List<Model>)).Serialize(f, sender);
            }
        }
        public static void XMLer(Model sender)
        {
            using (var f = new FileStream(Program.path + "\\x.xml", FileMode.OpenOrCreate))
            {
                new XmlSerializer(typeof(Model)).Serialize(f, sender);
            }
        }
    }
}
