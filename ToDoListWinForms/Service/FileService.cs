using System.Text.Json;
using ToDoListWinForms.Models;

namespace ToDoListWinForms.Service
{
    internal class FileService
    {
        private static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static string filePath = Path.Combine(desktopPath, "task.json");

        public static void CreateJsonFile()
        {
            if(!File.Exists(filePath))
            {
                string initialJsonContent = "[]";

                File.WriteAllText(filePath, initialJsonContent);
            }
        }

        public static void SaveTasksToFile(List<TaskModel> taskList)
        {
            string updatedJson = JsonSerializer.Serialize(taskList);
            File.WriteAllText(filePath, updatedJson);
        }

        public static List<TaskModel> LoadTasksFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                // Deserialize the JSON into a list of TaskModel
                return JsonSerializer.Deserialize<List<TaskModel>>(json) ?? new List<TaskModel>();
            }
            return new List<TaskModel>(); // Return an empty list if file does not exist
        }
    }
}
