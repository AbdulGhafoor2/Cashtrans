using Cashtrans.DataAccessLayer.Interface;
using Cashtrans.DTOS;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text;

namespace Cashtrans.Services
{
    public class DispatchLockService : IDispatchLockService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public DispatchLockService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<DispatchLockResponse> DispatchLockAsync(DispatchLockRequest request)
        {
            var url = _configuration["CenTranSettings:DispatchLockUrl"];

            var json = JsonSerializer.Serialize(request, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            });

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);

            if (!response.IsSuccessStatusCode)
                throw new ApplicationException($"Error calling CenTran: {response.ReasonPhrase}");

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<DispatchLockResponse>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}