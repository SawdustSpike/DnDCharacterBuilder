using DnDApp.ExternalService.DnDApi.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DnDApp.ExternalService.DnDApi.Services
{
    abstract public class BasDnDApiService
    {
        protected const string DnDApiBaseUrl = "https://www.dnd5eapi.co/api/";

        protected static HttpClient NewClient() => HttpClientFactory.Create();

        protected static string SearchParameter(string input) => $"?search={input}";

        protected static async Task<TOutput?> GetContentOrDefaultAsync<TOutput>(string url)
        {
            using var client = NewClient();

            return await DeserializeResponseAsync<TOutput?>(await client.GetAsync(url));
        }

        protected async Task<IEnumerable<TOutput>> GetContentFromAllPagesAsync<TOutput>(string url, List<TOutput>? results = null)
        {
            results ??= new();

            var response = await GetContentOrDefaultAsync<PagedResponse<TOutput>>(url);

            if (response?.results?.Length > 0)
            {
                foreach (var item in response.results)
                {
                    results.Add(item);
                }
            }

            if (!string.IsNullOrWhiteSpace(response?.next))
            {
                await GetContentFromAllPagesAsync(response.next, results);
            }

            return results;
        }

        private static async Task<TOutput?> DeserializeResponseAsync<TOutput>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<TOutput>(content);
            }

            return default;
        }
    }
}

    }
}
