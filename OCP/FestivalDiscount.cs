namespace SOLID_Principles.OCP
{
	public class FestivalDiscount : IDiscount
	{
		public decimal Apply(decimal amount) => amount * 0.90m;
	}
}
