namespace GsocPrep.Models;


public class ItemStorage<T>
    where T : Item
{
    private readonly List<T> _items = new();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public List<string> GetItemNames()
    {
        return _items
            .Select(i => i.Name)
            .ToList();
    }
}