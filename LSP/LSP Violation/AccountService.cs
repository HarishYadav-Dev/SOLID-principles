using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP.LSP_Violation
{
	public class AccountService
	{
		public void ProcessWithdrawal(BankAccount account)
		{
			account.Withdraw(1000);
		}
	}

}
