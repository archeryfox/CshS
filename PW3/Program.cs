using System;

namespace Piano
{
    internal class Program
    {
        /// <summary>
        /// Номер октавы
        /// </summary>
        static int OctNum = 5;
        static int PKN = 0;
        static void Main(string[] args)
        {
            
            int[,] Octavas = {
                { 16, 18, 21, 22, 24, 28, 31, 17, 19, 23, 26, 29 },
                { 33, 37, 41, 44, 49, 55, 62, 35, 39, 46, 52, 58 },
                { 65, 73, 82, 87, 98, 110, 123, 69, 78, 92, 104, 116 },
                { 130 , 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246},
                { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 },
                { 523,  554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 },
                { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865 , 1976  },
                { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 },
                { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 },
            };

            Console.WriteLine("\tЭто пианино. Белые клавиши ASDFGHJ, Чёрные QERTU");
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("           __..--''``---....___   _..._    __");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine(" /// //_.-'    .-/\";  `        ``<._  ``.''_ `. / // /\r");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("///_.-' _..--.'_    \\                    `( ) ) // //\r");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("/ (_..-' // (< _     ;_..__               ; `' / ///\r");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine(" / // // //  `-._,_)' // / ``--...____..-' /// / //");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("Выбор октав - F1, F2, F3, F4, F5, F6, F7, F8, F9. Также смена октав стирает \"нотный\" рисунок");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine($"Текущая октава - 5");
            PressKey(Octavas);
        }
        /// <summary>
        /// Метод, в который передаётся массив откав, в нём же происходит 
        /// смена октав и подаётся на подачу данные о ноте и номере октавы
        /// </summary>
        /// <param name="Octavas"></param>
        static void PressKey(int[,] Octavas)
        {
            while (true)
            {
            ConsoleKey Key = Console.ReadKey(true).Key;
                PKN++;
                switch (Key)
                {
                    case ConsoleKey.A: 
                        Playing(0, Octavas);
                        break;
                    case ConsoleKey.S:
                        Playing(1, Octavas);
                        break;
                    case ConsoleKey.D:
                        Playing(2, Octavas);
                        break;
                    case ConsoleKey.F:
                        Playing(3, Octavas);
                        break;
                    case ConsoleKey.G:
                        Playing(4, Octavas);
                        break;
                    case ConsoleKey.H:
                        Playing(5, Octavas);
                        break;
                    case ConsoleKey.J:
                        Playing(6, Octavas);
                        break;

                    case ConsoleKey.Q: 
                        Playing(7, Octavas);
                        break;
                    case ConsoleKey.E:
                        Playing(8, Octavas);
                        break;
                    case ConsoleKey.R:
                        Playing(9, Octavas);
                        break;
                    case ConsoleKey.T:
                        Playing(10, Octavas);
                        break;
                    case ConsoleKey.U:
                        Playing(11, Octavas);
                        break;

                    case ConsoleKey.F1: 
                        OctNum = 0;
                        OctOut();
                        break;
                    case ConsoleKey.F2:
                        OctNum = 1;
                        OctOut();
                        break;
                    case ConsoleKey.F3:
                        OctNum = 2;
                        OctOut();
                        break;
                    case ConsoleKey.F4:
                        OctNum = 3;
                        OctOut();
                        break;
                    case ConsoleKey.F5:
                        OctNum = 4;
                        OctOut();
                        break;
                    case ConsoleKey.F6:
                        OctNum = 5;
                        OctOut();
                        break;
                    case ConsoleKey.F7:
                        OctNum = 6;
                        OctOut();
                        break;
                    case ConsoleKey.F8:
                        OctNum = 7;
                        OctOut();
                        break;
                    case ConsoleKey.F9:
                        OctNum = 8;
                        OctOut();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        /// <summary>
        /// Дополнительный метод для упрощения вывода октавы
        /// </summary>
        private static void OctOut()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("           __..--''``---....___   _..._    __");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine(" /// //_.-'    .-/\";  `        ``<._  ``.''_ `. / // /\r");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("///_.-' _..--.'_    \\                    `( ) ) // //\r");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("/ (_..-' // (< _     ;_..__               ; `' / ///\r");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine(" / // // //  `-._,_)' // / ``--...____..-' /// / //");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("Выбор октав - F1, F2, F3, F4, F5, F6, F7, F8, F9.");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine($"Текущая октава - {OctNum+1}");
        }

        /// <summary>
        /// Проигрыш ноты из массива октав
        /// </summary>
        /// <param name="n"></param>
        /// <param name="Octavas"></param>
        
        static void Playing(int n, int[,] Octavas)
        {
            Random random = new Random();
            Random random2 = new Random();
            PKN = random.Next(1, 11);

            int x = random.Next(1, 100);
            int y = (random2.Next(9, 20) + (random.Next(1, 10)));

            switch (PKN)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("Пим");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("Пам");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("Бэм");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("Бин");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("Тум");
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("Лян");
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("Пем");
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("Тен");
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("Дем");
                    break;
                case 10:

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("Пым");
                    break;
            }
            Console.Beep((Octavas[OctNum, n]+1000), 100);
            
        }
    }
}
