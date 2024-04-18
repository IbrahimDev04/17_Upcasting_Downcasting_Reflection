namespace _11_Abstract_Virtual_Override.Models
{
    internal class Car : Vehicle
    {


        private int _doorCount;

        public int DoorCount
        {
            get { return _doorCount; }
            set 
            { 
                if(_doorCount==2 || _doorCount==4)
                {
                    _doorCount = value; 
                }
                
            }
        }


        public bool IsElctricCar { get; set; }

        public Car(string factoryName, string model, string color, double driveTime, double drivePath, int doorCount, bool isElectricCar) : base(factoryName, model, color, driveTime, drivePath)
        {
            DoorCount = doorCount;
            IsElctricCar = isElectricCar;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{FactoryName} {Model} {Color} {DriveTime} {DrivePath} {AverageSpeed()} {DoorCount} {IsElctricCar}");
        }
        public override void DefineNatureHarmness()
        {
            if ( IsElctricCar)
            {
                Console.WriteLine("Elektrik");
            }
            else
            {
                Console.WriteLine("Beenzin");
            }
        }

        public override void ToString()
        {
            Console.WriteLine($"{FactoryName} {Model}");
        }
    }
}
