using System;

using System.Collections.Generic;

namespace loanSystem
{
    public class DeviceClass
    {
        public int Id;
        public double DeviceNumber;
        public string Name;
        public Status deviceStatus;
        public enum Status
        {
            Accessible = 0,
            Borrowed = 1,
        }
      


        public DeviceClass(int Id, double DeviceNumber, string Name, Status status)
        {
            this.Id = Id;
            this.DeviceNumber = DeviceNumber;
            this.Name = Name;
            this.deviceStatus = status;
        }
    }
}


