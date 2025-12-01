using SOLID_Principles.OCP;
using SOLID_Principles.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=== SRP ===");
			var invoice = new Invoice { Amount = 1000 };
			var repo = new InvoiceRepository();
			repo.SaveToDatabase(invoice);

			Console.WriteLine("\n=== OCP ===");
			var discountService = new DiscountService(new FestivalDiscount());
			Console.WriteLine($"Final amount: {discountService.GetFinalAmount(1000)}");
		}
	}
}
