using RestSharp;

namespace BusBoard {
    class TflClient {
        private static readonly RestClient stopPointClient = new RestClient("https://api.tfl.gov.uk/StopPoint");
        public static async Task<List<BusArrivals>> GetBusArrivalsAsync(string stopPointId) {
            
            var request = new RestRequest($"{stopPointId}/Arrivals");
            var response = await stopPointClient.GetAsync<List<BusArrivals>>(request);
           
            if (response == null) {
                throw new Exception("Tfl API error");
            }
            return response;

        }
    }
}
        

