using System;

namespace Part15Task1P2
{
    public class Tram : Transport
    {
        private const string transportType = "Tram";
        static Tram() => TransportType = transportType;

        public Tram(string destination, int number, DateTime departureTime, int numberOfSeats)
        {
            Destination = destination;
            Number = number;
            DepartureTime = departureTime;
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return $"Tram info: destination point - {Destination}; number - {Number}; " +
                   $"date of departure - {DepartureTime}; number of seats - {NumberOfSeats}";
        }

        public override void PrintTransportType() => Console.WriteLine($"It is {transportType}");
    }
}