using Ecommerce_CQRS.Shared.Abstractions.Exceptions;

namespace Ecommerce_CQRS.Domain.Exceptions;

public class ProductNameLengthException : ProductException
{
	public ProductNameLengthException() : base("Product Name Can't Be More Than 50 Characters!")
	{

	}
}
