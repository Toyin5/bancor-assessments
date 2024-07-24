using RestSharp;

namespace ConsumeRestAPI
{
    public class ApiClient
    {
        private readonly RestClient _client;

        public ApiClient()
        {
            _client = new RestClient();
        }

        public async Task<object?> Get(string apiUrl)
        {
            RestRequest restRequest = new(apiUrl);
            var response = await _client.GetAsync(restRequest);
            return response.Content;
        }
    }
}
