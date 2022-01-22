using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Enums;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car(VehiclePick.Car, EngineType.Cylinders_6, 100);
            Console.Write(Car1);
            Console.ReadKey();
        }
    }
}
