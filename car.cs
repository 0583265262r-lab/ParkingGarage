using System;
namespace ManageCars
{
    interface INorderbale
    {
        bool IsAvilbale(); 
    }

    public abstract class Vehicle
    {
        public string carNumber;
        public string carType;

        public Vehicle(string carnumbar, string type)
        {
            carNumber = carnumbar;
            carType = type;

        }
        public abstract int CheckIn();
            
        public abstract int CheckOut();


    }
    public class RegularCar: Vehicle,INorderbale
    {
        public RegularCar (string carnumbar, string type) 
            : base(carnumbar, type) { }
        public override int CheckIn()
        {
            string now = DateTime.Now.ToString().Split()[1];
            bool result = int.TryParse(now, out int entryTime);
            return entryTime;
        }
        public override int CheckOut()
        {
            string now = DateTime.Now.ToString().Split()[1];
            bool result = int.TryParse(now, out int exitTime);
            return exitTime;
        }
           

        public bool IsAvilbale()
        {
            return true;
        }
    }
    public class DisabledCars :Vehicle,INorderbale
    {
        public DisabledCars(string carnumbar, string type)
            : base(carnumbar, type) { }
        public override int CheckIn()
        {
            string now = DateTime.Now.ToString().Split()[1];
            bool result = int.TryParse(now, out int entryTime);
            return entryTime;
        }
            
        public override int CheckOut()
        {
            string now = DateTime.Now.ToString().Split()[1];
            bool result = int.TryParse(now, out int exitTime);
            return exitTime;
        }
        public bool IsAvilbale()
        {
            return true;
        }
    }
    public class Motorcycles:Vehicle,INorderbale
    {
        public Motorcycles(string carnumbar, string type)
            : base(carnumbar, type) { }
        public override int CheckIn()
        {
            string now = DateTime.Now.ToString().Split()[1];
            bool result = int.TryParse(now, out int entryTime);
            return entryTime;
        }
        public override int CheckOut()
        {
            string now = DateTime.Now.ToString().Split()[1];
            bool result = int.TryParse(now, out int exitTime);
            return exitTime;
        }
        public bool IsAvilbale()
        {
            return false;
        }
    }

}