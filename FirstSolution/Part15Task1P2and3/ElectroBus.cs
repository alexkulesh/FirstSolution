using System;

namespace Part15Task1P2
{
    public class ElectroBus : Transport
    {
        static ElectroBus() => TransportType = "Electrobus";
        
        public ElectroBus(string destination, int number, string dateOfDepature, int numberOfSeats)
        {
            Destination = destination;
            Number = number;
            DateOfDepature = dateOfDepature;
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return $"Electrobus info: destination point - {Destination}; number - {Number}; " +
                   $"date of departure - {DateOfDepature}; number of seats - {NumberOfSeats}";
        }

        public override void PrintTransportType() => Console.WriteLine($"It is {TransportType}");
    }
}