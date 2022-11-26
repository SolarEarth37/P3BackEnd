using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loanSystem
{
    internal class PackageClass
    {
        public int Id;
        public string Devices;
        public string Name;
        public Status PackageStatus;
        public enum Status
        {
            Accessible = 0,
            Borrowed = 1,
        }



        public PackageClass(int Id, string Devices, string Name, Status status)
        {
            this.Id = Id;
            this.Devices = Devices;
            this.Name = Name;
            this.PackageStatus = status;
        }
    }
}
