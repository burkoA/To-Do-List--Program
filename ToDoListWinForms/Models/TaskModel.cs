using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListWinForms.Models
{
    public class TaskModel
    {
        public string Task { get; set; } = "";
        public bool IsCompleted { get; set; } = false;
        public DateTime? CompleteDate { get; set; }
    }
}
