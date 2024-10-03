namespace ToDoListWinForms.Service
{
    public class TaskService
    {
        public static bool ValidateTaskInput(string task, string dateInput, out DateTime date)
        {
            if (DateTime.TryParse(dateInput, out date) && date > DateTime.Now)
            {
                return !string.IsNullOrEmpty(task);
            }
            return false;
        }

        public static void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
