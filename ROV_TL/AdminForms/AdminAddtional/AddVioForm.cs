using NLog;
using ROV_TL.Models;

namespace ROV_TL.AdminForms.AdminAddtional
{
    public partial class AddVioForm : Form
    {
        // Entity framework things
        ApplicationContext db = new ApplicationContext();

        // NLOG things
        Logger log = LogManager.GetCurrentClassLogger();

        // Current admin
        Admin admin;

        // Vio to create
        Vio newVio;

        public AddVioForm(Admin currentAdmin)
        {
            InitializeComponent();
            admin = currentAdmin;
        }

        private void AddVioForm_Load(object sender, EventArgs e)
        {

        }

        private void RandomGenButton_Click(object sender, EventArgs e)
        {
            User[] users = db.Users.ToArray();
            Rule[] rules = db.Rules.ToArray();

            Random rnd = new Random();

            int rndUser = rnd.Next(0, users.Count());

            while (db.Cars.Where(c => c.UserId == users[rndUser].Id).ToArray().Count() <= 0)
            {
                rndUser = rnd.Next(0, users.Count());
            }

            Car[] cars = db.Cars.Where(c => c.UserId == users[rndUser].Id).ToArray();
            int rndCar = rnd.Next(0, cars.Count());
            int rndRule = rnd.Next(0, rules.Count());

            UIDTextBox.Text = users[rndUser].Id.ToString();
            LoginTextBox.Text = users[rndUser].Login;
            CIDTextBox.Text = cars[rndCar].CarId.ToString();
            ModelTextBox.Text = cars[rndCar].Model;

            VioTextBox.Text = rules[rndRule].Text;
            FineTextBox.Text = rules[rndRule].Fine.ToString();

            newVio = new Vio
            {
                CarId = cars[rndCar].CarId,
                UserId = users[rndUser].Id,

                Violation = rules[rndRule].Text,
                Fine = rules[rndRule].Fine.ToString(),
                Date = DateTimePicker.Value
            };

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {


            db.Violations.Add(newVio);
            db.SaveChanges();
        }
    }
}
