using System;
namespace loanSystem
using System.Collections.Generic;
{
    public class DeviceClass
    {
        public int Id;
        public double DeviceNumber;
        public string Name;
        public enum Status
        {
            Editor,
            Viewer
        }

        public DeviceClass(int Id, double DeviceNumber, string Name, enum Status)
		{
			deviceName = Id;
			deviceNumber = DeviceNumber;
			deviceName = Name;
			deviceStatus = Status;
		}



namespace loanSystem
    {
        //Definerar klassen Book
        class Id
        {
            public enum Status
            { get; set; }
            public string Name
            { get; set; }
            public double Devicename
            { get; set; }

        }
        class Program
        {
            static List<Id> IdList = new List<Id>();
            static Id Id = new Id();


            //Menyn och startsidan till programmet
            static void Main(string[] args)
            {
                //husk at rette den
                using (StreamReader readFile = new StreamReader("Bookfil.txt"))
                {
                    string s;
                    while ((s = readFile.ReadLine()) != null)
                    {
                        Id Id = new Id();
                        string[] IdData = s.Split(',');
                        Id.Author = IdData[0];
                        Id.Title = IdData[1];
                        IdList.Add(Id);
                    }
                    readFile.Close();
                }
                bool Close = true;
                while (Close)
                {
                    Console.WriteLine("\n\nVelkomme til lånsystemmet !\n" +
                    "\n1)Add a device \n" +
                    "2)Delete a device \n" +
                    "3)Search for a device \n" +
                    "4)Borrow device\n" +
                    "5)Return device\n" +
                    "6)Close program\n\n");

                    int val = int.Parse(Console.ReadLine());

                    if (val == 1)
                    {
                        AddDevice();
                    }
                    else if (val == 2)
                    {
                        RemoveDevice();
                    }
                    else if (val == 3)
                    {
                        SearchDevice();
                    }
                    else if (val == 4)
                    {
                        BorrowDevice();
                    }
                    else if (val == 5)
                    {
                        ReturnDevice();
                    }
                    else if (val == 6)
                    {
                        Console.WriteLine("Thanks!");
                        Close = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nTry igen! ");
                    }
                }




            }

        }