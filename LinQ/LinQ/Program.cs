class Program
{
    static void Main()
    {
        //LinQ sirve para hacer consultas a colecciones de datos
        List<int> numeros = new List<int> { 66, 56, 34, 6454, 1, 2, 3, 4, 5, 6, 7 };

        //var numer7 = numeros.Where(x => x == 7).FirstOrDefault();// el parametro de where se llama predicado

        //var numerosOrdenados = numeros.OrderBy(x => x); // ordenar de menor a mayor

        int numeros1 = numeros.Sum(x => x); // sumar

        double numeros2 = numeros.Average(x => x); //promedio

        //foreach (int n in numerosOrdenados)
        //{
        //    Console.WriteLine(n);
        //}

        Console.WriteLine(numeros2);
    }
}