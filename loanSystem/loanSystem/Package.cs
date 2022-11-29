using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loanSystem
{
    public class Package
    {
        private List<Device> _devices;

        public Package(List<Device> devices)
        {
            _devices = devices;
        }

        public List<Device> Devices => _devices;
    }
}
