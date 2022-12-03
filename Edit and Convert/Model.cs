using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edit_and_Convert
{
    /// <summary>
    /// Тип данных Модель
    /// </summary>
    public class Model
    {
        public string Name;
        public string Description;
        public dynamic Field;
        
        public static List<Model> somelist = new List<Model>();
        public Model()
        {
            
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
            Field = field1;
        }
        public Model(string name, string description, string field1)
        {
            Name = name;
            Description = description;
            Field = field1;
        }
 
    }
}
