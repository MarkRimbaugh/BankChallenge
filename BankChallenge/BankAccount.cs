using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChallenge
{
    internal class BankAccount
    {
        protected decimal _balance;
        private string _lastName;
        private string _firstName;

        public BankAccount(string firstName, string lastName, decimal startingBalance)
        {
            _balance = startingBalance;
            _lastName = lastName;
            _firstName = firstName;
        }

        // Properties
        public string AccountOwner
        {
            get { return $"{_lastName}, {_firstName}"; }
        }

        public decimal Balance
        {
            get { return _balance; }
        }

        // Methods
        public void Deposit(decimal depositAmount)
        {
            _balance += depositAmount;
        }

        public virtual void Withdraw(decimal withdrawAmount)
        {
            _balance -= withdrawAmount;
        }

        

    }

    
}
