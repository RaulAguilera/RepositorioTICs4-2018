using System;

namespace EjercicioOctubre4
{
    class Program
    {
        static void Main(string[] args)
        {
            Venta v1 = new Venta();

            v1.IdVenta = 1;
            v1.Producto1 = 3.5;
            v1.Producto2 = 7.0;
            v1.Producto3 = 2.6;

            Console.WriteLine("Venta 1");
            Console.WriteLine(v1.IdVenta + " " + v1.Producto1 + " " + v1.Producto2 + " " + v1.Producto3);
            double totalV1 = v1.CalcularTotal();
            Console.WriteLine(totalV1);
            Console.WriteLine("Venta 1");

            Venta v2 = new Venta();
            v2.IdVenta = 2;
            v2.Producto1 = 3.0;
            v2.Producto2 = 4.0;
            v2.Producto3 = 6.0;

            Console.WriteLine("Venta 2");
            Console.WriteLine(v2.IdVenta + " " + v2.Producto1 + " " + v2.Producto2 + " " + v2.Producto3);
            double totalV2 = v2.CalcularTotal();
            Console.WriteLine(totalV2);
            Console.WriteLine("Venta 2");

            Console.ReadKey();
        }
    }
}
