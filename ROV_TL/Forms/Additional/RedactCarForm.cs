using NLog;
using ROV_TL.Models;
using System.Text.RegularExpressions;

namespace ROV_TL.Forms.Additional
{
    public partial class RedactCarForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        CarsForm carsForm;

        Car car;
        int carId;
        public RedactCarForm(int carId, CarsForm carsForm)
        {
            InitializeComponent();
            this.carId = carId;
            this.carsForm = carsForm;
        }

        private void RedactCarForm_Load(object sender, EventArgs e)
        {
            car = db.Cars.Where(c => c.CarId == carId).First();

            CarModelTextBox.Text = car.Model;
            //NumPlateTextBox.Text = car.NumberPlate + " Изменяется с помощью администратора";
        }

        private void ConfirmDataButton_Click(object sender, EventArgs e)
        {
            if (CarModelTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Не все данные заполнены", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Regex for validating number plate
            //Regex regex = new Regex(@"^\d{4} [ABEIKMNOPCTX]{2}-[1-7]$");
            //if (regex.IsMatch(NumPlateTextBox.Text) == false)
            //{
            //    MessageBox.Show("Введен неверный гос. знак автомобиля", "ROV Error",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return;
            //}

            if (CarModelTextBox.Text == car.Model)
            {
                MessageBox.Show("Данная модель совпдает с прошлой!", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            car.Model = CarModelTextBox.Text;

            db.Cars.Update(car);
            db.SaveChanges();


            log.Info("Data changed success for car: {carId}", car.CarId);

            MessageBox.Show("Данные успешно изменены", "ROV",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StaticCloseLabel_Click(object sender, EventArgs e)
        {
            //carsForm.UpdateForm();
            this.Hide();
            User user = db.Users.Where(c => c.Id == car.UserId).First();
            CarsForm form = new CarsForm(user);
            carsForm.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //carsForm.UpdateForm();
            this.Hide();
            User user = db.Users.Where(c => c.Id == car.UserId).First();
            CarsForm form = new CarsForm(user);
            carsForm.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
