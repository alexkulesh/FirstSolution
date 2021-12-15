using System;

namespace Part15Task2
{
    public class Auto
    {
        private string brand;
        private string registrationNum;
        private int maxSpeed;
        private int carryingCapacity;

        public Auto(string brand, string registrationNum, int maxSpeed, int carryingCapacity)
        {
            this.brand = brand;
            this.registrationNum = registrationNum;
            this.maxSpeed = maxSpeed;
            this.carryingCapacity = carryingCapacity;
        }

        public virtual void printInfo()
        {
            Console.WriteLine($"{brand} auto info:registration number - {registrationNum}; max speed - {maxSpeed}; " +
                              $"carrying capacity - {carryingCapacity}");
        }

        public virtual int countCarryingCapacity()
        {
            return carryingCapacity;
        }

        public string Brand
        {
            get => brand;
            set => brand = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string RegistrationNum
        {
            get => registrationNum;
            set => registrationNum = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int MaxSpeed
        {
            get => maxSpeed;
            set => maxSpeed = value;
        }

        public int CarryingCapacity
        {
            get => carryingCapacity;
            set => carryingCapacity = value;
        }
    }
}