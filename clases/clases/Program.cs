using clases.Models;

namespace clases
{
    class Program
    {
        static void Main()
        {
            //Bebida bebida = new Bebida("Pinia Cola",1000);
            //bebida.Beberse(500);
            //Console.WriteLine(bebida.cantidad.ToString());

            Cerveza cerveza = new Cerveza("Regia",2000);
            cerveza.Beberse(200);
        }
    }
}