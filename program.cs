using ExitingTheParkingLot;
using OrderManagement;
using ParkingLotEntrance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1.Enter to the parking lot:");
                Console.WriteLine("2.Ordet plese in the parking");
                Console.WriteLine("3.Exit from the parking");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        new Entrance().checkin();
                        break;
                    case "2":
                        new OrderManage().createOrder();
                        break;
                    case "3":
                        new Exit().checkOut();
                        break;
                    default:
                        throw new ArgumentException("");
                }
            }
        }
    }
}
