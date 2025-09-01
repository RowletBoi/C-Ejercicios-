internal class Program
{
    private static void Main(string[] args)
    {
        ///////////////Ejercicio 2//////////////
        Console.WriteLine("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            Console.WriteLine("El numero es positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El numero es negativo");
        }
        else
        {
            Console.WriteLine("El numero es cero");
        }

        ///////////////Ejercicio 2//////////////
        Console.WriteLine("Ingrese un numero del 1 al 7: ");
        int diaNumero = int.Parse(Console.ReadLine());
        string diaSemana;

        switch (diaNumero)
        {
            case 1:
                diaSemana = "Lunes";
                break;
            case 2:
                diaSemana = "Martes";
                break;
            case 3:
                diaSemana = "Miercoles";
                break;
            case 4:
                diaSemana = "Jueves";
                break;
            case 5:
                diaSemana = "Viernes";
                break;
            case 6:
                diaSemana = "Sabado";
                break;
            case 7:
                diaSemana = "Domingo";
                break;
            default:
                diaSemana = "Numero invalido";
                break;
        }
        Console.WriteLine("El dia de la semana es: " + diaSemana);

        ///////////////Ejercicio 3//////////////
        Console.WriteLine("Ingrese una calificacion del 1 al 100: ");
        int Calificacion = Convert.ToInt32(Console.ReadLine());

        if (Calificacion >= 70)
        {
            Console.WriteLine("Aprobado");
        }
        else if (Calificacion >= 60)
        {
            Console.WriteLine("El estudiante está en recuperación.");
            
        }
        else
        {
            Console.WriteLine("El estudiante reprobó.");
        }
    }
}