using Microsoft.EntityFrameworkCore;
using Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp4.conext;

namespace Repository.Interface.Base
{
    public class Repository<T> : IRepository<T> where T : class 
    {


        private AppDbContext _db = null;
        private DbSet<T> table = null;

        public Repository(AppDbContext db)
        {
            this._db = db;
            table = _db.Set<T>();
        }

        public void Add(T entity)
        {
           this.table.Add(entity);
        }

        public IQueryable<T> GetAll()
        {
            return this.table.AsQueryable();
        }

        public T GetById(long Id)
        {
            return this.table.Find(Id);
        }

        public void Remove(long id)
        {
            var removableObject = this.GetById(id);
            this.table.Remove(removableObject);
        }

        public bool SaveChanges()
        {
            return this._db.SaveChanges() > 0;
        }

        public void Update(T entity)
        {
            this.table.Attach(entity);
            this._db.Entry(entity).State = EntityState.Modified;
        }
    }
}
