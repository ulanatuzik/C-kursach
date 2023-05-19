using ROV_TL.Models;
using ROV_TL.Forms;
using NLog;
using ROV_TL.AdminForms;
using Microsoft.EntityFrameworkCore;

namespace ROV_TL
{
    public partial class LoginForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();
        public LoginForm()
        {
            InitializeComponent();
            db.Set<User>().AsNoTracking();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Не все данные заполнены", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = new User { Login = LoginTextBox.Text, Password = PasswordTextBox.Text};

            try
            {
                User tryUser = db.Users.Where(x => x.Login == user.Login).First();

                if (user.Password == tryUser.Password)
                {
                    log.Info("User login success {login}", user.Login);

                    ProfileForm profileForm = new ProfileForm(tryUser.Id);
                    this.Hide();
                    profileForm.ShowDialog();

                    this.Close();
                }
                else
                {
                    log.Warn("Invalid password for user {login}", user.Login);

                    MessageBox.Show("Неверный пароль", "ROV Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                try
                {
                    Admin admin = db.Admins.Where(a => a.Login == LoginTextBox.Text).First();
                    
                    if (admin.Password == PasswordTextBox.Text)
                    {
                        AdminsForm adminForm = new AdminsForm(admin);
                        this.Hide();
                        adminForm.ShowDialog();
                        this.Show();

                        log.Info("Admin login success {login}", admin.Login);
                    }
                    else
                    {
                        log.Warn("Invalid password for admin {login}", admin.Login);

                        MessageBox.Show("Неверный пароль", "ROV Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception excep)
                {
                    log.Warn("Invalid login {login}", user.Login);

                    MessageBox.Show("Такого логина не существует", "ROV Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            log.Info("Application closing {args}", e.GetHashCode());
            LogManager.Shutdown();

            this.Close();
        }
    }
}