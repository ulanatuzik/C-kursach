using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ROV_TL.Models;

namespace ROV_TL
{
    public partial class CarsForm : Form
    {
        ApplicationContext db = new ApplicationContext();

        // Arrays for labels
        Label[] models;
        Label[] numplates;

        public CarsForm(User currentUser)
        {
            //car = db.Cars.Where(x => x.UserId == currentUser.Id).First();

            //modelLabel_1.Text = car.Model;
            //plateLabel_1.Text = car.NumberPlate;

            InitializeComponent();
            SetArrays();

            Car[] cars = db.Cars.Where(x => x.UserId == currentUser.Id).ToArray();

            for (int i = 0; i < cars.Length; i++)
            {
                models[i].Text = cars[i].Model;
                numplates[i].Text = cars[i].NumberPlate;
            }

            ClearEmptyLabel();
        }

        private void SetArrays()
        {
            models = new Label[5];
            models[0] = modelLabel_1;
            models[1] = modelLabel_2;
            models[2] = modelLabel_3;
            models[3] = modelLabel_4;
            models[4] = modelLabel_5;

            numplates = new Label[5];
            numplates[0] = plateLabel_1;
            numplates[1] = plateLabel_2;
            numplates[2] = plateLabel_3;
            numplates[3] = plateLabel_4;
            numplates[4] = plateLabel_5;
        }

        private void ClearEmptyLabel()
        {
            for (int i = 0; i < models.Length; i++)
            {
                if (models[i].Text == "model")
                {
                    models[i].Text = "";
                }

                if (numplates[i].Text == "plate")
                {
                    numplates[i].Text = "";
                }
            }
        }
    }
}
