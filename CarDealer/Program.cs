using CarDealer.DataAccess;
using CarDealer.Entities;
using CarDealer.Ropasitory.Abstract;
using CarDealer.Ropasitory.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CarDealer
{
    internal class Program
    {
        static void Start(CarDealerDbContext context)
        {
            IRepository<Car> carsRepository = new CarRepository(context);

            var added = carsRepository.Add(new Car
            {
                Brand = "Bmw",
                Model = "528i",
                ProductionYear = 2019,
                PlateNumber = "99AA999",
                BanCode = "A38TRT638TQM7RS9",
                Price = 49900,
            });
        }

        static void Main(string[] args)
        {
            //CarDealerDbContext context = new CarDealerDbContext();

           

            //Car car = new Car()
            //{

            //};

            //context.Cars.Add(car);

            //Car car2 = new Car()
            //{
            //    Brand = "Infiniti",
            //    Model = "FX35",
            //    ProductionYear = 2019,
            //    PlateNumber = "99KE848",
            //    BanCode = "R8T9LL638TQM7RS9",
            //    Price = 49900,
            //};

            //context.Cars.Add(car2);

            //Car car3 = new Car()
            //{
            //    Brand = "Bmw",
            //    Model = "528i",
            //    ProductionYear = 2019,
            //    PlateNumber = "99AA999",
            //    BanCode = "A79ITW638TXS7RS1",
            //    Price = 49900,
            //};

            //context.Cars.Add(car3);
            //context.SaveChanges();


        }
    }
}
