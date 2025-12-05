using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int intNumero;
        int[] ArregloEnteros = { 2, 3, 4, 5 };

        Console.WriteLine("Se tiene el siguiente arreglo: ");
        Console.Write("[");
        for (int i=0;i< ArregloEnteros.Length; i++)
        {
            if (i == ArregloEnteros.Length-1)
                Console.Write($"{ArregloEnteros[i]}]");
            else
                Console.Write($"{ArregloEnteros[i]}, ");
        }

        Console.WriteLine("\n\nMétodo de búsqueda: Secuencial");
        Console.Write("Inserte el número que desea buscar: ");
        intNumero=int.Parse(Console.ReadLine());

        Console.WriteLine("Posicion: "+BusquedaSecuencial(ArregloEnteros, intNumero));

        Console.ReadKey();
    }

    static int BusquedaSecuencial(int[] Arreglo,int intNumero)
    {
        int i = 0, Posicion = -1;

        while(i < Arreglo.Length)
        {
            if (Arreglo[i] == intNumero)
            {
                Posicion = i;
                i = Arreglo.Length;
            }

            i++;
        }

        return Posicion;
    }
}