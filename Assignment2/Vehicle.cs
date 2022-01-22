using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Enums;

namespace Assignment2
{
    class Vehicle
    {
        public string CarModels;
        public Makes Make;
        public int Year;
        public EngineType Engine;
        //public IsRepairNeeded Repair;

        public virtual int GetMaxSpeed()
        {
            return 0;
        }
    }
}
