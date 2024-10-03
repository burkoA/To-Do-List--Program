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
    public partial class CreateForm : Form
    {
        private TaskListView _taskListView;
        private List<TaskModel> _taskList;

        public CreateForm(TaskListView taskListView, List<TaskModel> taskList)
        {
            InitializeComponent();
            _taskListView = taskListView;
            _taskList = taskList;

            this.FormClosing += CreateForm_FormClosing;
        }

        private void CreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _taskListView.Show();
        }

        private void saveCreateButton_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(dateTextBox.Text, out DateTime date) && date > DateTime.Now)
            {
                if (!string.IsNullOrEmpty(taskTextBox.Text))
                {
                    TaskModel newTask = new TaskModel()
                    {
                        Task = taskTextBox.Text,
                        CompleteDate = date,
                    };

                    _taskList.Add(newTask);
                    FileService.SaveTasksToFile(_taskList);
                    MessageBox.Show("Task added!");


                    _taskListView.RefreshTaskList();
                    this.Close();
                    _taskListView.Show();
                }
                else
                {
                    MessageBox.Show("Task box is empty!");
                }
            }
            else
            {
                MessageBox.Show("Wrong type of date");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _taskListView.Show();
        }
    }

}
