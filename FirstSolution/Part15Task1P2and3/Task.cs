using System;

namespace Part15Task1P2
{
    public class Task
    {
        private static void Main(string[] args)
        {
            Transport[] transports =  {new Tram("Center of city", 23, "7:50", 20), new Trolleybus("Deviatouka", 10, "8:50", 30), new Metro("Ploscha peramogi", 5, "9:50", 500), new ElectroBus("Malinauka", 14, "10:23", 35)};
            
            for (int i = 0; i < transports.Length; i++)
            {   
                Transport temp;
                
                for (int j = i+1; j < transports.Length; j++)
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
            
            Console.WriteLine("Type in your desirable date of departure");
            string input = Console.ReadLine();
            Console.WriteLine("List of transport that fits your desirable date of departure");
                
            for (int i = 0; i < transports.Length; i++)
            {
                if (input == transports[i].DateOfDepature)
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