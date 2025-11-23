using static System.Runtime.InteropServices.JavaScript.JSType;

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

        Console.WriteLine("\n\nMétodo de Ordenamiento: QuickSort\n");

        ArregloEnteros=QuickSort(ArregloEnteros);

        for (int x = 0; x < ArregloEnteros.Length; x++)
        {
            if (x == ArregloEnteros.Length - 1)
                Console.Write(ArregloEnteros[x]);
            else
                Console.Write(ArregloEnteros[x] + ",");
        }

        Console.ReadKey();
    }

    static int[] QuickSort(int[] Arreglo)
    {
        if (Arreglo.Length<=1)
            return Arreglo;

        int pivote=Arreglo[0];

        int contIzq = 0, contDer = 0;

        for (int i = 1; i < Arreglo.Length; i++)
        {
            if (Arreglo[i] < pivote)
                contIzq++;
            else
                contDer++;
        }

        int[] Izquierda=new int[contIzq];
        int[] Derecha=new int[contDer];

        int indiceIzq = 0, indiceDer = 0;

        for(int i = 1; i < Arreglo.Length; i++)
        {
            if (Arreglo[i] < pivote)
            {
                Izquierda[indiceIzq]=Arreglo[i];
                indiceIzq++;
            }
            else
            {
                Derecha[indiceDer]=Arreglo[i];
                indiceDer++;
            }
        }

        Izquierda = QuickSort(Izquierda);
        Derecha = QuickSort(Derecha);

        int[] Resultado=new int[Izquierda.Length+1+Derecha.Length];

        int indiceRes = 0;

        for (int i = 0; i < Izquierda.Length; i++)
            Resultado[indiceRes++]= Izquierda[i];

        Resultado[indiceRes++] = pivote;

        for (int i = 0; i < Derecha.Length; i++)
            Resultado[indiceRes++]=Derecha[i];

        return Resultado;
    }
}