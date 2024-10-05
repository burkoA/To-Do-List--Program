using ToDoListWinForms.Models;
using ToDoListWinForms.Service;

namespace ToDoListWinForms.Forms
{
    public partial class RegistrationForm : Form
    {
        private RegistrationModel _registrationModel = new RegistrationModel();
        private List<LoginModel> _loginModelList = AccountService.LoadAllProfile();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void CreateAcc_Click(object sender, EventArgs e)
        {
            if (repeatPasswordBox.Text == createPasswordBox.Text && AccountService.IsValidEmail(createEmailBox.Text) == true)
            {
                List<LoginModel> loginEmail = _loginModelList.Where(e => e.Email == createEmailBox.Text.Trim()).ToList();
                if (loginEmail.Count == 0)
                {
                    _registrationModel.Password = createPasswordBox.Text;
                    _registrationModel.Email = createEmailBox.Text;

                    AccountService.CreateBinFile();
                    AccountService.SaveDataToFile(_registrationModel);

                    MessageBox.Show("You create account :)");

                    LoginForm loginForm = new LoginForm();
                    this.Close();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("This email is already in use");
                }
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
