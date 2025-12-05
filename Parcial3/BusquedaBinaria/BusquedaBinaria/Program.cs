internal class Program
{
    private static void Main(string[] args)
    {
        int intNumero;
        int[] ArregloEnteros = { 1,2,3,4,5,6,7,8,9 };

        Console.WriteLine("Se tiene el siguiente arreglo: ");
        Console.Write("[");
        for (int i = 0; i < ArregloEnteros.Length; i++)
        {
            if (i == ArregloEnteros.Length - 1)
                Console.Write($"{ArregloEnteros[i]}]");
            else
                Console.Write($"{ArregloEnteros[i]}, ");
        }

        Console.WriteLine("\n\nMétodo de búsqueda: Binaria");
        Console.Write("Inserte el número que desea buscar: ");
        intNumero = int.Parse(Console.ReadLine());

        Console.WriteLine("Posicion: " + BusquedaBinaria(ArregloEnteros, intNumero));

        Console.ReadKey();
    }

    static int BusquedaBinaria(int[] Arreglo,int intNumero)
    {
        int Inicio = 0, Fin = Arreglo.Length - 1,Posicion=-1;
        bool Bandera = false;

        while (Inicio <= Fin&&!Bandera)
        {
            int Medio = (Inicio + Fin) / 2;

            if (Arreglo[Medio] == intNumero)
            {
                Posicion = Medio;
                Bandera = true;
            }
            else if (intNumero < Arreglo[Medio])
                Fin = Medio - 1;
            else
                Inicio = Medio + 1;
        }

        return Posicion;
    }
}