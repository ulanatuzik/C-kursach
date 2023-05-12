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

namespace ROV_TL
{
    public partial class ProfileForm : Form
    {
        ApplicationContext db = new ApplicationContext();
        User user;

        public ProfileForm(User currentUser)
        {
            InitializeComponent();
            user = currentUser;

            loginLabel.Text = currentUser.Login;
            emailLabel.Text = currentUser.Email;
            fioLabel.Text = currentUser.Fio;
            balanceLabel.Text = currentUser.Balance.ToString();
        }

        private void vioLabel_Click(object sender, EventArgs e)
        {

        }

        private void carInfoLabel_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm(user);
        }
    }
}
