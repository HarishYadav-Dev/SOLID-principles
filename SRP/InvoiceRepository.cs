using System;

namespace SOLID_Principles.SRP
{
	public class InvoiceRepository
	{
		public void SaveToDatabase(Invoice invoice)
		{
			Console.WriteLine("Invoice saved to database");
		}
	}
}
