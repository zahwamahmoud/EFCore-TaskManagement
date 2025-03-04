using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ef.model
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; } // Low, Medium, High
        public Status Status { get; set; } // Pending, In Progress, Completed
        public int UserId { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
    public enum Status
    {
        Pending, InProgress, Completed
    }
    public enum Priority
    {
        Low, Medium, High
    }
}
