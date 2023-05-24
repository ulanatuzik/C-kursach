using NLog;
using ROV_TL.AdminForms.AdminAddtional;
using ROV_TL.Models;
using System.Data;
using System.Text.RegularExpressions;

namespace ROV_TL.AdminForms
{
    public partial class AdminProfileForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current admin
        Admin admin;

        // Array of lock/unlock pic boxes
        PictureBox[] accessBoxes;

        public AdminProfileForm(Admin currentAdmin)
        {
            InitializeComponent();
            admin = currentAdmin;
        }

        private void AdminProfileForm_Load(object sender, EventArgs e)
        {
            admin = db.Admins.Where(a => a.AdminId == admin.AdminId).First();

            WelcomeLabel.Text = $"Добро пожаловать, {admin.Login}";

            LoginTextBox.Text = admin.Login;
            PasswordTextBox.Text = admin.Password;
            EmailTextBox.Text = admin.Email;
            PasswordTextBox.UseSystemPasswordChar = true;

            accessBoxes = new PictureBox[3];
            accessBoxes[0] = AcessPictureBox_1;
            accessBoxes[1] = AcessPictureBox_2;
            accessBoxes[2] = AcessPictureBox_3;
        }

        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            LoginTextBox.ReadOnly = false;
            PasswordTextBox.ReadOnly = false;
            EmailTextBox.ReadOnly = false;

            for (int i = 0; i < accessBoxes.Length; i++)
            {
                accessBoxes[i].Image = Properties.Resources.UnlockIcon;
            }

            ConfirmDataButton.Enabled = true;
            ConfirmDataButton.Cursor = Cursors.Hand;
        }

        private bool IsEmailUnique(string email)
        {
            try
            {
                // If there's no users with 'email' it creates exception
                User userEmail = db.Users.Where(x => x.Email == email).First();
                Admin adminEmail = db.Admins.Where(a => a.Email == email).First();
            }
            catch (Exception ex)
            {
                return true;
            }

            log.Warn("Data is not unique: email {email}", email);
            return false;
        }
        private bool IsLoginUnique(string login)
        {
            try
            {
                // if there's no users with 'login' it creates exception
                User userLogin = db.Users.Where(x => x.Login == login).First();
                Admin adminLogin = db.Admins.Where(a => a.Login == login).First();
            }
            catch (Exception ex)
            {
                return true;
            }

            log.Warn("Data is not unique: login {login}", login);
            return false;
        }

        private void ConfirmDataButton_Click(object sender, EventArgs e)
        {
            // If any of data is empty it returns;
            if (LoginTextBox.Text == "" || PasswordTextBox.Text == "" || EmailTextBox.Text == "")
            {
                MessageBox.Show("Не все данные заполнены", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("Data is not fulled: admin {login}", admin.Login);
                return;
            }

            // Validating login; 4 < login < 12;
            if (LoginTextBox.Text.Length < 4 || LoginTextBox.Text.Length > 12)
            {
                MessageBox.Show("Неверный логин. Логин должен быть от 4 до 12 символов", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("Login is wrong: {login}", LoginTextBox.Text);
                return;
            }

            if (PasswordTextBox.Text.Length < 6 || LoginTextBox.Text.Length > 20)
            {
                MessageBox.Show("Неверный пароль. Пароль должен быть от 6 до 20 символов", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("Password is wrong: admin {login}", admin.Login);
                return;
            }

            // Regex for validating email 
            Regex regex = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            if (regex.IsMatch(EmailTextBox.Text) == false)
            {
                MessageBox.Show("Неверная электронная почта", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("Email is wrong: {email}", EmailTextBox.Text);
                return;
            }

            // Updating user info

            // Check if email unique
            if (EmailTextBox.Text != admin.Email)
            {
                if (IsEmailUnique(EmailTextBox.Text) == true)
                {
                    // Change user email
                    admin.Email = EmailTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Данная электронная почта уже занята", "ROV Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            // Check if login unique
            if (LoginTextBox.Text != admin.Login)
            {
                if (IsLoginUnique(LoginTextBox.Text) == true)
                {
                    // Change user login
                    admin.Login = LoginTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Данный логин уже занят", "ROV Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            admin.Login = LoginTextBox.Text;
            admin.Password = PasswordTextBox.Text;
            admin.Email = EmailTextBox.Text;

            db.Admins.Update(admin);
            db.SaveChanges();

            LoginTextBox.ReadOnly = true;
            PasswordTextBox.ReadOnly = true;
            EmailTextBox.ReadOnly = true;

            for (int i = 0; i < accessBoxes.Length; i++)
            {
                accessBoxes[i].Image = Properties.Resources.LockIcon;
            }

            ConfirmDataButton.Cursor = Cursors.No;
            ConfirmDataButton.Enabled = false;

            log.Info("Data changed success for user: {login}", admin.Login);

            MessageBox.Show("Данные успешно изменены", "ROV",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoginTextBox.Text = admin.Login;
            PasswordTextBox.Text = admin.Password;
            EmailTextBox.Text = admin.Email;
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminsLabel_Click(object sender, EventArgs e)
        {
            AdminsForm adminsForm = new AdminsForm(admin);
            this.Hide();
            adminsForm.ShowDialog();
            this.Close();
        }

        private void CarsLabel_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm(admin);
            this.Hide();
            carsForm.ShowDialog();
            this.Close();
        }

        private void ViosLabel_Click(object sender, EventArgs e)
        {
            ViosForm viosForm = new ViosForm(admin);
            this.Hide();
            viosForm.ShowDialog();
            this.Close();
        }

        private void UsersLabel_Click(object sender, EventArgs e)
        {
            UsersForm userForm = new UsersForm(admin);
            this.Hide();
            userForm.ShowDialog();
            this.Close();
        }
    }
}
