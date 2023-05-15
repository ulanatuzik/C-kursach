using ROV_TL.Models;

namespace ROV_TL
{
    internal static class DBCode
    {
        public static User GetUserById(int id)
        {
            ApplicationContext db = new ApplicationContext();
            User user = db.Users.Where(u => u.Id == id).First();
            return user;
        }

        public static Car GetCarById(int id)
        {
            ApplicationContext db = new ApplicationContext();
            Car car = db.Cars.Where(c => c.CarId == id).First();
            return car;
        }

        public static Vio GetVioById(int id)
        {
            ApplicationContext db = new ApplicationContext();
            Vio vio = db.Violations.Where(v => v.VioId == id).First();
            return vio;
        }
    }
}
