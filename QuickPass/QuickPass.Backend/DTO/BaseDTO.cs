using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuickPass.Backend.DTO
{
    public class BaseDTO
    {
        private Guid _Id;
        private DateTimeOffset _CreatedOn;
        private DateTimeOffset _UpdatedOn;
        private bool _IsDeleted;

        internal void PropertyChanged()
        {
            _UpdatedOn = DateTime.UtcNow;
        }

        public BaseDTO()
        {
            _Id = Guid.NewGuid();
            _CreatedOn = DateTime.UtcNow;
        }

        public void Delete()
        {
            _IsDeleted = true;
            PropertyChanged();
        }

        public Guid Id { get { return Id; } set { Id = value; } }

        public DateTimeOffset CreatedOn { get { return _CreatedOn; } set { _CreatedOn = value; PropertyChanged(); } }

        public DateTimeOffset UpdatedOn { get { return _UpdatedOn; } set { _UpdatedOn = value; PropertyChanged(); } }

        public bool IsDeleted { get { return _IsDeleted; } }
        
    }
}
