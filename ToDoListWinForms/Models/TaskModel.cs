namespace ToDoListWinForms.Models
{
    public class TaskModel
    {
        public string Task { get; set; } = "";
        public bool IsCompleted { get; set; } = false;
        public DateTime? CompleteDate { get; set; }
    }
}
