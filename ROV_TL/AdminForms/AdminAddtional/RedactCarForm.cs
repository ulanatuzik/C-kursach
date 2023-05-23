using NLog;
using ROV_TL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROV_TL.AdminForms.AdminAddtional
{
    public partial class RedactCarForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current admin
        Admin admin;

        // Car to redact
        Car car;
        
        // Link to cars form
        CarsForm carsForm;

        public RedactCarForm(Admin currentAdmin, Car redactCar, CarsForm carsForm)
        {
            InitializeComponent();
            admin = currentAdmin;
            car = redactCar;
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
                log.Warn("Number plate is not unique: {numberplate}", numberPlate);
                return true;
            }
        }

        private void RedactCarForm_Load(object sender, EventArgs e)
        {
            LoginTextBox.Text = db.Users
                    .Where(u => u.Id == car.UserId)
                    .Select(u => u.Login)
                    .First();

            ModelTextBox.Text = car.Model;
            PlateTextBox.Text = car.NumberPlate;
        }

        private bool IsLoginExists(string login)
        {
            try
            {
                // if there's no users with 'login' it creates exception
                User logUser = db.Users.Where(x => x.Login == login).First();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        private void ConfirmDataButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.Length <= 0 || ModelTextBox.Text.Length <= 0 || PlateTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Не все данные заполнены", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Regex for validating number plate
            Regex regex = new Regex(@"^\d{4} [ABEIKMNOPCTX]{2}-[1-7]$");
            if (regex.IsMatch(PlateTextBox.Text) == false)
            {
                MessageBox.Show("Введен неверный гос. знак автомобиля", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (IsNumberUnique(PlateTextBox.Text) == false)
            {
                MessageBox.Show("Данный гос. знак уже закреплен за другим авто", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (IsLoginExists(LoginTextBox.Text) == false)
            {
                MessageBox.Show("Такого логина не существует", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int userId =  db.Users
                    .Where(u => u.Login == LoginTextBox.Text)
                    .Select(u => u.Id)
                    .First();

            car.UserId = userId;
            car.NumberPlate = PlateTextBox.Text;
            car.Model = ModelTextBox.Text;

            db.Cars.Update(car);
            db.SaveChanges();

            MessageBox.Show("Данные успешно изменены");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsForm form = new CarsForm(admin);
            carsForm.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void StaticCloseLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsForm form = new CarsForm(admin);
            carsForm.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
