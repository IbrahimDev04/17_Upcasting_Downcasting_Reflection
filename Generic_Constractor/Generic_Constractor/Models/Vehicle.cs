namespace _11_Abstract_Virtual_Override.Models
{
    abstract class Vehicle
    {
        public string FactoryName { get; set; }
        public string Model {  get; set; }
        public string Color { get; set; }
        public double DriveTime { get; set; }
        public double DrivePath { get; set; }

        public Vehicle(string factoryName, string model, string color, double driveTime, double drivePath)
        {
            FactoryName = factoryName;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            DrivePath = drivePath;
        }
        public double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"{FactoryName} {Model} {Color} {DriveTime} {DrivePath} {AverageSpeed()}");
        }

        public virtual void ToString()
        {
            Console.WriteLine($"{FactoryName} {Model}");
        }

        public abstract void DefineNatureHarmness();

    }
}
