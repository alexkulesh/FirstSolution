using System;

namespace Part15Task2
{
    public class Motorcycle : Auto
    {
        private bool hasSidebar;
        
        public Motorcycle(string brand, string registrationNum, int maxSpeed, int carryingCapacity, bool hasSidebar) 
            : base(brand, registrationNum, maxSpeed, carryingCapacity)
        {   
            this.hasSidebar = hasSidebar;
            countCarryingCapacity();
        }
        
        public override void printInfo()
        {
            Console.WriteLine($"{Brand} auto info:registration number - {RegistrationNum}; " +
                              $"max speed - {MaxSpeed}; carrying capacity - {CarryingCapacity}; has sidebar - {hasSidebar}");
        }

        public override int countCarryingCapacity()
        {
            if (hasSidebar == false)
            {
                return CarryingCapacity = 0;
            }
            
            return base.countCarryingCapacity();
        }
    }
}