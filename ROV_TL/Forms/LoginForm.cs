using ROV_TL.Models;
using ROV_TL.Forms;

namespace ROV_TL
{
    public partial class LoginForm : Form
    {
        ApplicationContext db = new ApplicationContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = new User { Login = loginTextBox.Text, Password = passwordTextBox.Text};

            User tryUser = db.Users.Where(x => x.Login == user.Login).First();

            if (user.Password == tryUser.Password)
            {
                ProfileForm profileForm = new ProfileForm(tryUser);
                profileForm.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("xuy");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}