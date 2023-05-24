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
    public partial class AddAdminForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current admin
        Admin admin;

        // Link to main window
        AdminsForm adminsForm;

        public AddAdminForm(Admin currentAdmin, AdminsForm adminsForm)
        {
            InitializeComponent();
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


        private void AddAdminForm_Load(object sender, EventArgs e)
        {
            LvlTextBox.Text = admin.AdminLevel.ToString();
            EmailTextBox.Text = admin.Email;
            LoginTextBox.Text = admin.Login;
            PasswordTextBox.Text = admin.Password;
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
                admin.AdminLevel = Convert.ToInt32(LvlTextBox.Text);
                admin.Login = LoginTextBox.Text;
                admin.Password = PasswordTextBox.Text;
                admin.Email = EmailTextBox.Text;


                db.Admins.Update(admin);
                db.SaveChanges();

                MessageBox.Show("Новый админ успешно добавлен");

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
