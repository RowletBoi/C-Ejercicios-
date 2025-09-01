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
        




    }
}