using System;

namespace Part15Task1
{
    public class Bus
    {
        private string destination;
        private int number;
        private string dateOfDepature;
        private int numberOfSeats;

        public Bus(string destination, int number, string dateOfDepature, int numberOfSeats)
        {
            this.destination = destination;
            this.number = number;
            this.dateOfDepature = dateOfDepature;
            this.numberOfSeats = numberOfSeats;
        }

        public string Destination
        {
            get => destination;
            set => destination = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Number
        {
            get => number;
            set => number = value;
        }

        public string DateOfDepature
        {
            get => dateOfDepature;
            set => dateOfDepature = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int NumberOfSeats
        {
            get => numberOfSeats;
            set => numberOfSeats = value;
        }

        public override string ToString()
        {
            return $"Bus info: destination point - {destination}; number - {number}; " +
                   $"date of departure - {dateOfDepature}; number of seats - {numberOfSeats}";
        }
    }
}
