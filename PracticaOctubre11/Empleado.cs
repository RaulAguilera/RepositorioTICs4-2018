using System;

namespace PracticaOctubre11
{
    public class Empleado : Persona
    {
        public double SalarioDiario { get; set; }
        public int DiasTrabajados { get; set; }
        public double CalcularQuincena()
        {
            double quincena = DiasTrabajados * SalarioDiario;

            return quincena;
        }
    }
}
