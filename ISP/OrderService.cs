using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP
{
	public class OrderService
	{
		private readonly IEmailNotification _emailNotification;

		public OrderService(IEmailNotification emailNotification)
		{
			_emailNotification = emailNotification;
		}

		public void PlaceOrder()
		{
			// order logic
			_emailNotification.SendEmail("user@email.com", "Order placed");
		}
	}
}
