using CarDealer.DataAccess;
using CarDealer.Entities;
using CarDealer.Repository.Concrete;
using CarDealer.Ropasitory.Abstract;
using CarDealer.Ropasitory.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CarDealer
{
    internal class Program
    {


        static void Main(string[] args)
        {
            using (var context = new CarDealerDbContext())
            {
                var car = new Car
                {
                    Brand = "Infinit",
                    Model = "QX70S",
                    ProductionYear = 2019,
                    EngineLitr = 3.7,
                    PlateNumber = "99KE848",
                    Price = 89500
                };

                context.Cars.Add(car);
                context.SaveChanges();

                var passport = new TechnicalPassport
                {
                    CarId = car.Id,
                    SeriaNumber = "TP-777999",
                    BanCode = "WBA9876543210001"
                };

                context.TechnicalPassports.Add(passport);
                context.SaveChanges();

                Console.WriteLine("Car və TechnicalPassport uğurla əlavə olundu.");
            }

        }
    }
}
