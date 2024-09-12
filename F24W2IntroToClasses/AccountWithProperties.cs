using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24W2IntroToClasses
{
    public class AccountWithProperties
    {
		// field
		private double _balance;

		// property
		public double Balance
		{
			get { return _balance; }
			set 
			{ 
				if (value >= 0)
					_balance = value; 
			}
		}

		// constructor
		public AccountWithProperties(double initialBalance)
		{
			Balance = initialBalance;
		}

		public void Deposit(double amount)
		{
			Balance += amount;
		}

		public void Withdraw(double amount)
		{
			if (amount > Balance)
                throw new Exception("Amount cannot be more than the balance");

			Balance -= amount;
        }
	}
}
