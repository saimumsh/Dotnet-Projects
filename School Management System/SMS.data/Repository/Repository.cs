using Microsoft.EntityFrameworkCore;
using SMS.data.SMS_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.data.Repository
{
    public abstract  class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }
        public DbSet<T> Table
        {
            get { return _db.Set<T>(); }
        }
        public void DeleteById(int id)
        {
            T entity = Table.Find(id);
            Table.Remove(entity);
            _db.SaveChanges();
            
        }

        public List<T> GetAll()
        {
            return Table.ToList();
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public void UpdateById(T entity)
        {
           Table.Update(entity);
            _db.SaveChanges();
        }
    }
}
