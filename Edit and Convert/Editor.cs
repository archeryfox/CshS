using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Edit_and_Convert
{
    public class Editor
    {
        public Editor()
        {
        }
        static int ry = 0;
        static int _y = 3;
        static int y = _y + ry;
        static int x = 0;
        static ConsoleKey kk;
        static bool First = true;
        delegate void _delegate();
        static _delegate slep = Deserial.slep;
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
                        if (str[0] == "" || str[0].Contains(" "))
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
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Field);
            }
            Model.somelist = list;
            slep();
            return list;
        }
        public static void ObjectEditor(List<Model> models)
        {
            bool inp = false;
            if (First)
            {
                Console.SetCursorPosition(0, 4);
                First = false;
            }

            if (models.Count == 0)
            {
                x = 0;
                //Console.CursorVisible = false;
                Console.SetCursorPosition(x, 3);
                Console.Write($"Стрелки вверх/вниз/лево/право для перемещения. Tab - для сохранения модели {ry}\n");
                Console.Write("Шаблон пуст, загрузите файл для редактирования или нажмите +");
                Console.SetCursorPosition(x, 4);
                _y = 4;
            }
            else
            {
                Console.SetCursorPosition(x, 2);
                Console.Write($"Стрелки вверх/вниз/лево/право для перемещения. Tab - для сохранения модели {ry}\n");
            }
            foreach (var item in models)
            {
                Console.WriteLine($" {item.Name}\n {item.Description}\n {item.Field}");
            }
            if (!First)
            {
                if (Model.somelist.Count == 0)
                {
                    Console.SetCursorPosition(1, 4);
                }
                else
                {
                    x = models[0].Name.Length;
                }
                Console.SetCursorPosition(x, 4);
            }
            //Могу ли я писать буквы
            while (true)
            {
                switch (kk)
                {
                    case ConsoleKey.UpArrow:
                        inp = true;
                        if (ry != 0) ry--;
                        break;
                    case ConsoleKey.DownArrow:
                        inp = true;
                        if (ry < (Math.Floor((double)models.Count * 3) - 1) && models.Count != 0)
                        {
                            ry++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        inp = true;
                        if (x > 1) x--;
                        break;
                    case ConsoleKey.RightArrow:
                        inp = true;
                        if (models.Count != 0)
                        {
                            if (x <= models[0].Name.Length)
                                x++;
                        }
                        break;
                    case ConsoleKey.Backspace:
                        inp = false;
                        if (x > 1) x--; Console.Write(" ");
                        break;
                    case ConsoleKey.Delete:
                        inp = !inp;
                        if (inp)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        break;
                    default:
                        inp = false; 
                        if (x <= 50)
                        {
                            x++;
                        }
                        break;
                }
                y = _y + ry;
                Console.SetCursorPosition(x, y);
                Console.Write(ry);
                kk = Console.ReadKey(inp).Key;
                if (kk == ConsoleKey.Tab)
                {
                    _y = 0;
                    return;
                }
            }
        }
    }
}
