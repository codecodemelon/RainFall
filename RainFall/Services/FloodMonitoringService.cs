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

        public async Task<BaseModel> GetFloodMonitoringDataAsync(string stationId)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}{stationId}/measures");
            response.EnsureSuccessStatusCode();

            var serializer = new DataContractJsonSerializer(typeof(BaseModel));
            await using var responseStream = await response.Content.ReadAsStreamAsync();
            var floodData = serializer.ReadObject(responseStream) as BaseModel;

            return floodData;
        }

        public async Task<BaseModel> GetReadingFromMeasureAsync(string stationId, int limit)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}{stationId}/readings?_sorted&_limit={limit}");
            response.EnsureSuccessStatusCode();

            var serializer = new DataContractJsonSerializer(typeof(BaseModel));
            await using var responseStream = await response.Content.ReadAsStreamAsync();
            var floodData = serializer.ReadObject(responseStream) as BaseModel;

            return floodData;
        }


    }
}
