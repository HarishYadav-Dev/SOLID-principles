using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP.LSP_Violation
{
	public class FixedDepositAccount : BankAccount
	{
		public override void Deposit(decimal amount)
		{
			Console.WriteLine($"FD created with amount {amount}");
		}

		public override void Withdraw(decimal amount)
		{
			throw new NotSupportedException("Withdrawal not allowed before maturity");
		}
	}

}
