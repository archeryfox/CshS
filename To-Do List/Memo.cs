using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{

    internal class Memo : Program
    {
        public string Name = String.Empty;
        public string Description = String.Empty;
        public int Day = time.AddDays(DN).Day;
        public int Mouth = time.AddDays(DN).Month;
        public int Year = time.AddDays(DN).Year;
        public int Id = 0;
        static public List<Memo> AllMemos = new List<Memo>();

        public static string InputMemoName()
        {
            Console.Write("\n  Ведите название записки: ");
            return Console.ReadLine();
        }
        public static string InputMemoDescription()
        {
            Console.Write("  Ведите описание:\n  ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Выбор задачи курсором
        /// </summary>
        /// <param name="AllMemo"></param>
        public static void Select(List<Memo> AllMemo)
        {
            if(CursorSelection > 2)
            {
            Console.SetCursorPosition(1, CursorSelection);
            Console.WriteLine($"{CursorSelection}>");
            }
            if (CursorSelection < 2)
            {
                CursorSelection = 2;
                Console.SetCursorPosition(1, CursorSelection);
                Console.Write($"{CursorSelection}>");
            }
            if (CursorSelection > AllMemos.Where(i => i.Day == time.AddDays(DN).Day).ToList().Count)
            {
                CursorSelection = AllMemos.Where(i => i.Day == time.AddDays(DN).Day).ToList().Count;
                Console.SetCursorPosition(1, CursorSelection + 1);
                Console.Write($"{CursorSelection}->");
            }
        }

        /// <summary>
        /// Вывод задач
        /// </summary>
        /// <param name="AllMemo"></param>
        /// 
        public static void Check(List<Memo> AllMemo)
        {
            Console.Clear();
            Page(Memo.AllMemos, Program.day, month);
            Console.Write("  Вектор времени: "+DN);
            if(AllMemos.Where(i => i.Year == time.AddDays(DN).Year &&
            i.Mouth == time.AddDays(DN).Month &&
            i.Day == time.AddDays(DN).Day).ToList().Count == 0)
            {
                Console.WriteLine("   На сегодня нет записей\n " +
                        " CTRL+ для создания задачи, V для просмотра");
            }
            else
            { 
                Console.Write("   Кол-во заданий "+AllMemo.Count+"\n");
                List<Memo> t = new List<Memo>();

                foreach (var memo in AllMemo)
                {
                    if(memo.Year == time.AddDays(DN).Year &&
                    memo.Mouth == time.AddDays(DN).Month &&
                    memo.Day == time.AddDays(DN).Day)        
                       Console.WriteLine($"    {memo.Id}. {memo.Name}");
                }
                Console.CursorVisible = false;
            Select(AllMemo);
            }
        }
        /// <summary>
        /// Просмотр с описанием
        /// </summary>
        /// <param name="memos"></param>
        public static void Open(Memo memos)
        {

            foreach (var memo in AllMemos)
            {
                if (memo.Year == time.AddDays(DN).Year &&
                memo.Mouth == time.AddDays(DN).Month &&
                memo.Day == time.AddDays(DN).Day)
                    Console.WriteLine($"    {memo.Id}. {memo.Name}\n   {memo.Description}");
            }
            //Console.WriteLine($"    {memos.Id}. {memos.Name}\n   {memos.Description}");
        }
    }
}
