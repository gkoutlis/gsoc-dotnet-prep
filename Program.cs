
using GsocPrep.Models;
using GsocPrep.Models.Enums;

public class Program
{
    public static void Main()
    {
        WorkTask task = new WorkTask
        {
            Id = 1,
            Title = "Hello World",
            Priority = Priority.High,
            IsCompleted = true,

        };
        


        WorkTask task2 = new WorkTask
        {
            Id = 2,
            Title = "Hello fuck u",
            Priority = Priority.Low,
            IsCompleted = false

        };

        WorkTask task3 = new WorkTask
        {
            Id = 3,
            Title = "Hello World",
            Priority = Priority.Low,
            IsCompleted = true,
        };


        WorkTask task4 = new WorkTask
        {
            Id = 4,
            Title = "Hello World",
            Priority = Priority.Low,
            IsCompleted = false


        };
        WorkTask task5 = new WorkTask
        {
            Id = 5,
            Title = "Hello World",
            Priority = Priority.Low,
            IsCompleted = true,


        };


        List<WorkTask> workTasks = new List<WorkTask>
        {
            task, task2, task3, task4, task5
        };



        var tasksQuery = from w in workTasks
            where w.Priority == Priority.High
                  && w.IsCompleted == false
            select w;

        foreach (var item in tasksQuery)
        {
            Console.WriteLine(item.Title);
        }
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

    

    
