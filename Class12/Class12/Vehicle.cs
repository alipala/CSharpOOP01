using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class12
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized...");
        //}

        public Vehicle(string registirationNumber)
        {
            _registrationNumber = registirationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", registirationNumber);
        }
    }
}
