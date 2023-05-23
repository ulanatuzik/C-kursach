using Microsoft.EntityFrameworkCore;
using NLog;
using ROV_TL.AdminForms.AdminAddtional;
using ROV_TL.Models;

namespace ROV_TL.AdminForms
{
    public partial class UsersForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current Admin
        Admin admin;

        // Current page
        int page;

        // Page size
        int pageSize = 7;

        // Dict of label and id of user
        Dictionary<Label, int> userDict = new Dictionary<Label, int>();

        // Labels for UI
        Label[] loginLabels;
        Label[] passwordLabels;
        Label[] emailLabels;
        Label[] fioLabels;

        public UsersForm(Admin currentAdmin, int page = 1)
        {
            InitializeComponent();
            admin = currentAdmin;
            this.page = page;
            db.Set<User>().AsNoTracking();
        }

        private bool IsNextPageExist()
        {
            // getting count of all users
            int count = db.Users.Count();

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

            fioLabels = new Label[7];
            fioLabels[0] = FioLabel_1;
            fioLabels[1] = FioLabel_2;
            fioLabels[2] = FioLabel_3;
            fioLabels[3] = FioLabel_4;
            fioLabels[4] = FioLabel_5;
            fioLabels[5] = FioLabel_6;
            fioLabels[6] = FioLabel_7;
        }

        private void ClearEmptyLabels()
        {
            for (int i = 0; i < loginLabels.Length; i++)
            {
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
                
                if (fioLabels[i].Text == "Fio")
                {
                    fioLabels[i].Text = "";
                    fioLabels[i].Enabled = false;
                }
            }
        }

        private void SetLabelClicks()
        {
            for (int i = 0; i < loginLabels.Length; i++)
            {
                if (loginLabels[i].Text != "Login")
                {
                    loginLabels[i].Click += UserLogin_Click;
                }
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            SetArrays();
            //User[] users = db.Users.ToArray();
            IQueryable<User> allUsers = db.Users;
            int count = allUsers.Count();

            User[] users = allUsers.Skip((page - 1) * pageSize).Take(pageSize).ToArray();

            for (int i = 0; i < users.Length; i++)
            {
                userDict.Add(loginLabels[i], users[i].Id);
                loginLabels[i].Text = users[i].Login;
                passwordLabels[i].Text = users[i].Password;
                emailLabels[i].Text = users[i].Email;
                fioLabels[i].Text = users[i].Fio;
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
        }

        private void UserLogin_Click(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;
            User redactUser = db.Users.Where(u => u.Id == userDict[currentLabel]).First();

            RedactUserForm redactForm = new RedactUserForm(admin, redactUser, this);
            redactForm.ShowDialog();
            this.Close();
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(admin, page - 1);
            this.Hide();
            usersForm.ShowDialog();
            this.Close();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(admin, page + 1);
            this.Hide();
            usersForm.ShowDialog();
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(admin, this);
            this.Hide();
            addUserForm.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchUserForm searchForm = new SearchUserForm(admin, this);
            //this.Hide();
            searchForm.ShowDialog();
            this.Close();
        }

        private void AdminsLabel_Click(object sender, EventArgs e)
        {

        }

        private void CarsLabel_Click(object sender, EventArgs e)
        {

        }

        private void ViosLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
