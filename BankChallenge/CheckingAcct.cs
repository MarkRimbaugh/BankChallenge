using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankChallenge
{
    internal class CheckingAcct : BankAccount
    {
        public CheckingAcct(string firstName, string lastName, decimal startingBalance)
            : base(firstName, lastName, startingBalance) { }


        public override void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount <= _balance)
            {
                _balance -= withdrawAmount;
            }
            else
            {
                _balance -= (withdrawAmount + 35);
            }
        }
    }
}
