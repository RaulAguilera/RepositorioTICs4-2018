using System;

namespace EjemploNoviembre21_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Los constructores nos van a servir para inicializar instancias de nuestras clases
            //Los constructores se declaran indicando
            //1.-Modificador de acceso
            //2.-Nombre de la clase seguida de paréntesis
            //3.-Cuerpo del constructor


            Autobus a1 = new Autobus();//Llamamos constructor default

            Console.WriteLine("Modelo: " + a1.Modelo);

            Console.WriteLine("Kilometraje: " + a1.Kilometraje);

            Console.WriteLine("Activo: " + a1.Activo);


            Autobus a2 = new Autobus("Irizar",2300,true);//Llamamos constructor con parámetros

            Console.WriteLine("Modelo: " + a2.Modelo);

            Console.WriteLine("Kilometraje: " + a2.Kilometraje);

            Console.WriteLine("Activo: " + a2.Activo);


            Console.ReadKey();
        }
    }
}
