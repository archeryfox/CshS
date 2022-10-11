using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class Indexator : Program
    {
        public int Id = 0;
        static public int idB = 0;
        
        public int Ind(dynamic[] Days, int itb)
        {
            return 0;
        }
    }

    internal class Memo : Program
    {
        public int IdBuffer = 0;
        public string Name = String.Empty;
        public string Description = String.Empty;
        public int Mouth = time.AddDays(DN).Month;
        public int Day = time.AddDays(DN).Day;
        public List<List<int>> idList = new List<List<int>>();
        static public List<List<Memo>> DayList = new List<List<Memo>>();
        static public dynamic[] MonthList = new dynamic[32];
        public Indexator Id = new Indexator();

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
        /// 

        public static void Check(dynamic[] ThisMounthList)
        {
                Console.WriteLine("\n\t"+time.AddDays(DN).Day+":"+DN);
            if(ThisMounthList[time.AddDays(DN).Day].Count == 0)
            {
                Console.WriteLine("  На сегодня нет записей\n " +
                        " CTRL+ для создания задачи, V для просмотра");
            }
            else
            {
                int j = 0;int i = 0; 
                Console.WriteLine(" Кол-во заданий "+ThisMounthList[time.AddDays(DN).Day].Count);
                for (; i < 1; i++)
                {
                    // Месяц[День - №Списка - Задача]
                    for (; j < ThisMounthList[time.AddDays(DN).Day][i].Count; j++)
                    {
                        if (ThisMounthList[time.AddDays(DN).Day][i][j].Day == time.AddDays(DN).Day)
                        {
                            Console.WriteLine($"  {ThisMounthList[time.AddDays(DN).Day][i][j].IdBuffer/*ThisMounthList[time.AddDays(DN).Day][ThisMounthList[time.AddDays(DN).Day][i].Count-1].Count*/}. {ThisMounthList[time.AddDays(DN).Day][i][j].Name}\n" +
                            $"   {ThisMounthList[time.AddDays(DN).Day][i][j].Description}.2022\n");
                        }
                    }
                }

                Console.CursorVisible = true;
            }
        }

    }
}
