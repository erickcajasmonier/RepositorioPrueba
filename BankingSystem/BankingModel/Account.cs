using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public class Account
    {
        private string _name;

        public string getName()
        {
            return _name;
        }

        public void setName(string name)
        {
            _name = name;
        }

    }
}
