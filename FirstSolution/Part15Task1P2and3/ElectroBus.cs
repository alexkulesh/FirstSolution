using System;

namespace Part15Task1P2
{
    public class ElectroBus : Transport
    {
        private const string transportType = "Electrobus";

        static ElectroBus() => TransportType = transportType;

        public ElectroBus(string destination, int number, DateTime departureTime, int numberOfSeats)
        {
            Destination = destination;
            Number = number;
            DepartureTime = departureTime;
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return $"Electrobus info: destination point - {Destination}; number - {Number}; " +
                   $"date of departure - {DepartureTime}; number of seats - {NumberOfSeats}";
        }

        public override void PrintTransportType() => Console.WriteLine($"It is {transportType}");
    }
}