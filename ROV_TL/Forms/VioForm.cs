using NLog;
using ROV_TL.Forms.Additional;
using ROV_TL.Models;

namespace ROV_TL.Forms
{
    public partial class VioForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current user
        User user;

        // Current page
        int page;

        // Page size
        int pageSize = 5;

        // Arrays of labels
        Label[] vioLabels;
        Label[] modelLabels;
        Label[] sumLabels;
        Label[] dateLabels;

        public VioForm(User currentUser, int page = 1)
        {
            InitializeComponent();
            user = currentUser;
            this.page = page;
        }

        private bool IsNextPageExist()
        {
            // getting count of all violations for current user
            int count = db.Violations.Where(v => v.UserId == user.Id).Count();

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

        private void SetLabelClicks()
        {
            for (int i = 0; i < vioLabels.Length; i++)
            {
                vioLabels[i].Click += ViolationLabel_Click;
            }
        }

        private void SetArrays()
        {
            vioLabels = new Label[5];
            vioLabels[0] = VioLabel_1;
            vioLabels[1] = VioLabel_2;
            vioLabels[2] = VioLabel_3;
            vioLabels[3] = VioLabel_4;
            vioLabels[4] = VioLabel_5;

            modelLabels = new Label[5];
            modelLabels[0] = ModelLabel_1;
            modelLabels[1] = ModelLabel_2;
            modelLabels[2] = ModelLabel_3;
            modelLabels[3] = ModelLabel_4;
            modelLabels[4] = ModelLabel_5;

            sumLabels = new Label[5];
            sumLabels[0] = SumLabel_1;
            sumLabels[1] = SumLabel_2;
            sumLabels[2] = SumLabel_3;
            sumLabels[3] = SumLabel_4;
            sumLabels[4] = SumLabel_5;

            dateLabels = new Label[5];
            dateLabels[0] = DateLabel_1;
            dateLabels[1] = DateLabel_2;
            dateLabels[2] = DateLabel_3;
            dateLabels[3] = DateLabel_4;
            dateLabels[4] = DateLabel_5;
        }

        private void ClearEmptyLabels()
        {
            for (int i = 0; i < vioLabels.Length; i++)
            {
                if (vioLabels[i].Text == "VIO TEXT VIO TEXT VIO TEXT VIO TEXT  VIO TEXT ")
                {
                    vioLabels[i].Text = "";
                    vioLabels[i].Enabled = false;
                }

                if (modelLabels[i].Text == "Model Model")
                {
                    modelLabels[i].Text = "";
                    modelLabels[i].Enabled = false;
                }

                if (sumLabels[i].Text == "0")
                {
                    sumLabels[i].Text = "";
                    sumLabels[i].Enabled = false;
                }


                if (dateLabels[i].Text == "15.05.2023")
                {
                    dateLabels[i].Text = "";
                    dateLabels[i].Enabled = false;
                }
            }
        }

        private void VioForm_Load(object sender, EventArgs e)
        {
            SetArrays();
            try
            {
                IQueryable<Vio> vios = db.Violations.Where(v => v.UserId == user.Id);
                int count = vios.Count();
                Vio[] viosToShow = vios.Skip((page - 1) * pageSize).Take(pageSize).ToArray();

                for (int i = 0; i < viosToShow.Length; i++)
                {
                    vioLabels[i].Text = viosToShow[i].Violation;
                    sumLabels[i].Text = viosToShow[i].Fine;
                    dateLabels[i].Text = viosToShow[i].Date.ToString();

                    // Select car where carId = carId from vio and take model name from it
                    modelLabels[i].Text = db.Cars.Where(c => c.CarId == viosToShow[i].CarId).First().Model;
                }
            }
            catch (Exception ex)
            {
                // if no vios do smh
                MessageBox.Show(ex.Message);
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

        private void ViolationLabel_Click(object sender, EventArgs e)
        {

        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            VioForm vioForm = new VioForm(user, page - 1);
            this.Hide();
            vioForm.ShowDialog();
            this.Close();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            VioForm vioForm = new VioForm(user, page + 1);
            this.Hide();
            vioForm.ShowDialog();
            this.Close();
        }
    }
}
