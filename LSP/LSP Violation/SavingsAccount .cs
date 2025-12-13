using System;

namespace SOLID_Principles.LSP.LSP_Violation
{
	public class SavingsAccount : BankAccount
	{
		private decimal _balance = 0;

		public override void Deposit(decimal amount)
		{
			_balance += amount;
			Console.WriteLine($"Deposited {amount}. Balance: {_balance}");
		}

		public override void Withdraw(decimal amount)
		{
			_balance -= amount;
			Console.WriteLine($"Withdrawn {amount}. Balance: {_balance}");
		}
	}

}
