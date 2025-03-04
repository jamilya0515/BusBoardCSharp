
namespace BusBoard {
    class BusArrivals {
        public required string lineId { get; set; }
        public required string destinationName { get; set; }
        public required DateTime expectedArrival { get; set; }
    }
}
