using HttpPost.Models;
using System.Text;
using System.Text.Json;

class Program
{
    static async Task Main()
    {
        //await Post();
        //await Put(34);
        await Delete(22);
    }

    static async Task Post()
    {
        string url = "https://jsonplaceholder.typicode.com/posts";
        var client = new HttpClient();

        Post post = new Post()
        {
            userId = 50,
            body = "Hola como estas desde el body",
            title = "Hola titulo capullo"
        };

        var data = JsonSerializer.Serialize<Post>(post);
        HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
        var httpResponse = await client.PostAsync(url, content);

        if (httpResponse.IsSuccessStatusCode)
        {
            var result = await httpResponse.Content.ReadAsStringAsync();

            var postResult = JsonSerializer.Deserialize<Post>(result);

            Console.WriteLine(postResult.id + " " + postResult.title + " " + postResult.body);
        }
    }

    static async Task Put(int id)
    {
        string url = $"https://jsonplaceholder.typicode.com/posts/{id}";
        var client = new HttpClient();

        Post post = new Post()
        {
            userId = 50,
            body = "Hola como estas desde el body",
            title = "Hola titulo capullo"
        };

        var data = JsonSerializer.Serialize<Post>(post);
        HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
        var httpResponse = await client.PutAsync(url, content);

        if (httpResponse.IsSuccessStatusCode)
        {
            var result = await httpResponse.Content.ReadAsStringAsync();

            var postResult = JsonSerializer.Deserialize<Post>(result);

            Console.WriteLine(postResult.id + " " + postResult.title + " " + postResult.body);
        }
    }

    static async Task Delete(int id)
    {
        string url = $"https://jsonplaceholder.typicode.com/posts/{id}";
        var client = new HttpClient();
        var httpResponse = await client.DeleteAsync(url);

        if (httpResponse.IsSuccessStatusCode)
        {
            Console.WriteLine($"Borrado con exito el id: {id}!!");
        }
    }
}