using System;

namespace EjercicioOctubre4
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public double Producto1 { get; set; }
        public double Producto2 { get; set; }
        public double Producto3 { get; set; }
        public double CalcularTotal()
        {
            double total = Producto1 + Producto2 + Producto3;

            return total;
        }
    }
}