using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Generics.Service
{
    public class SendRequest<T> //la T nos indica con que clase de objeto va a trabajar SendReuqst
    {
        private HttpClient _client = new HttpClient();
        public async Task<T> Send(T model)
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            string data = JsonSerializer.Serialize<T>(model);

            HttpContent content = new StringContent(data,System.Text.Encoding.UTF8,"application/json");
            var httpResponse = await _client.PostAsync(url,content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<T>(result);
                return postResult;
            }
            return default(T);
        }
    }
}
