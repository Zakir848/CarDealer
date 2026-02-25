using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarDealer.Ropasitory.Abstract
{
    public interface IRepository<T>
    {
        T? Get(int Id);
        T? Get(Expression<Func<T, bool>> exp);

        IEnumerable<T> GetAll();
        IEnumerable<T> GetByFilter(Expression<Func<T, bool>> exp);

        T Add(T obj);
        T Update(T obj);
        bool Delete(T obj);
        bool SaveChanges();
    }
}
