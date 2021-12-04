using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11
{
    class Student
    {
        private static int i = 0;
        public int index { get; private set; }
        public byte VictNum { get; private set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string group { get; set; }

        List<Student> students = new List<Student>();

        public Student(string name, string surname, string group)
        {
            this.name = name;
            this.group = group;
            this.surname = surname;
            index = i++;
        }

        public Student()
        {
            index = i++;
        }

        public void LotteryWin()
        {
            VictNum++;
        }
        public override string ToString()
        {
            return $"Индекс:{index} Имя студента: {name} {surname} Номер группы: {group}";
        }
    }
}
