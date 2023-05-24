using NLog;
using ROV_TL.Models;
using System.Data;
using System.Text.RegularExpressions;

namespace ROV_TL.AdminForms.AdminAddtional
{
    public partial class AddUserForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current admin
        Admin admin;

        // Link to users form
        UsersForm usersForm;

        public AddUserForm(Admin currentAdmin, UsersForm usersForm)
        {
            InitializeComponent();
            admin = currentAdmin;
            this.usersForm = usersForm;
        }

        private bool IsEmailUnique(string email)
        {
            try
            {
                // if there's no admins with 'email' it creates exception
                User emailUser = db.Users.Where(u => u.Email == email).First();
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
                // if there's no admins with 'login' it creates exception
                User loginUser = db.Users.Where(u => u.Login == login).First();
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
            if (LoginTextBox.Text == "" || PasswordTextBox.Text == "" || EmailTextBox.Text == "" || FioTextBox.Text == "" || BalanceTextBox.Text == "")
            {
                MessageBox.Show("Не все данные заполнены", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("Data is not fulled: user {login}", LoginTextBox.Text);
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

                log.Warn("Password is wrong: user {login}", LoginTextBox.Text);
                return;
            }

            try
            {
                if (Convert.ToInt32(BalanceTextBox.Text) < 0)
                {
                    MessageBox.Show("Баланс не может быть отрицательным", "ROV Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    log.Warn("Password is wrong: user {login}", LoginTextBox.Text);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Баланс должен быть int", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("Balance is wrong: user {login}", LoginTextBox.Text);
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

            if (IsEmailUnique(EmailTextBox.Text) == false)
            {
                MessageBox.Show("Данная электронная почта уже занята", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (IsLoginUnique(LoginTextBox.Text) == false)
            {
                MessageBox.Show("Данный логин уже занят", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            User newUser = new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                Email = EmailTextBox.Text,
                Fio = FioTextBox.Text,
                Balance = Convert.ToInt32(BalanceTextBox.Text)
            };

            db.Users.Add(newUser);
            db.SaveChanges();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm form = new UsersForm(admin);
            usersForm.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void StaticCloseLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm form = new UsersForm(admin);
            usersForm.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
