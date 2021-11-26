using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_11
{
    class BankAccount 
    {
        static int number=1;
        public int accountNumber;
        public AccountType type;
        public int sum;

        internal BankAccount(AccountType type, int sum)
        {
            accountNumber = number++;
            this.type = type;
            this.sum = sum;
        }


        public override string ToString()
        {
            return $"Account type: {type}, account number: {accountNumber}, sum: {sum}";
        }
    }
}
