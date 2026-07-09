using ManageCars;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotEntrance
{
    
   public class Entrance
    {
        string[] CARSINPARKING = new string[100];
        string[] CARSTYPE = new string[100];
        int[] CHECKIN = new int[100];
        int counter = 0;
        public string carNum()
        {
            Console.WriteLine("please enter car ID: ");
            string? num = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(num))
                throw new ArgumentException("");
            return num;

        }
        public string carType()
        {
            Console.WriteLine("please enter car type: ");
            string? type = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(type))
            { throw new ArgumentException(""); }
            return type;

        }
        public string[] getAllCarsInParking() => CARSINPARKING;
        public Vehicle checkin()
        {
            string cartype = carType();
            string carnum = carNum();
            foreach (string carID in CARSINPARKING)
            {
                if (carnum == carID)
                {
                    throw new ArgumentException("");
                }
            }
            OrderManage order = new OrderManage();
            foreach (string carID in order.getAllOrders())
            {
                if (carnum == carID)
                {
                    Console.WriteLine("There is an order placed on this vehicle.");
                }
            }

            switch (cartype)
            {
                case "regularcar":
                    RegularCar regularCar = new RegularCar(carnum, cartype); ;
                    CARSINPARKING[counter] = regularCar.carNumber;
                    CARSTYPE[counter] = regularCar.carType;
                    CHECKIN[counter] = regularCar.Time();
                    counter++;
                    Console.WriteLine("geat open");
                    { return regularCar; }
                case "disabledcars":
                    DisabledCars disabledCars = new DisabledCars(carnum, cartype);
                    CARSINPARKING[counter] = disabledCars.carNumber;
                    CARSTYPE[counter] = disabledCars.carType;
                    CHECKIN[counter] = disabledCars.Time();
                    { return disabledCars; }
                case "motorcycles":
                    Motorcycles motorcycles = new Motorcycles(carnum, cartype);
                    CARSINPARKING[counter] = motorcycles.carNumber;
                    CARSTYPE[counter] = motorcycles.carType;
                    CHECKIN[counter] = motorcycles.Time();
                    counter++;
                    { return motorcycles; }
                default:
                    { throw new ArgumentException("Type of vehicle not found."); }
            }
            
        }

   }

}
