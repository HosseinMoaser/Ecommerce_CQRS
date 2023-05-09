namespace Ecommerce_CQRS.Shared.Abstractions.Exceptions;

public abstract class ProductException : Exception
{
	protected ProductException(string message) : base(message) 
	{

	}
	
}
