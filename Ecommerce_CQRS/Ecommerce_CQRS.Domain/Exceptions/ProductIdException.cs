using Ecommerce_CQRS.Shared.Abstractions.Exceptions;

namespace Ecommerce_CQRS.Domain.Exceptions;

public class ProductIdException : ProductException
{
	public ProductIdException() : base("Product Id Can Not Be Empty.")
	{

	}
}
