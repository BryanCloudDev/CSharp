using sqlConnection.Models;

class Program
{
    public static void Main()
    {
        CervezaDB cervezaBD = new CervezaDB();

        //creando nueva cerveza
        //Cerveza cerveza1 = new Cerveza("Suprema", 2300);
        //cerveza1.Brand = "Suprema";
        //cerveza1.Alcohol = 12;
        //cervezaBD.Add(cerveza1);

        //obteniendo las cervezas ya existentes
        //cervezaBD.Edit(cerveza1,5);
        //var cervezas = cervezaBD.Get();

        //imprimiendo todas las cervezas
        //foreach (var cerveza in cervezas)
        //{
        //    Console.WriteLine(cerveza.Name);
        //}

        //cervezaBD.Delete(2);
    }
}
