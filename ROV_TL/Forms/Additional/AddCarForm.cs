using NLog;
using ROV_TL.Models;
using System.Text.RegularExpressions;

namespace ROV_TL.Forms.Additional
{
    public partial class AddCarForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current user
        User user;

        CarsForm carsForm;
        public AddCarForm(User currentUser, CarsForm carsForm)
        {
            InitializeComponent();
            user = currentUser;
            this.carsForm = carsForm;
        }

        private bool IsNumberUnique(string numberPlate)
        {
            try
            {
                Car car = db.Cars.Where(c => c.NumberPlate == numberPlate).First();
                return false;
            }
            catch (Exception ex)
            {
                log.Warn("Number plate is not unique: {userId} {numberplate}", user.Id, numberPlate);
                return true;
            }
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            if (CarModelTextBox.Text.Length <= 0 || NumplateTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Не все данные заполнены", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Regex for validating number plate
            Regex regex = new Regex(@"^\d{4} [ABEIKMNOPCTX]{2}-[1-7]$");
            if (regex.IsMatch(NumplateTextBox.Text) == false)
            {
                MessageBox.Show("Введен неверный гос. знак автомобиля", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (IsNumberUnique(NumplateTextBox.Text) == false)
            {
                MessageBox.Show("Данный гос. знак уже закреплен за другим авто", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Car newCar = new Car { Model = CarModelTextBox.Text, NumberPlate = NumplateTextBox.Text, UserId = user.Id};
            try
            {
                db.Cars.Add(newCar);
                db.SaveChanges();

                log.Info("Car data added success for {userId} {carId}", user.Id);
                MessageBox.Show("Авто успешно добавлено!", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                log.Error(ex, "Something happened while adding car to base");

                MessageBox.Show("Что-то пошло не так во время добавления...", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaticCloseLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            User updateUser = db.Users.Where(c => c.Id == user.Id).First();
            CarsForm form = new CarsForm(user);
            carsForm.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            User updateUser = db.Users.Where(c => c.Id == user.Id).First();
            CarsForm form = new CarsForm(user);
            carsForm.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
