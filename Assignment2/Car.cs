using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Enums;
using Assignment2.Interfaces;

namespace Assignment2
{
    public class Car : Vehicle
    {
        public string Trim;
        public string BodyType;


        public decimal Kilometers;
        public decimal Price;

        public Car()
        {
            Engine = EngineType.Cylinder_4;
        }

        public Car(string model)
        {
            CarModels = model;
        }

        public Car(string trim, string bodyType, decimal kilometers, decimal price) : this(trim)
        {
            BodyType = bodyType;
            Kilometers = kilometers;
            Price = price;
        }
    }
}
