using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyPackingListNameException : PackITException
{
    public EmptyPackingListNameException() : base("Packing List Name cannot be empty.")
    {

    }
}
