using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP.ISP_Violation
{
	public interface INotificationService
	{
		void SendEmail(string email, string message);
		void SendSms(string phone, string message);
		void SendPush(string deviceId, string message);
	}

}
