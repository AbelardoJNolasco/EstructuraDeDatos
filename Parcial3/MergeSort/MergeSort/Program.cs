internal class Program
{
    private static void Main(string[] args)
    {
        int[] ArregloEnteros = { 4, 2, 7, 8, 9, 3, 1, 6, 5 };

        for (int x = 0; x < ArregloEnteros.Length; x++)
        {
            if (x == ArregloEnteros.Length - 1)
                Console.Write(ArregloEnteros[x]);
            else
                Console.Write(ArregloEnteros[x] + ",");
        }

        Console.WriteLine("\n\nMétodo de Ordenamiento: MergeSort\n");

        ArregloEnteros = MergeSort(ArregloEnteros);

        for (int x = 0; x < ArregloEnteros.Length; x++)
        {
            if (x == ArregloEnteros.Length - 1)
                Console.Write(ArregloEnteros[x]);
            else
                Console.Write(ArregloEnteros[x] + ",");
        }

        Console.ReadKey();
    }

    static int[] MergeSort(int[] Arreglo)
    {
        if (Arreglo.Length <= 1)
            return Arreglo;

        int Mitad = Arreglo.Length / 2;

        int[] Izquierda = new int[Mitad];
        int[] Derecha = new int[Arreglo.Length-Mitad];

        for (int i = 0; i < Mitad; i++)
            Izquierda[i] = Arreglo[i];

        for (int i = Mitad;i<Arreglo.Length; i++)
            Derecha[i-Mitad]= Arreglo[i];

        Izquierda = MergeSort(Izquierda);
        Derecha= MergeSort(Derecha);

        int[] Resultado = new int[Arreglo.Length];
        int indiceIzq = 0, indiceDer = 0, indiceRes = 0;

        while (indiceIzq < Izquierda.Length && indiceDer < Derecha.Length)
        {
            if (Izquierda[indiceIzq] <= Derecha[indiceDer])
                Resultado[indiceRes++] = Izquierda[indiceIzq++];
            else
                Resultado[indiceRes++] = Derecha[indiceDer++];
        }

        while (indiceIzq < Izquierda.Length)
            Resultado[indiceRes++] = Izquierda[indiceIzq++];

        while (indiceDer < Derecha.Length)
            Resultado[indiceRes++] = Derecha[indiceDer++];

        return Resultado;
    }
}