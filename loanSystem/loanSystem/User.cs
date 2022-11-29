using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loanSystem
{
    public class User : Employee 
    {
        public User(string name, string phoneNumber, string email) : base(name, phoneNumber, email)
        {
        }
    }
}
