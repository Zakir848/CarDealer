using CarDealer.DataAccess;
using CarDealer.Entities;
using CarDealer.Ropasitory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarDealer.Ropasitory.Concrete
{
    public class CarRepository : IRepository<Car>
    {
        private readonly CarDealerDbContext _context;

        public CarRepository(CarDealerDbContext context)
        {
            _context = context;
        }

        public Car Add(Car obj)
        {
            var addedEntity = _context.Cars.Add(obj);
            return addedEntity.Entity;
        }

        public bool Delete(Car obj)
        {
            return _context.Cars.Remove(obj) != null;
        }

        public Car? Get(int Id)
        {
            return _context.Cars.SingleOrDefault(c => c.Id == Id);
        }

        public Car? Get(Expression<Func<Car, bool>> exp)
        {
            return _context.Cars.FirstOrDefault(exp);
        }

        public IEnumerable<Car> GetAll()
        {
            return _context.Cars;
        }

        public IEnumerable<Car> GetByFilter(Expression<Func<Car, bool>> exp)
        {
            return _context.Cars.Where(exp);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public Car Update(Car obj)
        {
            var updatedEntity = _context.Cars.Update(obj);
            return updatedEntity.Entity;
        }
    }
}
