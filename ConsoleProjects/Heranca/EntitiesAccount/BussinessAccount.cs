using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal class BussinessAccount : Account
    {
        public double LoanLimt { get; set; }

        public BussinessAccount() { }

        public BussinessAccount(int number, string holder, double balance, double loanLimt) : base(number, holder, balance)
        {
            LoanLimt = loanLimt;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimt )
            {
                Balance += amount;
            }
        }
    }
}
