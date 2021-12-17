using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int year { get; set; } = 7;
        public string make { get; set; } = "jeep";
        public string model { get; set; } = "wangler";
        public bool HasTrunk { get; set; }

        public abstract void DriveAbstract();
        public virtual void DriveVirtual() 
        {
            Console.WriteLine($"This {GetType().Name} is in drive");
        }


    }
}
