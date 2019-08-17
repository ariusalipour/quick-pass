using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPass.Backend.Repository.Interface
{
    interface IBaseRepository<T> where T : class
    {
        List<T> GetAll(); 
        T Get(Guid id);
        bool Update(T obj);
        bool Delete(T obj);
    }
}
