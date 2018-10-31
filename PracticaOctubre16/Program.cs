using System;

namespace PracticaOctubre16
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura f1 = new Figura();
            f1.Base = 2.0;
            f1.Altura = 3.0;
            double af1 = f1.CalcularArea();
            Console.WriteLine("Area Figura f1: " + af1);

            Figura f2 = new Rectangulo(); //Polimorfismo
            f2.Base = 3.0;
            f2.Altura = 5.0;
            double af2 = f2.CalcularArea();
            Console.WriteLine("Area Rectangulo: " + af2);

            Figura f3 = new Triangulo();
            f3.Base = 3.0;
            f3.Altura = 5.0;
            double af3 = f3.CalcularArea();//Metodo sobreescrito en la clase triangulo
            Console.WriteLine("Area Triangulo: " + af3);

            Console.ReadKey();
        }
    }
}
