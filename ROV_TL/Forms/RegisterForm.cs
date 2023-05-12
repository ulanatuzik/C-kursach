using System.Data;
using ROV_TL.Models;
using NLog;

namespace ROV_TL.Forms
{
    public partial class RegisterForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text,
                Email = emailTextBox.Text,
                Fio = fioTextBox.Text,
                Balance = 0
            };

            if (IsLoginUnique(user) == true && IsEmailUnique(user) == true)
            {
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Успешная регистрация\nВаши данные можно найти в профиле.");

                log.Info("User register success {login}", user.Login);

                ProfileForm profileForm = new ProfileForm(user);
                this.Hide();
                profileForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Такие данные как логин и/или электронная почта уже существуют!");
            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private bool IsEmailUnique(User user)
        {
            try
            {
                // if there's no users with 'email' it creates exception
                User emailUser = db.Users.Where(x => x.Email == user.Email).First();
            }
            catch (Exception ex)
            {
                return true;
            }

            log.Warn("Data is not unique: email {email}", user.Email);
            return false;
        }
        private bool IsLoginUnique(User user)   
        {
            try
            {
                // if there's no users with 'login' it creates exception
                User logUser = db.Users.Where(x => x.Login == user.Login).First();
            }
            catch (Exception ex)
            {
                return true;
            }

            log.Warn("Data is not unique: login {login}", user.Login);
            return false;
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            log.Info("Application closing {args}", e.GetHashCode());
            LogManager.Shutdown();

            this.Close();
        }
    }
}
