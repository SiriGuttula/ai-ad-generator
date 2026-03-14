using System.Text;
using System.Net.Http.Headers;

namespace AiAdGeneratorAPI.Services
{
    public class OpenAIService
    {
        private readonly HttpClient _httpClient;

    private string key = "";
    public OpenAIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GenerateAd(string prompt)
        {
            var requestBody = new
            {
                model = "gpt-4.1-mini",
                input = prompt
            };

            var request = new HttpRequestMessage(
                HttpMethod.Post,
                "https://api.openai.com/v1/responses"
            );

            request.Headers.Authorization =
                new AuthenticationHeaderValue("Bearer", key);

            request.Content = new StringContent(
                System.Text.Json.JsonSerializer.Serialize(requestBody),
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpClient.SendAsync(request);

            var result = await response.Content.ReadAsStringAsync();

            return result;
        }
    }
}
