using NLog;
using ROV_TL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROV_TL.Forms.Additional
{
    public partial class BalanceForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Link to profile form
        ProfileForm profileForm;

        // Current user
        User user;

        public BalanceForm(User currentUser, ProfileForm profileForm)
        {
            InitializeComponent();
            user = currentUser;
            this.profileForm = profileForm;
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            CurrentBalanceLabel.Text = $"Текущий баланс: {user.Balance}";
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            int toUp = 0;

            try
            {
                toUp = Convert.ToInt32(SumTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сумма пополнения  должна быть числом");
                return;
            }

            user.Balance = user.Balance + toUp;

            db.Users.Update(user);
            db.SaveChanges();

            MessageBox.Show("Баланс успешно пополнен!");
            log.Info("User balanced upped {user} {newBalance}", user.Login, user.Balance);

            this.Hide();
            ProfileForm form = new ProfileForm(user.Id);
            profileForm.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm form = new ProfileForm(user.Id);
            profileForm.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm form = new ProfileForm(user.Id);
            profileForm.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
