using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListWinForms.Models;
using ToDoListWinForms.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDoListWinForms.Forms
{
    public partial class UserCalendarControl : UserControl
    {
        string _day, date, weekend;
        private List<TaskModel> _taskList = new List<TaskModel>();
        private string _userEmail;
        private bool _isPlaceholder;
        private CalendarForm _calendarForm;

        public UserCalendarControl(string day, string email, bool isPlaceHolder, CalendarForm calendar)
        {
            InitializeComponent();

            _day = day;
            label1.Text = _day;
            _userEmail = email;
            _isPlaceholder = isPlaceHolder;
            _calendarForm = calendar;

            _taskList = FileService.LoadTasksFromFile(_userEmail);

            this.BackColor = Color.Black;
            checkedListBox1.Hide();

            date = CalendarForm._month + "/" + _day + "/" + CalendarForm._year;

            if (!_isPlaceholder)
            {
                checkedListBox1.Show();
                if (!string.IsNullOrEmpty(_day) && int.TryParse(_day, out int dayInt))
                {
                    try
                    {
                        DateTime currentDate = new DateTime(CalendarForm._year, CalendarForm._month, dayInt);
                        date = currentDate.ToShortDateString();

                        List<TaskModel> tasksForDate = _taskList.Where(task => task.CompleteDate.Date == currentDate.Date).ToList();

                        if (tasksForDate.Any())
                        {
                            foreach (var task in tasksForDate)
                            {
                                if (task.Task.Length > 15)
                                {
                                    checkedListBox1.Items.Add(task.Task.Substring(0, 15) + "...", task.IsCompleted);
                                }
                                else
                                {
                                    checkedListBox1.Items.Add(task.Task, task.IsCompleted);
                                }
                            }

                            label1.ForeColor = Color.Blue;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error in formatting date: {ex.Message}");
                    }
                }
            }
        }

        private void UserCalendarControl_Load(object sender, EventArgs e)
        {
            Sundays();
        }

        private void Sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                weekend = day.ToString("ddd");
                if (weekend == "Sun")
                {
                    label1.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    label1.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }
            catch (Exception) { }
        }

        private void editTaskCalendarButton_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                string selectedTaskText = checkedListBox1.SelectedItem.ToString();

                TaskModel taskToEdit = _taskList.FirstOrDefault(task => task.Task == selectedTaskText);

                if (taskToEdit != null)
                {
                    EditForm edit = new EditForm(null, taskToEdit, _userEmail);

                    edit.Show();
                    _calendarForm.Close();
                }
                else
                {
                    MessageBox.Show("Task not found");
                }
            }
            else
            {
                MessageBox.Show("Choose task for edit! -_-");
            }
        }

        private void deleteTaskCalendarButton_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                int selectedIndex = checkedListBox1.SelectedIndex;

                TaskModel taskText = _taskList[selectedIndex];

                FileService.DeleteTask(_userEmail, taskText.Task);

                checkedListBox1.Items.RemoveAt(selectedIndex);

                _taskList = FileService.LoadTasksFromFile(_userEmail);
                MessageBox.Show("Successfully deleted :)");
            }
            else
            {
                MessageBox.Show("Choose a task to delete -_-");
            }
        }

        public void UpdateTaskCompletion(List<TaskModel> taskList)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                string taskText = checkedListBox1.Items[i].ToString();

                TaskModel taskToUpdate = taskList
                    .FirstOrDefault(task => task.Task == taskText && task.CompleteDate.Date == GetDate());

                if (taskToUpdate != null)
                {
                    taskToUpdate.IsCompleted = checkedListBox1.GetItemChecked(i);
                }
            }
        }

        public DateTime GetDate()
        {
            return DateTime.Parse(date);
        }
    }
}
