using Ejercicio1;

internal class Program
{
    private static void Main(string[] args)
    {
        string strCadena;
        Pila unaPila;

        Console.WriteLine("Inserte la operación: ");
        strCadena = Console.ReadLine();

        unaPila = new Pila(strCadena.Length);

        for (int x = 0; x < strCadena.Length; x++)
        {
            char c = strCadena[x];

            if (c == '(' || c == '{' || c == '[')
            {
                unaPila.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (unaPila.EstaVacia)
                {
                    Console.WriteLine("\nError: la operación está mal escrita");
                    Console.ReadKey();
                    return;
                }

                char tope = unaPila.Pop();

                if ((c == ')' && tope != '(') || (c == '}' && tope != '{') || (c == ']' && tope != '['))
                {
                    Console.WriteLine("\nError: la operación está mal escrita");
                    Console.ReadKey();
                    return;
                }
            }
        }

        if (unaPila.EstaVacia)
            Console.WriteLine("\nEstá bien escrita");
        else
            Console.WriteLine("\nError: la operación está mal escrita");

        Console.ReadKey();
    }
}