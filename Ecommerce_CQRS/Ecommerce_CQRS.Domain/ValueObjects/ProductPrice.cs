namespace Ecommerce_CQRS.Domain.ValueObjects;

public record ProductPrice
{
    public float Value { get; }

	public ProductPrice(float value)
	{
		if(value == 0)
		{
			throw new DivideByZeroException();
		}
		Value = value;
	}
}
