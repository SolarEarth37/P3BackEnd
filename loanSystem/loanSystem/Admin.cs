using System;
using System.Security.Cryptography;
using static loanSystem.Admin;

namespace loanSystem
{
    public class Admin : Employee
    {
        public Admin(string name, string phoneNumber, string email) : base(name, phoneNumber, email)
        {
        }

        public void AddUser(List<User> userList, User user)
        {
            userList.Add(user);
        }

        public void deleteUser(List<User> userList, User user)
        {
            userList.Remove(user);
        }
        
    }
}