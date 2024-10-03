using ToDoListWinForms.Models;
using ToDoListWinForms.Service;

namespace ToDoListWinForms.Forms
{
    public partial class EditForm : Form
    {
        private TaskModel _task;
        private TaskListView _listView;
        private int _selectedTask;
        private List<TaskModel> _taskList = FileService.LoadTasksFromFile();

        public EditForm(TaskListView taskView, TaskModel task, int selectedIndex)
        {
            InitializeComponent();

            _listView = taskView;
            _task = task;
            _selectedTask = selectedIndex;

            editDateBox.Text = _task.CompleteDate.HasValue ? _task.CompleteDate.Value.ToString("MM/dd/yy") : "No data set";
            editTaskBox.Text = _task.Task;

            this.FormClosing += EditForm_FormClosing;
        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _listView.Show();
        }

        private void SaveEditButton_Click(object sender, EventArgs e)
        {

            if (TaskService.ValidateTaskInput(editTaskBox.Text, editDateBox.Text, out DateTime date))
            {
                _taskList[_selectedTask].CompleteDate = date;
                _taskList[_selectedTask].Task = editTaskBox.Text;

                FileService.SaveTasksToFile(_taskList);
                TaskService.ShowMessage("Successfuly edited :)");

                _listView.RefreshTaskList();
                this.Close();
                _listView.Show();
            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void EditCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _listView.Show();
        }
    }
}
