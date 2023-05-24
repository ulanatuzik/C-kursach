using NLog;
using ROV_TL.AdminForms.AdminAddtional;
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

namespace ROV_TL.AdminForms
{
    public partial class ActivViosForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current admin
        Admin admin;

        // Current page
        int page;

        // Page size
        int pageSize = 7;

        // Dict of label and rule id
        Dictionary<Label, int> ruleDict = new Dictionary<Label, int>();

        // Arrays of labels
        Label[] idLabels;
        Label[] ruleLabels;
        Label[] fineLabels;

        public ActivViosForm(Admin currentAdmin, int page = 1)
        {
            InitializeComponent();
            admin = currentAdmin;
            this.page = page;
        }

        private bool IsNextPageExist()
        {
            // getting count of all admins
            int count = db.Rules.Count();

            double de = Convert.ToDouble(count) / Convert.ToDouble(pageSize);
            int pagesExist = (int)Math.Ceiling(de);
            if (page >= pagesExist)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsPrevPageExist()
        {
            if (page <= 1)
            {
                return false;
            }
            {
                return true;
            }
        }

        private void SetArrays()
        {
            idLabels = new Label[pageSize];
            idLabels[0] = IdLabel_1;
            idLabels[1] = IdLabel_2;
            idLabels[2] = IdLabel_3;
            idLabels[3] = IdLabel_4;
            idLabels[4] = IdLabel_5;
            idLabels[5] = IdLabel_6;
            idLabels[6] = IdLabel_7;

            ruleLabels = new Label[pageSize];
            ruleLabels[0] = RuleLabel_1;
            ruleLabels[1] = RuleLabel_2;
            ruleLabels[2] = RuleLabel_3;
            ruleLabels[3] = RuleLabel_4;
            ruleLabels[4] = RuleLabel_5;
            ruleLabels[5] = RuleLabel_6;
            ruleLabels[6] = RuleLabel_7;

            fineLabels = new Label[pageSize];
            fineLabels[0] = FineLabel_1;
            fineLabels[1] = FineLabel_2;
            fineLabels[2] = FineLabel_3;
            fineLabels[3] = FineLabel_4;
            fineLabels[4] = FineLabel_5;
            fineLabels[5] = FineLabel_6;
            fineLabels[6] = FineLabel_7;
        }

        private void ClearEmptyLabels()
        {
            for (int i = 0; i < pageSize; i++)
            {
                if (idLabels[i].Text == "0")
                {
                    idLabels[i].Text = "";
                    idLabels[i].Enabled = false;
                }

                if (ruleLabels[i].Text == "Rule")
                {
                    ruleLabels[i].Text = "";
                    ruleLabels[i].Enabled = false;
                }

                if (fineLabels[i].Text == "0")
                {
                    fineLabels[i].Text = "";
                    ruleLabels[i].Enabled = false;
                }
            }
        }

        private void SetClicks()
        {
            for (int i = 0; i < pageSize; i++)
            {
                if (ruleLabels[i].Enabled == true)
                {
                    ruleLabels[i].Click += RuleLabel_Click;
                }
            }
        }

        private void RuleLabel_Click(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;
            Models.Rule rule = db.Rules.Where(r => r.RuleId == ruleDict[currentLabel]).First();

            RedactRuleForm redactForm = new RedactRuleForm(admin, rule, this);
            this.Hide();
            redactForm.ShowDialog();
            this.Close();
        }

        private void ActivViosForm_Load(object sender, EventArgs e)
        {
            SetArrays();

            IQueryable<Models.Rule> allRules = db.Rules;
            int count = allRules.Count();

            Models.Rule[] rules = allRules.Skip((page - 1) * pageSize).Take(pageSize).ToArray();

            for (int i = 0; i < rules.Length; i++)
            {
                ruleDict.Add(ruleLabels[i], rules[i].RuleId);

                idLabels[i].Text = rules[i].RuleId.ToString();
                ruleLabels[i].Text = rules[i].Text;
                fineLabels[i].Text = rules[i].Fine.ToString();
            }

            if (IsNextPageExist() == false)
            {
                NextPageButton.Enabled = false;
                NextPageButton.Visible = false;
            }

            if (IsPrevPageExist() == false)
            {
                PrevPageButton.Enabled = false;
                PrevPageButton.Visible = false;
            }

            CurrentPageLabel.Text = "Текущая страница: " + page;

            ClearEmptyLabels();
            SetClicks();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            ActivViosForm vioForm = new ActivViosForm(admin, page + 1);
            this.Hide();
            vioForm.ShowDialog();
            this.Close();
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            ActivViosForm vioForm = new ActivViosForm(admin, page - 1);
            this.Hide();
            vioForm.ShowDialog();
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddRuleForm addForm = new AddRuleForm(admin, this);
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

        private void CarsLabel_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm(admin);
            this.Hide();
            carsForm.ShowDialog();
            this.Close();
        }

        private void ViosLabel_Click(object sender, EventArgs e)
        {
            ViosForm viosForm = new ViosForm(admin);
            this.Hide();
            viosForm.ShowDialog();
            this.Close();
        }

        private void UsersLabel_Click(object sender, EventArgs e)
        {
            UsersForm userForm = new UsersForm(admin);
            this.Hide();
            userForm.ShowDialog();
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
