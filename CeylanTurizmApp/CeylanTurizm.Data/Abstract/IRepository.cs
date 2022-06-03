using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Data.Abstract
{
    public interface IRepository<T> 
    {
        List<T> GetAll();
        T GetById(int id);
        void Delete(T entity);
        void Update(T entity);
        void Create(T entity);
    }
}
