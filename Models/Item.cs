
using GsocPrep.Models.Enums;
using GsocPrep.Interfaces;
namespace GsocPrep.Models;

public class Item
{
    public Rarity Rarity { get; set; }
    public string Name { get; set; }
    
    public Item(string name,Rarity rarity)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name must not be empty", nameof(name));
        }
        Name = name;
        Rarity = rarity;
    }
    
}

public class Weapon : Item
{
    public int Damage { get; set; }

    public Weapon(string name, Rarity rarity, int damage) : base(name, rarity)
    {
        if (damage <= 0)
        {
            throw new ArgumentException("Damage must be greater than 0", nameof(damage));
        }

        Damage = damage;

    }
}

public class Potion : Item, IUsable 
{
    public int HealingAmount { get; set; }

    public Potion(string name, Rarity rarity, int healingAmount) : base(name, rarity)
    {
        if (healingAmount <= 0)
        {
            throw new ArgumentException("Healing amount must be greater than 0", nameof(healingAmount));
            
        }
        HealingAmount = healingAmount;
    }

    public void Use()
    {
        Console.WriteLine($"Used {Name} and restored {HealingAmount} HP");
    }
}

public class Scroll : Item, IUsable
{
    public int SpellPower { get; set; }

    public Scroll(string name, Rarity rarity, int spellPower) : base(name, rarity)
    {
        if (spellPower <= 0)
        {
            throw new ArgumentException(
                "Spell power must be greater than 0",
                nameof(spellPower));
        }
        SpellPower = spellPower;
    }

    public void Use()
    {
        Console.WriteLine($"Used {Name} with spell power {SpellPower}.");
    }
}

