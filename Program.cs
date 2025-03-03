
namespace BusBoard {
    class Program {
        public static async Task Main() {
            Console.Write("Enter stop code: ");
            string stopPointId = Console.ReadLine() ?? string.Empty;
           
            List<BusArrivals> arrivals = await TflClient.GetBusArrivalsAsync(stopPointId);

            Console.WriteLine("Next 5 Buses:");
            foreach (var arrival in arrivals.Take(5))
            {
                Console.WriteLine($"Route: {arrival.LineId}, Destination: {arrival.Destination}, ExpectedArrival: {arrival.ExpectedArrival}");
            }
        }
    }
}
