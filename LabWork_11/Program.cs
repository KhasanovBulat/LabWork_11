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
            Console.WriteLine("Задание 1");
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

            Console.WriteLine("Задание 2");
            Creator creator_1 = new Creator("Иван",10);
            

        }
    }
}
