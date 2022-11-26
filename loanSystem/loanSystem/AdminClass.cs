using System;
using static loanSystem.AdminClass;

namespace loanSystem
{
	public class AdminClass
	{
		public string Name;
		public string PhoneNumber;
		public string Email;
		public role Role;
		public enum role
        {
            Admin,
            User,
			Employee
        }

        public AdminClass(string name, string phoneNumber, string email, role role)
		{
			Name = name;
            PhoneNumber = phoneNumber;
			Email = email;
			this.Role = role; 


		}

		
	//funtion



	}

  
}

