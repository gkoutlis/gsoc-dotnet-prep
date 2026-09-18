namespace GsocPrep.Models;

public class Storage<T>
{
    private readonly List<T> _items = new();
    
    public void AddItem(T item)
    {
        _items.Add(item);
    }
    
    public List<T>  GetAllItems()
    {
         return _items.ToList();
    }

    public T? GetFirstOrDefault<T>(List<T> items)
    {
        return items.FirstOrDefault();
    }
    
}