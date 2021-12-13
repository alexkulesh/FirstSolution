using System;

namespace Part15Task1P2
{
    public class Tram : Transport
    {   
        static Tram() => TransportType = "Tram";
        
        public Tram(string destination, int number, string dateOfDepature, int numberOfSeats)
        {
            Destination = destination;
            Number = number;
            DateOfDepature = dateOfDepature;
            NumberOfSeats = numberOfSeats;
        }
        
        public override string ToString()
        {
            return $"Tram info: destination point - {Destination}; number - {Number}; " +
                   $"date of departure - {DateOfDepature}; number of seats - {NumberOfSeats}";
        }
        
        public override void PrintTransportType() => Console.WriteLine($"It is {TransportType}");
    } 
}