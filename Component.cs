using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Component
    {
        public string Detail;
        private int Price;
        public Component(string Detail)
        {
            this.Detail = Detail;
            switch (Detail)
            {
                case "Стандарт":
                    Price = 100;
                    break;
                case "Тыква":
                    Price = 90;
                    break;
                case "Рыба":
                    Price = 300;
                    break;
                case "Квадрат":
                    Price = 200;
                    break;
            }
        }
    }

    public class Компонент
    {
    }
}
