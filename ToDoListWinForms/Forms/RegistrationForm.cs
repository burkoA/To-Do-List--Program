using ToDoListWinForms.Models;
using ToDoListWinForms.Service;

namespace ToDoListWinForms.Forms
{
    public partial class RegistrationForm : Form
    {
        private RegistrationModel registrationModel = new RegistrationModel();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void CreateAcc_Click(object sender, EventArgs e)
        {
            if (repeatPasswordBox.Text == createPasswordBox.Text && AccountService.IsValidEmail(createEmailBox.Text) == true)
            {

                registrationModel.Password = createPasswordBox.Text;
                registrationModel.Email = createEmailBox.Text;

                AccountService.CreateBinFile();
                AccountService.SaveDataToFile(registrationModel);

                MessageBox.Show("You create account :)");

                LoginForm loginForm = new LoginForm();
                this.Close();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Password doesn't match or email have wrong type");
            }
        }

        private void BackToLoginForm_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Close();
            loginForm.Show();
        }
    }
}
