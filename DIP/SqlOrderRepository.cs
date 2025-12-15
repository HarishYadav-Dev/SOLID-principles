using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP
{
	public class SqlOrderRepository : IOrderRepository
	{
		public void Save(string order)
		{
			// Save to SQL Server
			Console.WriteLine("Order saved to SQL Server database.");
		}
	}

}
