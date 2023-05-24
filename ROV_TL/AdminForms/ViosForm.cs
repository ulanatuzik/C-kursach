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

namespace ROV_TL.AdminForms.AdminAddtional
{
    public partial class ViosForm : Form
    {
        Admin admin;
        public ViosForm(Admin currentAdmin)
        {
            InitializeComponent();
            admin = currentAdmin;
        }

        private void NotPayedViosButton_Click(object sender, EventArgs e)
        {
            NoPayViosForm noPayForm = new NoPayViosForm(admin);
            this.Hide();
            noPayForm.ShowDialog();
            this.Close();
        }

        private void PayedVioButton_Click(object sender, EventArgs e)
        {
            PayedViosForm payedForms = new PayedViosForm(admin);
            this.Hide();
            payedForms.ShowDialog();
            this.Close();
        }

        private void ActiveVioButton_Click(object sender, EventArgs e)
        {
            ActivViosForm viosForm = new ActivViosForm(admin);
            this.Hide();
            viosForm.ShowDialog();
            this.Close();
        }

        private void CreateNewVio_Click(object sender, EventArgs e)
        {
            AddVioForm addForm = new AddVioForm(admin);
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        private void AdminsLabel_Click(object sender, EventArgs e)
        {
            AdminsForm adminsForm = new AdminsForm(admin);
            this.Hide();
            adminsForm.ShowDialog();
            this.Close();
        }

        private void UsersLabel_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(admin);
            this.Hide();
            usersForm.ShowDialog();
            this.Close();
        }

        private void CarsLabel_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm(admin);
            this.Hide();
            carsForm.ShowDialog();
            this.Close();
        }

        private void AdminProfileLabel_Click(object sender, EventArgs e)
        {
            AdminProfileForm profileForm = new AdminProfileForm(admin);
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }
    }
}
