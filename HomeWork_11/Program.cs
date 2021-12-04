using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace HomeWork_11
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<Student> GetSelectedStudents(List<Student> students)
            {
                List<Student> selectedStudents = new List<Student>();
                foreach (Student selected in students)
                {
                    if (rnd.Next(100) < 60)
                    {
                        selectedStudents.Add(selected);
                    }
                }
                return selectedStudents;
            }
            Console.WriteLine("Задание 1. Билетная лоттерея");
            List<Student> Students = new List<Student>();
            using (StreamReader sr = new StreamReader(@"MyStudents.txt"))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    Student student_PM = new Student();
                    string[] data = str.Split();
                    student_PM.name = data[0];
                    student_PM.surname = data[1];
                    student_PM.group = data[2];
                    Students.Add(student_PM);
                }
            }
            Lottery Concert = new Lottery("Билеты на концерт", 5);
            Lottery Football = new Lottery("Билеты на матч", 7);
            List<Student> LotteryParticipants = new List<Student>();
            Concert.Start(GetSelectedStudents(Students));
            Football.Start(GetSelectedStudents(Students));
            Console.WriteLine("Результаты лоттереи:");
            Concert.ShowResults();
            Football.ShowResults();

            Console.WriteLine("Задание 2. Эксель.");
            string disease_path = $"{Environment.CurrentDirectory} Diseases.XLSX";
            string general_path = $"{Environment.CurrentDirectory} General.XLSX";
            try
            {
                Console.WriteLine("Begin");
                //открытие первого файла
                Console.WriteLine("Begin reading file 1");
                Application excel = new Application();
                Workbook workbook = excel.Workbooks.Open(disease_path);
                Worksheet worksheet = workbook.Worksheets[1];
                //область 
                object[,] readRange = worksheet.Range["A2", "B10"].Value2;
                //словарь болезнь - лекарство
                Dictionary<string, string> diseases = new Dictionary<string, string>();
                //проходим по области 
                for (int i = 1; i <= readRange.GetLength(0); i++)
                {
                    diseases.Add(readRange[i, 1].ToString().ToLower(), readRange[i, 2].ToString());
                }
                //закрытие потока
                workbook.Close();

                Console.WriteLine("Begin reading file 2");

                //открытие нового файла
                workbook = excel.Workbooks.Open(general_path);
                worksheet = workbook.Worksheets[1];
                //считывание области
                readRange = worksheet.Range["G2", "G35"].Value2;
                //анализируем диагноз

                Console.WriteLine("Анализ диагноза");
                for (int i = 1; i <= readRange.Length; i++)
                {
                    //записываем и-ю строку в переменную
                    string readString = readRange[i, 1].ToString().ToLower();

                    //если внутри строки есть ключ - болезнь, то заменяем строку на значение - лекарство
                    foreach (var disease in diseases)
                    {
                        if (readString.Contains(disease.Key))
                        {
                            readRange[i, 1] = disease.Value;
                            break;
                        }
                        else
                        {
                            readRange[i, 1] = "Лекарство не найдено";
                            break;
                        }
                    }

                }
                //записываем Результат (лекарства) в столбец "H"
                worksheet.Range["H2", "H35"].Value2 = readRange;
                //сохраняем
                workbook.Save();
                //закрываем поток
                workbook.Close();

                excel.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End");
            }

            Console.ReadKey();
        }
    }
}
