internal class Program
{
    private static void Main(string[] args)
    {
        int[] datos = {6,2,5,1,4,7,3};

        for (int x = 0; x < datos.Length; x++)
        {
            if (x == datos.Length-1)
                Console.Write(datos[x]);
            else
                Console.Write(datos[x] + ",");
        }

        Console.WriteLine("\n\nMétodo de Ordenamiento: Burbuja\n");

        Burbuja(ref datos);

        for (int x = 0; x < datos.Length; x++)
        {
            if (x == datos.Length - 1)
                Console.Write(datos[x]);
            else
                Console.Write(datos[x] + ",");
        }

        Console.ReadKey();
    }

    static void Burbuja(ref int[] ArregloEnteros)
    {
        int i, j, temp;
        bool bandera = false;

        for (i=0;i<ArregloEnteros.Length-1&&!bandera;i++)
        {
            bandera = true;
            for (j =0;j<ArregloEnteros.Length-i-1;j++)
            {
                if (ArregloEnteros[j] > ArregloEnteros[j+1])
                {
                    temp = ArregloEnteros[j];
                    ArregloEnteros[j] = ArregloEnteros[j + 1];
                    ArregloEnteros [j+1] = temp;
                    bandera = false;
                }
            }
        }
    }
}