using ToDoList.Models;
using ToDoList.Service;

namespace ToDoList
{
    internal class Program
    {

        private const string _commandList = "\n1. View list of tasks \n" +
            "2. Add task \n" +
            "3. Delete Task \n" +
            "0. End program";

        private static List<TaskModel> _taskList = new List<TaskModel>();
        private static string _choosenCommand = "";

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
                        string choosenTask = Console.ReadLine();
                        DeleteTaskFromList(choosenTask);
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
                    Console.WriteLine($"{i + 1}. Task - {task.Task}, completed - {task.IsCompleted}, date - {task.CompleteDate}");
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

            _task.Task = task;

            _taskList.Add(_task);
            FileService.SaveTasksToFile(_taskList);

            Console.WriteLine("\n Your task was successfuly added :) . Your list - \n");
            GetTaskList();
        }

        private static void DeleteTaskFromList(string? numberOfTask)
        {
            if (int.TryParse(numberOfTask, out int number) && number > 0 && number <= _taskList.Count)
            {
                _taskList.RemoveAt(number - 1);

                FileService.SaveTasksToFile(_taskList);

                Console.WriteLine("\n Your task was successfuly deleted :) . Your list - \n");
                GetTaskList();
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }
    }
}
