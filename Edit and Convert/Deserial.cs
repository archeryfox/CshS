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
        static List<Model> TXTer()
        {
            List<Model> list = new List<Model>();
            if (File.Exists(Program.way))
            {
                var mslist = Model.somelist;
                string[] str = File.ReadAllLines(Program.way);
                for (int i = 0; i < Math.Truncate((double)str.Length / 3); i++)
                {
                    string name = "";
                    string des = "";
                    string f = "";
                    if (i == 0)
                    {
                        if (str[0] == "")
                        {
                            Console.WriteLine("Файл пуст!");
                        }
                        name = str[0];
                        des = str[1];
                        f = str[2];
                    }
                    else
                    {
                        name = str[3 * i];
                        des = str[3 * i + 1];
                        f = str[3 * i + 2];
                    }
                    list.Add(new Model(name, des, f));
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
            Model.somelist = list;
            slep();
            return list;
        }
        static List<Model> JSONer()
        {
            List<Model> _arj = JsonConvert.DeserializeObject<List<Model>>(
                File.ReadAllText(Program.way));
            if (_arj.Count == 0)
            {
                Console.WriteLine("Файл пуст!");
            }
            foreach (var item in _arj)
            {
                Console.WriteLine($"{item.Name}\n{item.Description}\n{item.Field}");
            }
            Model.somelist = _arj;
            slep();
            return _arj;
        }
        static List<Model> XMLer()
        {
            using (var j = new FileStream(Program.way, FileMode.Open))
            {
                List<Model> _arx = (List<Model>)new XmlSerializer(typeof(List<Model>)).Deserialize(j);
                if (_arx.Count == 0)
                    Console.WriteLine("Файл пуст");
                foreach (var item in _arx)
                {
                    Console.WriteLine($"{item.Name}\n{item.Description}\n{item.Field}");
                }
                Model.somelist = _arx;
                slep();
                return _arx;
            }


        }

        /// <summary>
        /// Вытягивание объектов из файла\ов
        /// </summary>
        public static List<Model> Import()
        {
            if (Program.way.Contains(".txt"))
            {
                return TXTer();
            }
            if (Program.way.Contains(".json"))
            {
                return JSONer();
            }
            if (Program.way.Contains(".xml"))
            {
                return XMLer();
            }
            return new List<Model>();
        }

        private static void slep()
        {
            Console.WriteLine("\nНажмите любую клавишу для следующей операции");
            Console.ReadKey(true);
        }
    }
}
