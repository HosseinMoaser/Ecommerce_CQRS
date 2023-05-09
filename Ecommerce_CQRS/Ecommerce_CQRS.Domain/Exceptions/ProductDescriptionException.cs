using Ecommerce_CQRS.Shared.Abstractions.Exceptions;

namespace Ecommerce_CQRS.Domain.Exceptions;

public class ProductDescriptionException : ProductException
{
	public ProductDescriptionException() : base("Product Description Can't Be Empty!")
	{

	}
}
