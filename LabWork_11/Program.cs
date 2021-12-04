using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_11
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11.1");
            BankFactory bankFactory = new BankFactory();
            int creditAccountNumber = bankFactory.CreateAccount(1000, 7.5, "Иван");
            int regularAccountNumber = bankFactory.CreateAccount(1000, 3);
            Console.WriteLine(creditAccountNumber);
            Console.WriteLine(regularAccountNumber);

            Console.WriteLine("Счета:");
            foreach(int accountNumber in bankFactory.hashTable.Keys)
            {
                Console.WriteLine(bankFactory.hashTable[accountNumber].ToString());
            }
            Console.WriteLine("Закрытие счета с номером 1");
            bankFactory.CloseBankAccount(1);

            Console.WriteLine("Счета после закрытия:");
            foreach (int accountNumber in bankFactory.hashTable.Keys)
            {
                Console.WriteLine(bankFactory.hashTable[accountNumber].ToString());
            }

            Console.WriteLine("Домашнее Задание 11.1");
            Console.Write("Введите ID здания ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту здания:");
            double h = Convert.ToDouble(Console.ReadLine());
            Building b = new Building(id, h);
            Creator creator_1 = new Creator("Иван",10);
            //creator_1.CreateBuild();
            

        }
    }
}
