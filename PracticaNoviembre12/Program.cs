using System;

namespace PracticaNoviembre12
{
    class Program
    {
        static void Main(string[] args)
        {
            Saludador s1 = new Saludador();

            s1.Saludar();
            s1.Saludar("Juanito");
            s1.Saludar("Stan","Lee");

            Console.ReadKey();

        }
    }
}
