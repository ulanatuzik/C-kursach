using NLog;
using ROV_TL.AdminForms.AdminAddtional;
using ROV_TL.Models;

namespace ROV_TL.AdminForms
{
    public partial class AdminsForm : Form
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

        // Arrays of labels
        Label[] lvlLabels;
        Label[] loginLabels;
        Label[] passwordLabels;
        Label[] emailLabels;


        // Dictionary with label and admin id
        Dictionary<Label, int> adminDict = new Dictionary<Label, int>();

        public AdminsForm(Admin currentAdmin, int page = 1)
        {
            InitializeComponent();
            admin = db.Admins.Where(a => a.AdminId == currentAdmin.AdminId).First();
            this.page = page;
        }

        private bool IsNextPageExist()
        {
            // getting count of all admins
            int count = db.Admins.Count();

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

        private void HidePasswords()
        {
            for (int i = 0; i < passwordLabels.Length; i++)
            {
                if (passwordLabels[i].Enabled == true)
                    passwordLabels[i].Text = "******";
            }
        }

        private void ClearEmptyLabels()
        {
            for (int i = 0; i < lvlLabels.Length; i++)
            {
                if (lvlLabels[i].Text == "-1")
                {
                    lvlLabels[i].Text = "";
                    lvlLabels[i].Enabled = false;
                }

                if (loginLabels[i].Text == "Login")
                {
                    loginLabels[i].Text = "";
                    loginLabels[i].Enabled = false;
                }

                if (passwordLabels[i].Text == "Password")
                {
                    passwordLabels[i].Text = "";
                    passwordLabels[i].Enabled = false;
                }

                if (emailLabels[i].Text == "Email")
                {
                    emailLabels[i].Text = "";
                    emailLabels[i].Enabled = false;
                }
            }
        }

        private void SetLabels()
        {
            lvlLabels = new Label[7];
            lvlLabels[0] = LvlLabel_1;
            lvlLabels[1] = LvlLabel_2;
            lvlLabels[2] = LvlLabel_3;
            lvlLabels[3] = LvlLabel_4;
            lvlLabels[4] = LvlLabel_5;
            lvlLabels[5] = LvlLabel_6;
            lvlLabels[6] = LvlLabel_7;

            loginLabels = new Label[7];
            loginLabels[0] = LoginLabel_1;
            loginLabels[1] = LoginLabel_2;
            loginLabels[2] = LoginLabel_3;
            loginLabels[3] = LoginLabel_4;
            loginLabels[4] = LoginLabel_5;
            loginLabels[5] = LoginLabel_6;
            loginLabels[6] = LoginLabel_7;

            passwordLabels = new Label[7];
            passwordLabels[0] = PasswordLabel_1;
            passwordLabels[1] = PasswordLabel_2;
            passwordLabels[2] = PasswordLabel_3;
            passwordLabels[3] = PasswordLabel_4;
            passwordLabels[4] = PasswordLabel_5;
            passwordLabels[5] = PasswordLabel_6;
            passwordLabels[6] = PasswordLabel_7;

            emailLabels = new Label[7];
            emailLabels[0] = EmailLabel_1;
            emailLabels[1] = EmailLabel_2;
            emailLabels[2] = EmailLabel_3;
            emailLabels[3] = EmailLabel_4;
            emailLabels[4] = EmailLabel_5;
            emailLabels[5] = EmailLabel_6;
            emailLabels[6] = EmailLabel_7;
        }

        private void SetLabelClicks()
        {
            for (int i = 0; i < loginLabels.Length; i++)
            {
                if (loginLabels[i].Text != "Login")
                {
                    loginLabels[i].Click += AdminLogin_Click;
                }
            }
        }

        private void AProfileForm_Load(object sender, EventArgs e)
        {
            SetLabels();
            IQueryable<Admin> admins = db.Admins;
            int count = admins.Count();

            Admin[] adminsToShow = admins.Skip((page - 1) * pageSize).Take(pageSize).ToArray();

            for (int i = 0; i < adminsToShow.Length; i++)
            {
                adminDict.Add(loginLabels[i], adminsToShow[i].AdminId);
                lvlLabels[i].Text = adminsToShow[i].AdminLevel.ToString();
                loginLabels[i].Text = adminsToShow[i].Login;
                passwordLabels[i].Text = adminsToShow[i].Password;
                emailLabels[i].Text = adminsToShow[i].Email;
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
            SetLabelClicks();

            if (admin.AdminLevel < 3)
            {
                AddButton.Enabled = false;
                AddButton.Visible = false;
                HidePasswords();
            }
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;
            Admin redactAdmin = db.Admins.Where(a => a.AdminId == adminDict[currentLabel]).First();

            RedactAdminForm redactForm = new RedactAdminForm(admin, redactAdmin, this);
            redactForm.ShowDialog();
            this.Close();
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            AdminsForm adminsForm = new AdminsForm(admin, page - 1);
            this.Hide();
            adminsForm.ShowDialog();
            this.Close();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            AdminsForm adminsForm = new AdminsForm(admin, page + 1);
            this.Hide();
            adminsForm.ShowDialog();
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
