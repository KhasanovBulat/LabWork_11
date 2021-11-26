using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_11
{
    class CreditAccount : BankAccount
    {
        double percent;
        string secondOwner; //поручитель
        internal CreditAccount(int sum, double percent, string secondOwner) : base(AccountType.CREDIT, sum)
        {
            this.percent = percent;
            this.secondOwner = secondOwner;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, percent: {percent}, поручитель: {secondOwner}";
        }
    }
}
