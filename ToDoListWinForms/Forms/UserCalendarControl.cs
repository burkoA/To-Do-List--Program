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
        
        public UserCalendarControl(string day, string email, bool isPlaceHolder)
        {
            InitializeComponent();
            
            _day = day;
            label1.Text = _day;
            _userEmail = email;
            _isPlaceholder = isPlaceHolder;

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
            catch(Exception) { }
        }
    }
}
