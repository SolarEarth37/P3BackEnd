using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loanSystem
{
    public class UserClass : AdminClass 
    {
        public UserClass(global::System.String name, global::System.String phoneNumber, global::System.String email, role role) : base(name, phoneNumber, email, role)
        {
        }
    }
}
