using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24W2IntroToClasses
{
    public class AccountWithMethods
    {
        // fields
        private double _balance;

        // constructor
        public AccountWithMethods(double intialBalance)
        {
            _balance = intialBalance;
        }

        // getters / setters
        public double GetBalance()
        {
            return _balance;
        }

        public void SetBalance(double balance)
        {
            _balance = balance;
        }

        // methods
        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > _balance)
                throw new Exception("Amount cannot be more than the balance");
            
            _balance -= amount;
        }
    }
}
