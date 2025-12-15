using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP
{
	public class SmsNotificationService : ISmsNotification
	{
		public void SendSms(string phone, string message)
		{
			// send SMS
			Console.WriteLine($"SMS sent to {phone} with message: {message}");
		}
	}
}
