using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP.ISP_Violation
{
	public class EmailNotificationService : INotificationService
	{
		public void SendEmail(string email, string message)
		{
			// send email
		}

		public void SendSms(string phone, string message)
		{
			throw new NotImplementedException(); // ❌
		}

		public void SendPush(string deviceId, string message)
		{
			throw new NotImplementedException(); // ❌
		}
	}
	//  What’s wrong here?

	//	Email service does not care about SMS or Push

	//Forced implementation of unused methods

	//Changes to INotificationService impact all services

	//Violates Interface Segregation Principle
}
