using System;

namespace Part15Task1P2
{
    public class Transport
    {
        private static string transportType;
        private string destination;
        private int number;
        private string dateOfDepature;
        private int numberOfSeats;
        
        public Transport()
        {
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
        
        public static string TransportType
        {
            get => transportType;
            set => transportType = value ?? throw new ArgumentNullException(nameof(value));
        }
        
        public virtual void PrintTransportType() => Console.WriteLine("Just some transport");
    }
}