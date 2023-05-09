using Ecommerce_CQRS.Domain.Exceptions;

namespace Ecommerce_CQRS.Domain.ValueObjects;

public record ProductDescription
{
    public string Value { get;  }

	public ProductDescription(string value)
	{
		if(string.IsNullOrWhiteSpace(value)) 
			throw new ProductDescriptionException();
		Value = value;
	}

    public static implicit operator string(ProductDescription description) => description.Value;
    public static implicit operator ProductDescription(string description) => new(description);
}
