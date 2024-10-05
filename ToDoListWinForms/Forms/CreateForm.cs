using ToDoListWinForms.Models;
using ToDoListWinForms.Service;

namespace ToDoListWinForms.Forms
{
    public partial class CreateForm : Form
    {
        private TaskListView _taskListView;
        private List<TaskModel> _taskList;
        private static string _userEmail;

        public CreateForm(TaskListView taskListView, List<TaskModel> taskList, string email)
        {
            InitializeComponent();
            _taskListView = taskListView;
            _taskList = taskList;
            _userEmail = email;

            this.FormClosing += CreateForm_FormClosing;
        }

        private void CreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_taskListView == null)
            {
                CalendarForm form = new CalendarForm(_userEmail);
                form.Show();
            }
            else
            {
                _taskListView.RefreshTaskList();
                _taskListView.Show();
            }
        }

        private void SaveCreateButton_Click(object sender, EventArgs e)
        {
            if (TaskService.ValidateTaskInput(taskTextBox.Text, dateTextBox.Text, out DateTime date))
            {

                TaskModel newTask = new TaskModel()
                {
                    Email = _userEmail,
                    Task = taskTextBox.Text,
                    CompleteDate = date,
                };

                _taskList.Add(newTask);
                FileService.SaveTasksToFile(_taskList);
                TaskService.ShowMessage("Task added");

                this.Close();            
            }
            else
            {
                TaskService.ShowMessage("Invalid input! -_-");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
