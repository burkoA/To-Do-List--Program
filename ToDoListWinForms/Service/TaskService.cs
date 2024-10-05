using System.Globalization;

namespace ToDoListWinForms.Service
{
    public class TaskService
    {
        public static bool ValidateTaskInput(string task, string dateInput, out DateTime date)
        {
            string[] formats = { "dddd, MMMM d, yyyy", "MM/dd/yy", "yyyy-MM-dd" };

            if (DateTime.TryParseExact(dateInput, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out date) && date > DateTime.Now)
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
