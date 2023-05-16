using NLog;
using ROV_TL.Models;

namespace ROV_TL.Forms.Additional
{
    public partial class PayForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Link to vio form
        VioForm vioForm;

        // Current user
        User user;

        // Vio to pay
        Vio vio;

        // Car id and Vio id to find data
        int carId;
        int vioId;

        public PayForm(User currentUser, int vioId, int carId, VioForm vioForm)
        {
            InitializeComponent();
            user = currentUser;
            this.vioId = vioId;
            this.carId = carId;
            this.vioForm = vioForm;
        }

        private void UpdateBalance()
        {
            CurrentBalanceLabel.Text = "Текущий баланс: " + user.Balance.ToString();
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            try
            {
                Car car = db.Cars.Where(c => c.CarId == carId).First();
                Vio vio = db.Violations.Where(v => v.VioId == vioId).First();
                this.vio = vio;

                CurrentBalanceLabel.Text = "Текущий баланс: " + user.Balance.ToString();

                int afterPay = user.Balance - Convert.ToInt32(vio.Fine);
                if (user.Balance < Convert.ToInt32(vio.Fine) && afterPay < 0)
                {
                    PayButton.Enabled = false;
                    PayButton.Cursor = Cursors.No;
                    PayButton.Text = "Недостаточно средств";
                    log.Info("Balance < vio fine {balance} {fine}", user.Balance, vio.Fine);
                }

                ViolationLabel.Text = vio.Violation;
                SumLabel.Text = vio.Fine;
                ModelLabel.Text = car.Model;
                PlateLabel.Text = car.NumberPlate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так во время загрузки информации о штрафе", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            int afterPay = user.Balance - Convert.ToInt32(vio.Fine);
            if (user.Balance > Convert.ToInt32(vio.Fine) && afterPay > 0)
            {
                PayedVio payedVio = new PayedVio
                {
                    PrevVioId = vio.VioId,
                    CarId = vio.CarId,
                    UserId = vio.UserId,
                    Violation = vio.Violation,
                    Fine = vio.Fine,
                    Date = vio.Date
                };

                try
                {
                    user.Balance = user.Balance - Convert.ToInt32(vio.Fine);
                    db.Users.Update(user);
                    db.PayedVio.Add(payedVio);
                    db.Violations.Remove(vio);

                    db.SaveChanges();

                    UpdateBalance();
                    log.Info("Payment success {vioId} {sum}", vio.VioId, vio.Fine);

                    MessageBox.Show("Оплата успешно проведена!", "ROV Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // do smh
                    log.Error(ex, "Error in violation payment {vioId}", vio.VioId);
                    MessageBox.Show("Что-то пошло не так во время оплаты...", "ROV Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Недостаточно средств для оплаты", "ROV Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            User updateUser = db.Users.Where(c => c.Id == user.Id).First();
            VioForm form = new VioForm(updateUser);

            vioForm.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            User updateUser = db.Users.Where(c => c.Id == user.Id).First();
            VioForm form = new VioForm(updateUser);

            vioForm.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
