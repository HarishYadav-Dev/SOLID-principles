using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP.LSP_Violation
{
	public abstract class BankAccount
	{
		public abstract void Deposit(decimal amount);
		public abstract void Withdraw(decimal amount);
	}

}
