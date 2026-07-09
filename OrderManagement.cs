using System;
using System.Collections.Generic;
using System.Text;
using ParkingLotEntrance;

namespace OrderManagement
{
    
    class OrderManage
    {
        string[] ORDERLIST = new string[100];
        Entrance order = new Entrance();
        public string carNum()
        {
            Console.WriteLine("please enter car ID: ");
            string? num = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(num))
                throw new ArgumentException("");
            return num;

        }
        public void Main()
        {
            order.
        }


    }
}
