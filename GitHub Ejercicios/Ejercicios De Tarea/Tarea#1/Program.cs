internal class Program
{
    private static void Main(string[] args)
    {
        ///////////////////////EJERCICIO 1//////////////////////////////////////////////
        int Vara = 5;
        double Longitud;
        double Manzana = 1428.8;
        double AreaZana;

        Console.WriteLine("Ingresa la Longitud que desea calcular: ");
        Longitud = Convert.ToDouble(Console.ReadLine());
        double Area = (Vara * Longitud);
        AreaZana = Area / Manzana;
        Console.WriteLine("Esta es la area en varas:  " + Area);
        Console.WriteLine("Esta es la area en Manzanas " + AreaZana);

        ///////////////////////EJERCICIO 2///////////////////////////////////////////////

        double KMH;
        int Kilometros = 40;
        Console.WriteLine("Ingrese su velocidad aproximada: ");
        KMH = Convert.ToDouble(Console.ReadLine());
        double Horas = Kilometros / KMH;

        Console.WriteLine("VAS A LLEGAR EN " + Horas + " HORAS");

        ///////////////////////EJERCICIO 3////////////////////////////////////
        double Velocidad, Tiempo, Distancia;
        Console.WriteLine("Ingrese cuanto es tu velocidad promedio (en KMH): ");
        Velocidad = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("En Cuanto tiempo lo recorriste?");
        Tiempo = Convert.ToDouble(Console.ReadLine());

        Distancia = Velocidad * Tiempo;
        Console.WriteLine("Tu distancia total fue de: " + Distancia + "KM");

        ///////////////////////Ejercicio 4/////////////////////////////////////////////
        double Altura, Ancho, Longitud2, Volumen;
        Console.WriteLine("Ingrese cuanto mide el tanque de alto en metros: ");
        Altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese cuanto mide el tanque de ancho: ");
        Ancho = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Finalmente, Ingrese la longitud de el tanque");
        Longitud2 = Convert.ToDouble(Console.ReadLine());

        Volumen = Altura * Ancho * Longitud2;

        Console.WriteLine("El volumen del tanque es: " + Volumen + "M^2");

        ///////////////////////Ejercicio 5/////////////////////////////////////////////
        double MyMilkPerAvarage, MyMilkTotalCow;
        Console.WriteLine("Igresa la cantidad promedio de vacas ordeñadas");
        MyMilkPerAvarage = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Igresa la cantidad total de vacas ordeñadas");
        MyMilkTotalCow = Convert.ToDouble(Console.ReadLine());

        double LitrosTotales = MyMilkPerAvarage * MyMilkTotalCow;
        double Baldes = LitrosTotales / 20;

        Console.WriteLine("Litros Totales Porducidos: " + LitrosTotales);
        Console.WriteLine("Cantidad de baldes total: " + Baldes);
    }
}
