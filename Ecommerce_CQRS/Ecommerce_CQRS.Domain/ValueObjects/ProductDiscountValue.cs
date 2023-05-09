namespace Ecommerce_CQRS.Domain.ValueObjects;

public record ProductDiscountValue
{
    public float Value { get; }

	public ProductDiscountValue(float value)
	{
		Value = value;
	}

    public static implicit operator float(ProductDiscountValue discount) => discount.Value;
    public static implicit operator ProductDiscountValue(float discount) => new(discount);
}
