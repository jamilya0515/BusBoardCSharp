
using System;

namespace BusBoard {
    class Program {
        public static async Task Main() {
            Console.Write("Please enter your stop code: ");
            string stopPointId = Console.ReadLine();
            try 
            {
                if (string.IsNullOrWhiteSpace(stopPointId)) 
                {
                    throw new ArgumentException("Stop code cannot be null, empty or white space.");
                }
                else
                {
                List<BusArrivals> arrivals = await TflClient.GetBusArrivalsAsync(stopPointId);
                var sortedArrivals = arrivals.OrderBy(a => a.timeToStation).ToList();
                Console.WriteLine("Next 5 Buses:");
                foreach (var arrival in sortedArrivals.Take(5))
                {
                    Console.WriteLine($"Route number: {arrival.lineId}, Destination: {arrival.destinationName}, ExpectedArrival: {arrival.expectedArrival}, Time to station: {arrival.timeToStation / 60} minutes");
                }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid stop code: {ex.Message}");
                Environment.Exit(0); 
            }
        }
    }
}