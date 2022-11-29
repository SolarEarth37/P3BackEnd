using System;

using System.Collections.Generic;

namespace loanSystem
{
    public class Device
    {
        private int _id;
        private double _deviceNumber;
        private string _name;
        private bool _isBorrowed;
        private List<User> _borrowedByUser = new List<User>();

        public Device(int id, double deviceNumber, string name)
        {
            _id = id;
            _deviceNumber = deviceNumber;
            _name = name;
        }


        public void Borrow(User user)
        {
            _isBorrowed = true;
            _borrowedByUser.Add(user);
        }

        public void Return()
        {
            _isBorrowed = false;
        }

        public string Name => _name;
    }
    
}


