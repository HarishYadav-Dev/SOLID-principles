using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP
{
	public interface IWithdrawableAccount : IBankAccount
	{
		void Withdraw(decimal amount);
	}
}
