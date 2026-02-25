using CarDealer.DataAccess;
using CarDealer.Entities;
using CarDealer.Ropasitory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarDealer.Repository.Concrete
{
    public class TechnicalPassportRepository : IRepository<TechnicalPassport>
    {

        private readonly CarDealerDbContext _context;

        public TechnicalPassportRepository(CarDealerDbContext context)
        {
            _context = context;
        }

        public TechnicalPassport Add(TechnicalPassport obj)
        {
            var addedEntity = _context.TechnicalPassports.Add(obj);
            return addedEntity.Entity;
        }

        public bool Delete(TechnicalPassport obj)
        {
            return _context.TechnicalPassports.Remove(obj) != null;
        }

        public TechnicalPassport? Get(int CarId)
        {
            return _context.TechnicalPassports.SingleOrDefault(c => c.CarId == CarId);
        }

        public TechnicalPassport? Get(Expression<Func<TechnicalPassport, bool>> exp)
        {
            return _context.TechnicalPassports.FirstOrDefault(exp);
        }

        public IEnumerable<TechnicalPassport> GetAll()
        {
            return _context.TechnicalPassports;
        }

        public IEnumerable<TechnicalPassport> GetByFilter(Expression<Func<TechnicalPassport, bool>> exp)
        {
            return _context.TechnicalPassports.Where(exp);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public TechnicalPassport Update(TechnicalPassport obj)
        {
            var updatedEntity = _context.TechnicalPassports.Update(obj);
            return updatedEntity.Entity;
        }
    }
}
