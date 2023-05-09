using Ecommerce_CQRS.Domain.Exceptions;

namespace Ecommerce_CQRS.Domain.ValueObjects;

public record ProductId
{
    public Guid Value { get; }
	public ProductId(Guid value)
	{
		if(value == Guid.Empty)
		{
			throw new ProductIdException();
		}

		Value = value;
	}

	public static implicit operator Guid(ProductId id) => id.Value;

	public static implicit operator ProductId(Guid id) => new(id);
}
