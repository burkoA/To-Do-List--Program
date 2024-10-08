﻿using ToDoListWinForms.Models;
using ToDoListWinForms.Service;

namespace ToDoListWinForms.Forms
{
    public partial class EditForm : Form
    {
        private static TaskModel _task;
        private TaskListView _listView;
        private static string _userEmail;
        private LoginForm _loginForm;

        public EditForm(TaskListView taskView, TaskModel task, string email, LoginForm loginForm)
        {
            InitializeComponent();

            _listView = taskView;
            _task = task;
            _userEmail = email;
            _loginForm = loginForm;

            dateTimePicker1.Text = _task.CompleteDate.ToString("MM/dd/yy");
            editTaskBox.Text = _task.Task;

            this.FormClosing += EditForm_FormClosing;
        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_listView == null)
            {
                CalendarForm calendar = new CalendarForm(_userEmail,_loginForm);
                calendar.Show();
            }
            else
            {
                _listView.Show();
            }
        }

        private void SaveEditButton_Click(object sender, EventArgs e)
        {
            if (TaskService.ValidateTaskInput(editTaskBox.Text, dateTimePicker1.Text, out DateTime date))
            {
                string oldTaskDescription = _task.Task;

                TaskModel editedTask = new TaskModel
                {
                    Email = _userEmail,
                    Task = editTaskBox.Text,
                    CompleteDate = date,
                };

                FileService.EditTask(editedTask, oldTaskDescription, _userEmail);
                TaskService.ShowMessage("Successfully edited :)");

                if(_listView != null)
                {
                    _listView.RefreshTaskList();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void EditCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
