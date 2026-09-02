
using System.Collections;
using GsocPrep.Models;
using GsocPrep.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class Program
{
    public static void Main()
    {
        WorkTask task = new WorkTask();
        {
            task.Id = 1;
            task.Title = "Hello World";
            task.Priority = Priority.High;
            task.IsCompleted = true;

            Console.WriteLine(task.Title);
        }

        WorkTask task2 = new WorkTask();
        {
            task2.Id = 2;
            task2.Title = "Hello fuck u";
            task2.Priority = Priority.Low;
            task2.IsCompleted = true;

            Console.WriteLine(task2.Title);
        }

        WorkTask task3 = new WorkTask();
        {
            task3.Id = 3;
            task3.Title = "Hello World";
            task3.Priority = Priority.Low;
            task3.IsCompleted = true;

            Console.WriteLine(task3.Title);


        }
        WorkTask task4 = new WorkTask();
        {
            task4.Id = 4;
            task4.Title = "Hello World";
            task4.Priority = Priority.Low;
            task4.IsCompleted = true;

            Console.WriteLine(task4.Title);


        }
        WorkTask task5 = new WorkTask();
        {
            task5.Id = 5;
            task5.Title = "Hello World";
            task5.Priority = Priority.Low;
            task5.IsCompleted = true;

            Console.WriteLine(task5.Title);


        }


        List<WorkTask> workTasks = new List<WorkTask>()
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
        if (task.IsCompleted == true)
        {
            task.IsCompleted = false;
        }
        else
        {
            task.IsCompleted = true;
        }
    }
}
