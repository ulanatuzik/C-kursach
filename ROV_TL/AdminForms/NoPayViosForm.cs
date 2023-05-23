using NLog;
using ROV_TL.AdminForms.AdminAddtional;
using ROV_TL.Models;

namespace ROV_TL.AdminForms
{
    public partial class NoPayViosForm : Form
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
        int pageSize = 5;

        // Dict of label and id of car
        Dictionary<Label, int> vioDict = new Dictionary<Label, int>();

        // Labels for ui
        Label[] vioLabels;
        Label[] loginLabels;
        Label[] modelLabels;
        Label[] sumLabels;
        Label[] dateLabels;

        public NoPayViosForm(Admin currentAdmin, int page = 1)
        {
            InitializeComponent();
            admin = currentAdmin;
            this.page = page;
        }

        private void SetLabels()
        {
            vioLabels = new Label[pageSize];
            vioLabels[0] = VioLabel_1;
            vioLabels[1] = VioLabel_2;
            vioLabels[2] = VioLabel_3;
            vioLabels[3] = VioLabel_4;
            vioLabels[4] = VioLabel_5;

            loginLabels = new Label[pageSize];
            loginLabels[0] = LoginLabel_1;
            loginLabels[1] = LoginLabel_2;
            loginLabels[2] = LoginLabel_3;
            loginLabels[3] = LoginLabel_4;
            loginLabels[4] = LoginLabel_5;

            modelLabels = new Label[pageSize];
            modelLabels[0] = ModelLabel_1;
            modelLabels[1] = ModelLabel_2;
            modelLabels[2] = ModelLabel_3;
            modelLabels[3] = ModelLabel_4;
            modelLabels[4] = ModelLabel_5;

            sumLabels = new Label[pageSize];
            sumLabels[0] = SumLabel_1;
            sumLabels[1] = SumLabel_2;
            sumLabels[2] = SumLabel_3;
            sumLabels[3] = SumLabel_4;
            sumLabels[4] = SumLabel_5;

            dateLabels = new Label[pageSize];
            dateLabels[0] = DateLabel_1;
            dateLabels[1] = DateLabel_2;
            dateLabels[2] = DateLabel_3;
            dateLabels[3] = DateLabel_4;
            dateLabels[4] = DateLabel_5;
        }

        private bool IsNextPageExist()
        {
            // getting count of all vios
            int count = db.Violations.Count();

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

        private void ClearEmptyLabels()
        {
            for (int i = 0; i < pageSize; i++)
            {
                if (loginLabels[i].Text == "Login")
                {
                    loginLabels[i].Text = "";
                    loginLabels[i].Enabled = false;
                }

                if (modelLabels[i].Text == "Model Model")
                {
                    modelLabels[i].Text = "";
                    modelLabels[i].Enabled = false;
                }

                if (dateLabels[i].Text == "15.05.2023")
                {
                    dateLabels[i].Text = "";
                    dateLabels[i].Enabled = false;
                }

                if (sumLabels[i].Text == "0")
                {
                    sumLabels[i].Text = "";
                    dateLabels[i].Enabled = false;
                }

                if (vioLabels[i].Text == "VIO TEXT VIO TEXT VIO TEXT VIO TEXT  VIO TEXT ")
                {
                    vioLabels[i].Text = "";
                    vioLabels[i].Enabled = false;
                }
            }
        }

        private void SetLabelClicks()
        {
            for (int i = 0; i < vioLabels.Length; i++)
            {
                if (vioLabels[i].Enabled != false)
                    vioLabels[i].Click += VioLabel_Click;
            }
        }

        private void NoPayViosForm_Load(object sender, EventArgs e)
        {
            SetLabels();
            IQueryable<Vio> allVio = db.Violations;
            int count = allVio.Count();

            Vio[] vios = allVio.Skip((page - 1) * pageSize).Take(pageSize).ToArray();

            for (int i = 0; i < vios.Length; i++)
            {
                vioDict.Add(vioLabels[i], vios[i].VioId);
                vioLabels[i].Text = vios[i].Violation;
                sumLabels[i].Text = vios[i].Fine;
                dateLabels[i].Text = vios[i].Date.ToString();

                string userLogin = db.Users
                    .Where(u => u.Id == vios[i].UserId)
                    .Select(u => u.Login)
                    .First();

                string carModel = db.Cars
                    .Where(c => c.CarId == vios[i].CarId)
                    .Select(c => c.Model)
                    .First();

                modelLabels[i].Text = carModel;
                loginLabels[i].Text = userLogin;
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


        private void VioLabel_Click(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;
            int vioId = vioDict[currentLabel];

            Vio redactVio = db.Violations.Where(v => v.VioId == vioId).First();
            RedactVioForm redactForm = new RedactVioForm(admin, redactVio, this);
            redactForm.ShowDialog();
            this.Close();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            NoPayViosForm payForm = new NoPayViosForm(admin, page + 1);
            this.Hide();
            payForm.ShowDialog();
            this.Close();
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            NoPayViosForm payForm = new NoPayViosForm(admin, page - 1);
            this.Hide();
            payForm.ShowDialog();
            this.Close();
        }
    }
}
