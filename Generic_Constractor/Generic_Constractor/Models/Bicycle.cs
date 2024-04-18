using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _11_Abstract_Virtual_Override.Models
{
    internal class Bicycle : Vehicle
    {
        public string Type { get; set; }


        public Bicycle(string factoryName, string model, string color, double driveTime, double drivePath, string type) : base(factoryName, model, color, driveTime, drivePath)
        {
            Type = type;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{FactoryName} {Model} {Color} {DriveTime} {DrivePath} {AverageSpeed()} {Type}");
        }
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("Motorsuzdur");
        }

        public override void ToString()
        {
            Console.WriteLine($"{FactoryName} {Model}");
        }
    }
}
