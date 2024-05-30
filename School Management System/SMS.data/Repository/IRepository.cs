using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.data.Repository
{
    public interface IRepository<T > where T : class
    {
        T GetById(int id);
        void UpdateById(T entity);
        void DeleteById(int id);
        List<T> GetAll();

    }
}
