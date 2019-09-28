using System;

namespace Constructors
{
    public class Car : Vehicle
    {
        public Car(string registration)
            : base(registration)
        {
            Console.WriteLine("Car is being initialized. Reg no - " + registration);
        }
    }
}
