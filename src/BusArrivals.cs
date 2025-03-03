
namespace BusBoard {
    class BusArrivals {
        public required string LineId { get; set; }
        public required string Destination { get; set; }
        public required DateTime ExpectedArrival { get; set; }
    }
}