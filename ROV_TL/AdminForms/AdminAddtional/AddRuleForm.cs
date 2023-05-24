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

namespace ROV_TL.AdminForms.AdminAddtional
{
    public partial class AddRuleForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current admin
        Admin admin;

        // Link to activ vio form
        ActivViosForm viosForm;

        public AddRuleForm(Admin currentAdmin, ActivViosForm viosForm)
        {
            InitializeComponent();
            admin = currentAdmin;
            this.viosForm = viosForm;
        }

        private void AddRuleForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmDataButton_Click(object sender, EventArgs e)
        {
            int fine = 0;
            if (RuleTextBox.Text == "" || FineTextBox.Text == "")
            {
                MessageBox.Show("Не все данные заполнены");
                return;
            }

            try
            {
                fine = Convert.ToInt32(FineTextBox.Text);
            }
            catch (Exception ex)
            {
                log.Warn(ex.Message);

                MessageBox.Show("Штраф должен быть числом");
                return;
            }

            Models.Rule newRule = new Models.Rule { Text = RuleTextBox.Text, Fine = fine };

            db.Rules.Add(newRule);
            db.SaveChanges();

            MessageBox.Show("Новое правило успешно добавлено");
        }

        private void StaticCloseLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivViosForm form = new ActivViosForm(admin);
            viosForm.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivViosForm form = new ActivViosForm(admin);
            viosForm.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
