namespace SOLID_Principles.OCP
{
	public class DiscountService
	{
		//Add new discount classes → No need to modify DiscountService

		private readonly IDiscount _discount;

		public DiscountService(IDiscount discount)
		{
			_discount = discount;
		}

		public decimal GetFinalAmount(decimal amount)
		{
			return _discount.Apply(amount);
		}
	}
}
