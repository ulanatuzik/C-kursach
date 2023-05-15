using ROV_TL.Models;
using NLog;
using System.Text.RegularExpressions;
using ROV_TL.Forms;

namespace ROV_TL
{
    public partial class ProfileForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current user class
        User user;

        // Array of lock/unlock pic boxes
        PictureBox[] accessBoxes;

        public ProfileForm(int id)
        {
            InitializeComponent();

            // For hiding password in text box;
            PasswordTextBox.UseSystemPasswordChar = true;


            user = DBCode.GetUserById(id);

            BalanceLabel.Text = user.Balance.ToString();
            LoginTextBox.Text = user.Login;
            PasswordTextBox.Text = user.Password;
            EmailTextBox.Text = user.Email;
            FioTextBox.Text = user.Fio;

            ChangeDataButton.Focus();

            accessBoxes = new PictureBox[4];
            accessBoxes[0] = AcessPictureBox_1;
            accessBoxes[1] = AcessPictureBox_2;
            accessBoxes[2] = AcessPictureBox_3;
            accessBoxes[3] = AcessPictureBox_4;
        }

        private void CarInfoLabel_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm(user);
            this.Hide();
            carsForm.ShowDialog();
            this.Close();
        }

        private void VioLabel_Click(object sender, EventArgs e)
        {
            VioForm vioForm = new VioForm(user);
            this.Hide();
            vioForm.ShowDialog();
            this.Close();
        }

        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            LoginTextBox.ReadOnly = false;
            PasswordTextBox.ReadOnly = false;
            EmailTextBox.ReadOnly = false;
            FioTextBox.ReadOnly = false;

            for (int i = 0; i < accessBoxes.Length; i++)
            {
                accessBoxes[i].Image = Properties.Resources.UnlockIcon;
            }

            ConfirmDataButton.Enabled = true;
            ConfirmDataButton.Cursor = Cursors.Hand;
        }

        private void ConfirmDataButton_Click(object sender, EventArgs e)
        {
            // If any of data is empty it returns;
            if (LoginTextBox.Text == "" || PasswordTextBox.Text == "" || EmailTextBox.Text == "" || FioTextBox.Text == "")
            {
                MessageBox.Show("Не все данные заполнены", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("Data is not fulled: user {login}", user.Login);
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

                log.Warn("Password is wrong: user {login}", user.Login);
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

            // Regex for validating FIO
            regex = new Regex(@"/^([А-ЯA-Z]|[А-ЯA-Z][\x27а-яa-z]{1,}|[А-ЯA-Z][\x27а-яa-z]{1,}\-([А-ЯA-Z][\x27а-яa-z]{1,}|(оглы)|(кызы)))\040[А-ЯA-Z][\x27а-яa-z]{1,}(\040[А-ЯA-Z][\x27а-яa-z]{1,})?$/");
            if (regex.IsMatch(LoginTextBox.Text) == false && FioTextBox.Text.Length < 5 || FioTextBox.Text.Length > 75)
            {
                MessageBox.Show("Неверное ФИО", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("FIO is wrong: {FIO}", LoginTextBox.Text);
                return;
            }
            

            // Updating user info

            // Check if email unique
            if (EmailTextBox.Text != user.Email)
            {
                if (IsEmailUnique(EmailTextBox.Text) == true)
                {
                    // Change user email
                    user.Email = EmailTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Данная электронная почта уже занята", "ROV Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            // Check if login unique
            if (LoginTextBox.Text != user.Login)
            {
                if (IsLoginUnique(LoginTextBox.Text) == true)
                {
                    // Change user login
                    user.Login = LoginTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Данный логин уже занят", "ROV Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            user.Password = PasswordTextBox.Text;
            user.Fio = FioTextBox.Text;

            db.Users.Update(user);
            db.SaveChanges();

            LoginTextBox.ReadOnly = true;
            PasswordTextBox.ReadOnly = true;
            EmailTextBox.ReadOnly = true;
            FioTextBox.ReadOnly = true;

            for (int i = 0; i < accessBoxes.Length; i++)
            {
                accessBoxes[i].Image = Properties.Resources.LockIcon;
            }

            ConfirmDataButton.Cursor = Cursors.No;
            ConfirmDataButton.Enabled = false;

            log.Info("Data changed success for user: {login}", user.Login);

            MessageBox.Show("Данные успешно изменены", "ROV",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdatePictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                User updatedUser = db.Users.Where(x => x.Id == user.Id).First();
                user = updatedUser;

                BalanceLabel.Text = user.Balance.ToString();
                LoginTextBox.Text = user.Login;
                PasswordTextBox.Text = user.Password;
                EmailTextBox.Text = user.Email;
                FioTextBox.Text = user.Fio;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так во время обновления...", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Error(ex, "Something happened while updating {msg} ", ex.Message);
                return;
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private bool IsEmailUnique(string email)
        {
            try
            {
                // If there's no users with 'email' it creates exception
                User userEmail = db.Users.Where(x => x.Email == email).First();
            }
            catch (Exception ex)
            {
                return true;
            }

            log.Warn("Data is not unique: email {email}", user.Email);
            return false;
        }
        private bool IsLoginUnique(string login)
        {
            try
            {
                // if there's no users with 'login' it creates exception
                User userLogin = db.Users.Where(x => x.Login == login).First();
            }
            catch (Exception ex)
            {
                return true;
            }

            log.Warn("Data is not unique: login {login}", user.Login);
            return false;
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            log.Info("Log off from profile {login}", user.Login); 
            this.Close();
        }
    }
}
