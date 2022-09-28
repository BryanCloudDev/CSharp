using sqlConnection.Models;
//para serializar JSON se usan estas clases
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    public static void Main()
    {
        //serializar objetos
        //Cerveza cerveza = new Cerveza("Pilsener",2345);
        //cerveza.Brand = "Millenial";
        //cerveza.Alcohol = 234;
        //string miJSON = JsonSerializer.Serialize(cerveza);

        //guardar archivo
        //File.WriteAllText("objeto.txt",miJSON);

        //Console.WriteLine(miJSON);

        //deserializar un Json

        string objeto = File.ReadAllText("objeto.txt");
        Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(objeto);

        //con Deserilaize<Cerveza> indicamos a que tipo de instancia se desea convertir

        Console.WriteLine(cerveza.Name);
    }
}
