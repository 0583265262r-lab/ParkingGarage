using System;
namespace ManageCars
{
    interface INpyment
    {
        void terminal();
    }
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
        public abstract int Time();


    }
    public class RegularCar: Vehicle,INorderbale
    {
        public RegularCar (string carnumbar, string type) 
            : base(carnumbar, type) { }
        public override int Time()
        {
            string now = DateTime.Now.ToString().Split()[1];
            bool result = int.TryParse(now, out int entryTime);
            return entryTime;
        }

        public bool IsAvilbale() => true;

    }
    public class DisabledCars :Vehicle,INorderbale
    {
        public DisabledCars(string carnumbar, string type)
            : base(carnumbar, type) { }
        public override int Time()
        {
            string now = DateTime.Now.ToString().Split()[1];
            bool result = int.TryParse(now, out int entryTime);
            return entryTime;
        }

        public bool IsAvilbale() => true;
    }
    public class Motorcycles:Vehicle,INorderbale
    {
        public Motorcycles(string carnumbar, string type)
            : base(carnumbar, type) { }
        public override int Time()
        {
            string now = DateTime.Now.ToString().Split()[1];
            bool result = int.TryParse(now, out int entryTime);
            return entryTime;
        }
        public bool IsAvilbale() => false;
    }

}