using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tortics;

namespace Cakes
{
    internal class Terminal
    {
        /// <summary>
        /// Более комфортный путь создания торта через конструктор
        /// </summary>
        /// <param name="amount">Количество деталек декора</param>
        /// <param name="view">Вид деталей</param>
        /// <param name="color">Цвет деталей</param>
        /// <param name="size">Введите размер деталек декора</param>
        /// <returns>Объект сразу с декором</returns>
        static Order OrderDecor(int DecAmount, string DecColor, string taste, string DecForm, int amount = 0, string view = "", string color = "", int size = 0)
        {
            return new Order(new Decor(), amount,  view, taste,  color, size, DecAmount, DecColor, DecForm);
        }
        delegate void Deleg();
        /// <summary>
        ///  ghjddgjjdjd
        /// </summary>
        static Deleg ab = Order.MenuL0;
        static void Main()
        {
            
        }
    }
}