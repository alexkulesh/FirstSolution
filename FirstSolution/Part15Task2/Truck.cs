using System;

namespace Part15Task2
{
    public class Truck : Auto
    {
        private bool hasTrailer;
        
        public override void printInfo()
        {
            Console.WriteLine($"{Brand} auto info:registration number - {RegistrationNum}; " +
                              $"max speed - {MaxSpeed}; carrying capacity - {CarryingCapacity}; has trailer - {hasTrailer}");
        }

        public override int countCarryingCapacity()
        {
            if (hasTrailer == true)
            {
                return CarryingCapacity *= 2;
            }
            
            return base.countCarryingCapacity();
        }

        public Truck(string brand, string registrationNum, int maxSpeed, int carryingCapacity, bool hasTrailer) 
            : base(brand, registrationNum, maxSpeed, carryingCapacity)
        {   
            this.hasTrailer = hasTrailer;
            countCarryingCapacity();
        }
    }
}