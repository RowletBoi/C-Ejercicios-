internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ferreteria");
    double  precio, total = 0;
    int productosVendidos = -1 , prod = 0;
    Console.WriteLine("1.....Taladro..C$350.00");
    Console.WriteLine("2.....Martillo...C$600.00");
    Console.WriteLine("3.....Tubo PVC..C$150.00");
    Console.WriteLine("4.....Llave Inglesa.C$500.00");
    

    do
    {
        Console.WriteLine("Ingrese el numero del producto que desea llevar: ");
        Console.WriteLine("(Ingrese '0' para salir)");

        prod = Convert.ToInt32(Console.ReadLine());
            switch (prod)
            {
                case 1:
                    precio = 350;
                    total += precio;
                    break;
                case 2:
                    precio = 600;
                    total += precio;
                    break;
                case 3:
                    precio = 150;
                    total += precio;
                    break;
                case 4:
                    precio = 500;
                    total += precio;
                    break;
                case 0:
                    Console.WriteLine("Calculando...");
                    break;
            default:
                Console.WriteLine("Ingrese un numero entre 1 - 4");
                
                break;

        }
        productosVendidos++;
    } while (prod != 0);


    Console.WriteLine($"Productos vendidos: {productosVendidos}");
    Console.WriteLine($"Total: ${total}");
    if (total > 10000)
    {
        Console.WriteLine("Venta mayorista detectada.");
    }
    }
}