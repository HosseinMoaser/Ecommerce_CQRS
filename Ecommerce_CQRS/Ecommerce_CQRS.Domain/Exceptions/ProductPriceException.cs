using Ecommerce_CQRS.Shared.Abstractions.Exceptions;

namespace Ecommerce_CQRS.Domain.Exceptions;

public class ProductPriceException : ProductException
{
	public ProductPriceException() : base("Price Can't Be Zero!")
	{

	}
}
