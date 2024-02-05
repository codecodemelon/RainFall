using RainFall.Models;
using System.Runtime.Serialization.Json;

namespace RainFall.Services
{
    public class FloodMonitoringService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public FloodMonitoringService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<FloodMonitoringData> GetFloodMonitoringDataAsync(string stationId)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}{stationId}/measures");
            response.EnsureSuccessStatusCode();

            var serializer = new DataContractJsonSerializer(typeof(FloodMonitoringData));
            await using var responseStream = await response.Content.ReadAsStreamAsync();
            var floodData = serializer.ReadObject(responseStream) as FloodMonitoringData;

            return floodData;
        }
    }
}
