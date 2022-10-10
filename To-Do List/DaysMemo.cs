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
        /// <param name="ThisMounthList"></param>
        public static void Check(dynamic[] ThisMounthList)
        {
            if(ThisMounthList[time.AddDays(DN).Day].Count == 0)
            {
                Console.WriteLine("  На сегодня нет записей\n " +
                        " CTRL+ для создания задачи, V для просмотра");
            }
            else
            {
                Console.WriteLine("+++++++++"+ThisMounthList[time.AddDays(DN).Day].Count);
                for (int i = 0; i < ThisMounthList[time.AddDays(DN).Day].Count; i++)
                {
                    for (int j = 0; j < ThisMounthList[time.AddDays(DN).Day][i].Count; j++)
                    {
                        Console.WriteLine($"  {ThisMounthList[time.AddDays(DN).Day][i][j].Id}. {ThisMounthList[time.AddDays(DN).Day][i][j].Name}\n" +
                        $"   {ThisMounthList[time.AddDays(DN).Day][i][j].Description}.2022\n");
                    }

                }
                Console.CursorVisible = true;

            }
        }

    }
}
