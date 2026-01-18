using PackIT.Domain.Exceptions;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Entities;

public class PackingList
{
    public PackingListId Id { get; private set; }
    private readonly LinkedList<PackingListItem> _items = new();
    public PackingListName _name { get; private set; }
    public Localization _localization { get; private set; }
    public PackingList(PackingListName name , Localization localization, LinkedList<PackingListItem> items)
    {
        _name = name;
        _localization = localization;
        _items = items;
    }

    public void AddItem(PackingListItem packingListItem)
    {
        bool alreadyAdded = _items.Any(item => item.Name == packingListItem.Name);

        if(alreadyAdded)
        {
            throw new PackingListItemAlreadyExistsException();
        }

        _items.AddLast(packingListItem);
    }
}
