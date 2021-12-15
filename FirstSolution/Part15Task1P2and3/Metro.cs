using System;

namespace Part15Task1P2
{
    public class Metro : Transport
    {
        private const string transportType = "Metro";
        static Metro() => TransportType = transportType;

        public Metro(string destination, int number, DateTime departureTime, int numberOfSeats)
        {
            Destination = destination;
            Number = number;
            DepartureTime = departureTime;
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return $"Metro info: destination point - {Destination}; number - {Number}; " +
                   $"date of departure - {DepartureTime}; number of seats - {NumberOfSeats}";
        }

        public override void PrintTransportType() => Console.WriteLine($"It is {transportType}");
    }
}