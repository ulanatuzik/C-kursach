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

        }
    }
}
