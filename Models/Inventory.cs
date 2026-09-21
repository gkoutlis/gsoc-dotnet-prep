
namespace GsocPrep.Models;

public class Inventory
{
    private readonly List<Item> _items = new();

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        _items.Remove(item);
    }

    public void PrintItems()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item.Name);
        }
    }

    public Item? FindItemByName(string name)
    {
        return _items.FirstOrDefault(item => item.Name == name);   
    }

    public bool ContainsItem(string name)
    {
        return _items.Any(item => item.Name == name);
    }

    public List<Item> GetItemsByRarity(Rarity rarity)
    {
        return _items.Where(item => item.Rarity == rarity).ToList();
    }

    public int CountItemsByRarity(Rarity rarity)
    {
        return _items.Count(item => item.Rarity == rarity);
    }
    
    public List<string> GetItemNames()
    {
        return _items.Select(item => item.Name).ToList();
    }

    public List<Item> GetRareOrEpicItems()
    {
        return _items
            .Where(item => item.Rarity == Rarity.Epic ||  item.Rarity == Rarity.Rare) 
            .ToList();
    }
    
    public List<Item> GetItemsOrderByName()
    {
        return _items.OrderBy( item => item.Name).ToList();
    }

    public List<Item> GetItemsOrderedByRarity()
    {
        return _items.OrderBy(item => item.Rarity).ToList();
    }

    public List<Item> GetItemsOrderedByRarityAndName()
    {
        return _items
            .OrderBy(item => item.Rarity)
            .ThenBy(item => item.Name) 
            .ToList();
        
    }

    public Item? GetRarestItem()
    {
        return _items
            .OrderByDescending(item => item.Rarity)
            .FirstOrDefault();
            
    }

    public List<Item> FindItems(Func<Item, bool> predicate)
    {
        return _items.Where(predicate).ToList();
    }
    
}