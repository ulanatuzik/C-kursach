using NLog;
using ROV_TL.Models;
using System.Text.RegularExpressions;

namespace ROV_TL.AdminForms.AdminAddtional
{
    public partial class RedactVioForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current admin
        Admin admin;

        // Vio to redact
        Vio vio;

        // Link to vio form
        NoPayViosForm viosForm;

        // 
        string plate;

        public RedactVioForm(Admin currentAdmin, Vio vio ,NoPayViosForm viosForm)
        {
            InitializeComponent();
            this.admin = currentAdmin;
            this.viosForm = viosForm;
            this.vio = vio;
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

        private bool IsLoginExists(string userLogin)
        {
            try
            {
                // if there's no users with 'login' it creates exception
                User logUser = db.Users.Where(x => x.Login == userLogin).First();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        private void RedactVioForm_Load(object sender, EventArgs e)
        {
            VioTextBox.Text = vio.Violation;
            SumTextBox.Text = vio.Fine;
            DateTextBox.Text = vio.Date.ToString();

            string userLogin = db.Users
                .Where(u => u.Id == vio.UserId)
                .Select(u => u.Login)
                .First();

            string carModel = db.Cars
                .Where(c => c.CarId == vio.CarId)
                .Select(c => c.Model)
                .First();

            plate = db.Cars
                .Where(c => c.CarId == vio.CarId)
                .Select(c => c.NumberPlate)
                .First();

            LoginTextBox.Text = userLogin;
            ModelTextBox.Text = carModel;
            PlateTextBox.Text = plate;
        }

        private void ConfirmDataButton_Click(object sender, EventArgs e)
        {
            if (VioTextBox.Text.Length <= 0 || SumTextBox.Text.Length <= 0 || LoginTextBox.Text.Length <= 0 || ModelTextBox.Text.Length <= 0 || PlateTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Не все данные заполнены");
                return;
            }

            int fine = 0;
            DateTime vioDate;

            try
            {
                fine = Convert.ToInt32(SumTextBox.Text);

                if (fine <= 0)
                {
                    MessageBox.Show("Штраф не может быть меньше либо равным нулю", "ROV Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введенный штраф должен быть числом", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Regex for validating number plate
            Regex regex = new Regex(@"^\d{4} [ABEIKMNOPCTX]{2}-[1-7]$");
            if (regex.IsMatch(PlateTextBox.Text) == false)
            {
                MessageBox.Show("Введен неверный гос. знак автомобиля", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (IsNumberUnique(PlateTextBox.Text) == false && PlateTextBox.Text != plate)
            {
                MessageBox.Show("Данный гос. знак уже закреплен за другим авто", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //try
            //{
            //    vioDate = Convert.ToDateTime(PlateTextBox.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Введена неверная дата", "ROV Error",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return;
            //}

            if (IsLoginExists(LoginTextBox.Text) == false)
            {
                MessageBox.Show("Пользователя с таким логином не существует", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //vio.Date = vioDate;
            vio.Violation = VioTextBox.Text;
            vio.Fine = fine.ToString();

            db.Violations.Update(vio);
            db.SaveChanges();

            MessageBox.Show("Данные успешно изменены");
        }

        private void StaticCloseLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoPayViosForm form = new NoPayViosForm(admin);
            viosForm.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoPayViosForm form = new NoPayViosForm(admin);
            viosForm.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
