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

namespace ToDoListWinForms.Forms
{
    public partial class CalendarForm : Form
    {
        public static int _year, _month;
        private static string _userEmail;
        private LoginModel _loginModel = new LoginModel();
        private List<TaskModel> _taskList = new List<TaskModel>();
        private LoginForm _loginForm;
        private bool _hasUnsavedChanges = false;

        public CalendarForm(string email, LoginForm loginForm)
        {
            InitializeComponent();

            _userEmail = email;
            setUserEmailCalendar.Text = _userEmail;
            _loginForm = loginForm;
            _taskList = FileService.LoadTasksFromFile(_userEmail);

            label1.ForeColor = Color.FromArgb(255, 128, 128);

            this.FormClosing += CalendarForm_FormClosing;
        }

        private void CalendarForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (_hasUnsavedChanges)
            {
                DialogResult result = MessageBox.Show("You have unsaved changes. Do you really want to close without saving?",
                    "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                _loginForm.Close();
            }
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            ShowDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void ShowDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lbMonth.Text = monthName.ToUpper() + " " + year;
            DateTime startTheMonth = new DateTime(year, month, 1);

            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < week; i++)
            {
                UserCalendarControl userControl = new UserCalendarControl("", _userEmail, isPlaceHolder: true, this, _loginForm);
                flowLayoutPanel1.Controls.Add(userControl);
            }

            for (int i = 1; i <= day; i++)
            {
                UserCalendarControl user = new UserCalendarControl(i + "", _userEmail, isPlaceHolder: false, this, _loginForm);
                flowLayoutPanel1.Controls.Add(user);
            }
        }

        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            ShowDays(_month, _year);
        }

        private void buttonPreviousMonth_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            ShowDays(_month, _year);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _loginModel.Email = _userEmail;
            TaskListView taskView = new TaskListView(_loginModel,_loginForm);

            this.Hide();
            taskView.Show();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm(null, _taskList, _userEmail,_loginForm);

            this.Hide();
            createForm.Show();
        }

        private void saveButtonCalendar_Click(object sender, EventArgs e)
        {
            foreach (UserCalendarControl calendarControl in flowLayoutPanel1.Controls.OfType<UserCalendarControl>())
            {
                calendarControl.UpdateTaskCompletion(_taskList);
            }

            FileService.SaveTasksToFile(_taskList);
            _hasUnsavedChanges = false;
            MessageBox.Show("Tasks saved successfully!");
        }

        public void MarkAsUnsaved()
        {
            _hasUnsavedChanges = true;
        }
    }
}
