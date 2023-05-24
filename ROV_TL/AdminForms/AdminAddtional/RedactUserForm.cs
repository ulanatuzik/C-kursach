using Microsoft.EntityFrameworkCore;
using NLog;
using ROV_TL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROV_TL.AdminForms.AdminAddtional
{
    public partial class RedactUserForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current admin
        Admin admin;
        
        // User to redact
        User user;

        // Link to users form
        UsersForm usersForm;

        public RedactUserForm(Admin currentAdmin, User user, UsersForm usersForm)
        {
            InitializeComponent();
            this.user = user;
            this.usersForm = usersForm;
            admin = currentAdmin;

            db.Set<User>().AsNoTracking();
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

        private void RedactUserForm_Load(object sender, EventArgs e)
        {
            User redactUser = db.Users.Where(u => u.Id == user.Id).First();
            
            LoginTextBox.Text = redactUser.Login;
            PasswordTextBox.Text = redactUser.Password;
            EmailTextBox.Text = redactUser.Email;
            FioTextBox.Text = redactUser.Fio;
            BalanceTextBox.Text = redactUser.Balance.ToString();
        }

        private void ConfirmDataButton_Click(object sender, EventArgs e)
        {
            // If any of data is empty it returns;
            if (LoginTextBox.Text == "" || PasswordTextBox.Text == "" || EmailTextBox.Text == "" || FioTextBox.Text == "" || BalanceTextBox.Text == "")
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

            try
            {
                if (Convert.ToInt32(BalanceTextBox.Text) < 0)
                {
                    MessageBox.Show("Баланс не может быть отрицательным", "ROV Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    log.Warn("Password is wrong: user {login}", user.Login);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Баланс должен быть int", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("Balance is wrong: user {login}", user.Login);
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

            user.Balance = Convert.ToInt32(BalanceTextBox.Text);
            user.Password = PasswordTextBox.Text;
            user.Fio = FioTextBox.Text;

            //db.Users.Remove(user);
            db.Users.Update(user);
            db.SaveChanges();

            log.Info("Data changed success for user: {login}", user.Login);

            MessageBox.Show("Данные успешно изменены", "ROV",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (admin.AdminLevel < 2)
            {
                MessageBox.Show("Ваш уровень не позволяет удалять пользователей", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Users.Remove(user);
            db.SaveChanges();

            MessageBox.Show("Пользователь успешно удален", "ROV",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            log.Info("User delete success user: {login}", user.Login);

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
