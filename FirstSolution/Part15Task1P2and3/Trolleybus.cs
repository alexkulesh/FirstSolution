using System;

namespace Part15Task1P2
{
    public class Trolleybus : Transport
    {
        private const string transportType = "Trolleybus";

        static Trolleybus() => TransportType = transportType;

        public Trolleybus(string destination, int number, DateTime departureTime, int numberOfSeats)
        {
            Destination = destination;
            Number = number;
            DepartureTime = departureTime;
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return $"Trolleybus info: destination point - {Destination}; number - {Number}; " +
                   $"date of departure - {DepartureTime}; number of seats - {NumberOfSeats}";
        }

        public override void PrintTransportType() => Console.WriteLine($"It is {transportType}");
    }
}