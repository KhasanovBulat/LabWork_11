using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_11
{
    class RegularAccount : BankAccount
    {
        double cashBack;
        internal RegularAccount(int sum, double cashBack) : base(AccountType.REGULAR, sum)
        {
            this.cashBack = cashBack;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, cashBack: {cashBack}";
        }
    }
}
