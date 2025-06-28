using Cashtrans.DataAccessLayer.Interface;
using Cashtrans.DTOS;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Cashtrans.Services
{
    public class CloseLockService : ICloseLockService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly ILogger<CloseLockService> _logger;

        public CloseLockService(HttpClient httpClient, ILogger<CloseLockService> logger, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<CloseLockResponse> CloseLockBySerialAsync(CloseLockRequest requestDto)
        {
            var url = _configuration["CenTranSettings:CloseLockUrl"]; // appsettings.json

            var requestJson = JsonSerializer.Serialize(requestDto, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            });

            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                _logger.LogError($"CloseLock failed. StatusCode: {response.StatusCode}, Response: {error}");
                throw new ApplicationException("Failed to close lock.");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<CloseLockResponse>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

     
    }
}

