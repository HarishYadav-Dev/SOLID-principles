using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP.DIP_Violation
{
	public class SqlServerDatabase
	{
		public void Save(string data)
		{
			// Save to SQL Server
			Console.WriteLine("Data saved to SQL Server database.");
		}
	}

}
