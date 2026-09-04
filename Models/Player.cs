namespace GsocPrep.Models;

public class Player
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Xp { get; private set; }

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
    }
}