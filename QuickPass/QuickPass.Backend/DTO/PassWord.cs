using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPass.Backend.DTO
{
    public class PassWord : BaseDTO
    {
        private string _PassName;
        private string _PassURL;
        private string _PassWord;

        public PassWord(): base()
        {

        }

        public string PassName { get { return _PassName; } set { _PassName = value; PropertyChanged(); } }
    }
}
