
namespace loanSystem
{
    class Program
    {
        private static bool _keepRunning = true;

        public static void Main (string[] args)
        {
            
            Console.CancelKeyPress += delegate(object sender, ConsoleCancelEventArgs e)
            {
                e.Cancel = true;
                Program._keepRunning = false;
            };

            Console.WriteLine("Starting HTTP listener...");
            List<User> userList = new List<User>();
            DeviceLender deviceLender = new DeviceLender();

            var httpServer = new HttpServer(userList, deviceLender);
            httpServer.Start();

            while (Program._keepRunning) { }

            httpServer.Stop();

            /*
            Console.WriteLine("Exiting gracefully...");
            // create a new List of users

            User user = new User("lol hansen", "123243435", "sdsd@sdsd.adsd");
            Admin peter = new Admin("Peter", "42424242", "p@corp.dk");
            Device mac = new Device(1, 456738, "iMac");
            Device macbook = new Device(2, 4563738, "Macbook");
            Device macKeyboard = new Device(3, 48938, "Mac Keyboard");
            Package MacSet = new Package(new List<Device>(){mac,macKeyboard});
            deviceLender.LendPackage(MacSet,user);
            // Geting lendingdate from date.now 
            DateOnly lendingDaytemp =DateOnly.FromDateTime(DateTime.Now);
           
            //DateOnly testdate = DateOnly.Parse("1/11/2022");
            deviceLender.LendDevice(macbook,user, lendingDaytemp);
            Console.WriteLine(userList.Count);
            
            peter.AddUser(userList, user);
            
            Console.WriteLine("List after:");
            Console.WriteLine(userList.Count);
            foreach (var item in deviceLender.LoanDevicesList)
            {
                Console.WriteLine($"lending Date :{item._lendingDate.ToString()}");
                Console.WriteLine($"due Date :{item._dueDate.ToString()}");
            }
           
            
            // Remove user
            peter.deleteUser(userList,user);
            
            Console.WriteLine("After remove:");
            Console.WriteLine(userList.Count);
            Console.WriteLine(deviceLender.LoanDevicesList[0].Devices[0].Name);
            Console.WriteLine(deviceLender.LoanPackagesList[0].Packages[0].Devices[0].Name);
            Console.WriteLine(deviceLender.LoanPackagesList[0].Packages[0].Devices[1].Name);

            */

        }
    }
    
}
