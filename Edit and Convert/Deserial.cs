using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Edit_and_Convert
{
    /// <summary>
    /// Класс, отвечающиий за десериализацию данных. ИЗ ТЕКСТА В ДАННЫЕ
    /// </summary>
    public static class Deserial
    {
         static void TXTer()
        {
            Console.WriteLine(File.ReadAllText(Program.desktop + "\\x.txt"));
        }
         static List<Model> JSONer()
        { 
            List<Model> _arj = JsonConvert.DeserializeObject<List<Model>>(
                File.ReadAllText(Program.desktop + "\\x.json"));
            foreach (var item in _arj)
            {
                Console.WriteLine($"{item.Name}\n{item.Description}\n{item.Field}");
            }
            return _arj;
        }
         static List<Model> XMLer()
        {
            using (var j = new FileStream(Program.desktop + "\\x.xml", FileMode.Open))
            {
                List<Model> _arx = (List<Model>)new XmlSerializer(typeof(List<Model>)).Deserialize(j);
                foreach (var item in _arx)
                {
                    Console.WriteLine($"{item.Name}\n{item.Description}\n{item.Field}");
                }
                return _arx;
            }

        }
        /// <summary>
        /// Вытягивание объектов из файла\ов
        /// </summary>
        public static List<Model> Import()
        {
            switch (Program.format.ToLower()
                .Replace(" ", "")
                .Replace(".", ""))
            {
                case "txt":
                   TXTer();
                    break;

                case "json":
                    return JSONer();

                case "xml":
                    return XMLer();
            }
            return new List<Model>();
        }
    }
}
