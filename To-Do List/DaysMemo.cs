using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class Memo : Program
    {
        public int Id = 1;
        public string Name = String.Empty;
        public string Description = String.Empty;
        /*public int Mouth = time.AddDays(DN).Month;
        public int Day = time.AddDays(DN).Day;*/
        static public List<List<Memo>> DayList = new List<List<Memo>>();
        static public dynamic[] MonthList = new dynamic[31];
        static public List<List<List<List<Memo>>>> YearList = new List<List<List<List<Memo>>>>();

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
        /// Работа с текущим днём
        /// </summary>
        /// <param name="ThisDayList"></param>
        public static void Check(dynamic[] ThisDayList)
        {
            if(ThisDayList.Length == 0)
            {
                Console.WriteLine("  На сегодня нет записей\n " +
                        " CTRL+ для создания задачи, V для просмотра");
            }
            else
            {
                Console.WriteLine(ThisDayList.Length);
                for (int i = 0; i < ThisDayList.Length; i++)
                {
                        Console.WriteLine($"  {ThisDayList[i].Id}. {ThisDayList[i].Name}\n" +
                        $"   {ThisDayList[i].Description}.2022\n");
                }
                Console.CursorVisible = true;

            }
        }

    }
}
