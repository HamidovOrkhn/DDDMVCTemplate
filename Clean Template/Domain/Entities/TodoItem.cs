using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Enums.PriorityLevel;

namespace Domain.Entities
{
    public class TodoItem:BaseEntity
    {
        public string? Name { get; set; }
        public int Count { get; set; }
        public DateTime Deadline { get; set; }
        public Priority Priority { get; set; }
    }
}
