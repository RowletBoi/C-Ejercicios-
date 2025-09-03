using System.Runtime.Serialization.Formatters;

internal class Program
{
    private static void Main(string[] args)
    {
        ////////////////////////Ejemplo 1//////////////////
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
        //El error era que el valor nunca se sumaba,
        //asi que era infinito el ciclo
        /////////////////////////Ejemplo 2//////////////////
        int edad = 20;
        if (edad > 18 && edad < 65)
        {
            Console.WriteLine("Edad valida para trabajar.");

        }
        //El error era que el operador logico era || (o)
        //y debia ser && (y)
        /////////////////////////Ejemplo 3//////////////////
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine(j);
        }
        //El error era que no tenia punto y coma antes del j<10
        /////////////////////////Ejemplo 4//////////////////
        int numero = 10;
        bool esMayor;
        esMayor = (numero > 5) ? true : false;
        Console.WriteLine("¿Es mayor que 5? " + esMayor);
        //El error era que faltaba el operador true : false
        /////////////////////////Ejemplo 5//////////////////
        int resultado = 5;
        resultado = resultado + 10;
        Console.WriteLine(resultado);
        //El error era que faltaba darle un valor a resultado  
        //////////////////////////Ejemplo 6//////////////////
        int edad2 = 17;
        if (edad2 >= 18)
        {
            Console.WriteLine("Es mayor de edad.");
            Console.WriteLine("Puede votar.");
        }
        else
        {
            Console.WriteLine("Es menor de edad.");
        }
        //El error era que faltaba el los {} en el else y if 

        
    }
}