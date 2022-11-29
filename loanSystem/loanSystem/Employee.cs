using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loanSystem
{
    public abstract class Employee
    {
        private string _name;
        private string _phoneNumber;
        private string _email;

        protected Employee(string name, string phoneNumber, string email)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _email = email;
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Email
        {
            get => _email;
            set => _email = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
