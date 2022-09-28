//una iterfaz es un contrato para cuando queremos implementar un contrato con una de las clases 
// debemos de cumplir las normas que nos da la interfaz

using interfaces.Models;

//Cerveza Heineken = new Cerveza("Heineken",2000);

//Vino Tinto = new Vino("Tintino", 3400);
//Tinto.MaximoRecomendado();

//Console.WriteLine(Heineken.Name.ToString());

class Program
{
    static void Main()
    {
        Vino bebidaAlholica = new Vino("Tinto",3400);
        Cerveza pilsener = new Cerveza("Pilsener", 3400);
        MostrarRecomendacion(bebidaAlholica);
        MostrarRecomendacion(pilsener);
        List<string> hola = new List<string>();
    }

    static void MostrarRecomendacion(IBebidaAlcoholica bebida)
    {
        bebida.MaximoRecomendado();
    }
}