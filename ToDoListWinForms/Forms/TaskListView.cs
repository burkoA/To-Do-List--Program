using System.ComponentModel;
using ToDoListWinForms.Models;
using ToDoListWinForms.Service;

namespace ToDoListWinForms
{
    public partial class TaskListView : Form
    {
        private BackgroundWorker createJsonWorker;
        private List<TaskModel> _taskList = FileService.LoadTasksFromFile();

        public TaskListView()
        {
            InitializeComponent();

            createJsonWorker = new BackgroundWorker();
            createJsonWorker.DoWork += createJson_DoWork;
        }

        private void TaskListView_Load(object sender, EventArgs e)
        {
            createJsonWorker.RunWorkerAsync();

            foreach (TaskModel task in _taskList)
            {
                taskListBox.Items.Add($"{(task.CompleteDate.HasValue
                    ? task.CompleteDate.Value.ToString("MM/dd/yy") : "No data set")} - {task.Task}"
                    , task.IsCompleted);
            }
        }

        private void createJson_DoWork(object sender, DoWorkEventArgs e)
        {
            FileService.CreateJsonFile();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < taskListBox.Items.Count; i++)
            {
                _taskList[i].IsCompleted = taskListBox.GetItemChecked(i);
            }

            FileService.SaveTasksToFile(_taskList);
            MessageBox.Show("Successfuly saved :)");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(taskListBox.SelectedIndex != -1)
            {
                int selectedIndex = taskListBox.SelectedIndex;

                _taskList.RemoveAt(selectedIndex);

                taskListBox.Items.RemoveAt(selectedIndex);

                FileService.SaveTasksToFile(_taskList);
                MessageBox.Show("Successfuly deleted :)");
            }
            else
            {
                MessageBox.Show("Choose task for delete -_-");
            }
        }
    }
}
