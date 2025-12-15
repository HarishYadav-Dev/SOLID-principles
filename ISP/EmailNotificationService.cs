using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP
{
	public class EmailNotificationService : IEmailNotification
	{
		public void SendEmail(string email, string message)
		{
			// send email
			Console.WriteLine($"Email sent to {email} with message: {message}");
		}
	}
}
