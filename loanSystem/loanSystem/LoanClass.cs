using System;
namespace loanSystem
{
	public class IDClass
	{
		public IDClass()
		{
		}
	}
}

public static void Borrow.Device()
{
    Console.Write("Enter a device name or a device number: ");
    string borrow = Console.ReadLine();
    foreach (Device b in DviceList)
    {
        if (b.DeviceNumber.Equals(borrow))
        {
            if (b.IsBorrowed == true)
            {
                Console.WriteLine("Device is already taken");
            }
            else
            {
                Console.WriteLine(b.DeviceName + ":" + b.DeviceNumber);
                b.IsBorrowed = true;
            }
        }

    }
}
        