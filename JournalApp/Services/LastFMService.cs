using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using JournalApp.Models.LastFM;

namespace JournalApp.Services
{
    public class LastFMService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "97800be6c93a7101bd93f43ec7c566d6";
        private readonly string _username = "Joeliono";

        public LastFMService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Track>> GetRecentTracksAsync()
        {
            string url = $"https://ws.audioscrobbler.com/2.0/?method=user.getrecenttracks&user={_username}&api_key={_apiKey}&format=json";
            var response = await _httpClient.GetFromJsonAsync<LastFmResponse>(url);
            return response?.recenttracks?.track ?? new List<Track>();
        }

    }
}
