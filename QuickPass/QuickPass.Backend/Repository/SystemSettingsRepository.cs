using QuickPass.Backend.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickPass.Backend.DTO;

namespace QuickPass.Backend.Repository
{
    public class SystemSettingsRepository : IBaseRepository<SystemSettings>
    {
        public List<SystemSettings> GetAll()
        {
            throw new NotImplementedException();
        }

        public SystemSettings Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(SystemSettings obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(SystemSettings obj)
        {
            throw new NotImplementedException();
        }
    }
}
