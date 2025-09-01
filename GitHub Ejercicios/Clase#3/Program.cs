internal class Program
{
    private static void Main(string[] args)
    {
         ///////Ejemplo 1//////////
        int i = 1, sumaPar = 0, sumaImpar = 0;
        for (i = 1; i <= 100;)
        {

            if (i % 2 == 0)
            {
                sumaPar = sumaPar + i;
            }
            else
            {
                sumaImpar = sumaImpar + i;
            }
            i++;


        }
        Console.WriteLine("La suma de los numeros pares es: " + sumaPar);
        Console.WriteLine("La suma de los numeros impares es: " + sumaImpar);
        ///////Ejemplo 2//////////
         int i = 1, sumaPar = 0, sumaImpar = 0;
        for (i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);
            if (i % 2 == 0)
            {
                sumaPar = sumaPar + i;
            }
            else
            {
                sumaImpar = sumaImpar + i;
            }

        }
        Console.WriteLine("Pares: " + sumaPar);
        Console.WriteLine("Impares: " + sumaImpar);

        ////////////////////////////////////////////////////////////////////////
        int num = 0;
        int numMayor = int.MinValue, numMenor = int.MaxValue;
        while (num != -99)
        {
            Console.WriteLine("Ingrese un numero (ingrese -99 para salir)");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == -99)
            {
                break;
            }

            if (num > numMayor)
            {
                numMayor = num;
            }
            else if (num < numMenor)
            {
                numMenor = num;
            }

        }
            Console.WriteLine("Numero mayor: " + numMayor);
            Console.WriteLine("Numero mayor: " + numMenor);

    }
}
