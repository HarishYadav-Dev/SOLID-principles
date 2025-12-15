using SOLID_Principles.DIP;
using SOLID_Principles.ISP;
using SOLID_Principles.LSP;
using SOLID_Principles.OCP;
using SOLID_Principles.SRP;
using System;

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

			//Console.WriteLine("\n=== LSP Violation ===");
			//AccountService service = new AccountService();

			//BankAccount savings = new SavingsAccount();
			//BankAccount fd = new FixedDepositAccount();

			//service.ProcessWithdrawal(savings); // ✔ Works
			//service.ProcessWithdrawal(fd);      // 💥 Runtime crash (LSP violation)

			Console.WriteLine("\n=== LSP ===");
			LSP.AccountService service = new LSP.AccountService();

			IWithdrawableAccount savings = new LSP.SavingsAccount();
			IBankAccount fd = new LSP.FixedDepositAccount();

			service.Withdraw(savings); // ✔ Allowed

			// service.Withdraw(fd);
			//❌ Compile-time error — LSP protected

			Console.WriteLine("\n=== ISP ===");
			IEmailNotification emailNotification = new EmailNotificationService();
			ISP.OrderService orderService = new ISP.OrderService(emailNotification);
			orderService.PlaceOrder();

			Console.WriteLine("\n=== DIP ===");
			IOrderRepository repository = new DIP.SqlOrderRepository();
			DIP.OrderService order = new DIP.OrderService(repository);
			order.PlaceOrder("Order001");

			Console.ReadLine();
		}
	}
}