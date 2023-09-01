using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exeptions.Exeptions;

namespace Exeptions.Entities
{
    internal class Account
    {
        public int Number { get; protected set; }
        public string Name { get; protected set; }
        public double Balance { get; protected set; }
        public double WithdrawLimit { get; protected set; }

        public Account(int number, string name, double balance, double withdrawLimit)
        {
            Number = number;
            Name = name;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new NoBalanceExeption("Not enough balance");
            }
            if (amount > WithdrawLimit)
            {
                throw new WithdrawLimitExeption("The amount exceeds withdraw limit");
            }
            Balance -= amount;
        }
    }
}
