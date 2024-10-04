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

        public static List<TaskModel> LoadAllTasksFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<TaskModel> allTasks = JsonSerializer.Deserialize<List<TaskModel>>(json) ?? new List<TaskModel>();
                return allTasks;
            }
            return new List<TaskModel>();
        }

        public static void SaveTasksToFile(List<TaskModel> taskList)
        {
            List<TaskModel> allTasks = LoadAllTasksFromFile();

            foreach (var newTask in taskList)
            {
                var existingTask = allTasks.FirstOrDefault(t => t.Email == newTask.Email && t.Task == newTask.Task);

                if (existingTask != null)
                {
                    existingTask.IsCompleted = newTask.IsCompleted;
                    existingTask.CompleteDate = newTask.CompleteDate;
                }
                else
                {
                    allTasks.Add(newTask);
                }
            }

            string updatedJson = JsonSerializer.Serialize(allTasks);
            File.WriteAllText(filePath, updatedJson);
        }

        public static void EditTask(TaskModel editedTask, string oldText, string userEmail)
        {
            if (File.Exists(filePath))
            {
                List<TaskModel> allTasks = LoadAllTasksFromFile();

                TaskModel existingTask = allTasks.FirstOrDefault(t => t.Email == userEmail && t.Task == oldText);

                if (existingTask != null)
                {
                    existingTask.CompleteDate = editedTask.CompleteDate;
                    existingTask.Task = editedTask.Task;

                    string updatedJson = JsonSerializer.Serialize(allTasks);
                    File.WriteAllText(filePath, updatedJson);
                }
                else
                {
                    MessageBox.Show("Task not found for this user.");
                }
            }
        }

        public static List<TaskModel> LoadTasksFromFile(string email)
        {
            List<TaskModel> allTasks = LoadAllTasksFromFile();

            return allTasks.Where(task => task.Email == email).ToList();
        }

        public static void DeleteTask(string email, string taskDescription)
        {
            if (File.Exists(filePath))
            {
                List<TaskModel> allTasks = LoadAllTasksFromFile();

                TaskModel taskToDelete = allTasks.FirstOrDefault(task => task.Email == email && task.Task == taskDescription);

                if (taskToDelete != null)
                {
                    allTasks.Remove(taskToDelete);
                    string updatedJson = JsonSerializer.Serialize(allTasks);
                    File.WriteAllText(filePath, updatedJson);
                }
            }
        }
    }
}
