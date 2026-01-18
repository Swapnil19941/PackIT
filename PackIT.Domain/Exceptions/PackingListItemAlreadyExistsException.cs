using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class PackingListItemAlreadyExistsException : PackITException
{
    public PackingListItemAlreadyExistsException() : base("Packing List item already exists.") { }
}
