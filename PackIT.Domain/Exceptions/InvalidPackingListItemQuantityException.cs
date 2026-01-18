using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class InvalidPackingListItemQuantityException : PackITException
{
    public InvalidPackingListItemQuantityException() : base("Packing list item quantity must be greater than zero.")
    {
    }
}
