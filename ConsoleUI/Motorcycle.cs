using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("motorcycle is in drive");
        }
        public override void DriveVirtual()
        {
            base.DriveVirtual();
            Console.WriteLine($"This {GetType().Name} is {GetType().BaseType.Name} in drive");
        }
    }
}
