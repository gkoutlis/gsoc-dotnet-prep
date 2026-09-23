namespace GsocPrep.Models;

public class Player
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Xp { get; private set; }
    public Weapon? EquippedWeapon { get; private set; }
    public event Action<int, string>? OnLevelUp ;
    
    

    public Player(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name must not be empty", nameof(name));
        }
        Name = name;
        Level = 1;
        Xp = 0;
    }

    public void AddXp(int amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("amount must be greater than zero", nameof(amount));
        }
        Xp += amount;
        
        while (Xp >= 100)
        {
            LevelUp();
            Xp -= 100;
        }
    }
    private void LevelUp()
    {
        Level++;
        OnLevelUp?.Invoke(Level, Name);
    }

    public void Equip(Weapon weapon)
    {
        
        
        ArgumentNullException.ThrowIfNull(weapon);
        
        EquippedWeapon = weapon;
    }
    
    public void  Unequip()
    {
        EquippedWeapon =  null;
    }
    
    public int GetEquippedDamage()
    {
        return EquippedWeapon?. Damage ?? 0 ;
    }

    
    
    
}

