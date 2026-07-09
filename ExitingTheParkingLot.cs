using ManageCars;
using ParkingLotEntrance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExitingTheParkingLot
{
    public class Exit
    {
        Entrance entry = new Entrance();
        string CARNUM = new Entrance().carNum();
        string CARTYPE = new Entrance().carType();

        public void checkOut()
        {
            

            for (int i = 0; i > entry.getAllCarsInParking().Length; i++) 
            {
                if (CARNUM == entry.getAllCarsInParking()[i])
                {
                    entry.getAllCarsInParking()[i].Remove(i);
                }


            }
        }
        public int isOrderbale()
        {

            switch (CARTYPE)
            {
                case "regularcar":
                    RegularCar regularCar = new RegularCar(CARNUM, CARTYPE);
                    return regularCar.Time();
                case "disabledcars":
                    DisabledCars disabledCars = new DisabledCars(CARNUM, CARTYPE);
                    return disabledCars.Time();
                case "motorcycles":
                    Motorcycles motorcycles = new Motorcycles(CARNUM, CARTYPE);
                    return motorcycles.Time();
                default:
                    { throw new ArgumentException("Type of vehicle not found."); }
            }
        }

    }
}
    