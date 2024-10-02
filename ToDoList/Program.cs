using ToDoList.Models;
using ToDoList.Service;

namespace ToDoList
{
    internal class Program
    {

        private const string _commandList = "\n1. View list of tasks \n" +
            "2. Add task \n" +
            "3. Delete Task \n" +
            "4. Add date to task \n" +
            "5. Mark as completed or uncompleted \n" +
            "0. End program";

        private static List<TaskModel> _taskList = new List<TaskModel>();
        private static string _choosenCommand = "";
        private static string choosenTask = "";

        private static TaskModel _task = new TaskModel();

        static void Main(string[] args)
        {
            FileService.CreateJsonFile();
            LoadTasks();

            Console.WriteLine($"Hello User! I'm To-Do List program. Choose the command - {_commandList}");
            _choosenCommand = Console.ReadLine();

            while (_choosenCommand != "0")
            {
                switch (_choosenCommand)
                {
                    case "1":
                        GetTaskList();
                        break;
                    case "2":
                        Console.WriteLine("Write your task for adding - ");
                        string taskToAdd = Console.ReadLine();
                        AddTaskToList(taskToAdd);
                        break;
                    case "3":
                        Console.WriteLine($"Write number of task that you want delete - ");
                        GetTaskList();
                        choosenTask = Console.ReadLine();
                        DeleteTaskFromList(choosenTask);
                        break;
                    case "4":
                        Console.WriteLine($"Write number of task for adding date - ");
                        GetTaskList();
                        choosenTask = Console.ReadLine();
                        AddAndEditDateTask(choosenTask);
                        break;
                    case "5":
                        Console.WriteLine($"Write numbber of task for change to completed - ");
                        GetTaskList();
                        choosenTask = Console.ReadLine();
                        MarkAsCompletedOrUnCompleted(choosenTask);
                        break;
                    default:
                        Console.WriteLine("Invalid command. Please try again!");
                        break;
                }

                Console.WriteLine($"{_commandList}");
                _choosenCommand = Console.ReadLine();
            }
        }

        private static void LoadTasks()
        {
            _taskList = FileService.LoadTasksFromFile();
        }

        private static void GetTaskList()
        {
            if (_taskList.Count == 0)
            {
                Console.WriteLine("Your task list is empty.");
            }
            else
            {
                for (int i = 0; i < _taskList.Count; i++)
                {
                    TaskModel task = _taskList[i];
                    Console.WriteLine($"{i + 1}. Task - {task.Task}, completed - {task.IsCompleted}, date - {(task.CompleteDate.HasValue ? task.CompleteDate.Value.ToString("MM/dd/yy") : "No data set")}");
                }
            }
        }

        private static void AddTaskToList(string? task)
        {
            while (string.IsNullOrEmpty(task))
            {
                Console.WriteLine("You didn't provide task. Try again - ");
                task = Console.ReadLine();
            }

            TaskModel newTask = new TaskModel { Task = task };

            _taskList.Add(newTask);
            FileService.SaveTasksToFile(_taskList);

            SuccAddToListText();
        }

        private static void DeleteTaskFromList(string? numberOfTask)
        {
            if (int.TryParse(numberOfTask, out int number) && number > 0 && number <= _taskList.Count)
            {
                _taskList.RemoveAt(number - 1);

                FileService.SaveTasksToFile(_taskList);

                SuccAddToListText();
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }

        private static void AddAndEditDateTask(string chooseTask)
        {
            if(int.TryParse(chooseTask, out int number) && number > 0 && number <= _taskList.Count)
            {
                Console.WriteLine("Provide data for event (ex. mm/dd/yy)");
                string date = Console.ReadLine();

                if (DateTime.TryParse(date, out DateTime convertDate) && convertDate > DateTime.Now)
                {
                    _taskList[number-1].CompleteDate = convertDate;

                    FileService.SaveTasksToFile(_taskList);

                    SuccAddToListText();
                }
                else
                {
                    Console.WriteLine("Invalid date format or date earlier of todays day. Please provide date again");
                }
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }

        private static void MarkAsCompletedOrUnCompleted(string chooseTask)
        {
            if (int.TryParse(chooseTask, out int number) && number > 0 && number <= _taskList.Count)
            {

                if (_taskList[number - 1].IsCompleted == false)
                {

                    _taskList[number - 1].IsCompleted = true;

                    FileService.SaveTasksToFile(_taskList);

                    SuccAddToListText();
                }
                else if (_taskList[number - 1].IsCompleted == true)
                {
                    _taskList[number - 1].IsCompleted = false;

                    FileService.SaveTasksToFile(_taskList);

                    SuccAddToListText();
                }
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }

        private static void SuccAddToListText()
        {
            Console.WriteLine("\n Operation ended successfuly :) . Your list - \n");
            GetTaskList();
        }
    }
}
