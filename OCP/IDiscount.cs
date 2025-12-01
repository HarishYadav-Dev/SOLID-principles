namespace SOLID_Principles.OCP
{
	public interface IDiscount
	{
		decimal Apply(decimal amount);
	}
}
