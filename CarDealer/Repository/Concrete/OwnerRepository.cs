using CarDealer.DataAccess;
using CarDealer.Entities;
using CarDealer.Ropasitory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarDealer.Repository.Concrete
{
    public class OwnerRepository : IRepository<Owner>
    {
        private readonly CarDealerDbContext _context;

        public OwnerRepository(CarDealerDbContext context)
        {
            _context = context;
        }

        public Owner Add(Owner obj)
        {
            var addedEntity = _context.Owners.Add(obj);
            return addedEntity.Entity;

        }

        public bool Delete(Owner obj)
        {
            return _context.Owners.Remove(obj) != null;
        }

        public Owner? Get(int Id)
        {
            return _context.Owners.SingleOrDefault(s => s.Id == Id);
        }

        public Owner? Get(Expression<Func<Owner, bool>> exp)
        {
            return _context.Owners.FirstOrDefault(exp);
        }

        public IEnumerable<Owner> GetAll()
        {
            return _context.Owners;
        }

        public IEnumerable<Owner> GetByFilter(Expression<Func<Owner, bool>> exp)
        {
            return _context.Owners.Where(exp);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public Owner Update(Owner obj)
        {
            var updatedEntity = _context.Owners.Update(obj);
            return updatedEntity.Entity;
        }
    }
}
