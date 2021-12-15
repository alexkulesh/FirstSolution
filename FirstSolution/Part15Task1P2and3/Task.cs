using System;
using System.Globalization;

namespace Part15Task1P2
{
    public class Task
    {
        private static void Main(string[] args)
        {
            Transport[] transports =
            {
                new Tram("Center of city", 23, new DateTime(2021, 12, 16, 11, 40, 0), 20),
                new Trolleybus("Deviatouka", 10, new DateTime(2021, 12, 16, 8, 50, 0), 30),
                new Metro("Ploscha peramogi", 5, new DateTime(2021, 12, 17, 12, 0, 0), 500),
                new ElectroBus("Malinauka", 14, new DateTime(2021, 12, 16, 14, 30, 0), 35)
            };

            for (int i = 0; i < transports.Length; i++)
            {
                Transport temp;

                for (int j = i + 1; j < transports.Length; j++)
                {
                    if (transports[i].NumberOfSeats > transports[j].NumberOfSeats)
                    {
                        temp = transports[i];
                        transports[i] = transports[j];
                        transports[j] = temp;
                    }
                }
            }

            for (int i = 0; i < transports.Length; i++)
            {
                Console.WriteLine(transports[i]);
            }

            Console.WriteLine("Type in your desirable time of departure");
            string format = "yyyy.MM.dd HH:mm";
            DateTime departureTime =
                DateTime.ParseExact(Console.ReadLine() ?? string.Empty, format, CultureInfo.InvariantCulture);
            Console.WriteLine("List of transport that fits your desirable date of departure");

            for (int i = 0; i < transports.Length; i++)
            {
                if (departureTime == transports[i].DepartureTime)
                {
                    Console.WriteLine(transports[i]);
                }
            }

            for (int i = 0; i < transports.Length; i++)
            {
                TransportService.printTransportType(transports[i]);
            }
        }
    }
}