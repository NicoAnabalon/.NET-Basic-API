using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAPI.Models
{
    public enum Priority
    {
        Urgent, High, Medium, Low
    }
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Priority Priority { get;set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsComplete { get; set; }
    }
}
