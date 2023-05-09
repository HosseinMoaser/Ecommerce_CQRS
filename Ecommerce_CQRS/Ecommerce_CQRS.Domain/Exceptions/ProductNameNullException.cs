using Ecommerce_CQRS.Shared.Abstractions.Exceptions;

namespace Ecommerce_CQRS.Domain.Exceptions
{
    public class ProductNameNullException : ProductException
    {
        public ProductNameNullException() : base("Product Name Can't Be Null Or Empty!")
        {

        }
    }
}
