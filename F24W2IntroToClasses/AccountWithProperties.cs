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
	}
}
