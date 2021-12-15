using System;

namespace Part15Task2
{
    public class Car : Auto
    {
        private int numberOfDoors;
        public Car(string brand, string registrationNum, int maxSpeed, int carryingCapacity, int numberOfDoors)
            : base(brand, registrationNum, maxSpeed, carryingCapacity)
        {
            this.numberOfDoors = numberOfDoors;
        }
        
        public override void printInfo()
        {
            Console.WriteLine($"{Brand} auto info:registration number - {RegistrationNum}; " +
                              $"max speed - {MaxSpeed}; carrying capacity - {CarryingCapacity}; number of doors - {numberOfDoors}");
        }
    }
}