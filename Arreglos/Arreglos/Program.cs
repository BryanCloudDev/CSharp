using Arreglos.Models;
using System;
using System.Numerics;

namespace Arreglos
{
    class Program
    {
        static void Main()
        {   //creando un array
            int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,0}; // adentro de las llaves indicamos cuantos espacios en memoria se usaran

            int numero = numeros[0];

            //for(int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("Iteracion: " + i + " - " + numeros[i]);
            //}

            //foreach (int numeroC in numeros)
            //{
            //    Console.WriteLine(numeroC);
            //}

            //podemos iterar arreglos y listas con foreach

            // la diferencia entre arreglos y listas esque nosotros al array le damos un tamanio inicial fijo
            // un array es mas rapido que una lista

            //podemos inicializar un array con datos iniciales dentro de corchetes

            List<int> listaDeEnteros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            listaDeEnteros.Add(9);
            listaDeEnteros.Add(10);
            listaDeEnteros.Remove(1);

            //foreach(int n in listaDeEnteros)
            //{
            //    Console.WriteLine(n.ToString());
            //}

            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza("Pilsener",2000) };
            cervezas.Add(new Cerveza("Regia", 2000));

            Cerveza Heineken = new Cerveza("Heineken", 2000);

            cervezas.Add(Heineken);


            //foreach (var c in cervezas)
            //{
            //    Console.WriteLine(c.nombre);
            //}

            List<int> integers = new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 };

            miniMaxSum(integers);
        }
        public static void miniMaxSum(List<int> arr)
        {
            long maxNumber = (long)arr.Max();
            long minNumber = (long)arr.Min();

            long maxSum = arr.Sum(x => (long)x) - minNumber;
            long minSum = arr.Sum(x => (long)x) - maxNumber;

            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}