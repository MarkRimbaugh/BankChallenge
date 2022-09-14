using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChallenge
{
    internal class SavingsAcct : BankAccount
    {
        private decimal _interestRate;
        int withdrawCount = 0;

        public SavingsAcct(string firstName, string lastName, decimal interestRate, decimal startingBalance)
            : base(firstName, lastName, startingBalance)
        {
            _interestRate = interestRate;
        }

        public void ApplyInterest()
        {
            _balance += (_balance * _interestRate);
        }

        public override void Withdraw(decimal withdrawAmount)
        {
            ++withdrawCount;
            if (withdrawAmount > _balance)
            {
                Console.WriteLine("Attempt to overdraw savings - denied");
            }

            else
            {
                if (withdrawCount <= 3)
                {
                    _balance -= withdrawAmount;
                }
                else
                {
                    _balance -= (withdrawAmount + 2);
                }
            }
            
        }

    }
}
