using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP
{
	public interface IOrderRepository
	{
		void Save(string order);
	}
}
