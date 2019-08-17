using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPass.Backend.DTO
{
    public class PassBook : BaseDTO
    {
        private string _PassCode;
        private bool _Unlocked;
        private Dictionary<string, PassWord> _PassBookDictionary;

        public PassBook() : base()
        {
            _PassBookDictionary = new Dictionary<string, PassWord>();
        }

        public bool ValidatePassCode(string passCode)
        {
            if (string.Equals(passCode, _PassCode))
            {
                _Unlocked = true;
            }
            else
            {
                _Unlocked = false;
            }

            return _Unlocked;
        }
    }
}
