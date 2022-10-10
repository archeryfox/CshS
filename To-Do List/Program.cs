using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class Program
    {
            static public DateTime time = DateTime.Now;
            public static int DN = 0;
            static int MonthMem = time.AddDays(DN).Month;
            static int DayMem = time.Day;

        public static void Main(string[] args)
        {

            List<Memo> MemoBook = new List<Memo>();

            List<List<Memo>> Memos = new List<List<Memo>> { };
            int MemoNum = 1;


            /*  for (int i = 0; i < Memos.Count; i++)
              {
                  for (int j = 0; j < Memo.Count; j++)
                  {
              Console.WriteLine(Memos[i][j]);
                  }
              }
            */
            
            string day = "";
            if (DayMem < 10)
            {
                day = $"0{DayMem}";
            }
            else
            {
                day = $"{DayMem}";
            }
            string month = "";
            if (MonthMem < 10)
            {
                month = $"0{MonthMem}";
            }
            else
            {
                month = $"{MonthMem}";
            }

            for (int i = 0; i < 31; i++)
            {
                Memo.MonthList[i] = new List<Memo>();
            }

            Console.SetCursorPosition(1, 1);
            Console.CursorVisible = false;
            Console.WriteLine($"Выбрана дата {day}.{month}.{time.Year}");

                if (MemoBook.Count == 0)
                {
                    Console.WriteLine("  На сегодня нет записей\n " +
                        " CTRL+ для создания задачи, V для просмотра");
                }
            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                if (/*consoleKeyInfo.Modifiers.HasFlag(ConsoleModifiers.Control) &&*/ consoleKeyInfo.Key == ConsoleKey.OemPlus)
                {
                    //Console.WriteLine("+");
                    Console.CursorVisible = true;
                    DataFix(ref day, ref month);
                    MemoBook.Add(new Memo()
                    {
                        Id = MemoNum++,
                        Name = Memo.InputMemoName(),
                        Description = Memo.InputMemoDescription() + $"({day}.{month})",
                    });
                    Memo.DayList.Add(MemoBook);
                    Memo.MonthList[time.AddDays(DN).Day] = Memo.DayList;
                    Console.Clear();
                    Console.WriteLine($"\n Выбрана дата {day}.{month}.{time.Year}");
                    Memo.Check(Memo.MonthList[time.AddDays(DN).Day]);
                }
                if (consoleKeyInfo.Modifiers.HasFlag(ConsoleModifiers.Control) && consoleKeyInfo.Key == ConsoleKey.OemMinus)
                {
                    Console.WriteLine("-");
                }
                if (consoleKeyInfo.Modifiers.HasFlag(ConsoleModifiers.Control) && consoleKeyInfo.Key == ConsoleKey.R)
                {
                   // Console.WriteLine("R");
                }

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.V:
                        // Console.WriteLine("Enter");
                        Console.Clear();
                        Console.SetCursorPosition(1, 1);
                        Console.WriteLine($"Выбрана дата {day}.{month}.{time.Year}");
                        Page(MemoBook, day, month);
                        Memo.Check(Memo.MonthList[time.AddDays(DN).Day]);
                        break;
                    case ConsoleKey.DownArrow:
                        //Console.Write("v");
                        break;
                    case ConsoleKey.UpArrow:
                        //Console.Write("^");
                        break;
                    case ConsoleKey.LeftArrow:
                        DN--;
                        Page(MemoBook, day, month);
                        Console.Write("<-");
                        Memo.Check(Memo.MonthList[time.AddDays(DN).Day]);
                        break;
                    case ConsoleKey.RightArrow:
                        DN++;
                        Page(MemoBook, day, month);
                        Memo.Check(Memo.MonthList[time.AddDays(DN).Day]);
                        Console.Write("->");
                        break;
                }
            }
        }

        public static void DataFix(ref string day, ref string month)
        {
            if (time.AddDays(DN).Day < 10)
            {
                day = $"0{time.AddDays(DN).Day}";
            }
            else
            {
                day = $"{time.AddDays(DN).Day}";
            }


            if (time.AddDays(DN).Month < 10)
            {
                month = $"0{time.AddDays(DN).Month}";
            }
            else
            {
                month = $"{time.AddDays(DN).Month}";
            }

        }

        public static void Page(List<Memo> MemoObj, string day, string month)
        {

            DataFix(ref day, ref month);
            Console.Clear();
            Console.SetCursorPosition(1, 1);
            Console.CursorVisible = false;
            Console.WriteLine($"Выбрана дата {day}.{month}.{time.AddDays(DN).Year}");
        }
    }
}
