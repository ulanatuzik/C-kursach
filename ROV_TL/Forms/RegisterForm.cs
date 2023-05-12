using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ROV_TL.Models;

namespace ROV_TL.Forms
{
    public partial class RegisterForm : Form
    {
        ApplicationContext db = new ApplicationContext();
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

            if (IsLoginUnique(user) == true)
            {
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("reg succ");

                ProfileForm profileForm = new ProfileForm(user);
                this.Hide();
                profileForm.ShowDialog();
                this.Close();
            }
        }

        private bool IsLoginUnique(User user)
        {
            try
            {
                // if there's no users with 'login' it creates exception
                User uniqUser = db.Users.Where(x => x.Login == user.Login).First();
            }
            catch (Exception ex)
            {
                return true;
            }

            return false;
        }
    }
}
