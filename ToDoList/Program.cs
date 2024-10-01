namespace ToDoList
{
    internal class Program
    {

        private const string commandList = "\n1. View list of tasks \n" +
            "2. Add task \n" +
            "3. Delete Task \n" +
            "0. End program";

        private static List<string> taskList = new List<string>();
        private static string choosenCommand = "";

        static void Main(string[] args)
        {
            Console.WriteLine($"Hello User! I'm To-Do List program. Choose the command - {commandList}");
            choosenCommand = Console.ReadLine();

            while (choosenCommand != "0")
            {
                switch (choosenCommand)
                {
                    case "1":
                        GetTaskList(taskList);
                        break;
                    case "2":
                        Console.WriteLine("Write your task for adding - ");
                        string taskToAdd = Console.ReadLine();
                        AddTaskToList(taskList, taskToAdd);
                        break;
                    case "3":
                        Console.WriteLine($"Write number of task that you want delete - ");
                        GetTaskList(taskList);
                        string choosenTask = Console.ReadLine();
                        DeleteTaskFromList(taskList, choosenTask);
                        break;
                    default:
                        Console.WriteLine("Invalid command. Please try again!");
                        break;
                }

                Console.WriteLine($"{commandList}");
                choosenCommand = Console.ReadLine();
            }
        }

        private static void GetTaskList(List<string> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Your list is empty :(");
            }
            else
            {
                for (int count = 0; count < list.Count; count++)
                {
                    Console.WriteLine($"{count + 1}. {list[count]} \n");
                }
            }
        }

        private static void AddTaskToList(List<string> list, string? task)
        {
            while (string.IsNullOrEmpty(task))
            {
                Console.WriteLine("You didn't provide task. Try again - ");
                task = Console.ReadLine();
            }

            list.Add(task);
            Console.WriteLine("\n Your task was successfuly added :) . Your list - \n");
            GetTaskList(list);
        }

        private static void DeleteTaskFromList(List<string> list, string? numberOfTask)
        {
            if (int.TryParse(numberOfTask, out int number) && number > 0 && number <= list.Count)
            {
                list.RemoveAt(number - 1);
                Console.WriteLine("\n Your task was successfuly deleted :) . Your list - \n");
                GetTaskList(list);
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }
    }
}
