using System;

namespace PracticaNoviembre12{

    public class Saludador
    {
        public void Saludar()
        {
            Console.WriteLine("Hola");
        }

        //Sobrecarga del metodo saludar
        public void Saludar(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }

        //Otra sobrecarga del metodo Saludar
        public void Saludar(string nombre, string apellido)
        {
            Console.WriteLine("Hola " + nombre + " " + apellido);
        }

    }

}