using System;

namespace PracticaOctubre11
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();

            p1.Nombre = "Juanito";
            p1.Apellido = "Blackmore";

            p1.FechaNacimiento = new DateTime(1990,1,15);

            int edadP1 =  p1.CalcularEdad();

            Console.WriteLine("Edad P1: " + edadP1);

            Empleado e1 = new Empleado();

            e1.Nombre = "Pepe";
            e1.Apellido = "El Toro";
            e1.SalarioDiario = 300.0;
            e1.DiasTrabajados = 10;
            e1.FechaNacimiento = new DateTime(1999,9,11);

            int edadE1 = e1.CalcularEdad();
            double quincena = e1.CalcularQuincena();

            Console.WriteLine("Quincena e1: " + quincena);
            Console.WriteLine("Edad e1:" + edadE1);

            Console.ReadKey();
        }
    }
}
