using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Edit_and_Convert
{
    internal class Program
    {
        static string path = "";
        static void Main(string[] args)
        {
                ///какойто код....Ы
            var js = JsonConvert.SerializeObject();
            Console.WriteLine(js);
        }
    }
}
