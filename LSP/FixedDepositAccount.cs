using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP
{
	public class FixedDepositAccount : IBankAccount
	{
		public void Deposit(decimal amount)
		{
			Console.WriteLine($"FD created with amount {amount}");
		}
	}

}
