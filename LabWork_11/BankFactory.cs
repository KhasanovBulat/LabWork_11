using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_11
{
    class BankFactory
    {
        public Hashtable hashTable = new Hashtable();
        public int CreateAccount(int sum, double percent, string secondOwner)
        {
            CreditAccount creditAccount = new CreditAccount(sum, percent, secondOwner);
            hashTable.Add(creditAccount.accountNumber, creditAccount);
            return creditAccount.accountNumber;
        }

        public int CreateAccount(int sum, double cashBack)
        {
            RegularAccount regularAccount = new RegularAccount(sum, cashBack);
            hashTable.Add(regularAccount.accountNumber, regularAccount);
            return regularAccount.accountNumber;
        }

        public void CloseBankAccount(int accountNumber)
        {
            hashTable.Remove(accountNumber);
        }
    }
}
