using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP
{
	public class SavingsAccount : IWithdrawableAccount
	{
		private decimal _balance = 0;

		public void Deposit(decimal amount)
		{
			_balance += amount;
			Console.WriteLine($"Deposited {amount}. Balance: {_balance}");
		}

		public void Withdraw(decimal amount)
		{
			_balance -= amount;
			Console.WriteLine($"Withdrawn {amount}. Balance: {_balance}");
		}
	}

}
