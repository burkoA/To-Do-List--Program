using ToDoListWinForms.Models;
using ToDoListWinForms.Service;

namespace ToDoListWinForms.Forms
{
    public partial class LoginForm : Form
    {
        private LoginModel _loginModel = new LoginModel();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            _loginModel.Password = passwordTextBox.Text;
            _loginModel.Email = emailTextBox.Text;

            if (AccountService.IsValidLogin(_loginModel.Email, _loginModel.Password))
            {
                TaskListView _taskListView = new TaskListView(_loginModel, this);

                MessageBox.Show("Login Succesful!");

                _taskListView.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password :(");
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm _registrationForm = new RegistrationForm();

            this.Hide();
            _registrationForm.Show();
        }
    }
}
