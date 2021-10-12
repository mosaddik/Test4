using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Base
{
    public interface IRepository <T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(long id);
        IQueryable<T> GetAll();
        T GetById(long Id);
        bool SaveChanges();
    }
}
