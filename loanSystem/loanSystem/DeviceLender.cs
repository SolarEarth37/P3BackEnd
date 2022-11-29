using System;

namespace loanSystem
{
    public class DeviceLender
    {
        private List<LoanDevice> _loanDevicesList = new List<LoanDevice>();
        private List<LoanPackage> _loanPackagesList = new List<LoanPackage>();

        public void LendDevice(Device deviceToLend, User lender)
        {
            List<Device> p = new List<Device> { deviceToLend };

            LoanDevice l = new LoanDevice(DateOnly.MaxValue, DateOnly.MinValue, lender, p);

            _loanDevicesList.Add(l);
        }

        public void LendPackage(Package packageToLend, User lender)
        {
            List<Package> p = new List<Package> { packageToLend };

            LoanPackage l = new LoanPackage(DateOnly.MaxValue, DateOnly.MinValue, lender,p);

            _loanPackagesList.Add(l);
        }

        public List<LoanDevice> LoanDevicesList => _loanDevicesList;

        public List<LoanPackage> LoanPackagesList => _loanPackagesList;
    }
}