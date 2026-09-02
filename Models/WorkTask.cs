using GsocPrep.Models.Enums;

namespace GsocPrep.Models
{
    public class WorkTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Priority Priority { get; set; }
        public bool IsCompleted { get; set; }
        
    }
}

