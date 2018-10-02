using System;

namespace EjemploClases{
    public class Alumno {
        public string Nombre {get; set;}

        public double Cal1 {get;set;}

        public double Cal2 {get;set;}

        public double Cal3 {get;set;}

        public double Promedio {get;set;}

        /*public double CalcularPromedio()
        {
            double promedio = (Cal1 + Cal2 + Cal3)/3.0;

            return promedio;
        }*/

        public void CalcularPromedio()
        {
            Promedio = (Cal1 + Cal2 + Cal3)/3.0;
        }

    }
}