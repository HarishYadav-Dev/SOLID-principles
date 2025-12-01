namespace SOLID_Principles.OCP
{
	public class NoDiscount : IDiscount
	{
		public decimal Apply(decimal amount) => amount;
	}
}
