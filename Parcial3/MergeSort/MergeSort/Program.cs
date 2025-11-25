internal class Program
{
    private static void Main(string[] args)
    {
        int[] ArregloEnteros = { 3,8,1,4,7,2,6,5,9,10 };

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

        Arreglo[..Mitad].CopyTo(Izquierda, 0);
        Arreglo[Mitad..].CopyTo(Derecha, 0);

        Izquierda = MergeSort(Izquierda);
        Derecha= MergeSort(Derecha);

        return Unir(Izquierda, Derecha);
    }

    static int[] Unir(int[] Izquierda, int[] Derecha)
    {
        int[] Resultado = new int[Izquierda.Length + Derecha.Length];

        int indiceIzq = 0, indiceDer = 0, indiceRes = 0;

        while (indiceIzq < Izquierda.Length && indiceDer < Derecha.Length)
        {
            if (Izquierda[indiceIzq] <= Derecha[indiceDer])
                Resultado[indiceRes++] = Izquierda[indiceIzq++];
            else
                Resultado[indiceRes++] = Derecha[indiceDer++];
        }

        if (indiceIzq < Izquierda.Length)
            Izquierda[indiceIzq..].CopyTo(Resultado, indiceRes);

        if(indiceDer < Derecha.Length)
            Derecha[indiceDer..].CopyTo(Resultado, indiceRes);

        return Resultado;
    }
}