using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edit_and_Convert
{
    public class Model
    {
        public string Name;
        public string Description;
        public dynamic Field1;
        public dynamic Field2;
        public dynamic Field3;
        public dynamic Field4;
        public dynamic Field5;
        public static List<Model> somelist = new List<Model>();
        public Model()
        {
            
        }

        /// <summary>
        /// Полный конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="field1"></param>
        /// <param name="field2"></param>
        /// <param name="field3"></param>
        /// <param name="field4"></param>
        /// <param name="field5"></param>
        public Model(string name, dynamic description, string field1, string field2, string field3, string field4, string field5)
        {
            Name = name;
            Description = description;
            Field1 = field1;
            Field2 = field2;
            Field3 = field3;
            Field4 = field4;
            Field5 = field5;
        }
        /// <summary>
        /// Минимальный конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="field1"></param>
        public Model(string name, string description, int field1)
        {
            Name = name;
            Description = description;
            Field1 = field1;
        }
        public Model(string name, string description, string field1)
        {
            Name = name;
            Description = description;
            Field1 = field1;
        }
        public Model(string name, int field1, int field2)
        {
            Name = name;
            Field1 = field1;
            Field2 = field2;
        }
    }
}
