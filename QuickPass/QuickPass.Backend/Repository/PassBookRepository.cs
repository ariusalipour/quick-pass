using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickPass.Backend.DTO;
using QuickPass.Backend.Repository.Interface;

namespace QuickPass.Backend.Repository
{
    public class PassBookRepository : IBaseRepository<PassBook>
    {
        public List<PassBook> GetAll()
        {
            throw new NotImplementedException();
        }

        public PassBook Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(PassBook obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(PassBook obj)
        {
            throw new NotImplementedException();
        }
    }
}
