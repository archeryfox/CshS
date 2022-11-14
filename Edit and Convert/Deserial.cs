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
    /// Класс, отвечающиий за десериализацию данных
    /// </summary>
    public static class Deserial
    {
        public static void TXTer()
        {
            Console.WriteLine(File.ReadAllText(Program.path + "\\x.txt"));
        }
        public static object JSONer()
        {
            using (var f = new FileStream(Program.path + "\\x.json", FileMode.Open))
            {
                return JsonConvert.DeserializeObject<List<Model>>(Program.path);
            }
        }
        public static void XMLer(List<Model> sender)
        {
            using (var f = new FileStream(Program.path + "\\x.xml", FileMode.Open))
            {
                new XmlSerializer(typeof(List<Model>)).Deserialize(f);
            }
        }
    }
}
