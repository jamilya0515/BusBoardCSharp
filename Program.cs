using RestSharp;

namespace BusBoard {
    class Program {
        public static async Task Main() {
            Console.Write("Please enter your stop code: ");
            string stopPointId = Console.ReadLine() ?? string.Empty;
           
            List<BusArrivals> arrivals = await TflClient.GetBusArrivalsAsync(stopPointId);

            Console.WriteLine("Next 5 Buses:");
            foreach (var arrival in arrivals.Take(5))
            {
                Console.WriteLine($"Route number: {arrival.lineId}, Destination: {arrival.destinationName}, ExpectedArrival: {arrival.expectedArrival}");
            }
        }
    }
}



   