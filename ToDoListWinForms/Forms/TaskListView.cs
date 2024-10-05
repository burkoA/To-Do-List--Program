using System.ComponentModel;
using ToDoListWinForms.Forms;
using ToDoListWinForms.Models;
using ToDoListWinForms.Service;

namespace ToDoListWinForms
{
    public partial class TaskListView : Form
    {
        private BackgroundWorker createJsonWorker;
        private static LoginModel _loginUser = new LoginModel();
        private List<TaskModel> _taskList = new List<TaskModel>();

        public TaskListView(LoginModel login)
        {
            InitializeComponent();

            createJsonWorker = new BackgroundWorker();
            createJsonWorker.DoWork += CreateJson_DoWork;
            _loginUser.Email = login.Email;
            userEmail.Text = login.Email;

            _taskList = FileService.LoadTasksFromFile(_loginUser.Email);
        }

        private void TaskListView_Load(object sender, EventArgs e)
        {
            createJsonWorker.RunWorkerAsync();

            foreach (TaskModel task in _taskList)
            {
                taskListBox.Items.Add($"{task.CompleteDate.ToString("MM/dd/yy")} - {task.Task}"
                    , task.IsCompleted);
            }
        }

        private void CreateJson_DoWork(object sender, DoWorkEventArgs e)
        {
            FileService.CreateJsonFile();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < taskListBox.Items.Count; i++)
            {
                _taskList[i].IsCompleted = taskListBox.GetItemChecked(i);
            }

            FileService.SaveTasksToFile(_taskList);
            MessageBox.Show("Successfuly saved :)");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex != -1)
            {
                int selectedIndex = taskListBox.SelectedIndex;

                TaskModel taskText = _taskList[selectedIndex];

                FileService.DeleteTask(_loginUser.Email, taskText.Task);

                taskListBox.Items.RemoveAt(selectedIndex);

                _taskList = FileService.LoadTasksFromFile(_loginUser.Email);
                MessageBox.Show("Successfully deleted :)");
            }
            else
            {
                MessageBox.Show("Choose a task to delete -_-");
            }
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            CreateForm create = new CreateForm(this, _taskList, _loginUser.Email);

            create.Show();
            this.Hide();
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex != -1)
            {
                int selectedIndex = taskListBox.SelectedIndex;
                EditForm edit = new EditForm(this, _taskList[selectedIndex], _loginUser.Email);

                edit.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Choose task for edit! -_-");
            }
        }

        public void RefreshTaskList()
        {
            taskListBox.Items.Clear();
            _taskList = FileService.LoadTasksFromFile(_loginUser.Email);
            foreach (TaskModel task in _taskList)
            {
                taskListBox.Items.Add($"{task.CompleteDate.ToString("MM/dd/yy")} - {task.Task}"
                    , task.IsCompleted);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Close();
            loginForm.Show();
        }

        private void convertToCalendarButton_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm(_loginUser.Email);

            calendarForm.Show();
            this.Close();
        }
    }
}
