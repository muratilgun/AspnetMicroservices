using Shopping.Aggregator.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace Shopping.Aggregator.Services
{
    public class BasketService : IBasketService
    {
        private readonly HttpClient _client;

        public BasketService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<BasketModel> GetBasket(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
