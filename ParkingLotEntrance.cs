using ManageCars;
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
        public string checkin()
        {
            string carnum = carNum();
            foreach (string id in CARSINPARKING)
            {
                if (carnum == id)
                    return $"the car {id} alredy in the parking lot.";
            }

            string cartype = carType();
            

            switch (cartype)
            {
                case "regularcar":
                    RegularCar regularCar = new RegularCar(carnum, cartype);
                    CARSINPARKING[counter] = regularCar.carNumber;
                    CARSTYPE[counter] = regularCar.carType;
                    CHECKIN[counter] = regularCar.CheckIn();
                    counter++;
                    { return $"car type: {regularCar.carType},car ID: {regularCar.carNumber},Check-in time: {regularCar.CheckIn()}"; }
                case "disabledcars":
                    DisabledCars disabledCars = new DisabledCars(carnum, cartype);
                    CARSINPARKING[counter] = disabledCars.carNumber;
                    CARSTYPE[counter] = disabledCars.carType;
                    CHECKIN[counter] = disabledCars.CheckIn();
                    { return $"car type: {disabledCars.carType},car ID: {disabledCars.carNumber},Check-in time: {disabledCars.CheckIn()}"; }
                case "motorcycles":
                    Motorcycles motorcycles = new Motorcycles(carnum, cartype);
                    CARSINPARKING[counter] = motorcycles.carNumber;
                    CARSTYPE[counter] = motorcycles.carType;
                    CHECKIN[counter] = motorcycles.CheckIn();
                    counter++;
                    { return $"car type: {motorcycles.carType},car ID: {motorcycles.carNumber},Check-in time: {motorcycles.CheckIn()}"; }
                default:
                    { throw new ArgumentException(""); }
            }
        }
   }

}
