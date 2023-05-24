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
    public partial class RedactAdminForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current admin
        Admin admin;

        // Admin to redact
        Admin redactAdmin;

        // Link to main window
        AdminsForm adminsForm;

        public RedactAdminForm(Admin currentAdmin, Admin redactAdmin, AdminsForm adminsForm)
        {
            InitializeComponent();
            admin = currentAdmin;
            this.redactAdmin = redactAdmin;
            this.adminsForm = adminsForm;
        }

        private bool IsEmailUnique(string email)
        {
            try
            {
                // if there's no admins with 'email' it creates exception
                Admin emailAdmin = db.Admins.Where(x => x.Email == email).First();
            }
            catch (Exception ex)
            {
                return true;
            }

            log.Warn("Data is not unique: email {email}", admin.Email);
            return false;
        }

        private bool IsLoginUnique(string login)
        {
            try
            {
                // if there's no admins with 'login' it creates exception
                Admin loginAdmin = db.Admins.Where(x => x.Login == login).First();
            }
            catch (Exception ex)
            {
                return true;
            }

            log.Warn("Data is not unique: login {login}", admin.Login);
            return false;
        }

        private void RedactAdminForm_Load(object sender, EventArgs e)
        {
            LvlTextBox.Text = redactAdmin.AdminLevel.ToString();
            EmailTextBox.Text = redactAdmin.Email;
            LoginTextBox.Text = redactAdmin.Login;
            PasswordTextBox.Text = redactAdmin.Password;
        }

        private void ConfirmDataButton_Click(object sender, EventArgs e)
        {
            if (LvlTextBox.Text == "" || EmailTextBox.Text == "" || LoginTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Не все данные заполнены", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsLoginUnique(LoginTextBox.Text) != true && IsEmailUnique(EmailTextBox.Text) != true)
            {
                MessageBox.Show("Логин и электронная почта должны быть уникальными", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Regex for validating email 
            Regex regex = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            if (regex.IsMatch(EmailTextBox.Text) == true)
            {
                redactAdmin.AdminLevel = Convert.ToInt32(LvlTextBox.Text);
                redactAdmin.Login = LoginTextBox.Text;
                redactAdmin.Password = PasswordTextBox.Text;
                redactAdmin.Email = EmailTextBox.Text;


                db.Admins.Update(redactAdmin);
                db.SaveChanges();

                MessageBox.Show("Информация об админе успешно изменена");

                this.Hide();
                AdminsForm form = new AdminsForm(admin);
                adminsForm.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверная электронная почта", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                log.Warn("Email is wrong: {email}", EmailTextBox.Text);
                return;
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminsForm form = new AdminsForm(admin);
            adminsForm.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void StaticCloseLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminsForm form = new AdminsForm(admin);
            adminsForm.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
