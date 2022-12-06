
namespace loanSystem
{
    class Program
    {
        public static void Main (string[] args)
        {
            
            // create a new List of users

            List<User> userList = new List<User>();
            DeviceLender deviceLender = new DeviceLender();
            User user = new User("lol hansen", "123243435", "sdsd@sdsd.adsd");
            Admin peter = new Admin("Peter", "42424242", "p@corp.dk");
            Device mac = new Device(1, 456738, "iMac");
            Device macbook = new Device(2, 4563738, "Macbook");
            Device macKeyboard = new Device(3, 48938, "Mac Keyboard");
            Package MacSet = new Package(new List<Device>(){mac,macKeyboard});
            deviceLender.LendPackage(MacSet,user);
            deviceLender.LendDevice(macbook,user);
            Console.WriteLine("The List before:");
            Console.WriteLine(userList.Count);
            
            peter.AddUser(userList, user);
            
            Console.WriteLine("List after:");
            Console.WriteLine(userList.Count);
            
            
            // Remove user
            peter.deleteUser(userList,user);
            
            Console.WriteLine("After remove:");
            Console.WriteLine(userList.Count);
            Console.WriteLine(deviceLender.LoanDevicesList[0].Devices[0].Name);
            Console.WriteLine(deviceLender.LoanPackagesList[0].Packages[0].Devices[0].Name);
            Console.WriteLine(deviceLender.LoanPackagesList[0].Packages[0].Devices[1].Name);
            

        }
    }
        public User GetUserFromName(string name) {
            foreach(User p in userList) {
                if (p.Name == name) return p;
            }
            return new User(name, "00000000", "default@email.dk");
        }
}
