using Cashtrans.DataAccessLayer.Interface;
using Cashtrans.DTOS;
using System.Text;
using System.Text.Json;

namespace Cashtrans.Services
{
    public class ReadLockDataService : IReadLockDataService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public ReadLockDataService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<ReadLockDataResponse> ReadLockDataBySerialAsync(ReadLockDataRequest request)
        {
            var apiUrl = _configuration["AS274Api:ReadLockDataBySerialUrl"]; // e.g., https://cenlockapi.com/api/ReadLockBySerial
            var jsonContent = JsonSerializer.Serialize(request);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(apiUrl, httpContent);

            if (!response.IsSuccessStatusCode)
            {
                return new ReadLockDataResponse
                {
                    IsSuccess = false,
                    Message = $"Error from API: {response.StatusCode}"
                };
            }

            var content = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ReadLockDataResponse>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return result ?? new ReadLockDataResponse
            {
                IsSuccess = false,
                Message = "Failed to parse response."
            };
        }
    }
}