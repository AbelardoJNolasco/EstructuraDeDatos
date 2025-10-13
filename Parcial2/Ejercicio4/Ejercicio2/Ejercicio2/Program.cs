using Ejercicio2;

internal class Program
{
    private static void Main(string[] args)
    {
        string strCadena;
        string strCadenaInvertida = "";
        Pila unaPila;

        Console.WriteLine("Ingresa la Cadena: ");
        strCadena = Console.ReadLine();

        unaPila = new Pila(strCadena.Length);

        for (int x = 0; x < strCadena.Length; x++)
        {
            char c = strCadena[x];

            unaPila.Push(c);
        }

        for (int x = 0; x < strCadena.Length; x++)
        {
            char c = unaPila.Pop();
            strCadenaInvertida = strCadenaInvertida + c;
        }

        Console.WriteLine(strCadenaInvertida);

        if (strCadena.ToLower() == strCadenaInvertida.ToLower())
        {
            Console.WriteLine("\nSon iguales");
        }
        else
        {
            Console.WriteLine("\nNo son iguales");
        }
    }
}