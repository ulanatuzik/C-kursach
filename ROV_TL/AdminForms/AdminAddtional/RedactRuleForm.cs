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
    public partial class RedactRuleForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current admin
        Admin admin;

        // Rule to redact
        Models.Rule rule;

        // Link to activ vio form
        ActivViosForm viosForm;

        public RedactRuleForm(Admin currentAdmin, Models.Rule rule, ActivViosForm viosForm)
        {
            InitializeComponent();
            this.admin = currentAdmin;
            this.rule = rule;
            this.viosForm = viosForm;
        }

        private void RedactRuleForm_Load(object sender, EventArgs e)
        {
            RuleTextBox.Text = rule.Text;
            FineTextBox.Text = rule.Fine.ToString();
        }

        private void ConfirmDataButton_Click(object sender, EventArgs e)
        {
            if (RuleTextBox.Text == "" || FineTextBox.Text == "")
            {
                MessageBox.Show("Не все данные заполнены");
                return;
            }

            int fine = 0;
            try
            {
                fine = Convert.ToInt32(FineTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Штраф должен быть числом");
                return;
            }

            rule.Text = RuleTextBox.Text;
            rule.Fine = fine;

            db.Rules.Update(rule);
            db.SaveChanges();

            MessageBox.Show("Данные успешно изменены");
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
