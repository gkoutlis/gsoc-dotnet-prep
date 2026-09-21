
using GsocPrep.Interfaces;
using GsocPrep.Models;
using GsocPrep.Models.Enums;

public class Program
{
    public static void Main()
    {
        Storage<Item> itemStorage = new();
        
        
        
        WorkTask task = new WorkTask(1,"dokimi", Priority.Low );
     
        


        WorkTask task2 = new WorkTask(2,"dokimi", Priority.Medium);
       

        WorkTask task3 = new WorkTask(3,"dokimi", Priority.High);



        WorkTask task4 = new WorkTask(4,"dokimi", Priority.Medium);
        Potion potion = new Potion("HealthPotion", Rarity.Common, 50);
        Scroll scroll = new Scroll("Fire Scroll", Rarity.Rare, 80);
        Weapon weapon = new Weapon("colosal", Rarity.Common, 54);
        
        try
        {
            WorkTask Invalidtask = new WorkTask(0, "", Priority.Low);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }


        List<IUsable> usables = new List<IUsable>
        {
            potion, scroll
        };
        List<WorkTask> workTasks = new List<WorkTask>
        {
            task, task2, task3, task4
        };

        foreach (var item in usables)
        {
            item.Use();
        }
        
        itemStorage.AddItem(potion);
        itemStorage.AddItem(scroll);
        
        var allΙtems = itemStorage.GetAllItems();

        foreach (var item in allΙtems)
        {
            Console.WriteLine(item.Name);
        }

        var tasksQuery = from w in workTasks
            where w.Priority == Priority.High
                  && w.IsCompleted == false
            select w;

        foreach (var item in tasksQuery)
        {
            Console.WriteLine(item.Title);
        }
        
        Player player1 = new Player("Thaladin");
        player1.OnLevelUp = level => Console.WriteLine($"Leveled up to {level}!");  

        Console.WriteLine($"Before: {player1.Name} - Level {player1.Level} - XP {player1.Xp}");

        player1.AddXp(500);

        Console.WriteLine($"After: {player1.Name} - Level {player1.Level} - XP {player1.Xp}");
        
        Console.WriteLine($"Damage before equip:{player1.GetEquippedDamage()}");
        player1.Equip(weapon);
        Console.WriteLine($"Equipped damage:{player1.GetEquippedDamage()}");
    }

    

    public void CompleteTask(WorkTask task)
    {
        task.IsCompleted = true;
    }

    public void PrintTask(WorkTask task)
    {
        Console.WriteLine(task.Id);
        Console.WriteLine(task.Title);
        Console.WriteLine(task.Priority);

        if (task.IsCompleted)
        {
            Console.WriteLine("completed");
        }
        else
        {
            Console.WriteLine("not completed");
        }
    }

    public void PrintTasks(List<WorkTask> tasks)
    {
        foreach (var task in tasks)
        {
            PrintTask(task);
        }

        
    }
    
    public List<WorkTask> GetInCompleteTasks(List<WorkTask> tasks)
    {
        List<WorkTask> incompleteTasks = new List<WorkTask>();

        foreach (var task in tasks)
        {
            if (task.IsCompleted == false)
            {
                incompleteTasks.Add(task);
            }
        }

        return incompleteTasks;
    }
    //LINQ
    //public List<WorkTask> GetInCompletetasks(List<WorkTask> tasks){
    //return tasks
    //  .Where(task=> !task.IsCompleted)
    //  .ToList();
    // }

    
    


}

    

    
