using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Enums;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car(VehiclePick.Car, EngineType.combustion, 100);
            Console.Write(car1);
            Console.ReadKey();
        }
    }
}
