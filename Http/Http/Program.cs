using System.Threading.Tasks;
using System.Net.Http;
using Http.Models;
using System.Text.Json;

class Program{
    //debemos de crear los metodos estaticos
    static async Task Main()
    {
        //GET
        string url = "https://jsonplaceholder.typicode.com/posts";
        HttpClient client = new HttpClient();

        var res = await client.GetAsync(url);

        if (res.IsSuccessStatusCode)// aca nos devuelve un codigo 200
        {
            var contenido  = await res.Content.ReadAsStringAsync();

            List<Post> posts = JsonSerializer.Deserialize<List<Post>>(contenido);

            foreach (var post in posts)
            {
                Console.WriteLine($"El titulo es: {post.title}");
            }


        }

        //Console.WriteLine("Mordi un nugget");

        // tenemos que esperar con el await que res este resuelto y asi no puede avanzar

        //Console.WriteLine("Beber Cerveza");
    }
}