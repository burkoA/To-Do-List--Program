using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (DateTime.TryParse(editDateBox.Text, out DateTime date) && date > DateTime.Now)
            {
                if (!string.IsNullOrEmpty(editTaskBox.Text))
                {
                    _taskList[_selectedTask].CompleteDate = date;
                    _taskList[_selectedTask].Task = editTaskBox.Text;

                    FileService.SaveTasksToFile(_taskList);
                    MessageBox.Show("Successfuly edit :)");

                    _listView.RefreshTaskList();

                    this.Close();
                    _listView.Show();
                }
                else
                {
                    MessageBox.Show("Task field is empty -_-");
                }
            }
            else
            {
                MessageBox.Show("Wrong date format -_-");
            }
        }

        private void EditCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _listView.Show();
        }
    }
}
