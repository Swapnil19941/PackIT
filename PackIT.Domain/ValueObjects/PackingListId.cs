using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects;

public record class PackingListId
{
    public Guid Value { get; }

    public PackingListId(Guid value)
    {
        if(value == null)
        {
            throw new EmptyPackingListIdException();
        }
        Value = value;
    }
}
