using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Code.Parsers;
using UnityEngine;

namespace Code.RestClient
{
    public class RestRestClient
    {
        private readonly HttpClient _client;
        private readonly IParser _parser;

        public RestRestClient(IParser parser)
        {
            _parser = parser;
            _client = new HttpClient();
        }

        public async Task<TResponse> Post<TRequest, TResponse>(string url, TRequest request)
            where TRequest : Request where TResponse : Response
        {
            const string jsonMediaType = "application/json";
            var data = new StringContent(_parser.Serialize(request), Encoding.UTF8, jsonMediaType);
            var response = await _client.PostAsync(url, data);
            var contents = await response.Content.ReadAsStringAsync();

            return _parser.Deserialize<TResponse>(contents);
        }

        public async Task<TResponse> Get<TRequest, TResponse>(string url, TRequest request)
            where TRequest : Request where TResponse : Response
        {
            var uri = new Uri(url);
            var finalUri = uri.ExtendQuery(request);

            var response = await _client.GetAsync(finalUri);
            var contents = await response.Content.ReadAsStringAsync();

            return _parser.Deserialize<TResponse>(contents);
        }
    }
}