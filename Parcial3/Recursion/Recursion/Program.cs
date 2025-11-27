internal class Program
{
    private static void Main(string[] args)
    {
        int intNumero;

        Console.WriteLine("Dame un número: ");
        intNumero = int.Parse(Console.ReadLine());

        Console.WriteLine("\nResultado de la factorial: \n" + FactorialRecursivo(intNumero));

    }

    static int FactorialRecursivo(int intNumero)
    {
        if (intNumero == 0)
            return (1);
        else
            return (intNumero * FactorialRecursivo(intNumero - 1));
    }
}