using GsocPrep.Models.Enums;

namespace GsocPrep.Models
{
    public class WorkTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Priority Priority { get; set; }
        public bool IsCompleted { get; set; }
        
        public WorkTask(int id, string title, Priority priority)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title can't be empty", nameof(title));
            }if(id <= 0){
                throw new ArgumentException("Id must be greater than 0", nameof(id));
                
            }
            Id = id;
            Title = title;
            Priority = priority;
            IsCompleted = false;
        }
        
        public WorkTask(
            int id,
            string title,
            Priority priority,
            bool isCompleted)
            : this(id, title, priority)
        {
            IsCompleted = isCompleted;
        }
    }
    
    
}

