using Ecommerce_CQRS.Domain.Exceptions;

namespace Ecommerce_CQRS.Domain.ValueObjects;

public record ProductName
{
    public string Value { get;  }
	public ProductName(string value)
	{
		if(string.IsNullOrWhiteSpace(value))
		{
			throw new ProductNameNullException();
		}
		if(value.Length > 50)
		{
			throw new ProductNameLengthException();
		}
		Value = value.Trim();
	}

	public static implicit operator string(ProductName name) => name.Value;
	public static implicit operator ProductName(string name) => new (name);
}
