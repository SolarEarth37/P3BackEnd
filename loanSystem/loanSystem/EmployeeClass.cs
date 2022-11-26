using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loanSystem
{
    public class EmployeeClass : AdminClass
    {
        public EmployeeClass(string name, string phoneNumber, string email, role role) : base(name, phoneNumber, email, role)
        {

        }
    }
}
