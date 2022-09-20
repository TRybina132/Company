using Application.Entities;
using System.Text.Json;

namespace Application.Services
{
    //  ᓚᘏᗢ Lets consider mockAPI as microservice
    public class ProductService
    {
        private const string url = "https://62d158addccad0cf1765a855.mockapi.io/product";

        public async Task<List<Product>?> GetProducts()
        {
            using var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(url));
            var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();

            await using Stream data = await response.Content.ReadAsStreamAsync();

            var products = await JsonSerializer.DeserializeAsync<List<Product>>(data);
            return products;
        }
    }
}
