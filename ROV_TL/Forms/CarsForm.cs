using System.Data;
using NLog;
using ROV_TL.Forms;
using ROV_TL.Forms.Additional;
using ROV_TL.Models;

namespace ROV_TL
{
    public partial class CarsForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Arrays for labels
        Label[] models;
        Label[] numplates;
        Label[] vios;


        // Dictionary with car id and it's model name
        Dictionary<string, int> carDict = new Dictionary<string, int>();

        // Current user
        User user;

        public CarsForm(User currentUser)
        {
            InitializeComponent();
            SetArrays();

            user = currentUser;
        }

        private int CountTotalVio(int carId)
        {
            try
            {
                Vio[] vio = db.Violations.Where(v => v.CarId == carId).ToArray();

                return vio.Length;
            }
            catch (Exception ex)
            {
                log.Warn("No violations found for car: {carId}", carId);
                return 0;
            }
        }

        private void SetArrays()
        {
            models = new Label[8];
            models[0] = modelLabel_1;
            models[1] = modelLabel_2;
            models[2] = modelLabel_3;
            models[3] = modelLabel_4;
            models[4] = modelLabel_5;
            models[5] = modelLabel_6;
            models[6] = modelLabel_7;
            models[7] = modelLabel_8;

            numplates = new Label[8];
            numplates[0] = plateLabel_1;
            numplates[1] = plateLabel_2;
            numplates[2] = plateLabel_3;
            numplates[3] = plateLabel_4;
            numplates[4] = plateLabel_5;
            numplates[5] = plateLabel_6;
            numplates[6] = plateLabel_7;
            numplates[7] = plateLabel_8;

            vios = new Label[8];
            vios[0] = vioLabel_1;
            vios[1] = vioLabel_2;
            vios[2] = vioLabel_3;
            vios[3] = vioLabel_4;
            vios[4] = vioLabel_5;
            vios[5] = vioLabel_6;
            vios[6] = vioLabel_7;
            vios[7] = vioLabel_8;
        }

        private void SetLabelClicks()
        {
            for (int i = 0; i < models.Length; i++)
            {
                if (models[i].Enabled == true)
                    models[i].Click += ModelLabel_Click;

                //if (numplates[i].Enabled == true)
                //    numplates[i].Click += PlateLabel_Click;

                if (vios[i].Enabled == true)
                    vios[i].Click += VioLabel_Click;

            }
        }

        private void ClearEmptyLabel()
        {
            for (int i = 0; i < models.Length; i++)
            {
                if (models[i].Text == "model")
                {
                    models[i].Text = "";
                    models[i].Enabled = false;
                }

                if (numplates[i].Text == "plate")
                {
                    numplates[i].Text = "";
                    numplates[i].Enabled = false;
                }

                if (vios[i].Text == "vio")
                {
                    vios[i].Text = "";
                    vios[i].Enabled = false;
                }
            }
        }

        private void ProfileLabel_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(user.Id);
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }

        private void VioLabel_Click_1(object sender, EventArgs e)
        {
            VioForm vioForm = new VioForm(user);
            this.Hide();
            vioForm.ShowDialog();
            this.Close();
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            try
            {
                Car[] cars = db.Cars.Where(c => c.UserId == user.Id).ToArray();

                string[] carModels = db.Cars.Select(c => c.Model).ToArray();
                int[] carIds = cars.Select(c => c.CarId).ToArray();


                for (int i = 0; i < cars.Length; i++)
                {
                    carDict.Add(cars[i].Model, cars[i].CarId);
                    models[i].Text = cars[i].Model;
                    numplates[i].Text = cars[i].NumberPlate;

                    int totalVio = CountTotalVio(cars[i].CarId);
                    if (totalVio > 0)
                        vios[i].Text = totalVio.ToString();
                    else
                        vios[i].Text = "0";

                }

                ClearEmptyLabel();
                SetLabelClicks();

                
            }
            catch (Exception ex)
            {
                log.Warn("No cars found for user: {userId}", user.Id);
                StaticNoCarLabel.Visible = true;
                ClearEmptyLabel();
            }
        }

        private void ModelLabel_Click(object sender, EventArgs e)
        {
            Label model = (Label)sender;
            RedactCarForm redactForm = new RedactCarForm(carDict[model.Text], this);

            redactForm.ShowDialog();
            this.Close();
            //this.Hide();
            //this.Close();
        }

        private void PlateLabel_Click(object sender, EventArgs e)
        {
            Label plate = (Label)sender;
            MessageBox.Show(plate.Text);;
        }

        private void VioLabel_Click(object sender, EventArgs e)
        {
            Label vio = (Label)sender;
            MessageBox.Show(vio.Text);
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            Car[] carAmount = db.Cars.Where(c => c.UserId == user.Id).ToArray();

            if (carAmount.Length >= 8)
            {
                MessageBox.Show("Кол-во автомобилей для одного профиля 8 штук. Удалите какой-либо чтобы продолжить", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            AddCarForm addCarForm = new AddCarForm(user, this);

            addCarForm.ShowDialog();
            this.Close();
        }
    }
}
