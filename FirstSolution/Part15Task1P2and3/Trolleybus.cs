using System;

namespace Part15Task1P2
{
    public class Trolleybus : Transport
    {
        static Trolleybus() => TransportType = "Trolleybus";
        
        public Trolleybus(string destination, int number, string dateOfDepature, int numberOfSeats)
        {
            Destination = destination;
            Number = number;
            DateOfDepature = dateOfDepature;
            NumberOfSeats = numberOfSeats;
        }
        
        public override string ToString()
        {
            return $"Trolleybus info: destination point - {Destination}; number - {Number}; " +
                   $"date of departure - {DateOfDepature}; number of seats - {NumberOfSeats}";
        }

        public override void PrintTransportType() => Console.WriteLine($"It is {TransportType}");
    }
}