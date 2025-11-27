internal class Program
{
    private static void Main(string[] args)
    {
        int[] ArregloEnteros = { 7,2,9,1,4,3,6,5,8};

        for (int x = 0; x < ArregloEnteros.Length; x++)
        {
            if (x == ArregloEnteros.Length - 1)
                Console.Write(ArregloEnteros[x]);
            else
                Console.Write(ArregloEnteros[x] + ",");
        }

        Console.WriteLine("\n\nMétodo de Ordenamiento: InsertionSort\n");

        ArregloEnteros = InsertionSort(ArregloEnteros);

        for (int x = 0; x < ArregloEnteros.Length; x++)
        {
            if (x == ArregloEnteros.Length - 1)
                Console.Write(ArregloEnteros[x]);
            else
                Console.Write(ArregloEnteros[x] + ",");
        }

        Console.ReadKey();
    }

    static int[] InsertionSort(int[] Arreglo)
    {
        for (int i = 1; i < Arreglo.Length; i++)
        {
            int Llave = Arreglo[i];
            int j = i - 1;

            while (j >= 0 && Arreglo[j] > Llave)
            {
                Arreglo[j + 1] = Arreglo[j];
                j--;
            }

            Arreglo[j + 1] = Llave;
        }

        return Arreglo;
    }
}