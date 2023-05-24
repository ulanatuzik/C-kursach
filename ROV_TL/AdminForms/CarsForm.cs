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
    public partial class CarsForm : Form
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

        // Dict of label and id of car
        Dictionary<Label, int> carDict = new Dictionary<Label, int>();

        // Labels for ui
        Label[] loginLabels;
        Label[] modelLabels;
        Label[] plateLabels;

        public CarsForm(Admin currentAdmin, int page = 1)
        {
            InitializeComponent();
            admin = currentAdmin;
            this.page = page;
        }

        public void SetArrays()
        {
            loginLabels = new Label[7];
            loginLabels[0] = LoginLabel_1;
            loginLabels[1] = LoginLabel_2;
            loginLabels[2] = LoginLabel_3;
            loginLabels[3] = LoginLabel_4;
            loginLabels[4] = LoginLabel_5;
            loginLabels[5] = LoginLabel_6;
            loginLabels[6] = LoginLabel_7;

            modelLabels = new Label[7];
            modelLabels[0] = ModelLabel_1;
            modelLabels[1] = ModelLabel_2;
            modelLabels[2] = ModelLabel_3;
            modelLabels[3] = ModelLabel_4;
            modelLabels[4] = ModelLabel_5;
            modelLabels[5] = ModelLabel_6;
            modelLabels[6] = ModelLabel_7;

            plateLabels = new Label[7];
            plateLabels[0] = PlateLabel_1;
            plateLabels[1] = PlateLabel_2;
            plateLabels[2] = PlateLabel_3;
            plateLabels[3] = PlateLabel_4;
            plateLabels[4] = PlateLabel_5;
            plateLabels[5] = PlateLabel_6;
            plateLabels[6] = PlateLabel_7;
        }

        private bool IsNextPageExist()
        {
            // getting count of all admins
            int count = db.Cars.Count();

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
            for (int i = 0; i < loginLabels.Length; i++)
            {
                if (loginLabels[i].Text == "Login")
                {
                    loginLabels[i].Text = "";
                    loginLabels[i].Enabled = false;
                }

                if (plateLabels[i].Text == "Plate")
                {
                    plateLabels[i].Text = "";
                    plateLabels[i].Enabled = false;
                }

                if (modelLabels[i].Text == "Model")
                {
                    modelLabels[i].Text = "";
                    modelLabels[i].Enabled = false;
                }
            }
        }

        private void SetLabelClicks()
        {
            for (int i = 0; i < loginLabels.Length; i++)
            {
                if (loginLabels[i].Text != "Login")
                {
                    loginLabels[i].Click += LoginLabel_Click;
                }
            }
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;
            Car redactCar = db.Cars.Where(c => c.CarId == carDict[currentLabel]).First();

            RedactCarForm redactForm = new RedactCarForm(admin, redactCar, this);
            redactForm.ShowDialog();
            this.Close();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            SetArrays();
            //User[] users = db.Users.ToArray();
            IQueryable<Car> allCars = db.Cars;
            int count = allCars.Count();

            Car[] cars = allCars.Skip((page - 1) * pageSize).Take(pageSize).ToArray();

        //        var dataset = entities.processlists
        //.Where(x => x.environmentID == environmentid && x.ProcessName == processname && x.RemoteIP == remoteip && x.CommandLine == commandlinepart)
        //.Select(x => new { x.ServerName, x.ProcessID, x.Username }).ToList();

            for (int i = 0; i < cars.Length; i++)
            {
                carDict.Add(loginLabels[i], cars[i].CarId);

                // Select userLogin
                string userLogin = db.Users
                    .Where(u => u.Id == cars[i].UserId)
                    .Select(u => u.Login)
                    .First();

                loginLabels[i].Text = userLogin;
                modelLabels[i].Text = cars[i].Model;
                plateLabels[i].Text = cars[i].NumberPlate;
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

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm(admin, page - 1);
            this.Hide();
            carsForm.ShowDialog();
            this.Close();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm(admin, page + 1);
            this.Hide();
            carsForm.ShowDialog();
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm(admin, this);
            //this.Hide();
            addCarForm.ShowDialog();
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

        private void ViosLabel_Click(object sender, EventArgs e)
        {
            ViosForm viosForm = new ViosForm(admin);
            this.Hide();
            viosForm.ShowDialog();
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
