using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects;

public sealed record PackingListItem
{
    public string Name { get; }
    public int Quantity { get; }
    public bool IsPacked { get; }

    public PackingListItem(string name , int quantity, bool isPacked = false)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new EmptyPackingListItemNameException();
        }

        if(quantity <= 0)
        {
            throw new InvalidPackingListItemQuantityException();
        }

        Name = name;
        Quantity = quantity;
        IsPacked = isPacked;
    }
}
