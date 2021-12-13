using System;

namespace Part15Task1P2
{
    public class Metro : Transport
    {   
        static Metro() => TransportType = "Metro";
        
        public Metro(string destination, int number, string dateOfDepature, int numberOfSeats)
        {
            Destination = destination;
            Number = number;
            DateOfDepature = dateOfDepature;
            NumberOfSeats = numberOfSeats;
        }
        
        public override string ToString()
        {
            return $"Metro info: destination point - {Destination}; number - {Number}; " +
                   $"date of departure - {DateOfDepature}; number of seats - {NumberOfSeats}";
        }
        
        public override void PrintTransportType() => Console.WriteLine($"It is {TransportType}");
    }
}