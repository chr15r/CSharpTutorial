using System;

namespace Constructors
{
    public class Vehicle
    {
        private readonly string registration;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized");
        //}

        public Vehicle(string registration)
        {
            this.registration = registration;

            Console.WriteLine("Vehicle initizlized - " + registration);
        }
    }
}
