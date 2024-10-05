using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListWinForms.Forms
{
    public partial class UserCalendarControl : UserControl
    {
        string _day, date, weekend;

        public UserCalendarControl(string day)
        {
            InitializeComponent();

            _day = day;
            label1.Text = _day;
            checkBox1.Hide();

            date = CalendarForm._month + "/" + _day + "/" + CalendarForm._year;
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

        private void panel1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.Black;
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }
    }
}
