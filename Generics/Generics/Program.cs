using Generics.Models;
using Generics.Service;

class Program
{
    static async Task Main()
    {
        var cerveza = new Cerveza("Ticus", 500);
        cerveza.Brand = "Colima";
        cerveza.Alcohol = 5;

        SendRequest<Cerveza> service = new SendRequest<Cerveza>();
        Cerveza CervezaRespuesta = await service.Send(cerveza);

        Console.WriteLine(CervezaRespuesta.Name);
    }
}