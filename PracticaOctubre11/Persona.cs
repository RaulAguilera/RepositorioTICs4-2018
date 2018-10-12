using System;

namespace PracticaOctubre11 {
    public class Persona {
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public DateTime FechaNacimiento {get;set;}
        public int CalcularEdad()
        {
            //Primero obtenemos la fecha actual
            DateTime fechaActual = DateTime.Now;
            //Obtenemos el año actual
            int anioActual = fechaActual.Year;
            //Obtener año de nacimiento
            int anioNacimiento = FechaNacimiento.Year;
            //Hacemos resta de años
            int edad = anioActual - anioNacimiento;
            
            return edad;
        }
    }
}