using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP.DIP_Violation
{
	public class OrderService
	{
		private readonly SqlServerDatabase _database = new SqlServerDatabase();

		public void PlaceOrder(string order)
		{
			_database.Save(order); // ❌ tightly coupled
		}
	}
}
