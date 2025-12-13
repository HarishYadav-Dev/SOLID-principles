using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP
{
	public class AccountService
	{
		public void Withdraw(IWithdrawableAccount account)
		{
			account.Withdraw(1000);
		}
	}

}
