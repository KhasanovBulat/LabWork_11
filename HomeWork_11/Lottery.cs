using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11
{
    class Lottery
    {
        private static Random rnd = new Random();
        public string LotteryName { get; private set; }
        public List<Student> Victories { get; private set; } = new List<Student>();
        public int TicketCount { get; private set; }
        public Lottery(string LotteryName, int TicketCount)
        {
            this.LotteryName = LotteryName;
            this.TicketCount = TicketCount;
        }
        public void Start(List<Student> ListOfStudents)
        {
            List<Student> sortStudents = new List<Student>(from u in ListOfStudents orderby u.VictNum select u);
            if (sortStudents.Count <= TicketCount)
            {
                for (int i = 0; i < sortStudents.Count; i++)
                {
                    sortStudents[i].LotteryWin();
                    Victories.Add(sortStudents[i]);
                }
            }
            else
            {
                int i = 0;
                while (Victories.Count < TicketCount)
                {
                    i %= sortStudents.Count;
                    if (rnd.Next(100) < 75)
                    {
                        sortStudents[i].LotteryWin();
                        Victories.Add(sortStudents[i]);
                    }
                    i++;
                }
            }
        }
        public void ShowResults()
        {
            Console.WriteLine($"Название: {LotteryName}");
            Console.WriteLine("Список победителей: ");
            foreach (Student winner in Victories)
            {
                Console.WriteLine(winner);
            }
        }
    }
}
